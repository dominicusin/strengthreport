/*
  KeePass Password Safe - The Open-Source Password Manager
  Copyright (C) 2003-2008 Dominik Reichl <dominik.reichl@t-online.de>

  This program is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

using KeePass.Resources;
using KeePass.UI;

using KeePassLib;
using KeePassLib.Resources;
using KeePassLib.Translation;
using KeePassLib.Utility;

namespace TrlUtil
{
	public partial class MainForm : Form
	{
		private KPTranslation m_trl = new KPTranslation();
		private string m_strFile = string.Empty;

		private ImageList m_ilStr = new ImageList();

		private const string m_strFileFilter = "KeePass Translation (*.lngx)|*.lngx|All Files (*.*)|*.*";

		private KPControlCustomization m_kpccLast = null;

		private const int m_inxWindow = 6;
		private const int m_inxMissing = 1;
		private const int m_inxOk = 4;
		private const int m_inxWarning = 5;

		private bool m_bModified = false;

		private PreviewForm m_prev = new PreviewForm();

		public MainForm()
		{
			InitializeComponent();
		}

		private void OnFormLoad(object sender, EventArgs e)
		{
			m_trl.Forms = FormTrlMgr.CreateListOfCurrentVersion();

			this.CreateStringTableUI();
			this.UpdateControlTree();

			if(m_tvControls.SelectedNode == null)
				m_tvControls.SelectedNode = m_tvControls.Nodes[0];
			UpdatePreviewForm();
			m_prev.Show();
		}

		private void CreateStringTableUI()
		{
			int nWidth = m_lvStrings.ClientSize.Width - 20;

			m_ilStr.ColorDepth = ColorDepth.Depth32Bit;
			m_ilStr.ImageSize = new Size(16, 16);
			m_ilStr.Images.Add(Properties.Resources.B16x16_Binary);
			m_ilStr.Images.Add(Properties.Resources.B16x16_KRec_Record);
			m_ilStr.Images.Add(Properties.Resources.B16x16_LedGreen);
			m_ilStr.Images.Add(Properties.Resources.B16x16_LedLightBlue);
			m_ilStr.Images.Add(Properties.Resources.B16x16_LedLightGreen);
			m_ilStr.Images.Add(Properties.Resources.B16x16_LedOrange);
			m_ilStr.Images.Add(Properties.Resources.B16x16_View_Remove);

			m_lvStrings.SmallImageList = m_ilStr;
			m_tvControls.ImageList = m_ilStr;

			m_lvStrings.Columns.Add("ID", nWidth / 5);
			m_lvStrings.Columns.Add("English", (nWidth * 2) / 5);
			m_lvStrings.Columns.Add("Translated", (nWidth * 2) / 5);

			m_trl.StringTables.Clear();
			KPStringTable kpstP = new KPStringTable();
			kpstP.Name = "KeePass.Resources.KPRes";
			m_trl.StringTables.Add(kpstP);
			KPStringTable kpstL = new KPStringTable();
			kpstL.Name = "KeePassLib.Resources.KLRes";
			m_trl.StringTables.Add(kpstL);
			KPStringTable kpstM = new KPStringTable();
			kpstM.Name = "KeePass.Forms.MainForm.m_menuMain";
			m_trl.StringTables.Add(kpstM);
			KPStringTable kpstE = new KPStringTable();
			kpstE.Name = "KeePass.Forms.MainForm.m_ctxPwList";
			m_trl.StringTables.Add(kpstE);
			KPStringTable kpstG = new KPStringTable();
			kpstG.Name = "KeePass.Forms.MainForm.m_ctxGroupList";
			m_trl.StringTables.Add(kpstG);
			KPStringTable kpstT = new KPStringTable();
			kpstT.Name = "KeePass.Forms.MainForm.m_ctxTray";
			m_trl.StringTables.Add(kpstT);
			KPStringTable kpstET = new KPStringTable();
			kpstET.Name = "KeePass.Forms.PwEntryForm.m_ctxTools";
			m_trl.StringTables.Add(kpstET);
			KPStringTable kpstDT = new KPStringTable();
			kpstDT.Name = "KeePass.Forms.PwEntryForm.m_ctxDefaultTimes";
			m_trl.StringTables.Add(kpstDT);
			KPStringTable kpstLO = new KPStringTable();
			kpstLO.Name = "KeePass.Forms.PwEntryForm.m_ctxListOperations";
			m_trl.StringTables.Add(kpstLO);
			KPStringTable kpstPG = new KPStringTable();
			kpstPG.Name = "KeePass.Forms.PwEntryForm.m_ctxPwGen";
			m_trl.StringTables.Add(kpstPG);
			KPStringTable kpstSM = new KPStringTable();
			kpstSM.Name = "KeePass.Forms.PwEntryForm.m_ctxStrMoveToStandard";
			m_trl.StringTables.Add(kpstSM);

			Type tKP = typeof(KPRes);
			ListViewGroup lvg = new ListViewGroup("KeePass Strings");
			m_lvStrings.Groups.Add(lvg);
			foreach(string strKey in KPRes.GetKeyNames())
			{
				PropertyInfo pi = tKP.GetProperty(strKey);
				MethodInfo mi = pi.GetGetMethod();
				if(mi.ReturnType != typeof(string))
				{
					MessageBox.Show("Return type is not string:\r\n" +
						strKey, "TrlUtil: Fatal error!", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				string strEng = mi.Invoke(null, null) as string;
				if(strEng == null)
				{
					MessageBox.Show("English string is null:\r\n" +
						strKey, "TrlUtil: Fatal error!", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				KPStringTableItem kpstItem = new KPStringTableItem();
				kpstItem.Name = strKey;
				kpstItem.ValueEnglish = strEng;
				kpstP.Strings.Add(kpstItem);

				ListViewItem lvi = new ListViewItem();
				lvi.Group = lvg;
				lvi.Text = strKey;
				lvi.SubItems.Add(strEng);
				lvi.SubItems.Add(string.Empty);
				lvi.Tag = kpstItem;
				lvi.ImageIndex = 0;
				m_lvStrings.Items.Add(lvi);
			}

			Type tKL = typeof(KLRes);
			lvg = new ListViewGroup("KeePass Library Strings");
			m_lvStrings.Groups.Add(lvg);
			foreach(string strLibKey in KLRes.GetKeyNames())
			{
				PropertyInfo pi = tKL.GetProperty(strLibKey);
				MethodInfo mi = pi.GetGetMethod();
				if(mi.ReturnType != typeof(string))
				{
					MessageBox.Show("Return type is not string:\r\n" +
						strLibKey, "TrlUtil: Fatal error!", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				string strEng = mi.Invoke(null, null) as string;
				if(strEng == null)
				{
					MessageBox.Show("English string is null:\r\n" +
						strLibKey, "TrlUtil: Fatal error!", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				KPStringTableItem kpstItem = new KPStringTableItem();
				kpstItem.Name = strLibKey;
				kpstItem.ValueEnglish = strEng;
				kpstL.Strings.Add(kpstItem);

				ListViewItem lvi = new ListViewItem();
				lvi.Group = lvg;
				lvi.Text = strLibKey;
				lvi.SubItems.Add(strEng);
				lvi.SubItems.Add(string.Empty);
				lvi.Tag = kpstItem;
				lvi.ImageIndex = 0;
				m_lvStrings.Items.Add(lvi);
			}

			lvg = new ListViewGroup("Main Menu Commands");
			m_lvStrings.Groups.Add(lvg);
			KeePass.Forms.MainForm mf = new KeePass.Forms.MainForm();
			TrlAddMenuCommands(kpstM, lvg, mf.MainMenu.Items);

			lvg = new ListViewGroup("Entry Context Menu Commands");
			m_lvStrings.Groups.Add(lvg);
			TrlAddMenuCommands(kpstE, lvg, mf.EntryContextMenu.Items);

			lvg = new ListViewGroup("Group Context Menu Commands");
			m_lvStrings.Groups.Add(lvg);
			TrlAddMenuCommands(kpstG, lvg, mf.GroupContextMenu.Items);

			lvg = new ListViewGroup("System Tray Context Menu Commands");
			m_lvStrings.Groups.Add(lvg);
			TrlAddMenuCommands(kpstT, lvg, mf.TrayContextMenu.Items);

			lvg = new ListViewGroup("Entry Tools Context Menu Commands");
			m_lvStrings.Groups.Add(lvg);
			KeePass.Forms.PwEntryForm ef = new KeePass.Forms.PwEntryForm();
			TrlAddMenuCommands(kpstET, lvg, ef.ToolsContextMenu.Items);

			lvg = new ListViewGroup("Default Times Context Menu Commands");
			m_lvStrings.Groups.Add(lvg);
			TrlAddMenuCommands(kpstDT, lvg, ef.DefaultTimesContextMenu.Items);

			lvg = new ListViewGroup("List Operations Context Menu Commands");
			m_lvStrings.Groups.Add(lvg);
			TrlAddMenuCommands(kpstLO, lvg, ef.ListOperationsContextMenu.Items);

			lvg = new ListViewGroup("Password Generator Context Menu Commands");
			m_lvStrings.Groups.Add(lvg);
			TrlAddMenuCommands(kpstPG, lvg, ef.PasswordGeneratorContextMenu.Items);

			lvg = new ListViewGroup("Standard String Movement Context Menu Commands");
			m_lvStrings.Groups.Add(lvg);
			TrlAddMenuCommands(kpstSM, lvg, ef.StandardStringMovementContextMenu.Items);
		}

		private void TrlAddMenuCommands(KPStringTable kpst, ListViewGroup grp,
			ToolStripItemCollection tsic)
		{
			foreach(ToolStripItem tsi in tsic)
			{
				if(tsi.Text.Length == 0) continue;
				if(tsi.Text.StartsWith(@"<") && tsi.Text.EndsWith(@">")) continue;

				KPStringTableItem kpstItem = new KPStringTableItem();
				kpstItem.Name = tsi.Name;
				kpstItem.ValueEnglish = tsi.Text;
				kpst.Strings.Add(kpstItem);

				ListViewItem lvi = new ListViewItem();
				lvi.Group = grp;
				lvi.Text = tsi.Name;
				lvi.SubItems.Add(tsi.Text);
				lvi.SubItems.Add(string.Empty);
				lvi.Tag = kpstItem;
				lvi.ImageIndex = 0;
				m_lvStrings.Items.Add(lvi);

				ToolStripMenuItem tsmi = tsi as ToolStripMenuItem;
				if(tsmi != null) TrlAddMenuCommands(kpst, grp, tsmi.DropDownItems);
			}
		}

		private void UpdateStringTableUI()
		{
			foreach(ListViewItem lvi in m_lvStrings.Items)
			{
				KPStringTableItem kpstItem  = lvi.Tag as KPStringTableItem;
				Debug.Assert(kpstItem != null);
				if(kpstItem == null) continue;

				lvi.SubItems[2].Text = kpstItem.Value;
			}
		}

		private void UpdateControlTree()
		{
			FormTrlMgr.RenderToTreeControl(m_trl.Forms, m_tvControls);
			UpdateStatusImages(null);
		}

		private void OnLinkLangCodeClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start(@"http://en.wikipedia.org/wiki/List_of_ISO_639-1_codes");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "TrlUtil",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void OnFileOpen(object sender, EventArgs e)
		{
			OpenFileDialog ofd = UIUtil.CreateOpenFileDialog("Open KeePass Translation",
				m_strFileFilter, 1, null, false, false);

			if(ofd.ShowDialog() != DialogResult.OK) return;

			KPTranslation kpTrl = null;
			try { kpTrl = KPTranslation.LoadFromFile(ofd.FileName); }
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "TrlUtil", MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			m_strFile = ofd.FileName;

			StringBuilder sbUnusedText = new StringBuilder();
			if(kpTrl.UnusedText.Length > 0)
			{
				if(kpTrl.UnusedText.EndsWith("\r") || kpTrl.UnusedText.EndsWith("\n"))
					sbUnusedText.Append(kpTrl.UnusedText);
				else sbUnusedText.AppendLine(kpTrl.UnusedText);
			}

			m_trl.Properties = kpTrl.Properties;
			foreach(KPStringTable kpstNew in kpTrl.StringTables)
			{
				foreach(KPStringTable kpstInto in m_trl.StringTables)
				{
					if(kpstInto.Name == kpstNew.Name)
						MergeInStringTable(kpstInto, kpstNew, sbUnusedText);
				}
			}

			FormTrlMgr.MergeForms(m_trl.Forms, kpTrl.Forms, sbUnusedText);

			m_tbNameEng.Text = m_trl.Properties.NameEnglish;
			m_tbNameLcl.Text = m_trl.Properties.NameNative;
			m_tbLangID.Text = m_trl.Properties.Iso6391Code;
			m_tbAuthorName.Text = m_trl.Properties.AuthorName;
			m_tbAuthorContact.Text = m_trl.Properties.AuthorContact;

			m_rtbUnusedText.Text = sbUnusedText.ToString();

			this.UpdateStringTableUI();
			this.UpdateStatusImages(null);
			this.UpdatePreviewForm();
		}

		private void MergeInStringTable(KPStringTable tbInto, KPStringTable tbSource,
			StringBuilder sbUnusedText)
		{
			foreach(KPStringTableItem kpSrc in tbSource.Strings)
			{
				bool bHasAssigned = false;
				foreach(KPStringTableItem kpDst in tbInto.Strings)
				{
					if(kpSrc.Name == kpDst.Name)
					{
						if(kpSrc.Value.Length > 0)
						{
							kpDst.Value = kpSrc.Value;
							bHasAssigned = true;
						}
					}
				}

				if(!bHasAssigned)
				{
					string strTrimmed = kpSrc.Value.Trim();
					if(strTrimmed.Length > 0) sbUnusedText.AppendLine(strTrimmed);
				}
			}
		}

		private void UpdateInternalTranslation()
		{
			m_trl.Properties.NameEnglish = StrUtil.SafeXmlString(m_tbNameEng.Text);
			m_trl.Properties.NameNative = StrUtil.SafeXmlString(m_tbNameLcl.Text);
			m_trl.Properties.Iso6391Code = StrUtil.SafeXmlString(m_tbLangID.Text);
			m_trl.Properties.AuthorName = StrUtil.SafeXmlString(m_tbAuthorName.Text);
			m_trl.Properties.AuthorContact = StrUtil.SafeXmlString(m_tbAuthorContact.Text);
		}

		private void UpdateStatusImages(TreeNodeCollection vtn)
		{
			if(vtn == null) vtn = m_tvControls.Nodes;

			foreach(TreeNode tn in vtn)
			{
				KPFormCustomization kpfc = tn.Tag as KPFormCustomization;
				KPControlCustomization kpcc = tn.Tag as KPControlCustomization;

				if(kpfc != null)
				{
					tn.ImageIndex = m_inxWindow;
					tn.SelectedImageIndex = m_inxWindow;
				}
				else if(kpcc != null)
				{
					int iCurrentImage = tn.ImageIndex, iNewImage;

					if((kpcc.TextEnglish == @"<DYN>") || (kpcc.TextEnglish == @"<>"))
						iNewImage = ((kpcc.Text.Length == 0) ? m_inxOk : m_inxWarning);
					else if((kpcc.TextEnglish.Length > 0) && (kpcc.Text.Length > 0))
						iNewImage = m_inxOk;
					else if((kpcc.TextEnglish.Length > 0) && (kpcc.Text.Length == 0))
						iNewImage = m_inxMissing;
					else if((kpcc.TextEnglish.Length == 0) && (kpcc.Text.Length == 0))
						iNewImage = m_inxOk;
					else if((kpcc.TextEnglish.Length == 0) && (kpcc.Text.Length > 0))
						iNewImage = m_inxWarning;
					else
						iNewImage = m_inxWarning;

					if(iNewImage != iCurrentImage)
					{
						tn.ImageIndex = iNewImage;
						tn.SelectedImageIndex = iNewImage;
					}
				}
				else { Debug.Assert(false); }

				if(tn.Nodes != null) UpdateStatusImages(tn.Nodes);
			}
		}

		private void OnFileSave(object sender, EventArgs e)
		{
			UpdateInternalTranslation();

			if(m_strFile.Length == 0)
			{
				OnFileSaveAs(sender, e);
				return;
			}

			PrepareSave();

			try
			{
				KPTranslation.SaveToFile(m_trl, m_strFile);
				m_bModified = false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "TrlUtil", MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
		}

		private void PrepareSave()
		{
			m_trl.Properties.Application = PwDefs.ProductName;
			m_trl.Properties.ApplicationVersion = PwDefs.VersionString;
			m_trl.Properties.Generator = "TrlUtil";

			PwUuid pwUuid = new PwUuid(true);
			m_trl.Properties.FileUuid = pwUuid.ToHexString();

			m_trl.Properties.LastModified = DateTime.Now.ToString("u");

			m_trl.UnusedText = m_rtbUnusedText.Text;
		}

		private void OnFileExit(object sender, EventArgs e)
		{
			if(m_bModified) OnFileSaveAs(sender, e);

			this.Close();
		}

		private void OnStringsSelectedIndexChanged(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection lvsic =
				m_lvStrings.SelectedItems;
			if(lvsic.Count != 1)
			{
				m_tbStrEng.Text = string.Empty;
				m_tbStrTrl.Text = string.Empty;
				return;
			}

			KPStringTableItem kpstItem = lvsic[0].Tag as KPStringTableItem;
			Debug.Assert(kpstItem != null);
			if(kpstItem == null) return;

			m_tbStrEng.Text = lvsic[0].SubItems[1].Text;
			m_tbStrTrl.Text = lvsic[0].SubItems[2].Text;
		}

		private void OnStrKeyDown(object sender, KeyEventArgs e)
		{
			if((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Enter))
			{
				e.Handled = true;

				ListView.SelectedListViewItemCollection lvsic =
					m_lvStrings.SelectedItems;
				if(lvsic.Count != 1) return;

				KPStringTableItem kpstItem = lvsic[0].Tag as KPStringTableItem;
				if(kpstItem == null)
				{
					Debug.Assert(false);
					return;
				}

				kpstItem.Value = StrUtil.SafeXmlString(m_tbStrTrl.Text);
				this.UpdateStringTableUI();

				int iIndex = lvsic[0].Index;
				if(iIndex < m_lvStrings.Items.Count - 1)
				{
					lvsic[0].Selected = false;
					m_lvStrings.Items[iIndex + 1].Selected = true;
					m_lvStrings.FocusedItem = m_lvStrings.Items[iIndex + 1];
				}

				m_bModified = true;
			}
		}

		private void OnStrKeyUp(object sender, KeyEventArgs e)
		{
			if((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Enter))
				e.Handled = true;
		}

		private void OnFileSaveAs(object sender, EventArgs e)
		{
			SaveFileDialog sfd = UIUtil.CreateSaveFileDialog("Save KeePass Translation",
				m_tbNameEng.Text + ".lngx", m_strFileFilter, 1, "lngx", false);

			if(sfd.ShowDialog() != DialogResult.OK) return;

			m_strFile = sfd.FileName;

			OnFileSave(sender, e);
		}

		private void OnStrDoubleClick(object sender, EventArgs e)
		{
			this.ActiveControl = m_tbStrTrl;
		}

		private void OnCustomControlsAfterSelect(object sender, TreeViewEventArgs e)
		{
			ShowCustomControlProps(e.Node.Tag as KPControlCustomization);
			UpdatePreviewForm();
		}

		private void ShowCustomControlProps(KPControlCustomization kpcc)
		{
			if(kpcc == null) return; // No assert

			m_kpccLast = kpcc;

			m_tbCtrlEngText.Text = m_kpccLast.TextEnglish;
			m_tbCtrlTrlText.Text = m_kpccLast.Text;

			m_tbLayoutX.Text = KpccLayout.ToControlRelativeString(m_kpccLast.Layout.X);
			m_tbLayoutY.Text = KpccLayout.ToControlRelativeString(m_kpccLast.Layout.Y);
			m_tbLayoutW.Text = KpccLayout.ToControlRelativeString(m_kpccLast.Layout.Width);
			m_tbLayoutH.Text = KpccLayout.ToControlRelativeString(m_kpccLast.Layout.Height);
		}

		private void OnCtrlTrlTextChanged(object sender, EventArgs e)
		{
			string strText = m_tbCtrlTrlText.Text;
			if((m_kpccLast != null) && (m_kpccLast.Text != strText))
			{
				m_kpccLast.Text = StrUtil.SafeXmlString(m_tbCtrlTrlText.Text);
				m_bModified = true;
			}

			UpdateStatusImages(null);
			UpdatePreviewForm();
		}

		private void OnLayoutXTextChanged(object sender, EventArgs e)
		{
			if(m_kpccLast != null)
			{
				m_kpccLast.Layout.SetControlRelativeValue(
					KpccLayout.LayoutParameterEx.X, m_tbLayoutX.Text);
				m_bModified = true;

				UpdatePreviewForm();
			}
		}

		private void OnLayoutYTextChanged(object sender, EventArgs e)
		{
			if(m_kpccLast != null)
			{
				m_kpccLast.Layout.SetControlRelativeValue(
					KpccLayout.LayoutParameterEx.Y, m_tbLayoutY.Text);
				m_bModified = true;

				UpdatePreviewForm();
			}
		}

		private void OnLayoutWidthTextChanged(object sender, EventArgs e)
		{
			if(m_kpccLast != null)
			{
				m_kpccLast.Layout.SetControlRelativeValue(
					KpccLayout.LayoutParameterEx.Width, m_tbLayoutW.Text);
				m_bModified = true;

				UpdatePreviewForm();
			}
		}

		private void OnLayoutHeightTextChanged(object sender, EventArgs e)
		{
			if(m_kpccLast != null)
			{
				m_kpccLast.Layout.SetControlRelativeValue(
					KpccLayout.LayoutParameterEx.Height, m_tbLayoutH.Text);
				m_bModified = true;

				UpdatePreviewForm();
			}
		}

		private void OnCtrlTrlTextKeyDown(object sender, KeyEventArgs e)
		{
			if((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Enter))
			{
				e.Handled = true;

				TreeNode tn = m_tvControls.SelectedNode;
				if(tn == null) return;

				try
				{
					TreeNode tnNew = tn.NextNode;
					if(tnNew != null) m_tvControls.SelectedNode = tnNew;
				}
				catch(Exception) { Debug.Assert(false); }
			}
		}

		private void OnCtrlTrlTextKeyUp(object sender, KeyEventArgs e)
		{
			if((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Enter))
				e.Handled = true;
		}

		private void UpdatePreviewForm()
		{
			TreeNode tn = m_tvControls.SelectedNode;
			if(tn == null) return;
			if(tn.Parent != null) tn = tn.Parent;
			string strFormName = tn.Text;

			foreach(KPFormCustomization kpfc in m_trl.Forms)
			{
				if(kpfc.FullName.EndsWith(strFormName))
				{
					UpdatePreviewForm(kpfc);
					break;
				}
			}
		}

		private void UpdatePreviewForm(KPFormCustomization kpfc)
		{
			m_prev.Controls.Clear();
			m_prev.CopyForm(kpfc.FormEnglish);
			kpfc.ApplyTo(m_prev);
		}

		private void OnBtnClearUnusedText(object sender, EventArgs e)
		{
			m_rtbUnusedText.Text = string.Empty;
		}

		private void OnImport1xLng(object sender, EventArgs e)
		{
			OpenFileDialog ofd = UIUtil.CreateOpenFileDialog("Import KeePass 1.x LNG File",
				"KeePass 1.x LNG File (*.lng)|*.lng|All Files (*.*)|*.*", 1, "lng", false, true);

			if(ofd.ShowDialog() != DialogResult.OK) return;

			try { KeePass1xLngImport.Import(m_trl, ofd.FileName); }
			catch(Exception ex) { MessageService.ShowWarning(ex); }

			UpdateStringTableUI();
			UpdateControlTree();
			m_tvControls.SelectedNode = m_tvControls.Nodes[0];
			UpdatePreviewForm();
		}
	}
}
