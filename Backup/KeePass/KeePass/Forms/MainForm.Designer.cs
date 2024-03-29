﻿namespace KeePass.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.m_ctxGroupList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_ctxGroupAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxGroupSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxGroupEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxGroupDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxGroupSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxGroupFind = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxGroupSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxGroupPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxGroupExport = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxGroupSep3 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxGroupRearrange = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxGroupMoveToTop = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxGroupMoveOneUp = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxGroupMoveOneDown = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxGroupMoveToBottom = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ilClientIcons = new System.Windows.Forms.ImageList(this.components);
			this.m_ctxPwList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_ctxEntryCopyUserName = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryUrl = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryOpenUrl = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryCopyUrl = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryUrlSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxEntryUrlOpenInInternal = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryCopyCustomString = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryBinaries = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySaveAttachedFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxEntryPerformAutoType = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxEntryAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryDuplicate = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryMassModify = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySetColor = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryColorStandard = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryColorSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxEntryColorLightRed = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryColorLightGreen = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryColorLightBlue = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryColorLightYellow = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryColorSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxEntryColorCustom = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryMassSetIcon = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySelectedSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxEntrySelectedPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySelectedExport = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySep2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxEntryClipboard = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryClipCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryClipPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryRearrangePopup = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryMoveToTop = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryMoveOneUp = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryMoveOneDown = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryMoveToBottom = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryRearrangeSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxEntrySortUnsorted = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntryRearrangeSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxEntrySortListByTitle = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySortListByUserName = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySortListByPassword = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySortListByURL = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySortListByNotes = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySortListByCreationTime = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySortListByLastModTime = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySortListByLastAccessTime = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxEntrySortListByExpirationTime = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuMain = new System.Windows.Forms.MenuStrip();
			this.m_menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileOpenLocal = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileOpenUrl = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileRecent = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSaveAsLocal = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSaveAsUrl = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSaveAsSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuFileSaveAsCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuFileDbSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileChangeMasterKey = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSep3 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuFileImport = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileExport = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSync = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSyncFile = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSyncUrl = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileSep4 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuFileLock = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuEditShowAllEntries = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuEditShowExpired = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuEditSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuEditFind = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuView = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuChangeLanguage = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuViewShowToolBar = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewShowEntryView = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewWindowLayout = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewWindowsStacked = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewWindowsSideBySide = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuViewAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuViewHiding = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewHideTitles = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewHideUserNames = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewHidePasswords = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewHideURLs = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewHideNotes = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewSep3 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuViewTanOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewTanSimpleList = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewTanIndices = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumns = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowTitle = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowUserName = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowPassword = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowUrl = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowNotes = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuViewColumnsShowCreation = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowLastAccess = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowLastMod = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowExpire = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuViewColumnsShowUuid = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewColumnsShowAttachs = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuViewSep4 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuViewShowEntriesOfSubGroups = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuToolsPwGenerator = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuToolsGeneratePwList = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuToolsSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuToolsTanWizard = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuToolsDbMaintenance = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuToolsSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuToolsPlugins = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuHelpContents = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuHelpSelectSource = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuHelpSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuHelpHomepage = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuHelpDonate = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuHelpSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuHelpCheckForUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuHelpSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.m_toolMain = new System.Windows.Forms.ToolStrip();
			this.m_tbNewDatabase = new System.Windows.Forms.ToolStripButton();
			this.m_tbOpenDatabase = new System.Windows.Forms.ToolStripButton();
			this.m_tbSaveDatabase = new System.Windows.Forms.ToolStripButton();
			this.m_tbSaveAll = new System.Windows.Forms.ToolStripButton();
			this.m_tbSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_tbAddEntry = new System.Windows.Forms.ToolStripSplitButton();
			this.m_tbAddEntryDefault = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tbSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_tbCopyUserName = new System.Windows.Forms.ToolStripButton();
			this.m_tbCopyPassword = new System.Windows.Forms.ToolStripButton();
			this.m_tbSep4 = new System.Windows.Forms.ToolStripSeparator();
			this.m_tbFind = new System.Windows.Forms.ToolStripButton();
			this.m_tbEntryViewsDropDown = new System.Windows.Forms.ToolStripDropDownButton();
			this.m_tbViewsShowAll = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tbViewsShowExpired = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tbSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_tbLockWorkspace = new System.Windows.Forms.ToolStripButton();
			this.m_tbSep3 = new System.Windows.Forms.ToolStripSeparator();
			this.m_tbQuickFind = new System.Windows.Forms.ToolStripComboBox();
			this.m_tbCloseTab = new System.Windows.Forms.ToolStripButton();
			this.m_statusMain = new System.Windows.Forms.StatusStrip();
			this.m_statusPartSelected = new System.Windows.Forms.ToolStripStatusLabel();
			this.m_statusPartInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.m_statusPartProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.m_statusClipboard = new System.Windows.Forms.ToolStripProgressBar();
			this.m_ntfTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.m_ctxTray = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_ctxTrayTray = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxTraySep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxTrayLock = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxTraySep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxTrayFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.m_timerMain = new System.Windows.Forms.Timer(this.components);
			this.m_colorDlg = new System.Windows.Forms.ColorDialog();
			this.m_tabMain = new System.Windows.Forms.TabControl();
			this.m_splitHorizontal = new KeePass.UI.CustomSplitContainerEx();
			this.m_splitVertical = new KeePass.UI.CustomSplitContainerEx();
			this.m_tvGroups = new System.Windows.Forms.TreeView();
			this.m_lvEntries = new System.Windows.Forms.ListView();
			this.m_richEntryView = new System.Windows.Forms.RichTextBox();
			this.m_ctxGroupList.SuspendLayout();
			this.m_ctxPwList.SuspendLayout();
			this.m_menuMain.SuspendLayout();
			this.m_toolMain.SuspendLayout();
			this.m_statusMain.SuspendLayout();
			this.m_ctxTray.SuspendLayout();
			this.m_splitHorizontal.Panel1.SuspendLayout();
			this.m_splitHorizontal.Panel2.SuspendLayout();
			this.m_splitHorizontal.SuspendLayout();
			this.m_splitVertical.Panel1.SuspendLayout();
			this.m_splitVertical.Panel2.SuspendLayout();
			this.m_splitVertical.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_ctxGroupList
			// 
			this.m_ctxGroupList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxGroupAdd,
            this.m_ctxGroupSep0,
            this.m_ctxGroupEdit,
            this.m_ctxGroupDelete,
            this.m_ctxGroupSep1,
            this.m_ctxGroupFind,
            this.m_ctxGroupSep2,
            this.m_ctxGroupPrint,
            this.m_ctxGroupExport,
            this.m_ctxGroupSep3,
            this.m_ctxGroupRearrange});
			this.m_ctxGroupList.Name = "m_ctxGroupList";
			this.m_ctxGroupList.Size = new System.Drawing.Size(227, 182);
			// 
			// m_ctxGroupAdd
			// 
			this.m_ctxGroupAdd.Image = global::KeePass.Properties.Resources.B16x16_Folder_Sent_Mail;
			this.m_ctxGroupAdd.Name = "m_ctxGroupAdd";
			this.m_ctxGroupAdd.Size = new System.Drawing.Size(226, 22);
			this.m_ctxGroupAdd.Text = "&Add Group";
			this.m_ctxGroupAdd.Click += new System.EventHandler(this.OnGroupsAdd);
			// 
			// m_ctxGroupSep0
			// 
			this.m_ctxGroupSep0.Name = "m_ctxGroupSep0";
			this.m_ctxGroupSep0.Size = new System.Drawing.Size(223, 6);
			// 
			// m_ctxGroupEdit
			// 
			this.m_ctxGroupEdit.Image = global::KeePass.Properties.Resources.B16x16_Folder_Txt;
			this.m_ctxGroupEdit.Name = "m_ctxGroupEdit";
			this.m_ctxGroupEdit.Size = new System.Drawing.Size(226, 22);
			this.m_ctxGroupEdit.Text = "&Edit Group";
			this.m_ctxGroupEdit.Click += new System.EventHandler(this.OnGroupsEdit);
			// 
			// m_ctxGroupDelete
			// 
			this.m_ctxGroupDelete.Image = global::KeePass.Properties.Resources.B16x16_Folder_Locked;
			this.m_ctxGroupDelete.Name = "m_ctxGroupDelete";
			this.m_ctxGroupDelete.ShortcutKeyDisplayString = "Del";
			this.m_ctxGroupDelete.Size = new System.Drawing.Size(226, 22);
			this.m_ctxGroupDelete.Text = "&Delete Group";
			this.m_ctxGroupDelete.Click += new System.EventHandler(this.OnGroupsDelete);
			// 
			// m_ctxGroupSep1
			// 
			this.m_ctxGroupSep1.Name = "m_ctxGroupSep1";
			this.m_ctxGroupSep1.Size = new System.Drawing.Size(223, 6);
			// 
			// m_ctxGroupFind
			// 
			this.m_ctxGroupFind.Image = global::KeePass.Properties.Resources.B16x16_XMag;
			this.m_ctxGroupFind.Name = "m_ctxGroupFind";
			this.m_ctxGroupFind.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.F)));
			this.m_ctxGroupFind.Size = new System.Drawing.Size(226, 22);
			this.m_ctxGroupFind.Text = "Find in this Group...";
			this.m_ctxGroupFind.Click += new System.EventHandler(this.OnGroupsFind);
			// 
			// m_ctxGroupSep2
			// 
			this.m_ctxGroupSep2.Name = "m_ctxGroupSep2";
			this.m_ctxGroupSep2.Size = new System.Drawing.Size(223, 6);
			// 
			// m_ctxGroupPrint
			// 
			this.m_ctxGroupPrint.Image = global::KeePass.Properties.Resources.B16x16_FilePrint;
			this.m_ctxGroupPrint.Name = "m_ctxGroupPrint";
			this.m_ctxGroupPrint.Size = new System.Drawing.Size(226, 22);
			this.m_ctxGroupPrint.Text = "&Print Group...";
			this.m_ctxGroupPrint.Click += new System.EventHandler(this.OnGroupsPrint);
			// 
			// m_ctxGroupExport
			// 
			this.m_ctxGroupExport.Image = global::KeePass.Properties.Resources.B16x16_Folder_Outbox;
			this.m_ctxGroupExport.Name = "m_ctxGroupExport";
			this.m_ctxGroupExport.Size = new System.Drawing.Size(226, 22);
			this.m_ctxGroupExport.Text = "E&xport...";
			this.m_ctxGroupExport.Click += new System.EventHandler(this.OnGroupsExport);
			// 
			// m_ctxGroupSep3
			// 
			this.m_ctxGroupSep3.Name = "m_ctxGroupSep3";
			this.m_ctxGroupSep3.Size = new System.Drawing.Size(223, 6);
			// 
			// m_ctxGroupRearrange
			// 
			this.m_ctxGroupRearrange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxGroupMoveToTop,
            this.m_ctxGroupMoveOneUp,
            this.m_ctxGroupMoveOneDown,
            this.m_ctxGroupMoveToBottom});
			this.m_ctxGroupRearrange.Name = "m_ctxGroupRearrange";
			this.m_ctxGroupRearrange.Size = new System.Drawing.Size(226, 22);
			this.m_ctxGroupRearrange.Text = "&Rearrange";
			// 
			// m_ctxGroupMoveToTop
			// 
			this.m_ctxGroupMoveToTop.Image = global::KeePass.Properties.Resources.B16x16_2UpArrow;
			this.m_ctxGroupMoveToTop.Name = "m_ctxGroupMoveToTop";
			this.m_ctxGroupMoveToTop.ShortcutKeyDisplayString = "Alt+Home";
			this.m_ctxGroupMoveToTop.Size = new System.Drawing.Size(240, 22);
			this.m_ctxGroupMoveToTop.Text = "Move Group To &Top";
			this.m_ctxGroupMoveToTop.Click += new System.EventHandler(this.OnGroupsMoveToTop);
			// 
			// m_ctxGroupMoveOneUp
			// 
			this.m_ctxGroupMoveOneUp.Image = global::KeePass.Properties.Resources.B16x16_1UpArrow;
			this.m_ctxGroupMoveOneUp.Name = "m_ctxGroupMoveOneUp";
			this.m_ctxGroupMoveOneUp.ShortcutKeyDisplayString = "Alt+Up";
			this.m_ctxGroupMoveOneUp.Size = new System.Drawing.Size(240, 22);
			this.m_ctxGroupMoveOneUp.Text = "Move Group &One Up";
			this.m_ctxGroupMoveOneUp.Click += new System.EventHandler(this.OnGroupsMoveOneUp);
			// 
			// m_ctxGroupMoveOneDown
			// 
			this.m_ctxGroupMoveOneDown.Image = global::KeePass.Properties.Resources.B16x16_1DownArrow;
			this.m_ctxGroupMoveOneDown.Name = "m_ctxGroupMoveOneDown";
			this.m_ctxGroupMoveOneDown.ShortcutKeyDisplayString = "Alt+Down";
			this.m_ctxGroupMoveOneDown.Size = new System.Drawing.Size(240, 22);
			this.m_ctxGroupMoveOneDown.Text = "Mo&ve Group One Down";
			this.m_ctxGroupMoveOneDown.Click += new System.EventHandler(this.OnGroupsMoveOneDown);
			// 
			// m_ctxGroupMoveToBottom
			// 
			this.m_ctxGroupMoveToBottom.Image = global::KeePass.Properties.Resources.B16x16_2DownArrow;
			this.m_ctxGroupMoveToBottom.Name = "m_ctxGroupMoveToBottom";
			this.m_ctxGroupMoveToBottom.ShortcutKeyDisplayString = "Alt+End";
			this.m_ctxGroupMoveToBottom.Size = new System.Drawing.Size(240, 22);
			this.m_ctxGroupMoveToBottom.Text = "Move Group To &Bottom";
			this.m_ctxGroupMoveToBottom.Click += new System.EventHandler(this.OnGroupsMoveToBottom);
			// 
			// m_ilClientIcons
			// 
			this.m_ilClientIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_ilClientIcons.ImageStream")));
			this.m_ilClientIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.m_ilClientIcons.Images.SetKeyName(0, "C00_Password.png");
			this.m_ilClientIcons.Images.SetKeyName(1, "C01_Package_Network.png");
			this.m_ilClientIcons.Images.SetKeyName(2, "C02_MessageBox_Warning.png");
			this.m_ilClientIcons.Images.SetKeyName(3, "C03_Server.png");
			this.m_ilClientIcons.Images.SetKeyName(4, "C04_Klipper.png");
			this.m_ilClientIcons.Images.SetKeyName(5, "C05_Edu_Languages.png");
			this.m_ilClientIcons.Images.SetKeyName(6, "C06_KCMDF.png");
			this.m_ilClientIcons.Images.SetKeyName(7, "C07_Kate.png");
			this.m_ilClientIcons.Images.SetKeyName(8, "C08_Socket.png");
			this.m_ilClientIcons.Images.SetKeyName(9, "C09_Identity.png");
			this.m_ilClientIcons.Images.SetKeyName(10, "C10_Kontact.png");
			this.m_ilClientIcons.Images.SetKeyName(11, "C11_Camera.png");
			this.m_ilClientIcons.Images.SetKeyName(12, "C12_IRKickFlash.png");
			this.m_ilClientIcons.Images.SetKeyName(13, "C13_KGPG_Key3.png");
			this.m_ilClientIcons.Images.SetKeyName(14, "C14_Laptop_Power.png");
			this.m_ilClientIcons.Images.SetKeyName(15, "C15_Scanner.png");
			this.m_ilClientIcons.Images.SetKeyName(16, "C16_Mozilla_Firebird.png");
			this.m_ilClientIcons.Images.SetKeyName(17, "C17_CDROM_Unmount.png");
			this.m_ilClientIcons.Images.SetKeyName(18, "C18_Display.png");
			this.m_ilClientIcons.Images.SetKeyName(19, "C19_Mail_Generic.png");
			this.m_ilClientIcons.Images.SetKeyName(20, "C20_Misc.png");
			this.m_ilClientIcons.Images.SetKeyName(21, "C21_KOrganizer.png");
			this.m_ilClientIcons.Images.SetKeyName(22, "C22_ASCII.png");
			this.m_ilClientIcons.Images.SetKeyName(23, "C23_Icons.png");
			this.m_ilClientIcons.Images.SetKeyName(24, "C24_Connect_Established.png");
			this.m_ilClientIcons.Images.SetKeyName(25, "C25_Folder_Mail.png");
			this.m_ilClientIcons.Images.SetKeyName(26, "C26_FileSave.png");
			this.m_ilClientIcons.Images.SetKeyName(27, "C27_NFS_Unmount.png");
			this.m_ilClientIcons.Images.SetKeyName(28, "C28_QuickTime.png");
			this.m_ilClientIcons.Images.SetKeyName(29, "C29_KGPG_Term.png");
			this.m_ilClientIcons.Images.SetKeyName(30, "C30_Konsole.png");
			this.m_ilClientIcons.Images.SetKeyName(31, "C31_FilePrint.png");
			this.m_ilClientIcons.Images.SetKeyName(32, "C32_FSView.png");
			this.m_ilClientIcons.Images.SetKeyName(33, "C33_Run.png");
			this.m_ilClientIcons.Images.SetKeyName(34, "C34_Configure.png");
			this.m_ilClientIcons.Images.SetKeyName(35, "C35_KRFB.png");
			this.m_ilClientIcons.Images.SetKeyName(36, "C36_Ark.png");
			this.m_ilClientIcons.Images.SetKeyName(37, "C37_KPercentage.png");
			this.m_ilClientIcons.Images.SetKeyName(38, "C38_Samba_Unmount.png");
			this.m_ilClientIcons.Images.SetKeyName(39, "C39_History.png");
			this.m_ilClientIcons.Images.SetKeyName(40, "C40_Mail_Find.png");
			this.m_ilClientIcons.Images.SetKeyName(41, "C41_VectorGfx.png");
			this.m_ilClientIcons.Images.SetKeyName(42, "C42_KCMMemory.png");
			this.m_ilClientIcons.Images.SetKeyName(43, "C43_EditTrash.png");
			this.m_ilClientIcons.Images.SetKeyName(44, "C44_KNotes.png");
			this.m_ilClientIcons.Images.SetKeyName(45, "C45_Cancel.png");
			this.m_ilClientIcons.Images.SetKeyName(46, "C46_Help.png");
			this.m_ilClientIcons.Images.SetKeyName(47, "C47_KPackage.png");
			this.m_ilClientIcons.Images.SetKeyName(48, "C48_Folder.png");
			this.m_ilClientIcons.Images.SetKeyName(49, "C49_Folder_Blue_Open.png");
			this.m_ilClientIcons.Images.SetKeyName(50, "C50_Folder_Tar.png");
			this.m_ilClientIcons.Images.SetKeyName(51, "C51_Decrypted.png");
			this.m_ilClientIcons.Images.SetKeyName(52, "C52_Encrypted.png");
			this.m_ilClientIcons.Images.SetKeyName(53, "C53_Apply.png");
			this.m_ilClientIcons.Images.SetKeyName(54, "C54_Signature.png");
			this.m_ilClientIcons.Images.SetKeyName(55, "C55_Thumbnail.png");
			this.m_ilClientIcons.Images.SetKeyName(56, "C56_KAddressBook.png");
			this.m_ilClientIcons.Images.SetKeyName(57, "C57_View_Text.png");
			this.m_ilClientIcons.Images.SetKeyName(58, "C58_KGPG.png");
			this.m_ilClientIcons.Images.SetKeyName(59, "C59_Package_Development.png");
			this.m_ilClientIcons.Images.SetKeyName(60, "C60_KFM_Home.png");
			this.m_ilClientIcons.Images.SetKeyName(61, "C61_Services.png");
			this.m_ilClientIcons.Images.SetKeyName(62, "C62_Tux.png");
			this.m_ilClientIcons.Images.SetKeyName(63, "C63_Feather.png");
			this.m_ilClientIcons.Images.SetKeyName(64, "C64_Apple.png");
			this.m_ilClientIcons.Images.SetKeyName(65, "C65_Apple.png");
			this.m_ilClientIcons.Images.SetKeyName(66, "C66_Money.png");
			this.m_ilClientIcons.Images.SetKeyName(67, "C67_Certificate.png");
			this.m_ilClientIcons.Images.SetKeyName(68, "C68_BlackBerry.png");
			// 
			// m_ctxPwList
			// 
			this.m_ctxPwList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxEntryCopyUserName,
            this.m_ctxEntryCopyPassword,
            this.m_ctxEntryUrl,
            this.m_ctxEntryCopyCustomString,
            this.m_ctxEntryBinaries,
            this.m_ctxEntrySaveAttachedFiles,
            this.m_ctxEntrySep0,
            this.m_ctxEntryPerformAutoType,
            this.m_ctxEntrySep1,
            this.m_ctxEntryAdd,
            this.m_ctxEntryEdit,
            this.m_ctxEntryDuplicate,
            this.m_ctxEntryDelete,
            this.m_ctxEntryMassModify,
            this.m_ctxEntrySelectAll,
            this.m_ctxEntrySep2,
            this.m_ctxEntryClipboard,
            this.m_ctxEntryRearrangePopup});
			this.m_ctxPwList.Name = "m_ctxPwList";
			this.m_ctxPwList.Size = new System.Drawing.Size(201, 352);
			this.m_ctxPwList.Opening += new System.ComponentModel.CancelEventHandler(this.OnCtxPwListOpening);
			// 
			// m_ctxEntryCopyUserName
			// 
			this.m_ctxEntryCopyUserName.Image = global::KeePass.Properties.Resources.B16x16_Personal;
			this.m_ctxEntryCopyUserName.Name = "m_ctxEntryCopyUserName";
			this.m_ctxEntryCopyUserName.ShortcutKeyDisplayString = "Ctrl+B";
			this.m_ctxEntryCopyUserName.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryCopyUserName.Text = "Copy User &Name";
			this.m_ctxEntryCopyUserName.Click += new System.EventHandler(this.OnEntryCopyUserName);
			// 
			// m_ctxEntryCopyPassword
			// 
			this.m_ctxEntryCopyPassword.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Info;
			this.m_ctxEntryCopyPassword.Name = "m_ctxEntryCopyPassword";
			this.m_ctxEntryCopyPassword.ShortcutKeyDisplayString = "Ctrl+C";
			this.m_ctxEntryCopyPassword.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryCopyPassword.Text = "<COPYPW>";
			this.m_ctxEntryCopyPassword.Click += new System.EventHandler(this.OnEntryCopyPassword);
			// 
			// m_ctxEntryUrl
			// 
			this.m_ctxEntryUrl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxEntryOpenUrl,
            this.m_ctxEntryCopyUrl,
            this.m_ctxEntryUrlSep0,
            this.m_ctxEntryUrlOpenInInternal});
			this.m_ctxEntryUrl.Name = "m_ctxEntryUrl";
			this.m_ctxEntryUrl.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryUrl.Text = "&URL(s)";
			// 
			// m_ctxEntryOpenUrl
			// 
			this.m_ctxEntryOpenUrl.Image = global::KeePass.Properties.Resources.B16x16_FTP;
			this.m_ctxEntryOpenUrl.Name = "m_ctxEntryOpenUrl";
			this.m_ctxEntryOpenUrl.ShortcutKeyDisplayString = "Ctrl+U";
			this.m_ctxEntryOpenUrl.Size = new System.Drawing.Size(190, 22);
			this.m_ctxEntryOpenUrl.Text = "&Open in Browser";
			this.m_ctxEntryOpenUrl.Click += new System.EventHandler(this.OnEntryOpenUrl);
			// 
			// m_ctxEntryCopyUrl
			// 
			this.m_ctxEntryCopyUrl.Image = global::KeePass.Properties.Resources.B16x16_EditCopy;
			this.m_ctxEntryCopyUrl.Name = "m_ctxEntryCopyUrl";
			this.m_ctxEntryCopyUrl.Size = new System.Drawing.Size(190, 22);
			this.m_ctxEntryCopyUrl.Text = "&Copy to Clipboard";
			this.m_ctxEntryCopyUrl.Click += new System.EventHandler(this.OnEntryCopyURL);
			// 
			// m_ctxEntryUrlSep0
			// 
			this.m_ctxEntryUrlSep0.Name = "m_ctxEntryUrlSep0";
			this.m_ctxEntryUrlSep0.Size = new System.Drawing.Size(187, 6);
			this.m_ctxEntryUrlSep0.Visible = false;
			// 
			// m_ctxEntryUrlOpenInInternal
			// 
			this.m_ctxEntryUrlOpenInInternal.Image = global::KeePass.Properties.Resources.B16x16_Browser;
			this.m_ctxEntryUrlOpenInInternal.Name = "m_ctxEntryUrlOpenInInternal";
			this.m_ctxEntryUrlOpenInInternal.Size = new System.Drawing.Size(190, 22);
			this.m_ctxEntryUrlOpenInInternal.Text = "Open in Internal Browser";
			this.m_ctxEntryUrlOpenInInternal.Visible = false;
			this.m_ctxEntryUrlOpenInInternal.Click += new System.EventHandler(this.OnEntryUrlOpenInInternal);
			// 
			// m_ctxEntryCopyCustomString
			// 
			this.m_ctxEntryCopyCustomString.Name = "m_ctxEntryCopyCustomString";
			this.m_ctxEntryCopyCustomString.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryCopyCustomString.Text = "Copy Custom &String";
			// 
			// m_ctxEntryBinaries
			// 
			this.m_ctxEntryBinaries.Name = "m_ctxEntryBinaries";
			this.m_ctxEntryBinaries.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryBinaries.Text = "Show in Internal Viewer";
			// 
			// m_ctxEntrySaveAttachedFiles
			// 
			this.m_ctxEntrySaveAttachedFiles.Image = global::KeePass.Properties.Resources.B16x16_Attach;
			this.m_ctxEntrySaveAttachedFiles.Name = "m_ctxEntrySaveAttachedFiles";
			this.m_ctxEntrySaveAttachedFiles.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntrySaveAttachedFiles.Text = "Save Attached &File(s) To...";
			this.m_ctxEntrySaveAttachedFiles.Click += new System.EventHandler(this.OnEntrySaveAttachments);
			// 
			// m_ctxEntrySep0
			// 
			this.m_ctxEntrySep0.Name = "m_ctxEntrySep0";
			this.m_ctxEntrySep0.Size = new System.Drawing.Size(197, 6);
			// 
			// m_ctxEntryPerformAutoType
			// 
			this.m_ctxEntryPerformAutoType.Image = global::KeePass.Properties.Resources.B16x16_KRec_Record;
			this.m_ctxEntryPerformAutoType.Name = "m_ctxEntryPerformAutoType";
			this.m_ctxEntryPerformAutoType.ShortcutKeyDisplayString = "Ctrl+V";
			this.m_ctxEntryPerformAutoType.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryPerformAutoType.Text = "Perform Auto-&Type";
			this.m_ctxEntryPerformAutoType.Click += new System.EventHandler(this.OnEntryPerformAutoType);
			// 
			// m_ctxEntrySep1
			// 
			this.m_ctxEntrySep1.Name = "m_ctxEntrySep1";
			this.m_ctxEntrySep1.Size = new System.Drawing.Size(197, 6);
			// 
			// m_ctxEntryAdd
			// 
			this.m_ctxEntryAdd.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Import;
			this.m_ctxEntryAdd.Name = "m_ctxEntryAdd";
			this.m_ctxEntryAdd.ShortcutKeyDisplayString = "Ins";
			this.m_ctxEntryAdd.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryAdd.Text = "&Add Entry...";
			this.m_ctxEntryAdd.Click += new System.EventHandler(this.OnEntryAdd);
			// 
			// m_ctxEntryEdit
			// 
			this.m_ctxEntryEdit.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Sign;
			this.m_ctxEntryEdit.Name = "m_ctxEntryEdit";
			this.m_ctxEntryEdit.ShortcutKeyDisplayString = "Ctrl+E";
			this.m_ctxEntryEdit.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryEdit.Text = "&Edit/View Entry...";
			this.m_ctxEntryEdit.Click += new System.EventHandler(this.OnEntryEdit);
			// 
			// m_ctxEntryDuplicate
			// 
			this.m_ctxEntryDuplicate.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Key2;
			this.m_ctxEntryDuplicate.Name = "m_ctxEntryDuplicate";
			this.m_ctxEntryDuplicate.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryDuplicate.Text = "Dupli&cate Entry";
			this.m_ctxEntryDuplicate.Click += new System.EventHandler(this.OnEntryDuplicate);
			// 
			// m_ctxEntryDelete
			// 
			this.m_ctxEntryDelete.Image = global::KeePass.Properties.Resources.B16x16_DeleteEntry;
			this.m_ctxEntryDelete.Name = "m_ctxEntryDelete";
			this.m_ctxEntryDelete.ShortcutKeyDisplayString = "Del";
			this.m_ctxEntryDelete.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryDelete.Text = "&Delete Entry";
			this.m_ctxEntryDelete.Click += new System.EventHandler(this.OnEntryDelete);
			// 
			// m_ctxEntryMassModify
			// 
			this.m_ctxEntryMassModify.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxEntrySetColor,
            this.m_ctxEntryMassSetIcon,
            this.m_ctxEntrySelectedSep0,
            this.m_ctxEntrySelectedPrint,
            this.m_ctxEntrySelectedExport});
			this.m_ctxEntryMassModify.Name = "m_ctxEntryMassModify";
			this.m_ctxEntryMassModify.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryMassModify.Text = "Selected Entries";
			// 
			// m_ctxEntrySetColor
			// 
			this.m_ctxEntrySetColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxEntryColorStandard,
            this.m_ctxEntryColorSep0,
            this.m_ctxEntryColorLightRed,
            this.m_ctxEntryColorLightGreen,
            this.m_ctxEntryColorLightBlue,
            this.m_ctxEntryColorLightYellow,
            this.m_ctxEntryColorSep1,
            this.m_ctxEntryColorCustom});
			this.m_ctxEntrySetColor.Name = "m_ctxEntrySetColor";
			this.m_ctxEntrySetColor.Size = new System.Drawing.Size(128, 22);
			this.m_ctxEntrySetColor.Text = "Set &Color";
			// 
			// m_ctxEntryColorStandard
			// 
			this.m_ctxEntryColorStandard.Name = "m_ctxEntryColorStandard";
			this.m_ctxEntryColorStandard.Size = new System.Drawing.Size(184, 22);
			this.m_ctxEntryColorStandard.Text = "&Standard";
			this.m_ctxEntryColorStandard.Click += new System.EventHandler(this.OnEntryColorStandard);
			// 
			// m_ctxEntryColorSep0
			// 
			this.m_ctxEntryColorSep0.Name = "m_ctxEntryColorSep0";
			this.m_ctxEntryColorSep0.Size = new System.Drawing.Size(181, 6);
			// 
			// m_ctxEntryColorLightRed
			// 
			this.m_ctxEntryColorLightRed.Name = "m_ctxEntryColorLightRed";
			this.m_ctxEntryColorLightRed.Size = new System.Drawing.Size(184, 22);
			this.m_ctxEntryColorLightRed.Text = "Light &Red";
			this.m_ctxEntryColorLightRed.Click += new System.EventHandler(this.OnEntryColorLightRed);
			// 
			// m_ctxEntryColorLightGreen
			// 
			this.m_ctxEntryColorLightGreen.Name = "m_ctxEntryColorLightGreen";
			this.m_ctxEntryColorLightGreen.Size = new System.Drawing.Size(184, 22);
			this.m_ctxEntryColorLightGreen.Text = "Light &Green";
			this.m_ctxEntryColorLightGreen.Click += new System.EventHandler(this.OnEntryColorLightGreen);
			// 
			// m_ctxEntryColorLightBlue
			// 
			this.m_ctxEntryColorLightBlue.Name = "m_ctxEntryColorLightBlue";
			this.m_ctxEntryColorLightBlue.Size = new System.Drawing.Size(184, 22);
			this.m_ctxEntryColorLightBlue.Text = "Light &Blue";
			this.m_ctxEntryColorLightBlue.Click += new System.EventHandler(this.OnEntryColorLightBlue);
			// 
			// m_ctxEntryColorLightYellow
			// 
			this.m_ctxEntryColorLightYellow.Name = "m_ctxEntryColorLightYellow";
			this.m_ctxEntryColorLightYellow.Size = new System.Drawing.Size(184, 22);
			this.m_ctxEntryColorLightYellow.Text = "Light &Yellow";
			this.m_ctxEntryColorLightYellow.Click += new System.EventHandler(this.OnEntryColorLightYellow);
			// 
			// m_ctxEntryColorSep1
			// 
			this.m_ctxEntryColorSep1.Name = "m_ctxEntryColorSep1";
			this.m_ctxEntryColorSep1.Size = new System.Drawing.Size(181, 6);
			// 
			// m_ctxEntryColorCustom
			// 
			this.m_ctxEntryColorCustom.Name = "m_ctxEntryColorCustom";
			this.m_ctxEntryColorCustom.Size = new System.Drawing.Size(184, 22);
			this.m_ctxEntryColorCustom.Text = "&Choose Custom Color...";
			this.m_ctxEntryColorCustom.Click += new System.EventHandler(this.OnEntryColorCustom);
			// 
			// m_ctxEntryMassSetIcon
			// 
			this.m_ctxEntryMassSetIcon.Image = global::KeePass.Properties.Resources.B16x16_Spreadsheet;
			this.m_ctxEntryMassSetIcon.Name = "m_ctxEntryMassSetIcon";
			this.m_ctxEntryMassSetIcon.Size = new System.Drawing.Size(128, 22);
			this.m_ctxEntryMassSetIcon.Text = "Set &Icons...";
			this.m_ctxEntryMassSetIcon.Click += new System.EventHandler(this.OnEntryMassSetIcon);
			// 
			// m_ctxEntrySelectedSep0
			// 
			this.m_ctxEntrySelectedSep0.Name = "m_ctxEntrySelectedSep0";
			this.m_ctxEntrySelectedSep0.Size = new System.Drawing.Size(125, 6);
			// 
			// m_ctxEntrySelectedPrint
			// 
			this.m_ctxEntrySelectedPrint.Image = global::KeePass.Properties.Resources.B16x16_FilePrint;
			this.m_ctxEntrySelectedPrint.Name = "m_ctxEntrySelectedPrint";
			this.m_ctxEntrySelectedPrint.Size = new System.Drawing.Size(128, 22);
			this.m_ctxEntrySelectedPrint.Text = "&Print...";
			this.m_ctxEntrySelectedPrint.Click += new System.EventHandler(this.OnEntrySelectedPrint);
			// 
			// m_ctxEntrySelectedExport
			// 
			this.m_ctxEntrySelectedExport.Image = global::KeePass.Properties.Resources.B16x16_Folder_Outbox;
			this.m_ctxEntrySelectedExport.Name = "m_ctxEntrySelectedExport";
			this.m_ctxEntrySelectedExport.Size = new System.Drawing.Size(128, 22);
			this.m_ctxEntrySelectedExport.Text = "&Export...";
			this.m_ctxEntrySelectedExport.Click += new System.EventHandler(this.OnEntrySelectedExport);
			// 
			// m_ctxEntrySelectAll
			// 
			this.m_ctxEntrySelectAll.Name = "m_ctxEntrySelectAll";
			this.m_ctxEntrySelectAll.ShortcutKeyDisplayString = "Ctrl+A";
			this.m_ctxEntrySelectAll.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntrySelectAll.Text = "Se&lect All";
			this.m_ctxEntrySelectAll.Click += new System.EventHandler(this.OnEntrySelectAll);
			// 
			// m_ctxEntrySep2
			// 
			this.m_ctxEntrySep2.Name = "m_ctxEntrySep2";
			this.m_ctxEntrySep2.Size = new System.Drawing.Size(197, 6);
			// 
			// m_ctxEntryClipboard
			// 
			this.m_ctxEntryClipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxEntryClipCopy,
            this.m_ctxEntryClipPaste});
			this.m_ctxEntryClipboard.Name = "m_ctxEntryClipboard";
			this.m_ctxEntryClipboard.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryClipboard.Text = "Clip&board";
			// 
			// m_ctxEntryClipCopy
			// 
			this.m_ctxEntryClipCopy.Image = global::KeePass.Properties.Resources.B16x16_EditCopy;
			this.m_ctxEntryClipCopy.Name = "m_ctxEntryClipCopy";
			this.m_ctxEntryClipCopy.Size = new System.Drawing.Size(136, 22);
			this.m_ctxEntryClipCopy.Text = "&Copy Entries";
			this.m_ctxEntryClipCopy.Click += new System.EventHandler(this.OnEntryClipCopy);
			// 
			// m_ctxEntryClipPaste
			// 
			this.m_ctxEntryClipPaste.Image = global::KeePass.Properties.Resources.B16x16_EditPaste;
			this.m_ctxEntryClipPaste.Name = "m_ctxEntryClipPaste";
			this.m_ctxEntryClipPaste.Size = new System.Drawing.Size(136, 22);
			this.m_ctxEntryClipPaste.Text = "&Paste Entries";
			this.m_ctxEntryClipPaste.Click += new System.EventHandler(this.OnEntryClipPaste);
			// 
			// m_ctxEntryRearrangePopup
			// 
			this.m_ctxEntryRearrangePopup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxEntryMoveToTop,
            this.m_ctxEntryMoveOneUp,
            this.m_ctxEntryMoveOneDown,
            this.m_ctxEntryMoveToBottom,
            this.m_ctxEntryRearrangeSep0,
            this.m_ctxEntrySortUnsorted,
            this.m_ctxEntryRearrangeSep1,
            this.m_ctxEntrySortListByTitle,
            this.m_ctxEntrySortListByUserName,
            this.m_ctxEntrySortListByPassword,
            this.m_ctxEntrySortListByURL,
            this.m_ctxEntrySortListByNotes,
            this.m_ctxEntrySortListByCreationTime,
            this.m_ctxEntrySortListByLastModTime,
            this.m_ctxEntrySortListByLastAccessTime,
            this.m_ctxEntrySortListByExpirationTime});
			this.m_ctxEntryRearrangePopup.Name = "m_ctxEntryRearrangePopup";
			this.m_ctxEntryRearrangePopup.Size = new System.Drawing.Size(200, 22);
			this.m_ctxEntryRearrangePopup.Text = "&Rearrange";
			// 
			// m_ctxEntryMoveToTop
			// 
			this.m_ctxEntryMoveToTop.Image = global::KeePass.Properties.Resources.B16x16_2UpArrow;
			this.m_ctxEntryMoveToTop.Name = "m_ctxEntryMoveToTop";
			this.m_ctxEntryMoveToTop.ShortcutKeyDisplayString = "Alt+Home";
			this.m_ctxEntryMoveToTop.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntryMoveToTop.Text = "Move Entry to &Top";
			this.m_ctxEntryMoveToTop.Click += new System.EventHandler(this.OnEntryMoveToTop);
			// 
			// m_ctxEntryMoveOneUp
			// 
			this.m_ctxEntryMoveOneUp.Image = global::KeePass.Properties.Resources.B16x16_1UpArrow;
			this.m_ctxEntryMoveOneUp.Name = "m_ctxEntryMoveOneUp";
			this.m_ctxEntryMoveOneUp.ShortcutKeyDisplayString = "Alt+Up";
			this.m_ctxEntryMoveOneUp.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntryMoveOneUp.Text = "Move Entry &One Up";
			this.m_ctxEntryMoveOneUp.Click += new System.EventHandler(this.OnEntryMoveOneUp);
			// 
			// m_ctxEntryMoveOneDown
			// 
			this.m_ctxEntryMoveOneDown.Image = global::KeePass.Properties.Resources.B16x16_1DownArrow;
			this.m_ctxEntryMoveOneDown.Name = "m_ctxEntryMoveOneDown";
			this.m_ctxEntryMoveOneDown.ShortcutKeyDisplayString = "Alt+Down";
			this.m_ctxEntryMoveOneDown.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntryMoveOneDown.Text = "Mo&ve Entry One Down";
			this.m_ctxEntryMoveOneDown.Click += new System.EventHandler(this.OnEntryMoveOneDown);
			// 
			// m_ctxEntryMoveToBottom
			// 
			this.m_ctxEntryMoveToBottom.Image = global::KeePass.Properties.Resources.B16x16_2DownArrow;
			this.m_ctxEntryMoveToBottom.Name = "m_ctxEntryMoveToBottom";
			this.m_ctxEntryMoveToBottom.ShortcutKeyDisplayString = "Alt+End";
			this.m_ctxEntryMoveToBottom.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntryMoveToBottom.Text = "Move Entry to &Bottom";
			this.m_ctxEntryMoveToBottom.Click += new System.EventHandler(this.OnEntryMoveToBottom);
			// 
			// m_ctxEntryRearrangeSep0
			// 
			this.m_ctxEntryRearrangeSep0.Name = "m_ctxEntryRearrangeSep0";
			this.m_ctxEntryRearrangeSep0.Size = new System.Drawing.Size(233, 6);
			// 
			// m_ctxEntrySortUnsorted
			// 
			this.m_ctxEntrySortUnsorted.Image = global::KeePass.Properties.Resources.B16x16_Reload_Page;
			this.m_ctxEntrySortUnsorted.Name = "m_ctxEntrySortUnsorted";
			this.m_ctxEntrySortUnsorted.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntrySortUnsorted.Text = "Original Order (Unsorted)";
			this.m_ctxEntrySortUnsorted.Click += new System.EventHandler(this.OnEntrySortUnsorted);
			// 
			// m_ctxEntryRearrangeSep1
			// 
			this.m_ctxEntryRearrangeSep1.Name = "m_ctxEntryRearrangeSep1";
			this.m_ctxEntryRearrangeSep1.Size = new System.Drawing.Size(233, 6);
			// 
			// m_ctxEntrySortListByTitle
			// 
			this.m_ctxEntrySortListByTitle.Image = global::KeePass.Properties.Resources.B16x16_Reload_Page;
			this.m_ctxEntrySortListByTitle.Name = "m_ctxEntrySortListByTitle";
			this.m_ctxEntrySortListByTitle.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntrySortListByTitle.Text = "Sort List By &Title";
			this.m_ctxEntrySortListByTitle.Click += new System.EventHandler(this.OnEntrySortTitle);
			// 
			// m_ctxEntrySortListByUserName
			// 
			this.m_ctxEntrySortListByUserName.Image = global::KeePass.Properties.Resources.B16x16_Reload_Page;
			this.m_ctxEntrySortListByUserName.Name = "m_ctxEntrySortListByUserName";
			this.m_ctxEntrySortListByUserName.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntrySortListByUserName.Text = "Sort List By User &Name";
			this.m_ctxEntrySortListByUserName.Click += new System.EventHandler(this.OnEntrySortUserName);
			// 
			// m_ctxEntrySortListByPassword
			// 
			this.m_ctxEntrySortListByPassword.Image = global::KeePass.Properties.Resources.B16x16_Reload_Page;
			this.m_ctxEntrySortListByPassword.Name = "m_ctxEntrySortListByPassword";
			this.m_ctxEntrySortListByPassword.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntrySortListByPassword.Text = "Sort List By &Password";
			this.m_ctxEntrySortListByPassword.Click += new System.EventHandler(this.OnEntrySortPassword);
			// 
			// m_ctxEntrySortListByURL
			// 
			this.m_ctxEntrySortListByURL.Image = global::KeePass.Properties.Resources.B16x16_Reload_Page;
			this.m_ctxEntrySortListByURL.Name = "m_ctxEntrySortListByURL";
			this.m_ctxEntrySortListByURL.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntrySortListByURL.Text = "Sort List By &URL";
			this.m_ctxEntrySortListByURL.Click += new System.EventHandler(this.OnEntrySortURL);
			// 
			// m_ctxEntrySortListByNotes
			// 
			this.m_ctxEntrySortListByNotes.Image = global::KeePass.Properties.Resources.B16x16_Reload_Page;
			this.m_ctxEntrySortListByNotes.Name = "m_ctxEntrySortListByNotes";
			this.m_ctxEntrySortListByNotes.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntrySortListByNotes.Text = "Sort List By Note&s";
			this.m_ctxEntrySortListByNotes.Click += new System.EventHandler(this.OnEntrySortNotes);
			// 
			// m_ctxEntrySortListByCreationTime
			// 
			this.m_ctxEntrySortListByCreationTime.Image = global::KeePass.Properties.Resources.B16x16_History;
			this.m_ctxEntrySortListByCreationTime.Name = "m_ctxEntrySortListByCreationTime";
			this.m_ctxEntrySortListByCreationTime.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntrySortListByCreationTime.Text = "Sort List By &Creation Time";
			this.m_ctxEntrySortListByCreationTime.Click += new System.EventHandler(this.OnEntrySortCreationTime);
			// 
			// m_ctxEntrySortListByLastModTime
			// 
			this.m_ctxEntrySortListByLastModTime.Image = global::KeePass.Properties.Resources.B16x16_History;
			this.m_ctxEntrySortListByLastModTime.Name = "m_ctxEntrySortListByLastModTime";
			this.m_ctxEntrySortListByLastModTime.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntrySortListByLastModTime.Text = "Sort List By Last &Modification Time";
			this.m_ctxEntrySortListByLastModTime.Click += new System.EventHandler(this.OnEntrySortLastMod);
			// 
			// m_ctxEntrySortListByLastAccessTime
			// 
			this.m_ctxEntrySortListByLastAccessTime.Image = global::KeePass.Properties.Resources.B16x16_History;
			this.m_ctxEntrySortListByLastAccessTime.Name = "m_ctxEntrySortListByLastAccessTime";
			this.m_ctxEntrySortListByLastAccessTime.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntrySortListByLastAccessTime.Text = "Sort List By Last &Access Time";
			this.m_ctxEntrySortListByLastAccessTime.Click += new System.EventHandler(this.OnEntrySortLastAccess);
			// 
			// m_ctxEntrySortListByExpirationTime
			// 
			this.m_ctxEntrySortListByExpirationTime.Image = global::KeePass.Properties.Resources.B16x16_History;
			this.m_ctxEntrySortListByExpirationTime.Name = "m_ctxEntrySortListByExpirationTime";
			this.m_ctxEntrySortListByExpirationTime.Size = new System.Drawing.Size(236, 22);
			this.m_ctxEntrySortListByExpirationTime.Text = "Sort List By &Expiration Time";
			this.m_ctxEntrySortListByExpirationTime.Click += new System.EventHandler(this.OnEntrySortExpiration);
			// 
			// m_menuMain
			// 
			this.m_menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuFile,
            this.m_menuEdit,
            this.m_menuView,
            this.m_menuTools,
            this.m_menuHelp});
			this.m_menuMain.Location = new System.Drawing.Point(0, 0);
			this.m_menuMain.Name = "m_menuMain";
			this.m_menuMain.Size = new System.Drawing.Size(654, 24);
			this.m_menuMain.TabIndex = 0;
			this.m_menuMain.Text = "Main Menu";
			// 
			// m_menuFile
			// 
			this.m_menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuFileNew,
            this.m_menuFileOpen,
            this.m_menuFileRecent,
            this.m_menuFileClose,
            this.m_menuFileSep0,
            this.m_menuFileSave,
            this.m_menuFileSaveAs,
            this.m_menuFileSep1,
            this.m_menuFileDbSettings,
            this.m_menuFileChangeMasterKey,
            this.m_menuFileSep2,
            this.m_menuFilePrint,
            this.m_menuFileSep3,
            this.m_menuFileImport,
            this.m_menuFileExport,
            this.m_menuFileSync,
            this.m_menuFileSep4,
            this.m_menuFileLock,
            this.m_menuFileExit});
			this.m_menuFile.Name = "m_menuFile";
			this.m_menuFile.Size = new System.Drawing.Size(35, 20);
			this.m_menuFile.Text = "&File";
			// 
			// m_menuFileNew
			// 
			this.m_menuFileNew.Image = global::KeePass.Properties.Resources.B16x16_FileNew;
			this.m_menuFileNew.Name = "m_menuFileNew";
			this.m_menuFileNew.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileNew.Text = "&New...";
			this.m_menuFileNew.Click += new System.EventHandler(this.OnFileNew);
			// 
			// m_menuFileOpen
			// 
			this.m_menuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuFileOpenLocal,
            this.m_menuFileOpenUrl});
			this.m_menuFileOpen.Name = "m_menuFileOpen";
			this.m_menuFileOpen.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileOpen.Text = "&Open";
			// 
			// m_menuFileOpenLocal
			// 
			this.m_menuFileOpenLocal.Image = global::KeePass.Properties.Resources.B16x16_Folder_Yellow_Open;
			this.m_menuFileOpenLocal.Name = "m_menuFileOpenLocal";
			this.m_menuFileOpenLocal.Size = new System.Drawing.Size(134, 22);
			this.m_menuFileOpenLocal.Text = "Open File...";
			this.m_menuFileOpenLocal.Click += new System.EventHandler(this.OnFileOpen);
			// 
			// m_menuFileOpenUrl
			// 
			this.m_menuFileOpenUrl.Image = global::KeePass.Properties.Resources.B16x16_Browser;
			this.m_menuFileOpenUrl.Name = "m_menuFileOpenUrl";
			this.m_menuFileOpenUrl.Size = new System.Drawing.Size(134, 22);
			this.m_menuFileOpenUrl.Text = "Open URL...";
			this.m_menuFileOpenUrl.Click += new System.EventHandler(this.OnFileOpenUrl);
			// 
			// m_menuFileRecent
			// 
			this.m_menuFileRecent.Name = "m_menuFileRecent";
			this.m_menuFileRecent.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileRecent.Text = "Open &Recent";
			// 
			// m_menuFileClose
			// 
			this.m_menuFileClose.Image = global::KeePass.Properties.Resources.B16x16_File_Close;
			this.m_menuFileClose.Name = "m_menuFileClose";
			this.m_menuFileClose.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileClose.Text = "&Close";
			this.m_menuFileClose.Click += new System.EventHandler(this.OnFileClose);
			// 
			// m_menuFileSep0
			// 
			this.m_menuFileSep0.Name = "m_menuFileSep0";
			this.m_menuFileSep0.Size = new System.Drawing.Size(173, 6);
			// 
			// m_menuFileSave
			// 
			this.m_menuFileSave.Image = global::KeePass.Properties.Resources.B16x16_FileSave;
			this.m_menuFileSave.Name = "m_menuFileSave";
			this.m_menuFileSave.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileSave.Text = "&Save";
			this.m_menuFileSave.Click += new System.EventHandler(this.OnFileSave);
			// 
			// m_menuFileSaveAs
			// 
			this.m_menuFileSaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuFileSaveAsLocal,
            this.m_menuFileSaveAsUrl,
            this.m_menuFileSaveAsSep0,
            this.m_menuFileSaveAsCopy});
			this.m_menuFileSaveAs.Name = "m_menuFileSaveAs";
			this.m_menuFileSaveAs.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileSaveAs.Text = "Save &As";
			// 
			// m_menuFileSaveAsLocal
			// 
			this.m_menuFileSaveAsLocal.Image = global::KeePass.Properties.Resources.B16x16_FileSaveAs;
			this.m_menuFileSaveAsLocal.Name = "m_menuFileSaveAsLocal";
			this.m_menuFileSaveAsLocal.Size = new System.Drawing.Size(166, 22);
			this.m_menuFileSaveAsLocal.Text = "Save to &File...";
			this.m_menuFileSaveAsLocal.Click += new System.EventHandler(this.OnFileSaveAs);
			// 
			// m_menuFileSaveAsUrl
			// 
			this.m_menuFileSaveAsUrl.Image = global::KeePass.Properties.Resources.B16x16_Browser;
			this.m_menuFileSaveAsUrl.Name = "m_menuFileSaveAsUrl";
			this.m_menuFileSaveAsUrl.Size = new System.Drawing.Size(166, 22);
			this.m_menuFileSaveAsUrl.Text = "Save to &URL...";
			this.m_menuFileSaveAsUrl.Click += new System.EventHandler(this.OnFileSaveAsUrl);
			// 
			// m_menuFileSaveAsSep0
			// 
			this.m_menuFileSaveAsSep0.Name = "m_menuFileSaveAsSep0";
			this.m_menuFileSaveAsSep0.Size = new System.Drawing.Size(163, 6);
			// 
			// m_menuFileSaveAsCopy
			// 
			this.m_menuFileSaveAsCopy.Image = global::KeePass.Properties.Resources.B16x16_FileSaveAs;
			this.m_menuFileSaveAsCopy.Name = "m_menuFileSaveAsCopy";
			this.m_menuFileSaveAsCopy.Size = new System.Drawing.Size(166, 22);
			this.m_menuFileSaveAsCopy.Text = "Save &Copy to File...";
			this.m_menuFileSaveAsCopy.Click += new System.EventHandler(this.OnFileSaveAsCopy);
			// 
			// m_menuFileSep1
			// 
			this.m_menuFileSep1.Name = "m_menuFileSep1";
			this.m_menuFileSep1.Size = new System.Drawing.Size(173, 6);
			// 
			// m_menuFileDbSettings
			// 
			this.m_menuFileDbSettings.Image = global::KeePass.Properties.Resources.B16x16_Package_Development;
			this.m_menuFileDbSettings.Name = "m_menuFileDbSettings";
			this.m_menuFileDbSettings.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileDbSettings.Text = "&Database Settings...";
			this.m_menuFileDbSettings.Click += new System.EventHandler(this.OnFileDbSettings);
			// 
			// m_menuFileChangeMasterKey
			// 
			this.m_menuFileChangeMasterKey.Image = global::KeePass.Properties.Resources.B16x16_File_Locked;
			this.m_menuFileChangeMasterKey.Name = "m_menuFileChangeMasterKey";
			this.m_menuFileChangeMasterKey.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileChangeMasterKey.Text = "Change &Master Key...";
			this.m_menuFileChangeMasterKey.Click += new System.EventHandler(this.OnFileChangeMasterKey);
			// 
			// m_menuFileSep2
			// 
			this.m_menuFileSep2.Name = "m_menuFileSep2";
			this.m_menuFileSep2.Size = new System.Drawing.Size(173, 6);
			// 
			// m_menuFilePrint
			// 
			this.m_menuFilePrint.Image = global::KeePass.Properties.Resources.B16x16_FilePrint;
			this.m_menuFilePrint.Name = "m_menuFilePrint";
			this.m_menuFilePrint.Size = new System.Drawing.Size(176, 22);
			this.m_menuFilePrint.Text = "&Print...";
			this.m_menuFilePrint.Click += new System.EventHandler(this.OnFilePrint);
			// 
			// m_menuFileSep3
			// 
			this.m_menuFileSep3.Name = "m_menuFileSep3";
			this.m_menuFileSep3.Size = new System.Drawing.Size(173, 6);
			// 
			// m_menuFileImport
			// 
			this.m_menuFileImport.Image = global::KeePass.Properties.Resources.B16x16_Folder_Inbox;
			this.m_menuFileImport.Name = "m_menuFileImport";
			this.m_menuFileImport.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileImport.Text = "&Import...";
			this.m_menuFileImport.Click += new System.EventHandler(this.OnFileImport);
			// 
			// m_menuFileExport
			// 
			this.m_menuFileExport.Image = global::KeePass.Properties.Resources.B16x16_Folder_Outbox;
			this.m_menuFileExport.Name = "m_menuFileExport";
			this.m_menuFileExport.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileExport.Text = "&Export...";
			this.m_menuFileExport.Click += new System.EventHandler(this.OnFileExport);
			// 
			// m_menuFileSync
			// 
			this.m_menuFileSync.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuFileSyncFile,
            this.m_menuFileSyncUrl});
			this.m_menuFileSync.Name = "m_menuFileSync";
			this.m_menuFileSync.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileSync.Text = "Synchronize";
			// 
			// m_menuFileSyncFile
			// 
			this.m_menuFileSyncFile.Image = global::KeePass.Properties.Resources.B16x16_Reload_Page;
			this.m_menuFileSyncFile.Name = "m_menuFileSyncFile";
			this.m_menuFileSyncFile.Size = new System.Drawing.Size(188, 22);
			this.m_menuFileSyncFile.Text = "Synchronize with File...";
			this.m_menuFileSyncFile.Click += new System.EventHandler(this.OnFileSynchronize);
			// 
			// m_menuFileSyncUrl
			// 
			this.m_menuFileSyncUrl.Image = global::KeePass.Properties.Resources.B16x16_Reload_Page;
			this.m_menuFileSyncUrl.Name = "m_menuFileSyncUrl";
			this.m_menuFileSyncUrl.Size = new System.Drawing.Size(188, 22);
			this.m_menuFileSyncUrl.Text = "Synchronize with URL...";
			this.m_menuFileSyncUrl.Click += new System.EventHandler(this.OnFileSynchronizeUrl);
			// 
			// m_menuFileSep4
			// 
			this.m_menuFileSep4.Name = "m_menuFileSep4";
			this.m_menuFileSep4.Size = new System.Drawing.Size(173, 6);
			// 
			// m_menuFileLock
			// 
			this.m_menuFileLock.Image = global::KeePass.Properties.Resources.B16x16_LockWorkspace;
			this.m_menuFileLock.Name = "m_menuFileLock";
			this.m_menuFileLock.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileLock.Text = "&Lock Workspace";
			this.m_menuFileLock.Click += new System.EventHandler(this.OnFileLock);
			// 
			// m_menuFileExit
			// 
			this.m_menuFileExit.Image = global::KeePass.Properties.Resources.B16x16_Exit;
			this.m_menuFileExit.Name = "m_menuFileExit";
			this.m_menuFileExit.Size = new System.Drawing.Size(176, 22);
			this.m_menuFileExit.Text = "E&xit";
			this.m_menuFileExit.Click += new System.EventHandler(this.OnFileExit);
			// 
			// m_menuEdit
			// 
			this.m_menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuEditShowAllEntries,
            this.m_menuEditShowExpired,
            this.m_menuEditSep0,
            this.m_menuEditFind});
			this.m_menuEdit.Name = "m_menuEdit";
			this.m_menuEdit.Size = new System.Drawing.Size(37, 20);
			this.m_menuEdit.Text = "&Edit";
			// 
			// m_menuEditShowAllEntries
			// 
			this.m_menuEditShowAllEntries.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Key3;
			this.m_menuEditShowAllEntries.Name = "m_menuEditShowAllEntries";
			this.m_menuEditShowAllEntries.Size = new System.Drawing.Size(188, 22);
			this.m_menuEditShowAllEntries.Text = "&Show All Entries";
			this.m_menuEditShowAllEntries.Click += new System.EventHandler(this.OnShowAllEntries);
			// 
			// m_menuEditShowExpired
			// 
			this.m_menuEditShowExpired.Image = global::KeePass.Properties.Resources.B16x16_History_Clear;
			this.m_menuEditShowExpired.Name = "m_menuEditShowExpired";
			this.m_menuEditShowExpired.Size = new System.Drawing.Size(188, 22);
			this.m_menuEditShowExpired.Text = "Show All &Expired Entries";
			this.m_menuEditShowExpired.Click += new System.EventHandler(this.OnToolsShowExpired);
			// 
			// m_menuEditSep0
			// 
			this.m_menuEditSep0.Name = "m_menuEditSep0";
			this.m_menuEditSep0.Size = new System.Drawing.Size(185, 6);
			// 
			// m_menuEditFind
			// 
			this.m_menuEditFind.Image = global::KeePass.Properties.Resources.B16x16_XMag;
			this.m_menuEditFind.Name = "m_menuEditFind";
			this.m_menuEditFind.Size = new System.Drawing.Size(188, 22);
			this.m_menuEditFind.Text = "&Find...";
			this.m_menuEditFind.Click += new System.EventHandler(this.OnPwListFind);
			// 
			// m_menuView
			// 
			this.m_menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuChangeLanguage,
            this.m_menuViewSep0,
            this.m_menuViewShowToolBar,
            this.m_menuViewShowEntryView,
            this.m_menuViewWindowLayout,
            this.m_menuViewSep1,
            this.m_menuViewAlwaysOnTop,
            this.m_menuViewSep2,
            this.m_menuViewHiding,
            this.m_menuViewSep3,
            this.m_menuViewTanOptions,
            this.m_menuViewColumns,
            this.m_menuViewSep4,
            this.m_menuViewShowEntriesOfSubGroups});
			this.m_menuView.Name = "m_menuView";
			this.m_menuView.Size = new System.Drawing.Size(42, 20);
			this.m_menuView.Text = "&View";
			// 
			// m_menuChangeLanguage
			// 
			this.m_menuChangeLanguage.Image = global::KeePass.Properties.Resources.B16x16_Keyboard_Layout;
			this.m_menuChangeLanguage.Name = "m_menuChangeLanguage";
			this.m_menuChangeLanguage.Size = new System.Drawing.Size(207, 22);
			this.m_menuChangeLanguage.Text = "Change &Language...";
			this.m_menuChangeLanguage.Click += new System.EventHandler(this.OnMenuChangeLanguage);
			// 
			// m_menuViewSep0
			// 
			this.m_menuViewSep0.Name = "m_menuViewSep0";
			this.m_menuViewSep0.Size = new System.Drawing.Size(204, 6);
			// 
			// m_menuViewShowToolBar
			// 
			this.m_menuViewShowToolBar.CheckOnClick = true;
			this.m_menuViewShowToolBar.Name = "m_menuViewShowToolBar";
			this.m_menuViewShowToolBar.Size = new System.Drawing.Size(207, 22);
			this.m_menuViewShowToolBar.Text = "Show &Toolbar";
			this.m_menuViewShowToolBar.Click += new System.EventHandler(this.OnViewShowToolBar);
			// 
			// m_menuViewShowEntryView
			// 
			this.m_menuViewShowEntryView.CheckOnClick = true;
			this.m_menuViewShowEntryView.Name = "m_menuViewShowEntryView";
			this.m_menuViewShowEntryView.Size = new System.Drawing.Size(207, 22);
			this.m_menuViewShowEntryView.Text = "&Show Entry View";
			this.m_menuViewShowEntryView.Click += new System.EventHandler(this.OnViewShowEntryView);
			// 
			// m_menuViewWindowLayout
			// 
			this.m_menuViewWindowLayout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuViewWindowsStacked,
            this.m_menuViewWindowsSideBySide});
			this.m_menuViewWindowLayout.Name = "m_menuViewWindowLayout";
			this.m_menuViewWindowLayout.Size = new System.Drawing.Size(207, 22);
			this.m_menuViewWindowLayout.Text = "&Window Layout";
			// 
			// m_menuViewWindowsStacked
			// 
			this.m_menuViewWindowsStacked.Image = global::KeePass.Properties.Resources.B16x16_Window_2Horz1Vert;
			this.m_menuViewWindowsStacked.Name = "m_menuViewWindowsStacked";
			this.m_menuViewWindowsStacked.Size = new System.Drawing.Size(134, 22);
			this.m_menuViewWindowsStacked.Text = "Stacked";
			this.m_menuViewWindowsStacked.Click += new System.EventHandler(this.OnViewWindowsStacked);
			// 
			// m_menuViewWindowsSideBySide
			// 
			this.m_menuViewWindowsSideBySide.Image = global::KeePass.Properties.Resources.B16x16_Window_3Horz;
			this.m_menuViewWindowsSideBySide.Name = "m_menuViewWindowsSideBySide";
			this.m_menuViewWindowsSideBySide.Size = new System.Drawing.Size(134, 22);
			this.m_menuViewWindowsSideBySide.Text = "Side By Side";
			this.m_menuViewWindowsSideBySide.Click += new System.EventHandler(this.OnViewWindowsSideBySide);
			// 
			// m_menuViewSep1
			// 
			this.m_menuViewSep1.Name = "m_menuViewSep1";
			this.m_menuViewSep1.Size = new System.Drawing.Size(204, 6);
			// 
			// m_menuViewAlwaysOnTop
			// 
			this.m_menuViewAlwaysOnTop.CheckOnClick = true;
			this.m_menuViewAlwaysOnTop.Name = "m_menuViewAlwaysOnTop";
			this.m_menuViewAlwaysOnTop.Size = new System.Drawing.Size(207, 22);
			this.m_menuViewAlwaysOnTop.Text = "&Always on Top";
			this.m_menuViewAlwaysOnTop.Click += new System.EventHandler(this.OnViewAlwaysOnTop);
			// 
			// m_menuViewSep2
			// 
			this.m_menuViewSep2.Name = "m_menuViewSep2";
			this.m_menuViewSep2.Size = new System.Drawing.Size(204, 6);
			// 
			// m_menuViewHiding
			// 
			this.m_menuViewHiding.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuViewHideTitles,
            this.m_menuViewHideUserNames,
            this.m_menuViewHidePasswords,
            this.m_menuViewHideURLs,
            this.m_menuViewHideNotes});
			this.m_menuViewHiding.Name = "m_menuViewHiding";
			this.m_menuViewHiding.Size = new System.Drawing.Size(207, 22);
			this.m_menuViewHiding.Text = "&Hide Fields (Asterisks)";
			// 
			// m_menuViewHideTitles
			// 
			this.m_menuViewHideTitles.CheckOnClick = true;
			this.m_menuViewHideTitles.Name = "m_menuViewHideTitles";
			this.m_menuViewHideTitles.Size = new System.Drawing.Size(157, 22);
			this.m_menuViewHideTitles.Text = "Hide &Titles";
			this.m_menuViewHideTitles.Click += new System.EventHandler(this.OnClickHideTitles);
			// 
			// m_menuViewHideUserNames
			// 
			this.m_menuViewHideUserNames.CheckOnClick = true;
			this.m_menuViewHideUserNames.Name = "m_menuViewHideUserNames";
			this.m_menuViewHideUserNames.Size = new System.Drawing.Size(157, 22);
			this.m_menuViewHideUserNames.Text = "Hide &User Names";
			this.m_menuViewHideUserNames.Click += new System.EventHandler(this.OnClickHideUserNames);
			// 
			// m_menuViewHidePasswords
			// 
			this.m_menuViewHidePasswords.CheckOnClick = true;
			this.m_menuViewHidePasswords.Name = "m_menuViewHidePasswords";
			this.m_menuViewHidePasswords.Size = new System.Drawing.Size(157, 22);
			this.m_menuViewHidePasswords.Text = "Hide &Passwords";
			this.m_menuViewHidePasswords.Click += new System.EventHandler(this.OnClickHidePasswords);
			// 
			// m_menuViewHideURLs
			// 
			this.m_menuViewHideURLs.CheckOnClick = true;
			this.m_menuViewHideURLs.Name = "m_menuViewHideURLs";
			this.m_menuViewHideURLs.Size = new System.Drawing.Size(157, 22);
			this.m_menuViewHideURLs.Text = "Hide UR&Ls";
			this.m_menuViewHideURLs.Click += new System.EventHandler(this.OnClickHideURLs);
			// 
			// m_menuViewHideNotes
			// 
			this.m_menuViewHideNotes.CheckOnClick = true;
			this.m_menuViewHideNotes.Name = "m_menuViewHideNotes";
			this.m_menuViewHideNotes.Size = new System.Drawing.Size(157, 22);
			this.m_menuViewHideNotes.Text = "Hide &Notes";
			this.m_menuViewHideNotes.Click += new System.EventHandler(this.OnClickHideNotes);
			// 
			// m_menuViewSep3
			// 
			this.m_menuViewSep3.Name = "m_menuViewSep3";
			this.m_menuViewSep3.Size = new System.Drawing.Size(204, 6);
			// 
			// m_menuViewTanOptions
			// 
			this.m_menuViewTanOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuViewTanSimpleList,
            this.m_menuViewTanIndices});
			this.m_menuViewTanOptions.Name = "m_menuViewTanOptions";
			this.m_menuViewTanOptions.Size = new System.Drawing.Size(207, 22);
			this.m_menuViewTanOptions.Text = "TAN &View Options";
			// 
			// m_menuViewTanSimpleList
			// 
			this.m_menuViewTanSimpleList.CheckOnClick = true;
			this.m_menuViewTanSimpleList.Name = "m_menuViewTanSimpleList";
			this.m_menuViewTanSimpleList.Size = new System.Drawing.Size(273, 22);
			this.m_menuViewTanSimpleList.Text = "Use &Simple List View for TAN-Only Groups";
			this.m_menuViewTanSimpleList.Click += new System.EventHandler(this.OnViewTanSimpleListClick);
			// 
			// m_menuViewTanIndices
			// 
			this.m_menuViewTanIndices.CheckOnClick = true;
			this.m_menuViewTanIndices.Name = "m_menuViewTanIndices";
			this.m_menuViewTanIndices.Size = new System.Drawing.Size(273, 22);
			this.m_menuViewTanIndices.Text = "Show TAN &Indices in Entry Titles";
			this.m_menuViewTanIndices.Click += new System.EventHandler(this.OnViewTanIndicesClick);
			// 
			// m_menuViewColumns
			// 
			this.m_menuViewColumns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuViewColumnsShowTitle,
            this.m_menuViewColumnsShowUserName,
            this.m_menuViewColumnsShowPassword,
            this.m_menuViewColumnsShowUrl,
            this.m_menuViewColumnsShowNotes,
            this.m_menuViewColumnsShowSep0,
            this.m_menuViewColumnsShowCreation,
            this.m_menuViewColumnsShowLastAccess,
            this.m_menuViewColumnsShowLastMod,
            this.m_menuViewColumnsShowExpire,
            this.m_menuViewColumnsShowSep1,
            this.m_menuViewColumnsShowUuid,
            this.m_menuViewColumnsShowAttachs});
			this.m_menuViewColumns.Name = "m_menuViewColumns";
			this.m_menuViewColumns.Size = new System.Drawing.Size(207, 22);
			this.m_menuViewColumns.Text = "Show &Columns";
			// 
			// m_menuViewColumnsShowTitle
			// 
			this.m_menuViewColumnsShowTitle.CheckOnClick = true;
			this.m_menuViewColumnsShowTitle.Name = "m_menuViewColumnsShowTitle";
			this.m_menuViewColumnsShowTitle.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowTitle.Text = "&Title";
			this.m_menuViewColumnsShowTitle.Click += new System.EventHandler(this.OnViewShowColTitle);
			// 
			// m_menuViewColumnsShowUserName
			// 
			this.m_menuViewColumnsShowUserName.CheckOnClick = true;
			this.m_menuViewColumnsShowUserName.Name = "m_menuViewColumnsShowUserName";
			this.m_menuViewColumnsShowUserName.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowUserName.Text = "User &Name";
			this.m_menuViewColumnsShowUserName.Click += new System.EventHandler(this.OnViewShowColUser);
			// 
			// m_menuViewColumnsShowPassword
			// 
			this.m_menuViewColumnsShowPassword.CheckOnClick = true;
			this.m_menuViewColumnsShowPassword.Name = "m_menuViewColumnsShowPassword";
			this.m_menuViewColumnsShowPassword.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowPassword.Text = "&Password";
			this.m_menuViewColumnsShowPassword.Click += new System.EventHandler(this.OnViewShowColPassword);
			// 
			// m_menuViewColumnsShowUrl
			// 
			this.m_menuViewColumnsShowUrl.CheckOnClick = true;
			this.m_menuViewColumnsShowUrl.Name = "m_menuViewColumnsShowUrl";
			this.m_menuViewColumnsShowUrl.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowUrl.Text = "&URL";
			this.m_menuViewColumnsShowUrl.Click += new System.EventHandler(this.OnViewShowColURL);
			// 
			// m_menuViewColumnsShowNotes
			// 
			this.m_menuViewColumnsShowNotes.CheckOnClick = true;
			this.m_menuViewColumnsShowNotes.Name = "m_menuViewColumnsShowNotes";
			this.m_menuViewColumnsShowNotes.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowNotes.Text = "Note&s";
			this.m_menuViewColumnsShowNotes.Click += new System.EventHandler(this.OnViewShowColNotes);
			// 
			// m_menuViewColumnsShowSep0
			// 
			this.m_menuViewColumnsShowSep0.Name = "m_menuViewColumnsShowSep0";
			this.m_menuViewColumnsShowSep0.Size = new System.Drawing.Size(177, 6);
			// 
			// m_menuViewColumnsShowCreation
			// 
			this.m_menuViewColumnsShowCreation.CheckOnClick = true;
			this.m_menuViewColumnsShowCreation.Name = "m_menuViewColumnsShowCreation";
			this.m_menuViewColumnsShowCreation.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowCreation.Text = "&Creation Time";
			this.m_menuViewColumnsShowCreation.Click += new System.EventHandler(this.OnViewShowColCreation);
			// 
			// m_menuViewColumnsShowLastAccess
			// 
			this.m_menuViewColumnsShowLastAccess.CheckOnClick = true;
			this.m_menuViewColumnsShowLastAccess.Name = "m_menuViewColumnsShowLastAccess";
			this.m_menuViewColumnsShowLastAccess.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowLastAccess.Text = "&Last Access Time";
			this.m_menuViewColumnsShowLastAccess.Click += new System.EventHandler(this.OnViewShowColLastAccess);
			// 
			// m_menuViewColumnsShowLastMod
			// 
			this.m_menuViewColumnsShowLastMod.CheckOnClick = true;
			this.m_menuViewColumnsShowLastMod.Name = "m_menuViewColumnsShowLastMod";
			this.m_menuViewColumnsShowLastMod.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowLastMod.Text = "Last &Modification Time";
			this.m_menuViewColumnsShowLastMod.Click += new System.EventHandler(this.OnViewShowColLastMod);
			// 
			// m_menuViewColumnsShowExpire
			// 
			this.m_menuViewColumnsShowExpire.CheckOnClick = true;
			this.m_menuViewColumnsShowExpire.Name = "m_menuViewColumnsShowExpire";
			this.m_menuViewColumnsShowExpire.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowExpire.Text = "&Expiration Time";
			this.m_menuViewColumnsShowExpire.Click += new System.EventHandler(this.OnViewShowColExpire);
			// 
			// m_menuViewColumnsShowSep1
			// 
			this.m_menuViewColumnsShowSep1.Name = "m_menuViewColumnsShowSep1";
			this.m_menuViewColumnsShowSep1.Size = new System.Drawing.Size(177, 6);
			// 
			// m_menuViewColumnsShowUuid
			// 
			this.m_menuViewColumnsShowUuid.CheckOnClick = true;
			this.m_menuViewColumnsShowUuid.Name = "m_menuViewColumnsShowUuid";
			this.m_menuViewColumnsShowUuid.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowUuid.Text = "UU&ID";
			this.m_menuViewColumnsShowUuid.Click += new System.EventHandler(this.OnViewShowColUUID);
			// 
			// m_menuViewColumnsShowAttachs
			// 
			this.m_menuViewColumnsShowAttachs.CheckOnClick = true;
			this.m_menuViewColumnsShowAttachs.Name = "m_menuViewColumnsShowAttachs";
			this.m_menuViewColumnsShowAttachs.Size = new System.Drawing.Size(180, 22);
			this.m_menuViewColumnsShowAttachs.Text = "&Attachments";
			this.m_menuViewColumnsShowAttachs.Click += new System.EventHandler(this.OnViewShowColAttachs);
			// 
			// m_menuViewSep4
			// 
			this.m_menuViewSep4.Name = "m_menuViewSep4";
			this.m_menuViewSep4.Size = new System.Drawing.Size(204, 6);
			// 
			// m_menuViewShowEntriesOfSubGroups
			// 
			this.m_menuViewShowEntriesOfSubGroups.CheckOnClick = true;
			this.m_menuViewShowEntriesOfSubGroups.Name = "m_menuViewShowEntriesOfSubGroups";
			this.m_menuViewShowEntriesOfSubGroups.Size = new System.Drawing.Size(207, 22);
			this.m_menuViewShowEntriesOfSubGroups.Text = "Show Entries of Sub-Groups";
			this.m_menuViewShowEntriesOfSubGroups.Click += new System.EventHandler(this.OnViewShowEntriesOfSubGroups);
			// 
			// m_menuTools
			// 
			this.m_menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuToolsPwGenerator,
            this.m_menuToolsGeneratePwList,
            this.m_menuToolsSep0,
            this.m_menuToolsTanWizard,
            this.m_menuToolsDbMaintenance,
            this.m_menuToolsSep1,
            this.m_menuToolsOptions,
            this.m_menuToolsPlugins});
			this.m_menuTools.Name = "m_menuTools";
			this.m_menuTools.Size = new System.Drawing.Size(45, 20);
			this.m_menuTools.Text = "&Tools";
			// 
			// m_menuToolsPwGenerator
			// 
			this.m_menuToolsPwGenerator.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Gen;
			this.m_menuToolsPwGenerator.Name = "m_menuToolsPwGenerator";
			this.m_menuToolsPwGenerator.Size = new System.Drawing.Size(195, 22);
			this.m_menuToolsPwGenerator.Text = "&Generate Password...";
			this.m_menuToolsPwGenerator.Click += new System.EventHandler(this.OnToolsPwGenerator);
			// 
			// m_menuToolsGeneratePwList
			// 
			this.m_menuToolsGeneratePwList.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Gen;
			this.m_menuToolsGeneratePwList.Name = "m_menuToolsGeneratePwList";
			this.m_menuToolsGeneratePwList.Size = new System.Drawing.Size(195, 22);
			this.m_menuToolsGeneratePwList.Text = "Generate Password &List...";
			this.m_menuToolsGeneratePwList.Click += new System.EventHandler(this.OnToolsGeneratePasswordList);
			// 
			// m_menuToolsSep0
			// 
			this.m_menuToolsSep0.Name = "m_menuToolsSep0";
			this.m_menuToolsSep0.Size = new System.Drawing.Size(192, 6);
			// 
			// m_menuToolsTanWizard
			// 
			this.m_menuToolsTanWizard.Image = global::KeePass.Properties.Resources.B16x16_Wizard;
			this.m_menuToolsTanWizard.Name = "m_menuToolsTanWizard";
			this.m_menuToolsTanWizard.Size = new System.Drawing.Size(195, 22);
			this.m_menuToolsTanWizard.Text = "&TAN Wizard...";
			this.m_menuToolsTanWizard.Click += new System.EventHandler(this.OnToolsTanWizard);
			// 
			// m_menuToolsDbMaintenance
			// 
			this.m_menuToolsDbMaintenance.Image = global::KeePass.Properties.Resources.B16x16_Package_Settings;
			this.m_menuToolsDbMaintenance.Name = "m_menuToolsDbMaintenance";
			this.m_menuToolsDbMaintenance.Size = new System.Drawing.Size(195, 22);
			this.m_menuToolsDbMaintenance.Text = "Database &Maintenance...";
			this.m_menuToolsDbMaintenance.Click += new System.EventHandler(this.OnToolsDbMaintenance);
			// 
			// m_menuToolsSep1
			// 
			this.m_menuToolsSep1.Name = "m_menuToolsSep1";
			this.m_menuToolsSep1.Size = new System.Drawing.Size(192, 6);
			// 
			// m_menuToolsOptions
			// 
			this.m_menuToolsOptions.Image = global::KeePass.Properties.Resources.B16x16_Misc;
			this.m_menuToolsOptions.Name = "m_menuToolsOptions";
			this.m_menuToolsOptions.Size = new System.Drawing.Size(195, 22);
			this.m_menuToolsOptions.Text = "&Options...";
			this.m_menuToolsOptions.Click += new System.EventHandler(this.OnToolsOptions);
			// 
			// m_menuToolsPlugins
			// 
			this.m_menuToolsPlugins.Image = global::KeePass.Properties.Resources.B16x16_BlockDevice;
			this.m_menuToolsPlugins.Name = "m_menuToolsPlugins";
			this.m_menuToolsPlugins.Size = new System.Drawing.Size(195, 22);
			this.m_menuToolsPlugins.Text = "&Plugins...";
			this.m_menuToolsPlugins.Click += new System.EventHandler(this.OnToolsPlugins);
			// 
			// m_menuHelp
			// 
			this.m_menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuHelpContents,
            this.m_menuHelpSelectSource,
            this.m_menuHelpSep0,
            this.m_menuHelpHomepage,
            this.m_menuHelpDonate,
            this.m_menuHelpSep1,
            this.m_menuHelpCheckForUpdate,
            this.m_menuHelpSep2,
            this.m_menuHelpAbout});
			this.m_menuHelp.Name = "m_menuHelp";
			this.m_menuHelp.Size = new System.Drawing.Size(41, 20);
			this.m_menuHelp.Text = "&Help";
			// 
			// m_menuHelpContents
			// 
			this.m_menuHelpContents.Image = global::KeePass.Properties.Resources.B16x16_Toggle_Log;
			this.m_menuHelpContents.Name = "m_menuHelpContents";
			this.m_menuHelpContents.Size = new System.Drawing.Size(175, 22);
			this.m_menuHelpContents.Text = "&Help Contents";
			this.m_menuHelpContents.Click += new System.EventHandler(this.OnHelpContents);
			// 
			// m_menuHelpSelectSource
			// 
			this.m_menuHelpSelectSource.Image = global::KeePass.Properties.Resources.B16x16_KOrganizer;
			this.m_menuHelpSelectSource.Name = "m_menuHelpSelectSource";
			this.m_menuHelpSelectSource.Size = new System.Drawing.Size(175, 22);
			this.m_menuHelpSelectSource.Text = "&Select Help Source...";
			this.m_menuHelpSelectSource.Click += new System.EventHandler(this.OnHelpSelectSource);
			// 
			// m_menuHelpSep0
			// 
			this.m_menuHelpSep0.Name = "m_menuHelpSep0";
			this.m_menuHelpSep0.Size = new System.Drawing.Size(172, 6);
			// 
			// m_menuHelpHomepage
			// 
			this.m_menuHelpHomepage.Image = global::KeePass.Properties.Resources.B16x16_Folder_Home;
			this.m_menuHelpHomepage.Name = "m_menuHelpHomepage";
			this.m_menuHelpHomepage.Size = new System.Drawing.Size(175, 22);
			this.m_menuHelpHomepage.Text = "&KeePass Homepage";
			this.m_menuHelpHomepage.Click += new System.EventHandler(this.OnHelpHomepage);
			// 
			// m_menuHelpDonate
			// 
			this.m_menuHelpDonate.Image = global::KeePass.Properties.Resources.B16x16_Identity;
			this.m_menuHelpDonate.Name = "m_menuHelpDonate";
			this.m_menuHelpDonate.Size = new System.Drawing.Size(175, 22);
			this.m_menuHelpDonate.Text = "&Donate...";
			this.m_menuHelpDonate.Click += new System.EventHandler(this.OnHelpDonate);
			// 
			// m_menuHelpSep1
			// 
			this.m_menuHelpSep1.Name = "m_menuHelpSep1";
			this.m_menuHelpSep1.Size = new System.Drawing.Size(172, 6);
			// 
			// m_menuHelpCheckForUpdate
			// 
			this.m_menuHelpCheckForUpdate.Image = global::KeePass.Properties.Resources.B16x16_FTP;
			this.m_menuHelpCheckForUpdate.Name = "m_menuHelpCheckForUpdate";
			this.m_menuHelpCheckForUpdate.Size = new System.Drawing.Size(175, 22);
			this.m_menuHelpCheckForUpdate.Text = "&Check for Update";
			this.m_menuHelpCheckForUpdate.Click += new System.EventHandler(this.OnHelpCheckForUpdate);
			// 
			// m_menuHelpSep2
			// 
			this.m_menuHelpSep2.Name = "m_menuHelpSep2";
			this.m_menuHelpSep2.Size = new System.Drawing.Size(172, 6);
			// 
			// m_menuHelpAbout
			// 
			this.m_menuHelpAbout.Image = global::KeePass.Properties.Resources.B16x16_Help;
			this.m_menuHelpAbout.Name = "m_menuHelpAbout";
			this.m_menuHelpAbout.Size = new System.Drawing.Size(175, 22);
			this.m_menuHelpAbout.Text = "&About KeePass...";
			this.m_menuHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
			// 
			// m_toolMain
			// 
			this.m_toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tbNewDatabase,
            this.m_tbOpenDatabase,
            this.m_tbSaveDatabase,
            this.m_tbSaveAll,
            this.m_tbSep0,
            this.m_tbAddEntry,
            this.m_tbSep1,
            this.m_tbCopyUserName,
            this.m_tbCopyPassword,
            this.m_tbSep4,
            this.m_tbFind,
            this.m_tbEntryViewsDropDown,
            this.m_tbSep2,
            this.m_tbLockWorkspace,
            this.m_tbSep3,
            this.m_tbQuickFind,
            this.m_tbCloseTab});
			this.m_toolMain.Location = new System.Drawing.Point(0, 24);
			this.m_toolMain.Name = "m_toolMain";
			this.m_toolMain.Size = new System.Drawing.Size(654, 25);
			this.m_toolMain.TabIndex = 1;
			// 
			// m_tbNewDatabase
			// 
			this.m_tbNewDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbNewDatabase.Image = global::KeePass.Properties.Resources.B16x16_FileNew;
			this.m_tbNewDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbNewDatabase.Name = "m_tbNewDatabase";
			this.m_tbNewDatabase.Size = new System.Drawing.Size(23, 22);
			this.m_tbNewDatabase.Click += new System.EventHandler(this.OnFileNew);
			// 
			// m_tbOpenDatabase
			// 
			this.m_tbOpenDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbOpenDatabase.Image = global::KeePass.Properties.Resources.B16x16_Folder_Yellow_Open;
			this.m_tbOpenDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbOpenDatabase.Name = "m_tbOpenDatabase";
			this.m_tbOpenDatabase.Size = new System.Drawing.Size(23, 22);
			this.m_tbOpenDatabase.Click += new System.EventHandler(this.OnFileOpen);
			// 
			// m_tbSaveDatabase
			// 
			this.m_tbSaveDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbSaveDatabase.Image = global::KeePass.Properties.Resources.B16x16_FileSave;
			this.m_tbSaveDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbSaveDatabase.Name = "m_tbSaveDatabase";
			this.m_tbSaveDatabase.Size = new System.Drawing.Size(23, 22);
			this.m_tbSaveDatabase.Click += new System.EventHandler(this.OnFileSave);
			// 
			// m_tbSaveAll
			// 
			this.m_tbSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbSaveAll.Image = global::KeePass.Properties.Resources.B16x16_File_SaveAll;
			this.m_tbSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbSaveAll.Name = "m_tbSaveAll";
			this.m_tbSaveAll.Size = new System.Drawing.Size(23, 22);
			this.m_tbSaveAll.Click += new System.EventHandler(this.OnFileSaveAll);
			// 
			// m_tbSep0
			// 
			this.m_tbSep0.Name = "m_tbSep0";
			this.m_tbSep0.Size = new System.Drawing.Size(6, 25);
			// 
			// m_tbAddEntry
			// 
			this.m_tbAddEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbAddEntry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tbAddEntryDefault});
			this.m_tbAddEntry.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Import;
			this.m_tbAddEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbAddEntry.Name = "m_tbAddEntry";
			this.m_tbAddEntry.Size = new System.Drawing.Size(32, 22);
			this.m_tbAddEntry.ButtonClick += new System.EventHandler(this.OnEntryAdd);
			// 
			// m_tbAddEntryDefault
			// 
			this.m_tbAddEntryDefault.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Import;
			this.m_tbAddEntryDefault.Name = "m_tbAddEntryDefault";
			this.m_tbAddEntryDefault.Size = new System.Drawing.Size(67, 22);
			this.m_tbAddEntryDefault.Click += new System.EventHandler(this.OnEntryAdd);
			// 
			// m_tbSep1
			// 
			this.m_tbSep1.Name = "m_tbSep1";
			this.m_tbSep1.Size = new System.Drawing.Size(6, 25);
			// 
			// m_tbCopyUserName
			// 
			this.m_tbCopyUserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbCopyUserName.Image = global::KeePass.Properties.Resources.B16x16_Personal;
			this.m_tbCopyUserName.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbCopyUserName.Name = "m_tbCopyUserName";
			this.m_tbCopyUserName.Size = new System.Drawing.Size(23, 22);
			this.m_tbCopyUserName.Click += new System.EventHandler(this.OnEntryCopyUserName);
			// 
			// m_tbCopyPassword
			// 
			this.m_tbCopyPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbCopyPassword.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Info;
			this.m_tbCopyPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbCopyPassword.Name = "m_tbCopyPassword";
			this.m_tbCopyPassword.Size = new System.Drawing.Size(23, 22);
			this.m_tbCopyPassword.Click += new System.EventHandler(this.OnEntryCopyPassword);
			// 
			// m_tbSep4
			// 
			this.m_tbSep4.Name = "m_tbSep4";
			this.m_tbSep4.Size = new System.Drawing.Size(6, 25);
			// 
			// m_tbFind
			// 
			this.m_tbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbFind.Image = global::KeePass.Properties.Resources.B16x16_XMag;
			this.m_tbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbFind.Name = "m_tbFind";
			this.m_tbFind.Size = new System.Drawing.Size(23, 22);
			this.m_tbFind.Click += new System.EventHandler(this.OnPwListFind);
			// 
			// m_tbEntryViewsDropDown
			// 
			this.m_tbEntryViewsDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbEntryViewsDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tbViewsShowAll,
            this.m_tbViewsShowExpired});
			this.m_tbEntryViewsDropDown.Image = global::KeePass.Properties.Resources.B16x16_View_Detailed;
			this.m_tbEntryViewsDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbEntryViewsDropDown.Name = "m_tbEntryViewsDropDown";
			this.m_tbEntryViewsDropDown.Size = new System.Drawing.Size(29, 22);
			// 
			// m_tbViewsShowAll
			// 
			this.m_tbViewsShowAll.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Key3;
			this.m_tbViewsShowAll.Name = "m_tbViewsShowAll";
			this.m_tbViewsShowAll.Size = new System.Drawing.Size(67, 22);
			this.m_tbViewsShowAll.Click += new System.EventHandler(this.OnShowAllEntries);
			// 
			// m_tbViewsShowExpired
			// 
			this.m_tbViewsShowExpired.Image = global::KeePass.Properties.Resources.B16x16_History_Clear;
			this.m_tbViewsShowExpired.Name = "m_tbViewsShowExpired";
			this.m_tbViewsShowExpired.Size = new System.Drawing.Size(67, 22);
			this.m_tbViewsShowExpired.Click += new System.EventHandler(this.OnToolsShowExpired);
			// 
			// m_tbSep2
			// 
			this.m_tbSep2.Name = "m_tbSep2";
			this.m_tbSep2.Size = new System.Drawing.Size(6, 25);
			// 
			// m_tbLockWorkspace
			// 
			this.m_tbLockWorkspace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbLockWorkspace.Image = global::KeePass.Properties.Resources.B16x16_LockWorkspace;
			this.m_tbLockWorkspace.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbLockWorkspace.Name = "m_tbLockWorkspace";
			this.m_tbLockWorkspace.Size = new System.Drawing.Size(23, 22);
			this.m_tbLockWorkspace.Click += new System.EventHandler(this.OnFileLock);
			// 
			// m_tbSep3
			// 
			this.m_tbSep3.Name = "m_tbSep3";
			this.m_tbSep3.Size = new System.Drawing.Size(6, 25);
			// 
			// m_tbQuickFind
			// 
			this.m_tbQuickFind.Name = "m_tbQuickFind";
			this.m_tbQuickFind.Size = new System.Drawing.Size(121, 25);
			this.m_tbQuickFind.SelectedIndexChanged += new System.EventHandler(this.OnQuickFindSelectedIndexChanged);
			this.m_tbQuickFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnQuickFindKeyUp);
			this.m_tbQuickFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnQuickFindKeyDown);
			// 
			// m_tbCloseTab
			// 
			this.m_tbCloseTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.m_tbCloseTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.m_tbCloseTab.Image = ((System.Drawing.Image)(resources.GetObject("m_tbCloseTab.Image")));
			this.m_tbCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_tbCloseTab.Name = "m_tbCloseTab";
			this.m_tbCloseTab.Size = new System.Drawing.Size(23, 22);
			this.m_tbCloseTab.Text = "Close";
			this.m_tbCloseTab.Click += new System.EventHandler(this.OnFileClose);
			// 
			// m_statusMain
			// 
			this.m_statusMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.m_statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_statusPartSelected,
            this.m_statusPartInfo,
            this.m_statusPartProgress,
            this.m_statusClipboard});
			this.m_statusMain.Location = new System.Drawing.Point(0, 464);
			this.m_statusMain.Name = "m_statusMain";
			this.m_statusMain.Size = new System.Drawing.Size(654, 22);
			this.m_statusMain.TabIndex = 3;
			// 
			// m_statusPartSelected
			// 
			this.m_statusPartSelected.AutoSize = false;
			this.m_statusPartSelected.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.m_statusPartSelected.Name = "m_statusPartSelected";
			this.m_statusPartSelected.Size = new System.Drawing.Size(140, 17);
			this.m_statusPartSelected.Text = "<SelectedInfo>";
			this.m_statusPartSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_statusPartInfo
			// 
			this.m_statusPartInfo.Name = "m_statusPartInfo";
			this.m_statusPartInfo.Size = new System.Drawing.Size(245, 17);
			this.m_statusPartInfo.Spring = true;
			this.m_statusPartInfo.Text = "<StatusInfo>";
			this.m_statusPartInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_statusPartProgress
			// 
			this.m_statusPartProgress.AutoSize = false;
			this.m_statusPartProgress.Name = "m_statusPartProgress";
			this.m_statusPartProgress.Size = new System.Drawing.Size(150, 16);
			this.m_statusPartProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// m_statusClipboard
			// 
			this.m_statusClipboard.Name = "m_statusClipboard";
			this.m_statusClipboard.Size = new System.Drawing.Size(100, 16);
			this.m_statusClipboard.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// m_ntfTray
			// 
			this.m_ntfTray.ContextMenuStrip = this.m_ctxTray;
			this.m_ntfTray.Text = "DYN";
			this.m_ntfTray.Visible = true;
			this.m_ntfTray.Click += new System.EventHandler(this.OnSystemTrayClick);
			this.m_ntfTray.DoubleClick += new System.EventHandler(this.OnSystemTrayDoubleClick);
			// 
			// m_ctxTray
			// 
			this.m_ctxTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxTrayTray,
            this.m_ctxTraySep0,
            this.m_ctxTrayLock,
            this.m_ctxTraySep1,
            this.m_ctxTrayFileExit});
			this.m_ctxTray.Name = "m_ctxTray";
			this.m_ctxTray.Size = new System.Drawing.Size(138, 82);
			this.m_ctxTray.Opening += new System.ComponentModel.CancelEventHandler(this.OnCtxTrayOpening);
			// 
			// m_ctxTrayTray
			// 
			this.m_ctxTrayTray.Image = global::KeePass.Properties.Resources.B16x16_View_Detailed;
			this.m_ctxTrayTray.Name = "m_ctxTrayTray";
			this.m_ctxTrayTray.Size = new System.Drawing.Size(137, 22);
			this.m_ctxTrayTray.Text = "&Tray / Untray";
			this.m_ctxTrayTray.Click += new System.EventHandler(this.OnTrayTray);
			// 
			// m_ctxTraySep0
			// 
			this.m_ctxTraySep0.Name = "m_ctxTraySep0";
			this.m_ctxTraySep0.Size = new System.Drawing.Size(134, 6);
			// 
			// m_ctxTrayLock
			// 
			this.m_ctxTrayLock.Image = global::KeePass.Properties.Resources.B16x16_LockWorkspace;
			this.m_ctxTrayLock.Name = "m_ctxTrayLock";
			this.m_ctxTrayLock.Size = new System.Drawing.Size(137, 22);
			this.m_ctxTrayLock.Text = "<>";
			this.m_ctxTrayLock.Click += new System.EventHandler(this.OnTrayLock);
			// 
			// m_ctxTraySep1
			// 
			this.m_ctxTraySep1.Name = "m_ctxTraySep1";
			this.m_ctxTraySep1.Size = new System.Drawing.Size(134, 6);
			// 
			// m_ctxTrayFileExit
			// 
			this.m_ctxTrayFileExit.Image = global::KeePass.Properties.Resources.B16x16_Exit;
			this.m_ctxTrayFileExit.Name = "m_ctxTrayFileExit";
			this.m_ctxTrayFileExit.Size = new System.Drawing.Size(137, 22);
			this.m_ctxTrayFileExit.Text = "E&xit";
			this.m_ctxTrayFileExit.Click += new System.EventHandler(this.OnFileExit);
			// 
			// m_timerMain
			// 
			this.m_timerMain.Enabled = true;
			this.m_timerMain.Interval = 1000;
			this.m_timerMain.Tick += new System.EventHandler(this.OnTimerMainTick);
			// 
			// m_colorDlg
			// 
			this.m_colorDlg.AnyColor = true;
			this.m_colorDlg.FullOpen = true;
			// 
			// m_tabMain
			// 
			this.m_tabMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_tabMain.Location = new System.Drawing.Point(0, 49);
			this.m_tabMain.Name = "m_tabMain";
			this.m_tabMain.SelectedIndex = 0;
			this.m_tabMain.ShowToolTips = true;
			this.m_tabMain.Size = new System.Drawing.Size(654, 22);
			this.m_tabMain.TabIndex = 1;
			this.m_tabMain.SelectedIndexChanged += new System.EventHandler(this.OnTabMainSelectedIndexChanged);
			// 
			// m_splitHorizontal
			// 
			this.m_splitHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_splitHorizontal.Location = new System.Drawing.Point(0, 71);
			this.m_splitHorizontal.Name = "m_splitHorizontal";
			this.m_splitHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// m_splitHorizontal.Panel1
			// 
			this.m_splitHorizontal.Panel1.Controls.Add(this.m_splitVertical);
			// 
			// m_splitHorizontal.Panel2
			// 
			this.m_splitHorizontal.Panel2.Controls.Add(this.m_richEntryView);
			this.m_splitHorizontal.Size = new System.Drawing.Size(654, 393);
			this.m_splitHorizontal.SplitterDistance = 306;
			this.m_splitHorizontal.TabIndex = 2;
			this.m_splitHorizontal.TabStop = false;
			// 
			// m_splitVertical
			// 
			this.m_splitVertical.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_splitVertical.Location = new System.Drawing.Point(0, 0);
			this.m_splitVertical.Name = "m_splitVertical";
			// 
			// m_splitVertical.Panel1
			// 
			this.m_splitVertical.Panel1.Controls.Add(this.m_tvGroups);
			// 
			// m_splitVertical.Panel2
			// 
			this.m_splitVertical.Panel2.Controls.Add(this.m_lvEntries);
			this.m_splitVertical.Size = new System.Drawing.Size(654, 306);
			this.m_splitVertical.SplitterDistance = 177;
			this.m_splitVertical.TabIndex = 0;
			this.m_splitVertical.TabStop = false;
			// 
			// m_tvGroups
			// 
			this.m_tvGroups.AllowDrop = true;
			this.m_tvGroups.ContextMenuStrip = this.m_ctxGroupList;
			this.m_tvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_tvGroups.HideSelection = false;
			this.m_tvGroups.HotTracking = true;
			this.m_tvGroups.LabelEdit = true;
			this.m_tvGroups.Location = new System.Drawing.Point(0, 0);
			this.m_tvGroups.Name = "m_tvGroups";
			this.m_tvGroups.ShowNodeToolTips = true;
			this.m_tvGroups.ShowRootLines = false;
			this.m_tvGroups.Size = new System.Drawing.Size(177, 306);
			this.m_tvGroups.TabIndex = 0;
			this.m_tvGroups.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.OnGroupsAfterCollapse);
			this.m_tvGroups.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.OnGroupsAfterLabelEdit);
			this.m_tvGroups.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnGroupsListDragDrop);
			this.m_tvGroups.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnGroupsListDragEnter);
			this.m_tvGroups.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnGroupsKeyUp);
			this.m_tvGroups.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.OnGroupsListClickNode);
			this.m_tvGroups.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnGroupsKeyDown);
			this.m_tvGroups.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.OnGroupsAfterExpand);
			this.m_tvGroups.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.OnGroupsListItemDrag);
			this.m_tvGroups.DragOver += new System.Windows.Forms.DragEventHandler(this.OnGroupsListDragOver);
			// 
			// m_lvEntries
			// 
			this.m_lvEntries.AllowColumnReorder = true;
			this.m_lvEntries.ContextMenuStrip = this.m_ctxPwList;
			this.m_lvEntries.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_lvEntries.FullRowSelect = true;
			this.m_lvEntries.GridLines = true;
			this.m_lvEntries.HideSelection = false;
			this.m_lvEntries.Location = new System.Drawing.Point(0, 0);
			this.m_lvEntries.Name = "m_lvEntries";
			this.m_lvEntries.ShowItemToolTips = true;
			this.m_lvEntries.Size = new System.Drawing.Size(473, 306);
			this.m_lvEntries.TabIndex = 0;
			this.m_lvEntries.UseCompatibleStateImageBehavior = false;
			this.m_lvEntries.View = System.Windows.Forms.View.Details;
			this.m_lvEntries.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnPwListMouseDoubleClick);
			this.m_lvEntries.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.OnPwListColumnWidthChanged);
			this.m_lvEntries.SelectedIndexChanged += new System.EventHandler(this.OnPwListSelectedIndexChanged);
			this.m_lvEntries.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnPwListColumnClick);
			this.m_lvEntries.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPwListMouseDown);
			this.m_lvEntries.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnPwListKeyUp);
			this.m_lvEntries.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.OnPwListColumnWidthChanging);
			this.m_lvEntries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnPwListKeyDown);
			this.m_lvEntries.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.OnPwListItemDrag);
			// 
			// m_richEntryView
			// 
			this.m_richEntryView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_richEntryView.Location = new System.Drawing.Point(0, 0);
			this.m_richEntryView.Name = "m_richEntryView";
			this.m_richEntryView.ReadOnly = true;
			this.m_richEntryView.Size = new System.Drawing.Size(654, 83);
			this.m_richEntryView.TabIndex = 0;
			this.m_richEntryView.Text = "";
			this.m_richEntryView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnEntryViewKeyDown);
			this.m_richEntryView.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.OnEntryViewLinkClicked);
			this.m_richEntryView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnEntryViewKeyUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 486);
			this.Controls.Add(this.m_splitHorizontal);
			this.Controls.Add(this.m_statusMain);
			this.Controls.Add(this.m_tabMain);
			this.Controls.Add(this.m_toolMain);
			this.Controls.Add(this.m_menuMain);
			this.MainMenuStrip = this.m_menuMain;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "<DYN>";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.Shown += new System.EventHandler(this.OnFormShown);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.Resize += new System.EventHandler(this.OnFormResize);
			this.m_ctxGroupList.ResumeLayout(false);
			this.m_ctxPwList.ResumeLayout(false);
			this.m_menuMain.ResumeLayout(false);
			this.m_menuMain.PerformLayout();
			this.m_toolMain.ResumeLayout(false);
			this.m_toolMain.PerformLayout();
			this.m_statusMain.ResumeLayout(false);
			this.m_statusMain.PerformLayout();
			this.m_ctxTray.ResumeLayout(false);
			this.m_splitHorizontal.Panel1.ResumeLayout(false);
			this.m_splitHorizontal.Panel2.ResumeLayout(false);
			this.m_splitHorizontal.ResumeLayout(false);
			this.m_splitVertical.Panel1.ResumeLayout(false);
			this.m_splitVertical.Panel2.ResumeLayout(false);
			this.m_splitVertical.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip m_menuMain;
		private System.Windows.Forms.ToolStripMenuItem m_menuFile;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileNew;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileClose;
		private System.Windows.Forms.ToolStripSeparator m_menuFileSep0;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileSave;
		private System.Windows.Forms.ToolStripSeparator m_menuFileSep1;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileDbSettings;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileChangeMasterKey;
		private System.Windows.Forms.ToolStripSeparator m_menuFileSep2;
		private System.Windows.Forms.ToolStripMenuItem m_menuFilePrint;
		private System.Windows.Forms.ToolStripSeparator m_menuFileSep3;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileExport;
		private System.Windows.Forms.ToolStripSeparator m_menuFileSep4;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileLock;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileExit;
		private System.Windows.Forms.ToolStripMenuItem m_menuEdit;
		private System.Windows.Forms.ToolStripMenuItem m_menuView;
		private System.Windows.Forms.ToolStripMenuItem m_menuTools;
		private System.Windows.Forms.ToolStripMenuItem m_menuHelp;
		private System.Windows.Forms.ToolStripMenuItem m_menuHelpHomepage;
		private System.Windows.Forms.ToolStripMenuItem m_menuHelpDonate;
		private System.Windows.Forms.ToolStripSeparator m_menuHelpSep0;
		private System.Windows.Forms.ToolStripMenuItem m_menuHelpContents;
		private System.Windows.Forms.ToolStripSeparator m_menuHelpSep1;
		private System.Windows.Forms.ToolStripMenuItem m_menuHelpCheckForUpdate;
		private System.Windows.Forms.ToolStripSeparator m_menuHelpSep2;
		private System.Windows.Forms.ToolStripMenuItem m_menuHelpAbout;
		private System.Windows.Forms.ToolStrip m_toolMain;
		private System.Windows.Forms.ToolStripButton m_tbNewDatabase;
		private System.Windows.Forms.ToolStripButton m_tbOpenDatabase;
		private System.Windows.Forms.RichTextBox m_richEntryView;
		private KeePass.UI.CustomSplitContainerEx m_splitHorizontal;
		private KeePass.UI.CustomSplitContainerEx m_splitVertical;
		private System.Windows.Forms.TreeView m_tvGroups;
		private System.Windows.Forms.StatusStrip m_statusMain;
		private System.Windows.Forms.ToolStripStatusLabel m_statusPartSelected;
		private System.Windows.Forms.ToolStripStatusLabel m_statusPartInfo;
		private System.Windows.Forms.ListView m_lvEntries;
		private System.Windows.Forms.ToolStripButton m_tbSaveDatabase;
		private System.Windows.Forms.ContextMenuStrip m_ctxPwList;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryCopyUserName;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryCopyPassword;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySaveAttachedFiles;
		private System.Windows.Forms.ToolStripSeparator m_ctxEntrySep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryPerformAutoType;
		private System.Windows.Forms.ToolStripSeparator m_ctxEntrySep1;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryAdd;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryEdit;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryDuplicate;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryDelete;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryMassModify;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySelectAll;
		private System.Windows.Forms.ToolStripSeparator m_ctxEntrySep2;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryRearrangePopup;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryMoveToTop;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryMoveOneUp;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryMoveOneDown;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryMoveToBottom;
		private System.Windows.Forms.ToolStripSeparator m_ctxEntryRearrangeSep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySortListByTitle;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySortListByUserName;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySortListByPassword;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySortListByURL;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySortListByNotes;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySortListByCreationTime;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySortListByLastModTime;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySortListByLastAccessTime;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySortListByExpirationTime;
		private System.Windows.Forms.ImageList m_ilClientIcons;
		private System.Windows.Forms.ToolStripMenuItem m_menuChangeLanguage;
		private System.Windows.Forms.ToolStripSeparator m_tbSep0;
		private System.Windows.Forms.ToolStripMenuItem m_menuEditFind;
		private System.Windows.Forms.ToolStripSeparator m_menuViewSep0;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewShowToolBar;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewShowEntryView;
		private System.Windows.Forms.ToolStripSeparator m_tbSep1;
		private System.Windows.Forms.ToolStripButton m_tbFind;
		private System.Windows.Forms.ToolStripSeparator m_tbSep2;
		private System.Windows.Forms.ToolStripButton m_tbLockWorkspace;
		private System.Windows.Forms.ToolStripSeparator m_tbSep3;
		private System.Windows.Forms.ToolStripComboBox m_tbQuickFind;
		private System.Windows.Forms.ToolStripMenuItem m_menuToolsOptions;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewHiding;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewHideTitles;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewHideUserNames;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewHidePasswords;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewHideURLs;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewHideNotes;
		private System.Windows.Forms.ToolStripSeparator m_menuViewSep1;
		private System.Windows.Forms.ContextMenuStrip m_ctxGroupList;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupAdd;
		private System.Windows.Forms.ToolStripSeparator m_ctxGroupSep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupEdit;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupDelete;
		private System.Windows.Forms.ToolStripProgressBar m_statusPartProgress;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewAlwaysOnTop;
		private System.Windows.Forms.ToolStripSeparator m_menuViewSep2;
		private System.Windows.Forms.ToolStripSeparator m_ctxGroupSep1;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupPrint;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumns;
		private System.Windows.Forms.ToolStripSeparator m_menuViewSep3;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowTitle;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowUserName;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowPassword;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowUrl;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowNotes;
		private System.Windows.Forms.ToolStripSeparator m_menuViewColumnsShowSep0;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowCreation;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowLastAccess;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowLastMod;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowExpire;
		private System.Windows.Forms.ToolStripSeparator m_menuViewColumnsShowSep1;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowUuid;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewColumnsShowAttachs;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileRecent;
		private System.Windows.Forms.NotifyIcon m_ntfTray;
		private System.Windows.Forms.ContextMenuStrip m_ctxTray;
		private System.Windows.Forms.ToolStripMenuItem m_ctxTrayTray;
		private System.Windows.Forms.Timer m_timerMain;
		private System.Windows.Forms.ToolStripMenuItem m_menuToolsPlugins;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryUrl;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryOpenUrl;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryCopyUrl;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryMassSetIcon;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySortUnsorted;
		private System.Windows.Forms.ToolStripSeparator m_ctxEntryRearrangeSep1;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupFind;
		private System.Windows.Forms.ToolStripSeparator m_ctxGroupSep2;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewTanOptions;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewTanSimpleList;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewTanIndices;
		private System.Windows.Forms.ToolStripMenuItem m_menuToolsPwGenerator;
		private System.Windows.Forms.ToolStripSeparator m_menuToolsSep0;
		private System.Windows.Forms.ToolStripMenuItem m_menuToolsTanWizard;
		private System.Windows.Forms.ToolStripMenuItem m_menuEditShowAllEntries;
		private System.Windows.Forms.ToolStripMenuItem m_menuEditShowExpired;
		private System.Windows.Forms.ToolStripSeparator m_menuEditSep0;
		private System.Windows.Forms.ToolStripProgressBar m_statusClipboard;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryClipboard;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryClipCopy;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryClipPaste;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySetColor;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryColorStandard;
		private System.Windows.Forms.ToolStripSeparator m_ctxEntryColorSep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryColorLightRed;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryColorLightGreen;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryColorLightBlue;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryColorLightYellow;
		private System.Windows.Forms.ToolStripSeparator m_ctxEntryColorSep1;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryColorCustom;
		private System.Windows.Forms.ColorDialog m_colorDlg;
		private System.Windows.Forms.ToolStripDropDownButton m_tbEntryViewsDropDown;
		private System.Windows.Forms.ToolStripMenuItem m_tbViewsShowAll;
		private System.Windows.Forms.ToolStripMenuItem m_tbViewsShowExpired;
		private System.Windows.Forms.ToolStripSplitButton m_tbAddEntry;
		private System.Windows.Forms.ToolStripMenuItem m_tbAddEntryDefault;
		private System.Windows.Forms.ToolStripMenuItem m_menuToolsDbMaintenance;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryCopyCustomString;
		private System.Windows.Forms.ToolStripMenuItem m_menuToolsGeneratePwList;
		private System.Windows.Forms.ToolStripSeparator m_menuToolsSep1;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewWindowLayout;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewWindowsStacked;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewWindowsSideBySide;
		private System.Windows.Forms.ToolStripButton m_tbCopyUserName;
		private System.Windows.Forms.ToolStripButton m_tbCopyPassword;
		private System.Windows.Forms.ToolStripSeparator m_tbSep4;
		private System.Windows.Forms.ToolStripMenuItem m_menuHelpSelectSource;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileOpen;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileOpenLocal;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileOpenUrl;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileSaveAs;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileSaveAsLocal;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileSaveAsUrl;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileImport;
		private System.Windows.Forms.ToolStripSeparator m_ctxGroupSep3;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupRearrange;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupMoveToTop;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupMoveOneUp;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupMoveOneDown;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupMoveToBottom;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryBinaries;
		private System.Windows.Forms.ToolStripSeparator m_ctxEntryUrlSep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntryUrlOpenInInternal;
		private System.Windows.Forms.ToolStripSeparator m_ctxTraySep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxTrayFileExit;
		private System.Windows.Forms.TabControl m_tabMain;
		private System.Windows.Forms.ToolStripButton m_tbSaveAll;
		private System.Windows.Forms.ToolStripButton m_tbCloseTab;
		private System.Windows.Forms.ToolStripSeparator m_menuFileSaveAsSep0;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileSaveAsCopy;
		private System.Windows.Forms.ToolStripSeparator m_ctxEntrySelectedSep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySelectedPrint;
		private System.Windows.Forms.ToolStripSeparator m_menuViewSep4;
		private System.Windows.Forms.ToolStripMenuItem m_menuViewShowEntriesOfSubGroups;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileSync;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileSyncFile;
		private System.Windows.Forms.ToolStripMenuItem m_menuFileSyncUrl;
		private System.Windows.Forms.ToolStripMenuItem m_ctxTrayLock;
		private System.Windows.Forms.ToolStripSeparator m_ctxTraySep1;
		private System.Windows.Forms.ToolStripMenuItem m_ctxGroupExport;
		private System.Windows.Forms.ToolStripMenuItem m_ctxEntrySelectedExport;
	}
}

