﻿namespace ETS2_Local_Radio_server
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.keyTimeout = new System.Windows.Forms.Timer(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.nextKeyTextBox = new System.Windows.Forms.TextBox();
            this.previousKeyTextBox = new System.Windows.Forms.TextBox();
            this.stopKeyTextBox = new System.Windows.Forms.TextBox();
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.goToFavouriteButtonTextbox = new System.Windows.Forms.TextBox();
            this.goToFavouriteKeyLabel = new System.Windows.Forms.Label();
            this.goToFavouriteKeyTextbox = new System.Windows.Forms.TextBox();
            this.buttonLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.makeFavouriteButtonTextbox = new System.Windows.Forms.TextBox();
            this.volumeDownButtonTextBox = new System.Windows.Forms.TextBox();
            this.volumeUpButtonTextBox = new System.Windows.Forms.TextBox();
            this.stopButtonTextBox = new System.Windows.Forms.TextBox();
            this.previousButtonTextBox = new System.Windows.Forms.TextBox();
            this.nextButtonTextBox = new System.Windows.Forms.TextBox();
            this.makeFavouriteKeyLabel = new System.Windows.Forms.Label();
            this.makeFavouriteKeyTextbox = new System.Windows.Forms.TextBox();
            this.volumeDownKeyLabel = new System.Windows.Forms.Label();
            this.volumeUpKeyLabel = new System.Windows.Forms.Label();
            this.volumeDownKeyTextBox = new System.Windows.Forms.TextBox();
            this.volumeUpKeyTextBox = new System.Windows.Forms.TextBox();
            this.previousKeyLabel = new System.Windows.Forms.Label();
            this.stopKeyLabel = new System.Windows.Forms.Label();
            this.nextKeyLabel = new System.Windows.Forms.Label();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.gameInfo = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.comboIP = new System.Windows.Forms.ComboBox();
            this.URLInfo = new System.Windows.Forms.Label();
            this.coordinatesInfo = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.statusInfo = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.URLLabel = new System.Windows.Forms.LinkLabel();
            this.comboLang = new System.Windows.Forms.ComboBox();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.joystickTimer = new System.Windows.Forms.Timer(this.components);
            this.currentGameTimer = new System.Windows.Forms.Timer(this.components);
            this.groupInstall = new System.Windows.Forms.GroupBox();
            this.installEts2Button = new System.Windows.Forms.Button();
            this.installAtsButton = new System.Windows.Forms.Button();
            this.Koenvh = new System.Windows.Forms.PictureBox();
            this.groupController = new System.Windows.Forms.GroupBox();
            this.comboController = new System.Windows.Forms.ComboBox();
            this.removePluginButton = new System.Windows.Forms.LinkLabel();
            this.groupSettings.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.groupInstall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Koenvh)).BeginInit();
            this.groupController.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyTimeout
            // 
            this.keyTimeout.Interval = 10;
            this.keyTimeout.Tick += new System.EventHandler(this.keyTimeout_Tick);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.saveButton.Location = new System.Drawing.Point(300, 227);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 34);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nextKeyTextBox
            // 
            this.nextKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextKeyTextBox.Location = new System.Drawing.Point(236, 38);
            this.nextKeyTextBox.Name = "nextKeyTextBox";
            this.nextKeyTextBox.ShortcutsEnabled = false;
            this.nextKeyTextBox.Size = new System.Drawing.Size(60, 22);
            this.nextKeyTextBox.TabIndex = 1;
            // 
            // previousKeyTextBox
            // 
            this.previousKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previousKeyTextBox.Location = new System.Drawing.Point(236, 64);
            this.previousKeyTextBox.Name = "previousKeyTextBox";
            this.previousKeyTextBox.ShortcutsEnabled = false;
            this.previousKeyTextBox.Size = new System.Drawing.Size(60, 22);
            this.previousKeyTextBox.TabIndex = 2;
            // 
            // stopKeyTextBox
            // 
            this.stopKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopKeyTextBox.Location = new System.Drawing.Point(236, 90);
            this.stopKeyTextBox.Name = "stopKeyTextBox";
            this.stopKeyTextBox.ShortcutsEnabled = false;
            this.stopKeyTextBox.Size = new System.Drawing.Size(60, 22);
            this.stopKeyTextBox.TabIndex = 3;
            // 
            // groupSettings
            // 
            this.groupSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSettings.Controls.Add(this.goToFavouriteButtonTextbox);
            this.groupSettings.Controls.Add(this.goToFavouriteKeyLabel);
            this.groupSettings.Controls.Add(this.goToFavouriteKeyTextbox);
            this.groupSettings.Controls.Add(this.buttonLabel);
            this.groupSettings.Controls.Add(this.keyLabel);
            this.groupSettings.Controls.Add(this.makeFavouriteButtonTextbox);
            this.groupSettings.Controls.Add(this.volumeDownButtonTextBox);
            this.groupSettings.Controls.Add(this.volumeUpButtonTextBox);
            this.groupSettings.Controls.Add(this.stopButtonTextBox);
            this.groupSettings.Controls.Add(this.previousButtonTextBox);
            this.groupSettings.Controls.Add(this.nextButtonTextBox);
            this.groupSettings.Controls.Add(this.makeFavouriteKeyLabel);
            this.groupSettings.Controls.Add(this.makeFavouriteKeyTextbox);
            this.groupSettings.Controls.Add(this.volumeDownKeyLabel);
            this.groupSettings.Controls.Add(this.volumeUpKeyLabel);
            this.groupSettings.Controls.Add(this.volumeDownKeyTextBox);
            this.groupSettings.Controls.Add(this.volumeUpKeyTextBox);
            this.groupSettings.Controls.Add(this.previousKeyLabel);
            this.groupSettings.Controls.Add(this.stopKeyLabel);
            this.groupSettings.Controls.Add(this.nextKeyLabel);
            this.groupSettings.Controls.Add(this.stopKeyTextBox);
            this.groupSettings.Controls.Add(this.saveButton);
            this.groupSettings.Controls.Add(this.previousKeyTextBox);
            this.groupSettings.Controls.Add(this.nextKeyTextBox);
            this.groupSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupSettings.Location = new System.Drawing.Point(12, 157);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Size = new System.Drawing.Size(413, 267);
            this.groupSettings.TabIndex = 4;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Settings";
            // 
            // goToFavouriteButtonTextbox
            // 
            this.goToFavouriteButtonTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goToFavouriteButtonTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.goToFavouriteButtonTextbox.Location = new System.Drawing.Point(332, 194);
            this.goToFavouriteButtonTextbox.Name = "goToFavouriteButtonTextbox";
            this.goToFavouriteButtonTextbox.ReadOnly = true;
            this.goToFavouriteButtonTextbox.ShortcutsEnabled = false;
            this.goToFavouriteButtonTextbox.Size = new System.Drawing.Size(60, 22);
            this.goToFavouriteButtonTextbox.TabIndex = 24;
            // 
            // goToFavouriteKeyLabel
            // 
            this.goToFavouriteKeyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.goToFavouriteKeyLabel.Location = new System.Drawing.Point(6, 194);
            this.goToFavouriteKeyLabel.Name = "goToFavouriteKeyLabel";
            this.goToFavouriteKeyLabel.Size = new System.Drawing.Size(224, 22);
            this.goToFavouriteKeyLabel.TabIndex = 23;
            this.goToFavouriteKeyLabel.Text = "Go to favourite key:";
            this.goToFavouriteKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // goToFavouriteKeyTextbox
            // 
            this.goToFavouriteKeyTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goToFavouriteKeyTextbox.Location = new System.Drawing.Point(236, 194);
            this.goToFavouriteKeyTextbox.Name = "goToFavouriteKeyTextbox";
            this.goToFavouriteKeyTextbox.ShortcutsEnabled = false;
            this.goToFavouriteKeyTextbox.Size = new System.Drawing.Size(60, 22);
            this.goToFavouriteKeyTextbox.TabIndex = 22;
            // 
            // buttonLabel
            // 
            this.buttonLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.buttonLabel.Location = new System.Drawing.Point(317, 15);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(90, 20);
            this.buttonLabel.TabIndex = 21;
            this.buttonLabel.Text = "Controller";
            this.buttonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyLabel
            // 
            this.keyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.keyLabel.Location = new System.Drawing.Point(221, 15);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(90, 20);
            this.keyLabel.TabIndex = 20;
            this.keyLabel.Text = "Keyboard";
            this.keyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // makeFavouriteButtonTextbox
            // 
            this.makeFavouriteButtonTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.makeFavouriteButtonTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.makeFavouriteButtonTextbox.Location = new System.Drawing.Point(332, 168);
            this.makeFavouriteButtonTextbox.Name = "makeFavouriteButtonTextbox";
            this.makeFavouriteButtonTextbox.ReadOnly = true;
            this.makeFavouriteButtonTextbox.ShortcutsEnabled = false;
            this.makeFavouriteButtonTextbox.Size = new System.Drawing.Size(60, 22);
            this.makeFavouriteButtonTextbox.TabIndex = 19;
            // 
            // volumeDownButtonTextBox
            // 
            this.volumeDownButtonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeDownButtonTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.volumeDownButtonTextBox.Location = new System.Drawing.Point(332, 142);
            this.volumeDownButtonTextBox.Name = "volumeDownButtonTextBox";
            this.volumeDownButtonTextBox.ReadOnly = true;
            this.volumeDownButtonTextBox.ShortcutsEnabled = false;
            this.volumeDownButtonTextBox.Size = new System.Drawing.Size(60, 22);
            this.volumeDownButtonTextBox.TabIndex = 18;
            // 
            // volumeUpButtonTextBox
            // 
            this.volumeUpButtonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeUpButtonTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.volumeUpButtonTextBox.Location = new System.Drawing.Point(332, 116);
            this.volumeUpButtonTextBox.Name = "volumeUpButtonTextBox";
            this.volumeUpButtonTextBox.ReadOnly = true;
            this.volumeUpButtonTextBox.ShortcutsEnabled = false;
            this.volumeUpButtonTextBox.Size = new System.Drawing.Size(60, 22);
            this.volumeUpButtonTextBox.TabIndex = 17;
            // 
            // stopButtonTextBox
            // 
            this.stopButtonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButtonTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.stopButtonTextBox.Location = new System.Drawing.Point(332, 90);
            this.stopButtonTextBox.Name = "stopButtonTextBox";
            this.stopButtonTextBox.ReadOnly = true;
            this.stopButtonTextBox.ShortcutsEnabled = false;
            this.stopButtonTextBox.Size = new System.Drawing.Size(60, 22);
            this.stopButtonTextBox.TabIndex = 16;
            // 
            // previousButtonTextBox
            // 
            this.previousButtonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previousButtonTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.previousButtonTextBox.Location = new System.Drawing.Point(332, 64);
            this.previousButtonTextBox.Name = "previousButtonTextBox";
            this.previousButtonTextBox.ReadOnly = true;
            this.previousButtonTextBox.ShortcutsEnabled = false;
            this.previousButtonTextBox.Size = new System.Drawing.Size(60, 22);
            this.previousButtonTextBox.TabIndex = 15;
            // 
            // nextButtonTextBox
            // 
            this.nextButtonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButtonTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nextButtonTextBox.Location = new System.Drawing.Point(332, 38);
            this.nextButtonTextBox.Name = "nextButtonTextBox";
            this.nextButtonTextBox.ReadOnly = true;
            this.nextButtonTextBox.ShortcutsEnabled = false;
            this.nextButtonTextBox.Size = new System.Drawing.Size(60, 22);
            this.nextButtonTextBox.TabIndex = 14;
            // 
            // makeFavouriteKeyLabel
            // 
            this.makeFavouriteKeyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.makeFavouriteKeyLabel.Location = new System.Drawing.Point(6, 168);
            this.makeFavouriteKeyLabel.Name = "makeFavouriteKeyLabel";
            this.makeFavouriteKeyLabel.Size = new System.Drawing.Size(224, 22);
            this.makeFavouriteKeyLabel.TabIndex = 13;
            this.makeFavouriteKeyLabel.Text = "Make favourite key:";
            this.makeFavouriteKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // makeFavouriteKeyTextbox
            // 
            this.makeFavouriteKeyTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.makeFavouriteKeyTextbox.Location = new System.Drawing.Point(236, 168);
            this.makeFavouriteKeyTextbox.Name = "makeFavouriteKeyTextbox";
            this.makeFavouriteKeyTextbox.ShortcutsEnabled = false;
            this.makeFavouriteKeyTextbox.Size = new System.Drawing.Size(60, 22);
            this.makeFavouriteKeyTextbox.TabIndex = 12;
            // 
            // volumeDownKeyLabel
            // 
            this.volumeDownKeyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.volumeDownKeyLabel.Location = new System.Drawing.Point(6, 142);
            this.volumeDownKeyLabel.Name = "volumeDownKeyLabel";
            this.volumeDownKeyLabel.Size = new System.Drawing.Size(224, 22);
            this.volumeDownKeyLabel.TabIndex = 11;
            this.volumeDownKeyLabel.Text = "Volume down key:";
            this.volumeDownKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volumeUpKeyLabel
            // 
            this.volumeUpKeyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.volumeUpKeyLabel.Location = new System.Drawing.Point(6, 116);
            this.volumeUpKeyLabel.Name = "volumeUpKeyLabel";
            this.volumeUpKeyLabel.Size = new System.Drawing.Size(224, 22);
            this.volumeUpKeyLabel.TabIndex = 10;
            this.volumeUpKeyLabel.Text = "Volume up key:";
            this.volumeUpKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volumeDownKeyTextBox
            // 
            this.volumeDownKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeDownKeyTextBox.Location = new System.Drawing.Point(236, 142);
            this.volumeDownKeyTextBox.Name = "volumeDownKeyTextBox";
            this.volumeDownKeyTextBox.ShortcutsEnabled = false;
            this.volumeDownKeyTextBox.Size = new System.Drawing.Size(60, 22);
            this.volumeDownKeyTextBox.TabIndex = 9;
            // 
            // volumeUpKeyTextBox
            // 
            this.volumeUpKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeUpKeyTextBox.Location = new System.Drawing.Point(236, 116);
            this.volumeUpKeyTextBox.Name = "volumeUpKeyTextBox";
            this.volumeUpKeyTextBox.ShortcutsEnabled = false;
            this.volumeUpKeyTextBox.Size = new System.Drawing.Size(60, 22);
            this.volumeUpKeyTextBox.TabIndex = 8;
            // 
            // previousKeyLabel
            // 
            this.previousKeyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.previousKeyLabel.Location = new System.Drawing.Point(6, 64);
            this.previousKeyLabel.Name = "previousKeyLabel";
            this.previousKeyLabel.Size = new System.Drawing.Size(224, 22);
            this.previousKeyLabel.TabIndex = 5;
            this.previousKeyLabel.Text = "Previous station key:";
            this.previousKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stopKeyLabel
            // 
            this.stopKeyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.stopKeyLabel.Location = new System.Drawing.Point(6, 90);
            this.stopKeyLabel.Name = "stopKeyLabel";
            this.stopKeyLabel.Size = new System.Drawing.Size(224, 22);
            this.stopKeyLabel.TabIndex = 5;
            this.stopKeyLabel.Text = "Stop playback key:";
            this.stopKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextKeyLabel
            // 
            this.nextKeyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.nextKeyLabel.Location = new System.Drawing.Point(6, 38);
            this.nextKeyLabel.Name = "nextKeyLabel";
            this.nextKeyLabel.Size = new System.Drawing.Size(224, 22);
            this.nextKeyLabel.TabIndex = 4;
            this.nextKeyLabel.Text = "Next station key:";
            this.nextKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupInfo
            // 
            this.groupInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInfo.Controls.Add(this.gameInfo);
            this.groupInfo.Controls.Add(this.gameLabel);
            this.groupInfo.Controls.Add(this.comboIP);
            this.groupInfo.Controls.Add(this.URLInfo);
            this.groupInfo.Controls.Add(this.coordinatesInfo);
            this.groupInfo.Controls.Add(this.locationLabel);
            this.groupInfo.Controls.Add(this.statusInfo);
            this.groupInfo.Controls.Add(this.statusLabel);
            this.groupInfo.Controls.Add(this.URLLabel);
            this.groupInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupInfo.Location = new System.Drawing.Point(12, 12);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(413, 139);
            this.groupInfo.TabIndex = 5;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Info";
            // 
            // gameInfo
            // 
            this.gameInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gameInfo.Location = new System.Drawing.Point(7, 17);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(82, 22);
            this.gameInfo.TabIndex = 13;
            this.gameInfo.Text = "Game:";
            this.gameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameLabel
            // 
            this.gameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gameLabel.Location = new System.Drawing.Point(95, 17);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(310, 22);
            this.gameLabel.TabIndex = 12;
            this.gameLabel.Text = "Euro Truck Simulator 2";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboIP
            // 
            this.comboIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIP.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboIP.FormattingEnabled = true;
            this.comboIP.Location = new System.Drawing.Point(95, 85);
            this.comboIP.Name = "comboIP";
            this.comboIP.Size = new System.Drawing.Size(310, 21);
            this.comboIP.TabIndex = 11;
            // 
            // URLInfo
            // 
            this.URLInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.URLInfo.Location = new System.Drawing.Point(7, 83);
            this.URLInfo.Name = "URLInfo";
            this.URLInfo.Size = new System.Drawing.Size(82, 22);
            this.URLInfo.TabIndex = 10;
            this.URLInfo.Text = "URL:";
            this.URLInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // coordinatesInfo
            // 
            this.coordinatesInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.coordinatesInfo.Location = new System.Drawing.Point(7, 61);
            this.coordinatesInfo.Name = "coordinatesInfo";
            this.coordinatesInfo.Size = new System.Drawing.Size(82, 22);
            this.coordinatesInfo.TabIndex = 9;
            this.coordinatesInfo.Text = "Coordinates:";
            this.coordinatesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // locationLabel
            // 
            this.locationLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.locationLabel.Location = new System.Drawing.Point(95, 61);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(312, 22);
            this.locationLabel.TabIndex = 6;
            this.locationLabel.Text = "XYZ";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusInfo
            // 
            this.statusInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.statusInfo.Location = new System.Drawing.Point(7, 39);
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(82, 22);
            this.statusInfo.TabIndex = 8;
            this.statusInfo.Text = "Status:";
            this.statusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.statusLabel.Location = new System.Drawing.Point(95, 39);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(310, 22);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // URLLabel
            // 
            this.URLLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.URLLabel.Location = new System.Drawing.Point(92, 109);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(313, 21);
            this.URLLabel.TabIndex = 6;
            this.URLLabel.TabStop = true;
            this.URLLabel.Text = "Open ETS2 Local Radio";
            this.URLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.URLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.URLLabel_LinkClicked);
            // 
            // comboLang
            // 
            this.comboLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLang.FormattingEnabled = true;
            this.comboLang.Location = new System.Drawing.Point(360, 618);
            this.comboLang.Name = "comboLang";
            this.comboLang.Size = new System.Drawing.Size(65, 21);
            this.comboLang.TabIndex = 8;
            this.comboLang.SelectedIndexChanged += new System.EventHandler(this.comboLang_SelectedIndexChanged);
            // 
            // folderDialog
            // 
            this.folderDialog.Description = "Please select the Euro Truck Simulator 2 installation folder, usually found in C:" +
    "\\Program Files (x86)\\Steam\\SteamApps\\common\\Euro Truck Simulator 2";
            this.folderDialog.ShowNewFolderButton = false;
            // 
            // joystickTimer
            // 
            this.joystickTimer.Interval = 10;
            this.joystickTimer.Tick += new System.EventHandler(this.joystickTimer_Tick);
            // 
            // currentGameTimer
            // 
            this.currentGameTimer.Interval = 3000;
            this.currentGameTimer.Tick += new System.EventHandler(this.currentGameTimer_Tick);
            // 
            // groupInstall
            // 
            this.groupInstall.Controls.Add(this.removePluginButton);
            this.groupInstall.Controls.Add(this.installEts2Button);
            this.groupInstall.Controls.Add(this.installAtsButton);
            this.groupInstall.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupInstall.Location = new System.Drawing.Point(12, 492);
            this.groupInstall.Name = "groupInstall";
            this.groupInstall.Size = new System.Drawing.Size(413, 91);
            this.groupInstall.TabIndex = 9;
            this.groupInstall.TabStop = false;
            this.groupInstall.Text = "Install plugin";
            // 
            // installEts2Button
            // 
            this.installEts2Button.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.installEts2Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.installEts2Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.installEts2Button.Location = new System.Drawing.Point(213, 23);
            this.installEts2Button.Name = "installEts2Button";
            this.installEts2Button.Size = new System.Drawing.Size(190, 44);
            this.installEts2Button.TabIndex = 1;
            this.installEts2Button.Text = "Install plugin for \r\nEuro Truck Simulator 2";
            this.installEts2Button.UseVisualStyleBackColor = true;
            this.installEts2Button.Click += new System.EventHandler(this.installEts2Button_Click);
            // 
            // installAtsButton
            // 
            this.installAtsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.installAtsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.installAtsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.installAtsButton.Location = new System.Drawing.Point(10, 23);
            this.installAtsButton.Name = "installAtsButton";
            this.installAtsButton.Size = new System.Drawing.Size(190, 44);
            this.installAtsButton.TabIndex = 0;
            this.installAtsButton.Text = "Install plugin for \r\nAmerican Truck Simulator";
            this.installAtsButton.UseVisualStyleBackColor = true;
            this.installAtsButton.Click += new System.EventHandler(this.installAtsButton_Click);
            // 
            // Koenvh
            // 
            this.Koenvh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Koenvh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Koenvh.Image = global::ETS2_Local_Radio_server.Properties.Resources.Koenvh_fat_text_smaller;
            this.Koenvh.Location = new System.Drawing.Point(140, 589);
            this.Koenvh.Name = "Koenvh";
            this.Koenvh.Size = new System.Drawing.Size(156, 50);
            this.Koenvh.TabIndex = 6;
            this.Koenvh.TabStop = false;
            this.Koenvh.Click += new System.EventHandler(this.Koenvh_Click);
            // 
            // groupController
            // 
            this.groupController.Controls.Add(this.comboController);
            this.groupController.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupController.Location = new System.Drawing.Point(12, 430);
            this.groupController.Name = "groupController";
            this.groupController.Size = new System.Drawing.Size(413, 56);
            this.groupController.TabIndex = 10;
            this.groupController.TabStop = false;
            this.groupController.Text = "Controller";
            // 
            // comboController
            // 
            this.comboController.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboController.FormattingEnabled = true;
            this.comboController.Location = new System.Drawing.Point(10, 22);
            this.comboController.Name = "comboController";
            this.comboController.Size = new System.Drawing.Size(393, 21);
            this.comboController.TabIndex = 11;
            this.comboController.SelectedIndexChanged += new System.EventHandler(this.comboController_SelectedIndexChanged);
            // 
            // removePluginButton
            // 
            this.removePluginButton.AutoSize = true;
            this.removePluginButton.Location = new System.Drawing.Point(10, 72);
            this.removePluginButton.Name = "removePluginButton";
            this.removePluginButton.Size = new System.Drawing.Size(84, 13);
            this.removePluginButton.TabIndex = 2;
            this.removePluginButton.TabStop = true;
            this.removePluginButton.Text = "Remove plugin";
            this.removePluginButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.removePluginButton_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 649);
            this.Controls.Add(this.groupController);
            this.Controls.Add(this.groupInstall);
            this.Controls.Add(this.comboLang);
            this.Controls.Add(this.Koenvh);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.groupSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "ETS2 Local Radio server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            this.groupInfo.ResumeLayout(false);
            this.groupInstall.ResumeLayout(false);
            this.groupInstall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Koenvh)).EndInit();
            this.groupController.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer keyTimeout;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nextKeyTextBox;
        private System.Windows.Forms.TextBox previousKeyTextBox;
        private System.Windows.Forms.TextBox stopKeyTextBox;
        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.Label previousKeyLabel;
        private System.Windows.Forms.Label stopKeyLabel;
        private System.Windows.Forms.Label nextKeyLabel;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.LinkLabel URLLabel;
        private System.Windows.Forms.Label volumeDownKeyLabel;
        private System.Windows.Forms.Label volumeUpKeyLabel;
        private System.Windows.Forms.TextBox volumeDownKeyTextBox;
        private System.Windows.Forms.TextBox volumeUpKeyTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusInfo;
        private System.Windows.Forms.Label coordinatesInfo;
        private System.Windows.Forms.PictureBox Koenvh;
        private System.Windows.Forms.Label URLInfo;
        private System.Windows.Forms.ComboBox comboIP;
        private System.Windows.Forms.ComboBox comboLang;
        private System.Windows.Forms.Label makeFavouriteKeyLabel;
        private System.Windows.Forms.TextBox makeFavouriteKeyTextbox;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Timer joystickTimer;
        private System.Windows.Forms.Label buttonLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox makeFavouriteButtonTextbox;
        private System.Windows.Forms.TextBox volumeDownButtonTextBox;
        private System.Windows.Forms.TextBox volumeUpButtonTextBox;
        private System.Windows.Forms.TextBox stopButtonTextBox;
        private System.Windows.Forms.TextBox previousButtonTextBox;
        private System.Windows.Forms.TextBox nextButtonTextBox;
        private System.Windows.Forms.Timer currentGameTimer;
        private System.Windows.Forms.Label gameInfo;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.GroupBox groupInstall;
        private System.Windows.Forms.Button installEts2Button;
        private System.Windows.Forms.Button installAtsButton;
        private System.Windows.Forms.GroupBox groupController;
        private System.Windows.Forms.ComboBox comboController;
        private System.Windows.Forms.TextBox goToFavouriteButtonTextbox;
        private System.Windows.Forms.Label goToFavouriteKeyLabel;
        private System.Windows.Forms.TextBox goToFavouriteKeyTextbox;
        private System.Windows.Forms.LinkLabel removePluginButton;
    }
}