﻿namespace KeePass.Forms
{
	partial class PwEntryForm
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
			this.m_lblUserName = new System.Windows.Forms.Label();
			this.m_lblPassword = new System.Windows.Forms.Label();
			this.m_lblTitle = new System.Windows.Forms.Label();
			this.m_lblPasswordRepeat = new System.Windows.Forms.Label();
			this.m_lblUrl = new System.Windows.Forms.Label();
			this.m_lblNotes = new System.Windows.Forms.Label();
			this.m_lblQuality = new System.Windows.Forms.Label();
			this.m_tbTitle = new System.Windows.Forms.TextBox();
			this.m_btnIcon = new System.Windows.Forms.Button();
			this.m_lblIcon = new System.Windows.Forms.Label();
			this.m_tbUserName = new System.Windows.Forms.TextBox();
			this.m_tbPassword = new System.Windows.Forms.TextBox();
			this.m_tbRepeatPassword = new System.Windows.Forms.TextBox();
			this.m_tbUrl = new System.Windows.Forms.TextBox();
			this.m_rtNotes = new System.Windows.Forms.RichTextBox();
			this.m_cbExpires = new System.Windows.Forms.CheckBox();
			this.m_dtExpireDateTime = new System.Windows.Forms.DateTimePicker();
			this.m_ctxDefaultTimes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_menuExpireNow = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuExpireSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuExpire1Week = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuExpire2Weeks = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuExpireSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuExpire1Month = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuExpire3Months = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuExpire6Months = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuExpireSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_menuExpire1Year = new System.Windows.Forms.ToolStripMenuItem();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_lblQualityBitsText = new System.Windows.Forms.Label();
			this.m_ttRect = new System.Windows.Forms.ToolTip(this.components);
			this.m_btnGenPw = new System.Windows.Forms.Button();
			this.m_cbHidePassword = new System.Windows.Forms.CheckBox();
			this.m_btnStandardExpires = new System.Windows.Forms.Button();
			this.m_lblSeparator = new System.Windows.Forms.Label();
			this.m_ttBalloon = new System.Windows.Forms.ToolTip(this.components);
			this.m_ttValidationError = new System.Windows.Forms.ToolTip(this.components);
			this.m_tabMain = new System.Windows.Forms.TabControl();
			this.m_tabEntry = new System.Windows.Forms.TabPage();
			this.m_pbQuality = new KeePass.UI.QualityProgressBar();
			this.m_tabAdvanced = new System.Windows.Forms.TabPage();
			this.m_grpAttachments = new System.Windows.Forms.GroupBox();
			this.m_btnBinView = new System.Windows.Forms.Button();
			this.m_btnBinSave = new System.Windows.Forms.Button();
			this.m_btnBinDelete = new System.Windows.Forms.Button();
			this.m_btnBinAdd = new System.Windows.Forms.Button();
			this.m_lvBinaries = new System.Windows.Forms.ListView();
			this.m_grpStringFields = new System.Windows.Forms.GroupBox();
			this.m_btnStrMove = new System.Windows.Forms.Button();
			this.m_btnStrAdd = new System.Windows.Forms.Button();
			this.m_btnStrEdit = new System.Windows.Forms.Button();
			this.m_btnStrDelete = new System.Windows.Forms.Button();
			this.m_lvStrings = new System.Windows.Forms.ListView();
			this.m_ctxListOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_menuListCtxCopyFieldValue = new System.Windows.Forms.ToolStripMenuItem();
			this.m_tabProperties = new System.Windows.Forms.TabPage();
			this.m_tbUuid = new System.Windows.Forms.TextBox();
			this.m_lblUuid = new System.Windows.Forms.Label();
			this.m_tbOverrideUrl = new System.Windows.Forms.TextBox();
			this.m_lblOverrideUrl = new System.Windows.Forms.Label();
			this.m_cbCustomBackgroundColor = new System.Windows.Forms.CheckBox();
			this.m_btnPickBgColor = new System.Windows.Forms.Button();
			this.m_tabAutoType = new System.Windows.Forms.TabPage();
			this.m_linkAutoTypeObfuscation = new System.Windows.Forms.LinkLabel();
			this.m_cbAutoTypeObfuscation = new System.Windows.Forms.CheckBox();
			this.m_btnAutoTypeEditDefault = new System.Windows.Forms.Button();
			this.m_rbAutoTypeOverride = new System.Windows.Forms.RadioButton();
			this.m_rbAutoTypeSeqInherit = new System.Windows.Forms.RadioButton();
			this.m_lblCustomAutoType = new System.Windows.Forms.Label();
			this.m_cbAutoTypeEnabled = new System.Windows.Forms.CheckBox();
			this.m_tbDefaultAutoTypeSeq = new System.Windows.Forms.TextBox();
			this.m_btnAutoTypeEdit = new System.Windows.Forms.Button();
			this.m_btnAutoTypeAdd = new System.Windows.Forms.Button();
			this.m_btnAutoTypeDelete = new System.Windows.Forms.Button();
			this.m_lvAutoType = new System.Windows.Forms.ListView();
			this.m_tabHistory = new System.Windows.Forms.TabPage();
			this.m_btnHistoryDelete = new System.Windows.Forms.Button();
			this.m_btnHistoryView = new System.Windows.Forms.Button();
			this.m_btnHistoryRestore = new System.Windows.Forms.Button();
			this.m_lvHistory = new System.Windows.Forms.ListView();
			this.m_btnTools = new System.Windows.Forms.Button();
			this.m_bannerImage = new System.Windows.Forms.PictureBox();
			this.m_ctxStrMoveToStandard = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_menuListCtxMoveStandardTitle = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuListCtxMoveStandardUser = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuListCtxMoveStandardPassword = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuListCtxMoveStandardURL = new System.Windows.Forms.ToolStripMenuItem();
			this.m_menuListCtxMoveStandardNotes = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxPwGen = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_ctxPwGenOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxPwGenSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxPwGenProfiles = new System.Windows.Forms.ToolStripMenuItem();
			this.m_dlgColorSel = new System.Windows.Forms.ColorDialog();
			this.m_ctxTools = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_ctxToolsHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxToolsSep0 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxToolsUrlHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxToolsUrlSelApp = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxToolsUrlSelDoc = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxToolsSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ctxToolsFieldRefs = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxToolsFieldRefsInTitle = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxToolsFieldRefsInUserName = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxToolsFieldRefsInPassword = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxToolsFieldRefsInUrl = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxToolsFieldRefsInNotes = new System.Windows.Forms.ToolStripMenuItem();
			this.m_ctxDefaultTimes.SuspendLayout();
			this.m_tabMain.SuspendLayout();
			this.m_tabEntry.SuspendLayout();
			this.m_tabAdvanced.SuspendLayout();
			this.m_grpAttachments.SuspendLayout();
			this.m_grpStringFields.SuspendLayout();
			this.m_ctxListOperations.SuspendLayout();
			this.m_tabProperties.SuspendLayout();
			this.m_tabAutoType.SuspendLayout();
			this.m_tabHistory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
			this.m_ctxStrMoveToStandard.SuspendLayout();
			this.m_ctxPwGen.SuspendLayout();
			this.m_ctxTools.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_lblUserName
			// 
			this.m_lblUserName.AutoSize = true;
			this.m_lblUserName.Location = new System.Drawing.Point(6, 40);
			this.m_lblUserName.Name = "m_lblUserName";
			this.m_lblUserName.Size = new System.Drawing.Size(61, 13);
			this.m_lblUserName.TabIndex = 4;
			this.m_lblUserName.Text = "User name:";
			// 
			// m_lblPassword
			// 
			this.m_lblPassword.AutoSize = true;
			this.m_lblPassword.Location = new System.Drawing.Point(6, 67);
			this.m_lblPassword.Name = "m_lblPassword";
			this.m_lblPassword.Size = new System.Drawing.Size(56, 13);
			this.m_lblPassword.TabIndex = 6;
			this.m_lblPassword.Text = "Password:";
			// 
			// m_lblTitle
			// 
			this.m_lblTitle.AutoSize = true;
			this.m_lblTitle.Location = new System.Drawing.Point(6, 13);
			this.m_lblTitle.Name = "m_lblTitle";
			this.m_lblTitle.Size = new System.Drawing.Size(30, 13);
			this.m_lblTitle.TabIndex = 1;
			this.m_lblTitle.Text = "Title:";
			// 
			// m_lblPasswordRepeat
			// 
			this.m_lblPasswordRepeat.AutoSize = true;
			this.m_lblPasswordRepeat.Location = new System.Drawing.Point(6, 94);
			this.m_lblPasswordRepeat.Name = "m_lblPasswordRepeat";
			this.m_lblPasswordRepeat.Size = new System.Drawing.Size(45, 13);
			this.m_lblPasswordRepeat.TabIndex = 9;
			this.m_lblPasswordRepeat.Text = "Repeat:";
			// 
			// m_lblUrl
			// 
			this.m_lblUrl.AutoSize = true;
			this.m_lblUrl.Location = new System.Drawing.Point(6, 143);
			this.m_lblUrl.Name = "m_lblUrl";
			this.m_lblUrl.Size = new System.Drawing.Size(32, 13);
			this.m_lblUrl.TabIndex = 15;
			this.m_lblUrl.Text = "URL:";
			// 
			// m_lblNotes
			// 
			this.m_lblNotes.AutoSize = true;
			this.m_lblNotes.Location = new System.Drawing.Point(6, 170);
			this.m_lblNotes.Name = "m_lblNotes";
			this.m_lblNotes.Size = new System.Drawing.Size(38, 13);
			this.m_lblNotes.TabIndex = 17;
			this.m_lblNotes.Text = "Notes:";
			// 
			// m_lblQuality
			// 
			this.m_lblQuality.AutoSize = true;
			this.m_lblQuality.Location = new System.Drawing.Point(6, 118);
			this.m_lblQuality.Name = "m_lblQuality";
			this.m_lblQuality.Size = new System.Drawing.Size(42, 13);
			this.m_lblQuality.TabIndex = 12;
			this.m_lblQuality.Text = "Quality:";
			// 
			// m_tbTitle
			// 
			this.m_tbTitle.Location = new System.Drawing.Point(81, 10);
			this.m_tbTitle.Name = "m_tbTitle";
			this.m_tbTitle.Size = new System.Drawing.Size(293, 20);
			this.m_tbTitle.TabIndex = 0;
			this.m_tbTitle.TextChanged += new System.EventHandler(this.OnTitleTextChanged);
			// 
			// m_btnIcon
			// 
			this.m_btnIcon.Location = new System.Drawing.Point(422, 8);
			this.m_btnIcon.Name = "m_btnIcon";
			this.m_btnIcon.Size = new System.Drawing.Size(32, 23);
			this.m_btnIcon.TabIndex = 3;
			this.m_btnIcon.UseVisualStyleBackColor = true;
			this.m_btnIcon.Click += new System.EventHandler(this.OnBtnPickIcon);
			// 
			// m_lblIcon
			// 
			this.m_lblIcon.AutoSize = true;
			this.m_lblIcon.Location = new System.Drawing.Point(384, 13);
			this.m_lblIcon.Name = "m_lblIcon";
			this.m_lblIcon.Size = new System.Drawing.Size(31, 13);
			this.m_lblIcon.TabIndex = 2;
			this.m_lblIcon.Text = "Icon:";
			// 
			// m_tbUserName
			// 
			this.m_tbUserName.Location = new System.Drawing.Point(81, 37);
			this.m_tbUserName.Name = "m_tbUserName";
			this.m_tbUserName.Size = new System.Drawing.Size(373, 20);
			this.m_tbUserName.TabIndex = 5;
			this.m_tbUserName.TextChanged += new System.EventHandler(this.OnUserNameTextChanged);
			// 
			// m_tbPassword
			// 
			this.m_tbPassword.Location = new System.Drawing.Point(81, 64);
			this.m_tbPassword.Name = "m_tbPassword";
			this.m_tbPassword.Size = new System.Drawing.Size(335, 20);
			this.m_tbPassword.TabIndex = 7;
			// 
			// m_tbRepeatPassword
			// 
			this.m_tbRepeatPassword.Location = new System.Drawing.Point(81, 91);
			this.m_tbRepeatPassword.Name = "m_tbRepeatPassword";
			this.m_tbRepeatPassword.Size = new System.Drawing.Size(335, 20);
			this.m_tbRepeatPassword.TabIndex = 10;
			this.m_ttBalloon.SetToolTip(this.m_tbRepeatPassword, "Repeat the password to prevent typing errors.");
			// 
			// m_tbUrl
			// 
			this.m_tbUrl.Location = new System.Drawing.Point(81, 140);
			this.m_tbUrl.Name = "m_tbUrl";
			this.m_tbUrl.Size = new System.Drawing.Size(373, 20);
			this.m_tbUrl.TabIndex = 16;
			this.m_tbUrl.TextChanged += new System.EventHandler(this.OnUrlTextChanged);
			// 
			// m_rtNotes
			// 
			this.m_rtNotes.Location = new System.Drawing.Point(81, 167);
			this.m_rtNotes.Name = "m_rtNotes";
			this.m_rtNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.m_rtNotes.Size = new System.Drawing.Size(373, 140);
			this.m_rtNotes.TabIndex = 18;
			this.m_rtNotes.Text = "";
			this.m_rtNotes.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.OnNotesLinkClicked);
			this.m_rtNotes.TextChanged += new System.EventHandler(this.OnNotesTextChanged);
			// 
			// m_cbExpires
			// 
			this.m_cbExpires.AutoSize = true;
			this.m_cbExpires.Location = new System.Drawing.Point(9, 316);
			this.m_cbExpires.Name = "m_cbExpires";
			this.m_cbExpires.Size = new System.Drawing.Size(63, 17);
			this.m_cbExpires.TabIndex = 19;
			this.m_cbExpires.Text = "Expires:";
			this.m_cbExpires.UseVisualStyleBackColor = true;
			this.m_cbExpires.CheckedChanged += new System.EventHandler(this.OnExpiresCheckedChanged);
			// 
			// m_dtExpireDateTime
			// 
			this.m_dtExpireDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.m_dtExpireDateTime.Location = new System.Drawing.Point(81, 313);
			this.m_dtExpireDateTime.Name = "m_dtExpireDateTime";
			this.m_dtExpireDateTime.Size = new System.Drawing.Size(335, 20);
			this.m_dtExpireDateTime.TabIndex = 20;
			this.m_dtExpireDateTime.ValueChanged += new System.EventHandler(this.OnExpireDateTimeChanged);
			// 
			// m_ctxDefaultTimes
			// 
			this.m_ctxDefaultTimes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuExpireNow,
            this.m_menuExpireSep0,
            this.m_menuExpire1Week,
            this.m_menuExpire2Weeks,
            this.m_menuExpireSep1,
            this.m_menuExpire1Month,
            this.m_menuExpire3Months,
            this.m_menuExpire6Months,
            this.m_menuExpireSep2,
            this.m_menuExpire1Year});
			this.m_ctxDefaultTimes.Name = "m_ctxDefaultTimes";
			this.m_ctxDefaultTimes.Size = new System.Drawing.Size(119, 176);
			// 
			// m_menuExpireNow
			// 
			this.m_menuExpireNow.Name = "m_menuExpireNow";
			this.m_menuExpireNow.Size = new System.Drawing.Size(118, 22);
			this.m_menuExpireNow.Text = "&Now";
			this.m_menuExpireNow.Click += new System.EventHandler(this.OnMenuExpireNow);
			// 
			// m_menuExpireSep0
			// 
			this.m_menuExpireSep0.Name = "m_menuExpireSep0";
			this.m_menuExpireSep0.Size = new System.Drawing.Size(115, 6);
			// 
			// m_menuExpire1Week
			// 
			this.m_menuExpire1Week.Name = "m_menuExpire1Week";
			this.m_menuExpire1Week.Size = new System.Drawing.Size(118, 22);
			this.m_menuExpire1Week.Text = "&1 Week";
			this.m_menuExpire1Week.Click += new System.EventHandler(this.OnMenuExpire1Week);
			// 
			// m_menuExpire2Weeks
			// 
			this.m_menuExpire2Weeks.Name = "m_menuExpire2Weeks";
			this.m_menuExpire2Weeks.Size = new System.Drawing.Size(118, 22);
			this.m_menuExpire2Weeks.Text = "&2 Weeks";
			this.m_menuExpire2Weeks.Click += new System.EventHandler(this.OnMenuExpire2Weeks);
			// 
			// m_menuExpireSep1
			// 
			this.m_menuExpireSep1.Name = "m_menuExpireSep1";
			this.m_menuExpireSep1.Size = new System.Drawing.Size(115, 6);
			// 
			// m_menuExpire1Month
			// 
			this.m_menuExpire1Month.Name = "m_menuExpire1Month";
			this.m_menuExpire1Month.Size = new System.Drawing.Size(118, 22);
			this.m_menuExpire1Month.Text = "1 &Month";
			this.m_menuExpire1Month.Click += new System.EventHandler(this.OnMenuExpire1Month);
			// 
			// m_menuExpire3Months
			// 
			this.m_menuExpire3Months.Name = "m_menuExpire3Months";
			this.m_menuExpire3Months.Size = new System.Drawing.Size(118, 22);
			this.m_menuExpire3Months.Text = "&3 Months";
			this.m_menuExpire3Months.Click += new System.EventHandler(this.OnMenuExpire3Months);
			// 
			// m_menuExpire6Months
			// 
			this.m_menuExpire6Months.Name = "m_menuExpire6Months";
			this.m_menuExpire6Months.Size = new System.Drawing.Size(118, 22);
			this.m_menuExpire6Months.Text = "&6 Months";
			this.m_menuExpire6Months.Click += new System.EventHandler(this.OnMenuExpire6Months);
			// 
			// m_menuExpireSep2
			// 
			this.m_menuExpireSep2.Name = "m_menuExpireSep2";
			this.m_menuExpireSep2.Size = new System.Drawing.Size(115, 6);
			// 
			// m_menuExpire1Year
			// 
			this.m_menuExpire1Year.Name = "m_menuExpire1Year";
			this.m_menuExpire1Year.Size = new System.Drawing.Size(118, 22);
			this.m_menuExpire1Year.Text = "1 &Year";
			this.m_menuExpire1Year.Click += new System.EventHandler(this.OnMenuExpire1Year);
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Location = new System.Drawing.Point(311, 453);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(80, 23);
			this.m_btnOK.TabIndex = 1;
			this.m_btnOK.Text = "&OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(397, 453);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(80, 23);
			this.m_btnCancel.TabIndex = 2;
			this.m_btnCancel.Text = "&Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancel);
			// 
			// m_lblQualityBitsText
			// 
			this.m_lblQualityBitsText.Location = new System.Drawing.Point(366, 118);
			this.m_lblQualityBitsText.Name = "m_lblQualityBitsText";
			this.m_lblQualityBitsText.Size = new System.Drawing.Size(53, 13);
			this.m_lblQualityBitsText.TabIndex = 14;
			this.m_lblQualityBitsText.Text = "0000 bits";
			this.m_lblQualityBitsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// m_ttRect
			// 
			this.m_ttRect.AutoPopDelay = 32000;
			this.m_ttRect.InitialDelay = 250;
			this.m_ttRect.ReshowDelay = 100;
			// 
			// m_btnGenPw
			// 
			this.m_btnGenPw.Image = global::KeePass.Properties.Resources.B15x13_KGPG_Gen;
			this.m_btnGenPw.Location = new System.Drawing.Point(422, 90);
			this.m_btnGenPw.Name = "m_btnGenPw";
			this.m_btnGenPw.Size = new System.Drawing.Size(32, 23);
			this.m_btnGenPw.TabIndex = 11;
			this.m_btnGenPw.UseVisualStyleBackColor = true;
			this.m_btnGenPw.Click += new System.EventHandler(this.OnPwGenClick);
			// 
			// m_cbHidePassword
			// 
			this.m_cbHidePassword.Appearance = System.Windows.Forms.Appearance.Button;
			this.m_cbHidePassword.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.m_cbHidePassword.Image = global::KeePass.Properties.Resources.B17x05_3BlackDots;
			this.m_cbHidePassword.Location = new System.Drawing.Point(422, 63);
			this.m_cbHidePassword.Name = "m_cbHidePassword";
			this.m_cbHidePassword.Size = new System.Drawing.Size(32, 23);
			this.m_cbHidePassword.TabIndex = 8;
			this.m_cbHidePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.m_cbHidePassword.UseVisualStyleBackColor = true;
			this.m_cbHidePassword.CheckedChanged += new System.EventHandler(this.OnCheckedHidePassword);
			// 
			// m_btnStandardExpires
			// 
			this.m_btnStandardExpires.ContextMenuStrip = this.m_ctxDefaultTimes;
			this.m_btnStandardExpires.Image = global::KeePass.Properties.Resources.B16x16_History;
			this.m_btnStandardExpires.Location = new System.Drawing.Point(422, 311);
			this.m_btnStandardExpires.Name = "m_btnStandardExpires";
			this.m_btnStandardExpires.Size = new System.Drawing.Size(32, 23);
			this.m_btnStandardExpires.TabIndex = 21;
			this.m_btnStandardExpires.UseVisualStyleBackColor = true;
			this.m_btnStandardExpires.Click += new System.EventHandler(this.OnBtnStandardExpiresClick);
			// 
			// m_lblSeparator
			// 
			this.m_lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_lblSeparator.Location = new System.Drawing.Point(0, 448);
			this.m_lblSeparator.Name = "m_lblSeparator";
			this.m_lblSeparator.Size = new System.Drawing.Size(486, 2);
			this.m_lblSeparator.TabIndex = 4;
			// 
			// m_ttBalloon
			// 
			this.m_ttBalloon.AutoPopDelay = 32000;
			this.m_ttBalloon.InitialDelay = 250;
			this.m_ttBalloon.IsBalloon = true;
			this.m_ttBalloon.ReshowDelay = 100;
			// 
			// m_ttValidationError
			// 
			this.m_ttValidationError.AutoPopDelay = 32000;
			this.m_ttValidationError.InitialDelay = 250;
			this.m_ttValidationError.ReshowDelay = 100;
			this.m_ttValidationError.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
			this.m_ttValidationError.ToolTipTitle = "Validation Warning";
			// 
			// m_tabMain
			// 
			this.m_tabMain.Controls.Add(this.m_tabEntry);
			this.m_tabMain.Controls.Add(this.m_tabAdvanced);
			this.m_tabMain.Controls.Add(this.m_tabProperties);
			this.m_tabMain.Controls.Add(this.m_tabAutoType);
			this.m_tabMain.Controls.Add(this.m_tabHistory);
			this.m_tabMain.Location = new System.Drawing.Point(6, 66);
			this.m_tabMain.Name = "m_tabMain";
			this.m_tabMain.SelectedIndex = 0;
			this.m_tabMain.Size = new System.Drawing.Size(475, 368);
			this.m_tabMain.TabIndex = 0;
			// 
			// m_tabEntry
			// 
			this.m_tabEntry.Controls.Add(this.m_lblTitle);
			this.m_tabEntry.Controls.Add(this.m_rtNotes);
			this.m_tabEntry.Controls.Add(this.m_cbExpires);
			this.m_tabEntry.Controls.Add(this.m_lblQualityBitsText);
			this.m_tabEntry.Controls.Add(this.m_tbUrl);
			this.m_tabEntry.Controls.Add(this.m_btnGenPw);
			this.m_tabEntry.Controls.Add(this.m_cbHidePassword);
			this.m_tabEntry.Controls.Add(this.m_pbQuality);
			this.m_tabEntry.Controls.Add(this.m_lblIcon);
			this.m_tabEntry.Controls.Add(this.m_btnIcon);
			this.m_tabEntry.Controls.Add(this.m_tbRepeatPassword);
			this.m_tabEntry.Controls.Add(this.m_tbPassword);
			this.m_tabEntry.Controls.Add(this.m_lblNotes);
			this.m_tabEntry.Controls.Add(this.m_dtExpireDateTime);
			this.m_tabEntry.Controls.Add(this.m_btnStandardExpires);
			this.m_tabEntry.Controls.Add(this.m_tbTitle);
			this.m_tabEntry.Controls.Add(this.m_lblUrl);
			this.m_tabEntry.Controls.Add(this.m_lblQuality);
			this.m_tabEntry.Controls.Add(this.m_lblPassword);
			this.m_tabEntry.Controls.Add(this.m_lblPasswordRepeat);
			this.m_tabEntry.Controls.Add(this.m_lblUserName);
			this.m_tabEntry.Controls.Add(this.m_tbUserName);
			this.m_tabEntry.Location = new System.Drawing.Point(4, 22);
			this.m_tabEntry.Name = "m_tabEntry";
			this.m_tabEntry.Padding = new System.Windows.Forms.Padding(3);
			this.m_tabEntry.Size = new System.Drawing.Size(467, 342);
			this.m_tabEntry.TabIndex = 0;
			this.m_tabEntry.Text = "Entry";
			this.m_tabEntry.UseVisualStyleBackColor = true;
			// 
			// m_pbQuality
			// 
			this.m_pbQuality.Location = new System.Drawing.Point(81, 118);
			this.m_pbQuality.Maximum = 100;
			this.m_pbQuality.Minimum = 0;
			this.m_pbQuality.Name = "m_pbQuality";
			this.m_pbQuality.Size = new System.Drawing.Size(283, 16);
			this.m_pbQuality.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.m_pbQuality.TabIndex = 13;
			this.m_pbQuality.TabStop = false;
			this.m_pbQuality.Value = 50;
			// 
			// m_tabAdvanced
			// 
			this.m_tabAdvanced.Controls.Add(this.m_grpAttachments);
			this.m_tabAdvanced.Controls.Add(this.m_grpStringFields);
			this.m_tabAdvanced.Location = new System.Drawing.Point(4, 22);
			this.m_tabAdvanced.Name = "m_tabAdvanced";
			this.m_tabAdvanced.Padding = new System.Windows.Forms.Padding(3);
			this.m_tabAdvanced.Size = new System.Drawing.Size(467, 342);
			this.m_tabAdvanced.TabIndex = 1;
			this.m_tabAdvanced.Text = "Advanced";
			this.m_tabAdvanced.UseVisualStyleBackColor = true;
			// 
			// m_grpAttachments
			// 
			this.m_grpAttachments.Controls.Add(this.m_btnBinView);
			this.m_grpAttachments.Controls.Add(this.m_btnBinSave);
			this.m_grpAttachments.Controls.Add(this.m_btnBinDelete);
			this.m_grpAttachments.Controls.Add(this.m_btnBinAdd);
			this.m_grpAttachments.Controls.Add(this.m_lvBinaries);
			this.m_grpAttachments.Location = new System.Drawing.Point(6, 174);
			this.m_grpAttachments.Name = "m_grpAttachments";
			this.m_grpAttachments.Size = new System.Drawing.Size(455, 162);
			this.m_grpAttachments.TabIndex = 1;
			this.m_grpAttachments.TabStop = false;
			this.m_grpAttachments.Text = "File attachments";
			// 
			// m_btnBinView
			// 
			this.m_btnBinView.Location = new System.Drawing.Point(374, 104);
			this.m_btnBinView.Name = "m_btnBinView";
			this.m_btnBinView.Size = new System.Drawing.Size(75, 23);
			this.m_btnBinView.TabIndex = 4;
			this.m_btnBinView.Text = "&View";
			this.m_btnBinView.UseVisualStyleBackColor = true;
			this.m_btnBinView.Click += new System.EventHandler(this.OnBtnBinView);
			// 
			// m_btnBinSave
			// 
			this.m_btnBinSave.Location = new System.Drawing.Point(374, 133);
			this.m_btnBinSave.Name = "m_btnBinSave";
			this.m_btnBinSave.Size = new System.Drawing.Size(75, 23);
			this.m_btnBinSave.TabIndex = 3;
			this.m_btnBinSave.Text = "&Save";
			this.m_btnBinSave.UseVisualStyleBackColor = true;
			this.m_btnBinSave.Click += new System.EventHandler(this.OnBtnBinSave);
			// 
			// m_btnBinDelete
			// 
			this.m_btnBinDelete.Location = new System.Drawing.Point(374, 48);
			this.m_btnBinDelete.Name = "m_btnBinDelete";
			this.m_btnBinDelete.Size = new System.Drawing.Size(75, 23);
			this.m_btnBinDelete.TabIndex = 2;
			this.m_btnBinDelete.Text = "De&lete";
			this.m_btnBinDelete.UseVisualStyleBackColor = true;
			this.m_btnBinDelete.Click += new System.EventHandler(this.OnBtnBinDelete);
			// 
			// m_btnBinAdd
			// 
			this.m_btnBinAdd.Location = new System.Drawing.Point(374, 19);
			this.m_btnBinAdd.Name = "m_btnBinAdd";
			this.m_btnBinAdd.Size = new System.Drawing.Size(75, 23);
			this.m_btnBinAdd.TabIndex = 1;
			this.m_btnBinAdd.Text = "A&ttach";
			this.m_btnBinAdd.UseVisualStyleBackColor = true;
			this.m_btnBinAdd.Click += new System.EventHandler(this.OnBtnBinAdd);
			// 
			// m_lvBinaries
			// 
			this.m_lvBinaries.FullRowSelect = true;
			this.m_lvBinaries.HideSelection = false;
			this.m_lvBinaries.Location = new System.Drawing.Point(6, 20);
			this.m_lvBinaries.Name = "m_lvBinaries";
			this.m_lvBinaries.ShowItemToolTips = true;
			this.m_lvBinaries.Size = new System.Drawing.Size(362, 136);
			this.m_lvBinaries.TabIndex = 0;
			this.m_lvBinaries.UseCompatibleStateImageBehavior = false;
			this.m_lvBinaries.View = System.Windows.Forms.View.Details;
			this.m_lvBinaries.SelectedIndexChanged += new System.EventHandler(this.OnBinariesSelectedIndexChanged);
			// 
			// m_grpStringFields
			// 
			this.m_grpStringFields.Controls.Add(this.m_btnStrMove);
			this.m_grpStringFields.Controls.Add(this.m_btnStrAdd);
			this.m_grpStringFields.Controls.Add(this.m_btnStrEdit);
			this.m_grpStringFields.Controls.Add(this.m_btnStrDelete);
			this.m_grpStringFields.Controls.Add(this.m_lvStrings);
			this.m_grpStringFields.Location = new System.Drawing.Point(6, 6);
			this.m_grpStringFields.Name = "m_grpStringFields";
			this.m_grpStringFields.Size = new System.Drawing.Size(455, 162);
			this.m_grpStringFields.TabIndex = 0;
			this.m_grpStringFields.TabStop = false;
			this.m_grpStringFields.Text = "String fields";
			// 
			// m_btnStrMove
			// 
			this.m_btnStrMove.Location = new System.Drawing.Point(374, 106);
			this.m_btnStrMove.Name = "m_btnStrMove";
			this.m_btnStrMove.Size = new System.Drawing.Size(75, 23);
			this.m_btnStrMove.TabIndex = 4;
			this.m_btnStrMove.Text = "&Move";
			this.m_btnStrMove.UseVisualStyleBackColor = true;
			this.m_btnStrMove.Click += new System.EventHandler(this.OnBtnStrMove);
			// 
			// m_btnStrAdd
			// 
			this.m_btnStrAdd.Location = new System.Drawing.Point(374, 19);
			this.m_btnStrAdd.Name = "m_btnStrAdd";
			this.m_btnStrAdd.Size = new System.Drawing.Size(75, 23);
			this.m_btnStrAdd.TabIndex = 1;
			this.m_btnStrAdd.Text = "&Add";
			this.m_btnStrAdd.UseVisualStyleBackColor = true;
			this.m_btnStrAdd.Click += new System.EventHandler(this.OnBtnStrAdd);
			// 
			// m_btnStrEdit
			// 
			this.m_btnStrEdit.Location = new System.Drawing.Point(374, 48);
			this.m_btnStrEdit.Name = "m_btnStrEdit";
			this.m_btnStrEdit.Size = new System.Drawing.Size(75, 23);
			this.m_btnStrEdit.TabIndex = 2;
			this.m_btnStrEdit.Text = "&Edit";
			this.m_btnStrEdit.UseVisualStyleBackColor = true;
			this.m_btnStrEdit.Click += new System.EventHandler(this.OnBtnStrEdit);
			// 
			// m_btnStrDelete
			// 
			this.m_btnStrDelete.Location = new System.Drawing.Point(374, 77);
			this.m_btnStrDelete.Name = "m_btnStrDelete";
			this.m_btnStrDelete.Size = new System.Drawing.Size(75, 23);
			this.m_btnStrDelete.TabIndex = 3;
			this.m_btnStrDelete.Text = "D&elete";
			this.m_btnStrDelete.UseVisualStyleBackColor = true;
			this.m_btnStrDelete.Click += new System.EventHandler(this.OnBtnStrDelete);
			// 
			// m_lvStrings
			// 
			this.m_lvStrings.ContextMenuStrip = this.m_ctxListOperations;
			this.m_lvStrings.FullRowSelect = true;
			this.m_lvStrings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.m_lvStrings.HideSelection = false;
			this.m_lvStrings.Location = new System.Drawing.Point(6, 20);
			this.m_lvStrings.Name = "m_lvStrings";
			this.m_lvStrings.ShowItemToolTips = true;
			this.m_lvStrings.Size = new System.Drawing.Size(362, 136);
			this.m_lvStrings.TabIndex = 0;
			this.m_lvStrings.UseCompatibleStateImageBehavior = false;
			this.m_lvStrings.View = System.Windows.Forms.View.Details;
			this.m_lvStrings.ItemActivate += new System.EventHandler(this.OnStringsItemActivate);
			this.m_lvStrings.SelectedIndexChanged += new System.EventHandler(this.OnStringsSelectedIndexChanged);
			// 
			// m_ctxListOperations
			// 
			this.m_ctxListOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuListCtxCopyFieldValue});
			this.m_ctxListOperations.Name = "m_ctxListOperations";
			this.m_ctxListOperations.Size = new System.Drawing.Size(213, 26);
			// 
			// m_menuListCtxCopyFieldValue
			// 
			this.m_menuListCtxCopyFieldValue.Image = global::KeePass.Properties.Resources.B16x16_EditCopy;
			this.m_menuListCtxCopyFieldValue.Name = "m_menuListCtxCopyFieldValue";
			this.m_menuListCtxCopyFieldValue.Size = new System.Drawing.Size(212, 22);
			this.m_menuListCtxCopyFieldValue.Text = "&Copy Field Value to Clipboard";
			this.m_menuListCtxCopyFieldValue.Click += new System.EventHandler(this.OnCtxCopyFieldValue);
			// 
			// m_tabProperties
			// 
			this.m_tabProperties.Controls.Add(this.m_tbUuid);
			this.m_tabProperties.Controls.Add(this.m_lblUuid);
			this.m_tabProperties.Controls.Add(this.m_tbOverrideUrl);
			this.m_tabProperties.Controls.Add(this.m_lblOverrideUrl);
			this.m_tabProperties.Controls.Add(this.m_cbCustomBackgroundColor);
			this.m_tabProperties.Controls.Add(this.m_btnPickBgColor);
			this.m_tabProperties.Location = new System.Drawing.Point(4, 22);
			this.m_tabProperties.Name = "m_tabProperties";
			this.m_tabProperties.Size = new System.Drawing.Size(467, 342);
			this.m_tabProperties.TabIndex = 4;
			this.m_tabProperties.Text = "Properties";
			this.m_tabProperties.UseVisualStyleBackColor = true;
			// 
			// m_tbUuid
			// 
			this.m_tbUuid.Location = new System.Drawing.Point(51, 309);
			this.m_tbUuid.Name = "m_tbUuid";
			this.m_tbUuid.ReadOnly = true;
			this.m_tbUuid.Size = new System.Drawing.Size(403, 20);
			this.m_tbUuid.TabIndex = 5;
			// 
			// m_lblUuid
			// 
			this.m_lblUuid.AutoSize = true;
			this.m_lblUuid.Location = new System.Drawing.Point(9, 312);
			this.m_lblUuid.Name = "m_lblUuid";
			this.m_lblUuid.Size = new System.Drawing.Size(37, 13);
			this.m_lblUuid.TabIndex = 4;
			this.m_lblUuid.Text = "UUID:";
			// 
			// m_tbOverrideUrl
			// 
			this.m_tbOverrideUrl.Location = new System.Drawing.Point(12, 61);
			this.m_tbOverrideUrl.Name = "m_tbOverrideUrl";
			this.m_tbOverrideUrl.Size = new System.Drawing.Size(442, 20);
			this.m_tbOverrideUrl.TabIndex = 3;
			this.m_tbOverrideUrl.TextChanged += new System.EventHandler(this.OnOverrideUrlTextChanged);
			// 
			// m_lblOverrideUrl
			// 
			this.m_lblOverrideUrl.AutoSize = true;
			this.m_lblOverrideUrl.Location = new System.Drawing.Point(9, 45);
			this.m_lblOverrideUrl.Name = "m_lblOverrideUrl";
			this.m_lblOverrideUrl.Size = new System.Drawing.Size(75, 13);
			this.m_lblOverrideUrl.TabIndex = 2;
			this.m_lblOverrideUrl.Text = "Override URL:";
			// 
			// m_cbCustomBackgroundColor
			// 
			this.m_cbCustomBackgroundColor.AutoSize = true;
			this.m_cbCustomBackgroundColor.Location = new System.Drawing.Point(12, 16);
			this.m_cbCustomBackgroundColor.Name = "m_cbCustomBackgroundColor";
			this.m_cbCustomBackgroundColor.Size = new System.Drawing.Size(150, 17);
			this.m_cbCustomBackgroundColor.TabIndex = 0;
			this.m_cbCustomBackgroundColor.Text = "Custom background color:";
			this.m_cbCustomBackgroundColor.UseVisualStyleBackColor = true;
			this.m_cbCustomBackgroundColor.CheckedChanged += new System.EventHandler(this.OnCustomBackgroundColorCheckedChanged);
			// 
			// m_btnPickBgColor
			// 
			this.m_btnPickBgColor.Location = new System.Drawing.Point(168, 12);
			this.m_btnPickBgColor.Name = "m_btnPickBgColor";
			this.m_btnPickBgColor.Size = new System.Drawing.Size(48, 23);
			this.m_btnPickBgColor.TabIndex = 1;
			this.m_btnPickBgColor.UseVisualStyleBackColor = true;
			this.m_btnPickBgColor.Click += new System.EventHandler(this.OnPickBackgroundColor);
			// 
			// m_tabAutoType
			// 
			this.m_tabAutoType.Controls.Add(this.m_linkAutoTypeObfuscation);
			this.m_tabAutoType.Controls.Add(this.m_cbAutoTypeObfuscation);
			this.m_tabAutoType.Controls.Add(this.m_btnAutoTypeEditDefault);
			this.m_tabAutoType.Controls.Add(this.m_rbAutoTypeOverride);
			this.m_tabAutoType.Controls.Add(this.m_rbAutoTypeSeqInherit);
			this.m_tabAutoType.Controls.Add(this.m_lblCustomAutoType);
			this.m_tabAutoType.Controls.Add(this.m_cbAutoTypeEnabled);
			this.m_tabAutoType.Controls.Add(this.m_tbDefaultAutoTypeSeq);
			this.m_tabAutoType.Controls.Add(this.m_btnAutoTypeEdit);
			this.m_tabAutoType.Controls.Add(this.m_btnAutoTypeAdd);
			this.m_tabAutoType.Controls.Add(this.m_btnAutoTypeDelete);
			this.m_tabAutoType.Controls.Add(this.m_lvAutoType);
			this.m_tabAutoType.Location = new System.Drawing.Point(4, 22);
			this.m_tabAutoType.Name = "m_tabAutoType";
			this.m_tabAutoType.Size = new System.Drawing.Size(467, 342);
			this.m_tabAutoType.TabIndex = 2;
			this.m_tabAutoType.Text = "Auto-Type";
			this.m_tabAutoType.UseVisualStyleBackColor = true;
			// 
			// m_linkAutoTypeObfuscation
			// 
			this.m_linkAutoTypeObfuscation.AutoSize = true;
			this.m_linkAutoTypeObfuscation.Location = new System.Drawing.Point(213, 314);
			this.m_linkAutoTypeObfuscation.Name = "m_linkAutoTypeObfuscation";
			this.m_linkAutoTypeObfuscation.Size = new System.Drawing.Size(68, 13);
			this.m_linkAutoTypeObfuscation.TabIndex = 11;
			this.m_linkAutoTypeObfuscation.TabStop = true;
			this.m_linkAutoTypeObfuscation.Text = "What is this?";
			this.m_linkAutoTypeObfuscation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnAutoTypeObfuscationLink);
			// 
			// m_cbAutoTypeObfuscation
			// 
			this.m_cbAutoTypeObfuscation.AutoSize = true;
			this.m_cbAutoTypeObfuscation.Location = new System.Drawing.Point(10, 313);
			this.m_cbAutoTypeObfuscation.Name = "m_cbAutoTypeObfuscation";
			this.m_cbAutoTypeObfuscation.Size = new System.Drawing.Size(193, 17);
			this.m_cbAutoTypeObfuscation.TabIndex = 10;
			this.m_cbAutoTypeObfuscation.Text = "Two-channel auto-type obfuscation";
			this.m_cbAutoTypeObfuscation.UseVisualStyleBackColor = true;
			this.m_cbAutoTypeObfuscation.CheckedChanged += new System.EventHandler(this.OnAutoTypeObfuscationCheckedChanged);
			// 
			// m_btnAutoTypeEditDefault
			// 
			this.m_btnAutoTypeEditDefault.Location = new System.Drawing.Point(378, 84);
			this.m_btnAutoTypeEditDefault.Name = "m_btnAutoTypeEditDefault";
			this.m_btnAutoTypeEditDefault.Size = new System.Drawing.Size(75, 23);
			this.m_btnAutoTypeEditDefault.TabIndex = 4;
			this.m_btnAutoTypeEditDefault.Text = "&Edit";
			this.m_btnAutoTypeEditDefault.UseVisualStyleBackColor = true;
			this.m_btnAutoTypeEditDefault.Click += new System.EventHandler(this.OnBtnAutoTypeEditDefault);
			// 
			// m_rbAutoTypeOverride
			// 
			this.m_rbAutoTypeOverride.AutoSize = true;
			this.m_rbAutoTypeOverride.Location = new System.Drawing.Point(10, 65);
			this.m_rbAutoTypeOverride.Name = "m_rbAutoTypeOverride";
			this.m_rbAutoTypeOverride.Size = new System.Drawing.Size(153, 17);
			this.m_rbAutoTypeOverride.TabIndex = 2;
			this.m_rbAutoTypeOverride.TabStop = true;
			this.m_rbAutoTypeOverride.Text = "Override default sequence:";
			this.m_rbAutoTypeOverride.UseVisualStyleBackColor = true;
			// 
			// m_rbAutoTypeSeqInherit
			// 
			this.m_rbAutoTypeSeqInherit.AutoSize = true;
			this.m_rbAutoTypeSeqInherit.Location = new System.Drawing.Point(10, 44);
			this.m_rbAutoTypeSeqInherit.Name = "m_rbAutoTypeSeqInherit";
			this.m_rbAutoTypeSeqInherit.Size = new System.Drawing.Size(239, 17);
			this.m_rbAutoTypeSeqInherit.TabIndex = 1;
			this.m_rbAutoTypeSeqInherit.TabStop = true;
			this.m_rbAutoTypeSeqInherit.Text = "Inherit default auto-type sequence from group";
			this.m_rbAutoTypeSeqInherit.UseVisualStyleBackColor = true;
			this.m_rbAutoTypeSeqInherit.CheckedChanged += new System.EventHandler(this.OnAutoTypeSeqInheritCheckedChanged);
			// 
			// m_lblCustomAutoType
			// 
			this.m_lblCustomAutoType.AutoSize = true;
			this.m_lblCustomAutoType.Location = new System.Drawing.Point(7, 118);
			this.m_lblCustomAutoType.Name = "m_lblCustomAutoType";
			this.m_lblCustomAutoType.Size = new System.Drawing.Size(219, 13);
			this.m_lblCustomAutoType.TabIndex = 5;
			this.m_lblCustomAutoType.Text = "Use custom sequences for specific windows:";
			// 
			// m_cbAutoTypeEnabled
			// 
			this.m_cbAutoTypeEnabled.AutoSize = true;
			this.m_cbAutoTypeEnabled.Location = new System.Drawing.Point(10, 12);
			this.m_cbAutoTypeEnabled.Name = "m_cbAutoTypeEnabled";
			this.m_cbAutoTypeEnabled.Size = new System.Drawing.Size(166, 17);
			this.m_cbAutoTypeEnabled.TabIndex = 0;
			this.m_cbAutoTypeEnabled.Text = "Enable auto-type for this entry";
			this.m_cbAutoTypeEnabled.UseVisualStyleBackColor = true;
			this.m_cbAutoTypeEnabled.CheckedChanged += new System.EventHandler(this.OnAutoTypeEnableCheckedChanged);
			// 
			// m_tbDefaultAutoTypeSeq
			// 
			this.m_tbDefaultAutoTypeSeq.Location = new System.Drawing.Point(29, 86);
			this.m_tbDefaultAutoTypeSeq.Name = "m_tbDefaultAutoTypeSeq";
			this.m_tbDefaultAutoTypeSeq.Size = new System.Drawing.Size(343, 20);
			this.m_tbDefaultAutoTypeSeq.TabIndex = 3;
			this.m_tbDefaultAutoTypeSeq.TextChanged += new System.EventHandler(this.OnDefaultAutoTypeSeqTextChanged);
			// 
			// m_btnAutoTypeEdit
			// 
			this.m_btnAutoTypeEdit.Location = new System.Drawing.Point(378, 162);
			this.m_btnAutoTypeEdit.Name = "m_btnAutoTypeEdit";
			this.m_btnAutoTypeEdit.Size = new System.Drawing.Size(75, 23);
			this.m_btnAutoTypeEdit.TabIndex = 8;
			this.m_btnAutoTypeEdit.Text = "&Edit";
			this.m_btnAutoTypeEdit.UseVisualStyleBackColor = true;
			this.m_btnAutoTypeEdit.Click += new System.EventHandler(this.OnBtnAutoTypeEdit);
			// 
			// m_btnAutoTypeAdd
			// 
			this.m_btnAutoTypeAdd.Location = new System.Drawing.Point(378, 133);
			this.m_btnAutoTypeAdd.Name = "m_btnAutoTypeAdd";
			this.m_btnAutoTypeAdd.Size = new System.Drawing.Size(75, 23);
			this.m_btnAutoTypeAdd.TabIndex = 7;
			this.m_btnAutoTypeAdd.Text = "&Add";
			this.m_btnAutoTypeAdd.UseVisualStyleBackColor = true;
			this.m_btnAutoTypeAdd.Click += new System.EventHandler(this.OnBtnAutoTypeAdd);
			// 
			// m_btnAutoTypeDelete
			// 
			this.m_btnAutoTypeDelete.Location = new System.Drawing.Point(378, 191);
			this.m_btnAutoTypeDelete.Name = "m_btnAutoTypeDelete";
			this.m_btnAutoTypeDelete.Size = new System.Drawing.Size(75, 23);
			this.m_btnAutoTypeDelete.TabIndex = 9;
			this.m_btnAutoTypeDelete.Text = "&Remove";
			this.m_btnAutoTypeDelete.UseVisualStyleBackColor = true;
			this.m_btnAutoTypeDelete.Click += new System.EventHandler(this.OnBtnAutoTypeDelete);
			// 
			// m_lvAutoType
			// 
			this.m_lvAutoType.ContextMenuStrip = this.m_ctxListOperations;
			this.m_lvAutoType.FullRowSelect = true;
			this.m_lvAutoType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.m_lvAutoType.HideSelection = false;
			this.m_lvAutoType.Location = new System.Drawing.Point(10, 134);
			this.m_lvAutoType.Name = "m_lvAutoType";
			this.m_lvAutoType.ShowItemToolTips = true;
			this.m_lvAutoType.Size = new System.Drawing.Size(362, 170);
			this.m_lvAutoType.TabIndex = 6;
			this.m_lvAutoType.UseCompatibleStateImageBehavior = false;
			this.m_lvAutoType.View = System.Windows.Forms.View.Details;
			this.m_lvAutoType.ItemActivate += new System.EventHandler(this.OnAutoTypeItemActivate);
			this.m_lvAutoType.SelectedIndexChanged += new System.EventHandler(this.OnAutoTypeSelectedIndexChanged);
			// 
			// m_tabHistory
			// 
			this.m_tabHistory.Controls.Add(this.m_btnHistoryDelete);
			this.m_tabHistory.Controls.Add(this.m_btnHistoryView);
			this.m_tabHistory.Controls.Add(this.m_btnHistoryRestore);
			this.m_tabHistory.Controls.Add(this.m_lvHistory);
			this.m_tabHistory.Location = new System.Drawing.Point(4, 22);
			this.m_tabHistory.Name = "m_tabHistory";
			this.m_tabHistory.Size = new System.Drawing.Size(467, 342);
			this.m_tabHistory.TabIndex = 3;
			this.m_tabHistory.Text = "History";
			this.m_tabHistory.UseVisualStyleBackColor = true;
			// 
			// m_btnHistoryDelete
			// 
			this.m_btnHistoryDelete.Location = new System.Drawing.Point(93, 307);
			this.m_btnHistoryDelete.Name = "m_btnHistoryDelete";
			this.m_btnHistoryDelete.Size = new System.Drawing.Size(75, 23);
			this.m_btnHistoryDelete.TabIndex = 2;
			this.m_btnHistoryDelete.Text = "&Delete";
			this.m_btnHistoryDelete.UseVisualStyleBackColor = true;
			this.m_btnHistoryDelete.Click += new System.EventHandler(this.OnBtnHistoryDelete);
			// 
			// m_btnHistoryView
			// 
			this.m_btnHistoryView.Location = new System.Drawing.Point(12, 307);
			this.m_btnHistoryView.Name = "m_btnHistoryView";
			this.m_btnHistoryView.Size = new System.Drawing.Size(75, 23);
			this.m_btnHistoryView.TabIndex = 1;
			this.m_btnHistoryView.Text = "&View";
			this.m_btnHistoryView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.m_btnHistoryView.UseVisualStyleBackColor = true;
			this.m_btnHistoryView.Click += new System.EventHandler(this.OnBtnHistoryView);
			// 
			// m_btnHistoryRestore
			// 
			this.m_btnHistoryRestore.Location = new System.Drawing.Point(377, 307);
			this.m_btnHistoryRestore.Name = "m_btnHistoryRestore";
			this.m_btnHistoryRestore.Size = new System.Drawing.Size(75, 23);
			this.m_btnHistoryRestore.TabIndex = 3;
			this.m_btnHistoryRestore.Text = "&Restore";
			this.m_btnHistoryRestore.UseVisualStyleBackColor = true;
			this.m_btnHistoryRestore.Click += new System.EventHandler(this.OnBtnHistoryRestore);
			// 
			// m_lvHistory
			// 
			this.m_lvHistory.FullRowSelect = true;
			this.m_lvHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.m_lvHistory.HideSelection = false;
			this.m_lvHistory.Location = new System.Drawing.Point(12, 14);
			this.m_lvHistory.Name = "m_lvHistory";
			this.m_lvHistory.ShowItemToolTips = true;
			this.m_lvHistory.Size = new System.Drawing.Size(440, 287);
			this.m_lvHistory.TabIndex = 0;
			this.m_lvHistory.UseCompatibleStateImageBehavior = false;
			this.m_lvHistory.View = System.Windows.Forms.View.Details;
			this.m_lvHistory.SelectedIndexChanged += new System.EventHandler(this.OnHistorySelectedIndexChanged);
			// 
			// m_btnTools
			// 
			this.m_btnTools.Image = global::KeePass.Properties.Resources.B16x16_Package_Settings;
			this.m_btnTools.Location = new System.Drawing.Point(6, 453);
			this.m_btnTools.Name = "m_btnTools";
			this.m_btnTools.Size = new System.Drawing.Size(80, 23);
			this.m_btnTools.TabIndex = 3;
			this.m_btnTools.Text = "&Tools";
			this.m_btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.m_btnTools.UseVisualStyleBackColor = true;
			this.m_btnTools.Click += new System.EventHandler(this.OnBtnTools);
			// 
			// m_bannerImage
			// 
			this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
			this.m_bannerImage.Name = "m_bannerImage";
			this.m_bannerImage.Size = new System.Drawing.Size(487, 60);
			this.m_bannerImage.TabIndex = 16;
			this.m_bannerImage.TabStop = false;
			// 
			// m_ctxStrMoveToStandard
			// 
			this.m_ctxStrMoveToStandard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuListCtxMoveStandardTitle,
            this.m_menuListCtxMoveStandardUser,
            this.m_menuListCtxMoveStandardPassword,
            this.m_menuListCtxMoveStandardURL,
            this.m_menuListCtxMoveStandardNotes});
			this.m_ctxStrMoveToStandard.Name = "m_ctxStrMoveToStandard";
			this.m_ctxStrMoveToStandard.Size = new System.Drawing.Size(144, 114);
			// 
			// m_menuListCtxMoveStandardTitle
			// 
			this.m_menuListCtxMoveStandardTitle.Name = "m_menuListCtxMoveStandardTitle";
			this.m_menuListCtxMoveStandardTitle.Size = new System.Drawing.Size(143, 22);
			this.m_menuListCtxMoveStandardTitle.Text = "To &Title";
			this.m_menuListCtxMoveStandardTitle.Click += new System.EventHandler(this.OnCtxMoveToTitle);
			// 
			// m_menuListCtxMoveStandardUser
			// 
			this.m_menuListCtxMoveStandardUser.Name = "m_menuListCtxMoveStandardUser";
			this.m_menuListCtxMoveStandardUser.Size = new System.Drawing.Size(143, 22);
			this.m_menuListCtxMoveStandardUser.Text = "To User &Name";
			this.m_menuListCtxMoveStandardUser.Click += new System.EventHandler(this.OnCtxMoveToUserName);
			// 
			// m_menuListCtxMoveStandardPassword
			// 
			this.m_menuListCtxMoveStandardPassword.Name = "m_menuListCtxMoveStandardPassword";
			this.m_menuListCtxMoveStandardPassword.Size = new System.Drawing.Size(143, 22);
			this.m_menuListCtxMoveStandardPassword.Text = "To &Password";
			this.m_menuListCtxMoveStandardPassword.Click += new System.EventHandler(this.OnCtxMoveToPassword);
			// 
			// m_menuListCtxMoveStandardURL
			// 
			this.m_menuListCtxMoveStandardURL.Name = "m_menuListCtxMoveStandardURL";
			this.m_menuListCtxMoveStandardURL.Size = new System.Drawing.Size(143, 22);
			this.m_menuListCtxMoveStandardURL.Text = "To &URL";
			this.m_menuListCtxMoveStandardURL.Click += new System.EventHandler(this.OnCtxMoveToURL);
			// 
			// m_menuListCtxMoveStandardNotes
			// 
			this.m_menuListCtxMoveStandardNotes.Name = "m_menuListCtxMoveStandardNotes";
			this.m_menuListCtxMoveStandardNotes.Size = new System.Drawing.Size(143, 22);
			this.m_menuListCtxMoveStandardNotes.Text = "To No&tes";
			this.m_menuListCtxMoveStandardNotes.Click += new System.EventHandler(this.OnCtxMoveToNotes);
			// 
			// m_ctxPwGen
			// 
			this.m_ctxPwGen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxPwGenOpen,
            this.m_ctxPwGenSep0,
            this.m_ctxPwGenProfiles});
			this.m_ctxPwGen.Name = "m_ctxPwGen";
			this.m_ctxPwGen.Size = new System.Drawing.Size(209, 54);
			// 
			// m_ctxPwGenOpen
			// 
			this.m_ctxPwGenOpen.Image = global::KeePass.Properties.Resources.B16x16_KGPG_Gen;
			this.m_ctxPwGenOpen.Name = "m_ctxPwGenOpen";
			this.m_ctxPwGenOpen.Size = new System.Drawing.Size(208, 22);
			this.m_ctxPwGenOpen.Text = "&Open Password Generator...";
			this.m_ctxPwGenOpen.Click += new System.EventHandler(this.OnPwGenOpen);
			// 
			// m_ctxPwGenSep0
			// 
			this.m_ctxPwGenSep0.Name = "m_ctxPwGenSep0";
			this.m_ctxPwGenSep0.Size = new System.Drawing.Size(205, 6);
			// 
			// m_ctxPwGenProfiles
			// 
			this.m_ctxPwGenProfiles.Name = "m_ctxPwGenProfiles";
			this.m_ctxPwGenProfiles.Size = new System.Drawing.Size(208, 22);
			this.m_ctxPwGenProfiles.Text = "Generate Using Profile";
			// 
			// m_dlgColorSel
			// 
			this.m_dlgColorSel.AnyColor = true;
			this.m_dlgColorSel.FullOpen = true;
			// 
			// m_ctxTools
			// 
			this.m_ctxTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxToolsHelp,
            this.m_ctxToolsSep0,
            this.m_ctxToolsUrlHelp,
            this.m_ctxToolsUrlSelApp,
            this.m_ctxToolsUrlSelDoc,
            this.m_ctxToolsSep1,
            this.m_ctxToolsFieldRefs});
			this.m_ctxTools.Name = "m_ctxTools";
			this.m_ctxTools.Size = new System.Drawing.Size(222, 126);
			// 
			// m_ctxToolsHelp
			// 
			this.m_ctxToolsHelp.Image = global::KeePass.Properties.Resources.B16x16_Help;
			this.m_ctxToolsHelp.Name = "m_ctxToolsHelp";
			this.m_ctxToolsHelp.Size = new System.Drawing.Size(221, 22);
			this.m_ctxToolsHelp.Text = "&Help";
			this.m_ctxToolsHelp.Click += new System.EventHandler(this.OnCtxToolsHelp);
			// 
			// m_ctxToolsSep0
			// 
			this.m_ctxToolsSep0.Name = "m_ctxToolsSep0";
			this.m_ctxToolsSep0.Size = new System.Drawing.Size(218, 6);
			// 
			// m_ctxToolsUrlHelp
			// 
			this.m_ctxToolsUrlHelp.Image = global::KeePass.Properties.Resources.B16x16_Help;
			this.m_ctxToolsUrlHelp.Name = "m_ctxToolsUrlHelp";
			this.m_ctxToolsUrlHelp.Size = new System.Drawing.Size(221, 22);
			this.m_ctxToolsUrlHelp.Text = "&URL Field: Help";
			this.m_ctxToolsUrlHelp.Click += new System.EventHandler(this.OnCtxUrlHelp);
			// 
			// m_ctxToolsUrlSelApp
			// 
			this.m_ctxToolsUrlSelApp.Image = global::KeePass.Properties.Resources.B16x16_View_Detailed;
			this.m_ctxToolsUrlSelApp.Name = "m_ctxToolsUrlSelApp";
			this.m_ctxToolsUrlSelApp.Size = new System.Drawing.Size(221, 22);
			this.m_ctxToolsUrlSelApp.Text = "URL Field: Select &Application...";
			this.m_ctxToolsUrlSelApp.Click += new System.EventHandler(this.OnCtxUrlSelApp);
			// 
			// m_ctxToolsUrlSelDoc
			// 
			this.m_ctxToolsUrlSelDoc.Image = global::KeePass.Properties.Resources.B16x16_CompFile;
			this.m_ctxToolsUrlSelDoc.Name = "m_ctxToolsUrlSelDoc";
			this.m_ctxToolsUrlSelDoc.Size = new System.Drawing.Size(221, 22);
			this.m_ctxToolsUrlSelDoc.Text = "URL Field: Select &Document...";
			this.m_ctxToolsUrlSelDoc.Click += new System.EventHandler(this.OnCtxUrlSelDoc);
			// 
			// m_ctxToolsSep1
			// 
			this.m_ctxToolsSep1.Name = "m_ctxToolsSep1";
			this.m_ctxToolsSep1.Size = new System.Drawing.Size(218, 6);
			// 
			// m_ctxToolsFieldRefs
			// 
			this.m_ctxToolsFieldRefs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxToolsFieldRefsInTitle,
            this.m_ctxToolsFieldRefsInUserName,
            this.m_ctxToolsFieldRefsInPassword,
            this.m_ctxToolsFieldRefsInUrl,
            this.m_ctxToolsFieldRefsInNotes});
			this.m_ctxToolsFieldRefs.Name = "m_ctxToolsFieldRefs";
			this.m_ctxToolsFieldRefs.Size = new System.Drawing.Size(221, 22);
			this.m_ctxToolsFieldRefs.Text = "Insert Field &Reference";
			// 
			// m_ctxToolsFieldRefsInTitle
			// 
			this.m_ctxToolsFieldRefsInTitle.Name = "m_ctxToolsFieldRefsInTitle";
			this.m_ctxToolsFieldRefsInTitle.Size = new System.Drawing.Size(164, 22);
			this.m_ctxToolsFieldRefsInTitle.Text = "In &Title Field";
			this.m_ctxToolsFieldRefsInTitle.Click += new System.EventHandler(this.OnFieldRefInTitle);
			// 
			// m_ctxToolsFieldRefsInUserName
			// 
			this.m_ctxToolsFieldRefsInUserName.Name = "m_ctxToolsFieldRefsInUserName";
			this.m_ctxToolsFieldRefsInUserName.Size = new System.Drawing.Size(164, 22);
			this.m_ctxToolsFieldRefsInUserName.Text = "In User &Name Field";
			this.m_ctxToolsFieldRefsInUserName.Click += new System.EventHandler(this.OnFieldRefInUserName);
			// 
			// m_ctxToolsFieldRefsInPassword
			// 
			this.m_ctxToolsFieldRefsInPassword.Name = "m_ctxToolsFieldRefsInPassword";
			this.m_ctxToolsFieldRefsInPassword.Size = new System.Drawing.Size(164, 22);
			this.m_ctxToolsFieldRefsInPassword.Text = "In &Password Field";
			this.m_ctxToolsFieldRefsInPassword.Click += new System.EventHandler(this.OnFieldRefInPassword);
			// 
			// m_ctxToolsFieldRefsInUrl
			// 
			this.m_ctxToolsFieldRefsInUrl.Name = "m_ctxToolsFieldRefsInUrl";
			this.m_ctxToolsFieldRefsInUrl.Size = new System.Drawing.Size(164, 22);
			this.m_ctxToolsFieldRefsInUrl.Text = "In &URL Field";
			this.m_ctxToolsFieldRefsInUrl.Click += new System.EventHandler(this.OnFieldRefInUrl);
			// 
			// m_ctxToolsFieldRefsInNotes
			// 
			this.m_ctxToolsFieldRefsInNotes.Name = "m_ctxToolsFieldRefsInNotes";
			this.m_ctxToolsFieldRefsInNotes.Size = new System.Drawing.Size(164, 22);
			this.m_ctxToolsFieldRefsInNotes.Text = "In N&otes Field";
			this.m_ctxToolsFieldRefsInNotes.Click += new System.EventHandler(this.OnFieldRefInNotes);
			// 
			// PwEntryForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(487, 486);
			this.Controls.Add(this.m_tabMain);
			this.Controls.Add(this.m_lblSeparator);
			this.Controls.Add(this.m_bannerImage);
			this.Controls.Add(this.m_btnTools);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PwEntryForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "<DYN>";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			this.m_ctxDefaultTimes.ResumeLayout(false);
			this.m_tabMain.ResumeLayout(false);
			this.m_tabEntry.ResumeLayout(false);
			this.m_tabEntry.PerformLayout();
			this.m_tabAdvanced.ResumeLayout(false);
			this.m_grpAttachments.ResumeLayout(false);
			this.m_grpStringFields.ResumeLayout(false);
			this.m_ctxListOperations.ResumeLayout(false);
			this.m_tabProperties.ResumeLayout(false);
			this.m_tabProperties.PerformLayout();
			this.m_tabAutoType.ResumeLayout(false);
			this.m_tabAutoType.PerformLayout();
			this.m_tabHistory.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
			this.m_ctxStrMoveToStandard.ResumeLayout(false);
			this.m_ctxPwGen.ResumeLayout(false);
			this.m_ctxTools.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label m_lblUserName;
		private System.Windows.Forms.Label m_lblPassword;
		private System.Windows.Forms.Label m_lblTitle;
		private System.Windows.Forms.Label m_lblPasswordRepeat;
		private System.Windows.Forms.Label m_lblUrl;
		private System.Windows.Forms.Label m_lblNotes;
		private System.Windows.Forms.Label m_lblQuality;
		private System.Windows.Forms.TextBox m_tbTitle;
		private System.Windows.Forms.Button m_btnIcon;
		private System.Windows.Forms.Label m_lblIcon;
		private System.Windows.Forms.TextBox m_tbUserName;
		private System.Windows.Forms.TextBox m_tbPassword;
		private System.Windows.Forms.TextBox m_tbRepeatPassword;
		private KeePass.UI.QualityProgressBar m_pbQuality;
		private System.Windows.Forms.TextBox m_tbUrl;
		private System.Windows.Forms.RichTextBox m_rtNotes;
		private System.Windows.Forms.CheckBox m_cbExpires;
		private System.Windows.Forms.DateTimePicker m_dtExpireDateTime;
		private System.Windows.Forms.Button m_btnStandardExpires;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.CheckBox m_cbHidePassword;
		private System.Windows.Forms.Button m_btnGenPw;
		private System.Windows.Forms.Label m_lblQualityBitsText;
		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.ToolTip m_ttRect;
		private System.Windows.Forms.Label m_lblSeparator;
		private System.Windows.Forms.ToolTip m_ttBalloon;
		private System.Windows.Forms.ToolTip m_ttValidationError;
		private System.Windows.Forms.TabControl m_tabMain;
		private System.Windows.Forms.TabPage m_tabEntry;
		private System.Windows.Forms.TabPage m_tabAdvanced;
		private System.Windows.Forms.TabPage m_tabAutoType;
		private System.Windows.Forms.TabPage m_tabHistory;
		private System.Windows.Forms.GroupBox m_grpAttachments;
		private System.Windows.Forms.Button m_btnBinSave;
		private System.Windows.Forms.Button m_btnBinDelete;
		private System.Windows.Forms.Button m_btnBinAdd;
		private System.Windows.Forms.ListView m_lvBinaries;
		private System.Windows.Forms.GroupBox m_grpStringFields;
		private System.Windows.Forms.Button m_btnStrEdit;
		private System.Windows.Forms.Button m_btnStrDelete;
		private System.Windows.Forms.Button m_btnStrAdd;
		private System.Windows.Forms.ListView m_lvStrings;
		private System.Windows.Forms.Button m_btnTools;
		private System.Windows.Forms.Button m_btnAutoTypeEdit;
		private System.Windows.Forms.Button m_btnAutoTypeAdd;
		private System.Windows.Forms.Button m_btnAutoTypeDelete;
		private System.Windows.Forms.ListView m_lvAutoType;
		private System.Windows.Forms.Button m_btnHistoryRestore;
		private System.Windows.Forms.Button m_btnHistoryView;
		private System.Windows.Forms.ListView m_lvHistory;
		private System.Windows.Forms.Button m_btnHistoryDelete;
		private System.Windows.Forms.ContextMenuStrip m_ctxDefaultTimes;
		private System.Windows.Forms.ToolStripMenuItem m_menuExpireNow;
		private System.Windows.Forms.ToolStripSeparator m_menuExpireSep0;
		private System.Windows.Forms.ToolStripMenuItem m_menuExpire1Week;
		private System.Windows.Forms.ToolStripMenuItem m_menuExpire2Weeks;
		private System.Windows.Forms.ToolStripSeparator m_menuExpireSep1;
		private System.Windows.Forms.ToolStripMenuItem m_menuExpire1Month;
		private System.Windows.Forms.ToolStripMenuItem m_menuExpire3Months;
		private System.Windows.Forms.ToolStripMenuItem m_menuExpire6Months;
		private System.Windows.Forms.ToolStripSeparator m_menuExpireSep2;
		private System.Windows.Forms.ToolStripMenuItem m_menuExpire1Year;
		private System.Windows.Forms.ContextMenuStrip m_ctxListOperations;
		private System.Windows.Forms.ToolStripMenuItem m_menuListCtxCopyFieldValue;
		private System.Windows.Forms.TextBox m_tbDefaultAutoTypeSeq;
		private System.Windows.Forms.CheckBox m_cbAutoTypeEnabled;
		private System.Windows.Forms.Label m_lblCustomAutoType;
		private System.Windows.Forms.RadioButton m_rbAutoTypeOverride;
		private System.Windows.Forms.RadioButton m_rbAutoTypeSeqInherit;
		private System.Windows.Forms.Button m_btnAutoTypeEditDefault;
		private System.Windows.Forms.Button m_btnStrMove;
		private System.Windows.Forms.ContextMenuStrip m_ctxStrMoveToStandard;
		private System.Windows.Forms.ToolStripMenuItem m_menuListCtxMoveStandardTitle;
		private System.Windows.Forms.ToolStripMenuItem m_menuListCtxMoveStandardUser;
		private System.Windows.Forms.ToolStripMenuItem m_menuListCtxMoveStandardPassword;
		private System.Windows.Forms.ToolStripMenuItem m_menuListCtxMoveStandardURL;
		private System.Windows.Forms.ToolStripMenuItem m_menuListCtxMoveStandardNotes;
		private System.Windows.Forms.ContextMenuStrip m_ctxPwGen;
		private System.Windows.Forms.ToolStripMenuItem m_ctxPwGenOpen;
		private System.Windows.Forms.ToolStripSeparator m_ctxPwGenSep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxPwGenProfiles;
		private System.Windows.Forms.TabPage m_tabProperties;
		private System.Windows.Forms.Button m_btnPickBgColor;
		private System.Windows.Forms.ColorDialog m_dlgColorSel;
		private System.Windows.Forms.CheckBox m_cbCustomBackgroundColor;
		private System.Windows.Forms.TextBox m_tbOverrideUrl;
		private System.Windows.Forms.Label m_lblOverrideUrl;
		private System.Windows.Forms.LinkLabel m_linkAutoTypeObfuscation;
		private System.Windows.Forms.CheckBox m_cbAutoTypeObfuscation;
		private System.Windows.Forms.Button m_btnBinView;
		private System.Windows.Forms.TextBox m_tbUuid;
		private System.Windows.Forms.Label m_lblUuid;
		private System.Windows.Forms.ContextMenuStrip m_ctxTools;
		private System.Windows.Forms.ToolStripMenuItem m_ctxToolsHelp;
		private System.Windows.Forms.ToolStripSeparator m_ctxToolsSep0;
		private System.Windows.Forms.ToolStripMenuItem m_ctxToolsUrlHelp;
		private System.Windows.Forms.ToolStripMenuItem m_ctxToolsUrlSelApp;
		private System.Windows.Forms.ToolStripMenuItem m_ctxToolsUrlSelDoc;
		private System.Windows.Forms.ToolStripSeparator m_ctxToolsSep1;
		private System.Windows.Forms.ToolStripMenuItem m_ctxToolsFieldRefs;
		private System.Windows.Forms.ToolStripMenuItem m_ctxToolsFieldRefsInTitle;
		private System.Windows.Forms.ToolStripMenuItem m_ctxToolsFieldRefsInUserName;
		private System.Windows.Forms.ToolStripMenuItem m_ctxToolsFieldRefsInPassword;
		private System.Windows.Forms.ToolStripMenuItem m_ctxToolsFieldRefsInUrl;
		private System.Windows.Forms.ToolStripMenuItem m_ctxToolsFieldRefsInNotes;

	}
}