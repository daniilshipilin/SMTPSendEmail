namespace SMTPSendEmail
{
    partial class MainForm
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
            this.serverLabel = new System.Windows.Forms.Label();
            this.serverHostnameTextBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.credentialsLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.serverConnectionLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.attachFileButton = new System.Windows.Forms.Button();
            this.removeAttachedFileButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileSizeLimitTextBox = new System.Windows.Forms.TextBox();
            this.fileSizeLimitLabel = new System.Windows.Forms.Label();
            this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.attachmentListBox = new System.Windows.Forms.ListBox();
            this.ccLabel = new System.Windows.Forms.Label();
            this.ccTextBox = new System.Windows.Forms.TextBox();
            this.timestampCheckBox = new System.Windows.Forms.CheckBox();
            this.boldButton = new System.Windows.Forms.Button();
            this.removeFormattingButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.textColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.attachmentGroupBox = new System.Windows.Forms.GroupBox();
            this.messageGroupBox = new System.Windows.Forms.GroupBox();
            this.strikeoutButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.htmlBodyCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.showFilePathCheckBox = new System.Windows.Forms.CheckBox();
            this.serverPortTextBox = new System.Windows.Forms.TextBox();
            this.colonLabel = new System.Windows.Forms.Label();
            this.useSslCheckBox = new System.Windows.Forms.CheckBox();
            this.safeExtensionCheckBox = new System.Windows.Forms.CheckBox();
            this.attachmentGroupBox.SuspendLayout();
            this.messageGroupBox.SuspendLayout();
            this.SuspendLayout();
            //
            // serverLabel
            //
            this.serverLabel.Location = new System.Drawing.Point(12, 41);
            this.serverLabel.Margin = new System.Windows.Forms.Padding(3);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(50, 23);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "Server:";
            this.serverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // serverHostnameTextBox
            //
            this.serverHostnameTextBox.Location = new System.Drawing.Point(68, 43);
            this.serverHostnameTextBox.Name = "serverHostnameTextBox";
            this.serverHostnameTextBox.Size = new System.Drawing.Size(107, 20);
            this.serverHostnameTextBox.TabIndex = 1;
            //
            // fromLabel
            //
            this.fromLabel.Location = new System.Drawing.Point(12, 70);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(3);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(50, 23);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From:";
            this.fromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // fromTextBox
            //
            this.fromTextBox.Location = new System.Drawing.Point(68, 72);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(160, 20);
            this.fromTextBox.TabIndex = 3;
            //
            // credentialsLabel
            //
            this.credentialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credentialsLabel.Location = new System.Drawing.Point(246, 12);
            this.credentialsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.credentialsLabel.Name = "credentialsLabel";
            this.credentialsLabel.Size = new System.Drawing.Size(80, 23);
            this.credentialsLabel.TabIndex = 4;
            this.credentialsLabel.Text = "Credentials";
            this.credentialsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // usernameLabel
            //
            this.usernameLabel.Location = new System.Drawing.Point(246, 41);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 23);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // passwordLabel
            //
            this.passwordLabel.Location = new System.Drawing.Point(246, 70);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(3);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 23);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // usernameTextBox
            //
            this.usernameTextBox.Location = new System.Drawing.Point(312, 43);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(160, 20);
            this.usernameTextBox.TabIndex = 7;
            //
            // passwordTextBox
            //
            this.passwordTextBox.Location = new System.Drawing.Point(312, 72);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(160, 20);
            this.passwordTextBox.TabIndex = 8;
            //
            // serverConnectionLabel
            //
            this.serverConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverConnectionLabel.Location = new System.Drawing.Point(12, 12);
            this.serverConnectionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.serverConnectionLabel.Name = "serverConnectionLabel";
            this.serverConnectionLabel.Size = new System.Drawing.Size(150, 23);
            this.serverConnectionLabel.TabIndex = 9;
            this.serverConnectionLabel.Text = "SMTP Server Connection";
            this.serverConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // subjectLabel
            //
            this.subjectLabel.Location = new System.Drawing.Point(12, 156);
            this.subjectLabel.Margin = new System.Windows.Forms.Padding(3);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(50, 23);
            this.subjectLabel.TabIndex = 10;
            this.subjectLabel.Text = "Subject:";
            this.subjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // subjectTextBox
            //
            this.subjectTextBox.Location = new System.Drawing.Point(68, 158);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(160, 20);
            this.subjectTextBox.TabIndex = 6;
            this.subjectTextBox.Text = "Test email";
            //
            // messageLabel
            //
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(6, 19);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(3);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(100, 23);
            this.messageLabel.TabIndex = 12;
            this.messageLabel.Text = "Message Body";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // sendButton
            //
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.sendButton.Location = new System.Drawing.Point(180, 444);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(100, 23);
            this.sendButton.TabIndex = 10;
            this.sendButton.Text = "Send email";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            //
            // toTextBox
            //
            this.toTextBox.Location = new System.Drawing.Point(68, 100);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(160, 20);
            this.toTextBox.TabIndex = 4;
            //
            // toLabel
            //
            this.toLabel.Location = new System.Drawing.Point(12, 98);
            this.toLabel.Margin = new System.Windows.Forms.Padding(3);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(50, 23);
            this.toLabel.TabIndex = 14;
            this.toLabel.Text = "To:";
            this.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // openFileDialog
            //
            this.openFileDialog.Multiselect = true;
            //
            // attachFileButton
            //
            this.attachFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachFileButton.Location = new System.Drawing.Point(6, 19);
            this.attachFileButton.Name = "attachFileButton";
            this.attachFileButton.Size = new System.Drawing.Size(100, 23);
            this.attachFileButton.TabIndex = 0;
            this.attachFileButton.TabStop = false;
            this.attachFileButton.Text = "Attach file(s)";
            this.attachFileButton.UseVisualStyleBackColor = true;
            this.attachFileButton.Click += new System.EventHandler(this.AttachFileButton_Click);
            //
            // removeAttachedFileButton
            //
            this.removeAttachedFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAttachedFileButton.Location = new System.Drawing.Point(6, 52);
            this.removeAttachedFileButton.Name = "removeAttachedFileButton";
            this.removeAttachedFileButton.Size = new System.Drawing.Size(100, 23);
            this.removeAttachedFileButton.TabIndex = 0;
            this.removeAttachedFileButton.TabStop = false;
            this.removeAttachedFileButton.Text = "Remove";
            this.removeAttachedFileButton.UseVisualStyleBackColor = true;
            this.removeAttachedFileButton.Click += new System.EventHandler(this.RemoveAttachedFileButton_Click);
            //
            // statusStrip
            //
            this.statusStrip.Location = new System.Drawing.Point(0, 470);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            //
            // toolStripStatusLabel
            //
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            //
            // fileSizeLimitTextBox
            //
            this.fileSizeLimitTextBox.Location = new System.Drawing.Point(447, 158);
            this.fileSizeLimitTextBox.Name = "fileSizeLimitTextBox";
            this.fileSizeLimitTextBox.Size = new System.Drawing.Size(25, 20);
            this.fileSizeLimitTextBox.TabIndex = 0;
            this.fileSizeLimitTextBox.TabStop = false;
            this.fileSizeLimitTextBox.Text = "10";
            this.fileSizeLimitTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.FileSizeLimitTextBox_Validating);
            //
            // fileSizeLimitLabel
            //
            this.fileSizeLimitLabel.Location = new System.Drawing.Point(311, 156);
            this.fileSizeLimitLabel.Margin = new System.Windows.Forms.Padding(3);
            this.fileSizeLimitLabel.Name = "fileSizeLimitLabel";
            this.fileSizeLimitLabel.Size = new System.Drawing.Size(130, 23);
            this.fileSizeLimitLabel.TabIndex = 0;
            this.fileSizeLimitLabel.Text = "Total file(s) size limit (MB):";
            this.fileSizeLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // messageRichTextBox
            //
            this.messageRichTextBox.AutoWordSelection = true;
            this.messageRichTextBox.Location = new System.Drawing.Point(6, 48);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.Size = new System.Drawing.Size(448, 108);
            this.messageRichTextBox.TabIndex = 9;
            this.messageRichTextBox.Text = "This message was sent from C# application.";
            this.messageRichTextBox.WordWrap = false;
            this.messageRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.MessageRichTextBox_LinkClicked);
            //
            // attachmentListBox
            //
            this.attachmentListBox.FormattingEnabled = true;
            this.attachmentListBox.HorizontalScrollbar = true;
            this.attachmentListBox.Location = new System.Drawing.Point(112, 19);
            this.attachmentListBox.Name = "attachmentListBox";
            this.attachmentListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.attachmentListBox.Size = new System.Drawing.Size(342, 56);
            this.attachmentListBox.Sorted = true;
            this.attachmentListBox.TabIndex = 0;
            this.attachmentListBox.TabStop = false;
            //
            // ccLabel
            //
            this.ccLabel.Location = new System.Drawing.Point(12, 127);
            this.ccLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(50, 23);
            this.ccLabel.TabIndex = 21;
            this.ccLabel.Text = "CC:";
            this.ccLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // ccTextBox
            //
            this.ccTextBox.Location = new System.Drawing.Point(68, 129);
            this.ccTextBox.Name = "ccTextBox";
            this.ccTextBox.Size = new System.Drawing.Size(160, 20);
            this.ccTextBox.TabIndex = 5;
            //
            // timestampCheckBox
            //
            this.timestampCheckBox.AutoSize = true;
            this.timestampCheckBox.Checked = true;
            this.timestampCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timestampCheckBox.Location = new System.Drawing.Point(395, 448);
            this.timestampCheckBox.Name = "timestampCheckBox";
            this.timestampCheckBox.Size = new System.Drawing.Size(77, 17);
            this.timestampCheckBox.TabIndex = 0;
            this.timestampCheckBox.TabStop = false;
            this.timestampCheckBox.Text = "Timestamp";
            this.timestampCheckBox.UseVisualStyleBackColor = true;
            //
            // boldButton
            //
            this.boldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldButton.Location = new System.Drawing.Point(244, 19);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(30, 23);
            this.boldButton.TabIndex = 0;
            this.boldButton.TabStop = false;
            this.boldButton.Text = "B";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.BoldButton_Click);
            //
            // removeFormattingButton
            //
            this.removeFormattingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeFormattingButton.ForeColor = System.Drawing.Color.DarkRed;
            this.removeFormattingButton.Location = new System.Drawing.Point(424, 19);
            this.removeFormattingButton.Name = "removeFormattingButton";
            this.removeFormattingButton.Size = new System.Drawing.Size(30, 23);
            this.removeFormattingButton.TabIndex = 0;
            this.removeFormattingButton.TabStop = false;
            this.removeFormattingButton.Text = "Tx";
            this.removeFormattingButton.UseVisualStyleBackColor = true;
            this.removeFormattingButton.Click += new System.EventHandler(this.RemoveFormattingButton_Click);
            //
            // italicButton
            //
            this.italicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.italicButton.Location = new System.Drawing.Point(280, 19);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(30, 23);
            this.italicButton.TabIndex = 0;
            this.italicButton.TabStop = false;
            this.italicButton.Text = "I";
            this.italicButton.UseVisualStyleBackColor = true;
            this.italicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            //
            // underlineButton
            //
            this.underlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.underlineButton.Location = new System.Drawing.Point(316, 19);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(30, 23);
            this.underlineButton.TabIndex = 0;
            this.underlineButton.TabStop = false;
            this.underlineButton.Text = "U";
            this.underlineButton.UseVisualStyleBackColor = true;
            this.underlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            //
            // textColorButton
            //
            this.textColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textColorButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.textColorButton.Location = new System.Drawing.Point(388, 19);
            this.textColorButton.Name = "textColorButton";
            this.textColorButton.Size = new System.Drawing.Size(30, 23);
            this.textColorButton.TabIndex = 0;
            this.textColorButton.TabStop = false;
            this.textColorButton.Text = "A";
            this.textColorButton.UseVisualStyleBackColor = true;
            this.textColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            //
            // label1
            //
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Formatting options:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // attachmentGroupBox
            //
            this.attachmentGroupBox.Controls.Add(this.attachmentListBox);
            this.attachmentGroupBox.Controls.Add(this.attachFileButton);
            this.attachmentGroupBox.Controls.Add(this.removeAttachedFileButton);
            this.attachmentGroupBox.Location = new System.Drawing.Point(12, 185);
            this.attachmentGroupBox.Name = "attachmentGroupBox";
            this.attachmentGroupBox.Size = new System.Drawing.Size(460, 89);
            this.attachmentGroupBox.TabIndex = 30;
            this.attachmentGroupBox.TabStop = false;
            this.attachmentGroupBox.Text = "Attachment(s) - none";
            //
            // messageGroupBox
            //
            this.messageGroupBox.Controls.Add(this.strikeoutButton);
            this.messageGroupBox.Controls.Add(this.messageLabel);
            this.messageGroupBox.Controls.Add(this.label1);
            this.messageGroupBox.Controls.Add(this.boldButton);
            this.messageGroupBox.Controls.Add(this.textColorButton);
            this.messageGroupBox.Controls.Add(this.removeFormattingButton);
            this.messageGroupBox.Controls.Add(this.messageRichTextBox);
            this.messageGroupBox.Controls.Add(this.underlineButton);
            this.messageGroupBox.Controls.Add(this.italicButton);
            this.messageGroupBox.Location = new System.Drawing.Point(12, 280);
            this.messageGroupBox.Name = "messageGroupBox";
            this.messageGroupBox.Size = new System.Drawing.Size(460, 162);
            this.messageGroupBox.TabIndex = 31;
            this.messageGroupBox.TabStop = false;
            //
            // strikeoutButton
            //
            this.strikeoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strikeoutButton.Location = new System.Drawing.Point(352, 19);
            this.strikeoutButton.Name = "strikeoutButton";
            this.strikeoutButton.Size = new System.Drawing.Size(30, 23);
            this.strikeoutButton.TabIndex = 0;
            this.strikeoutButton.TabStop = false;
            this.strikeoutButton.Text = "S";
            this.strikeoutButton.UseVisualStyleBackColor = true;
            this.strikeoutButton.Click += new System.EventHandler(this.StrikeoutButton_Click);
            //
            // colorDialog
            //
            this.colorDialog.AnyColor = true;
            //
            // htmlBodyCheckBox
            //
            this.htmlBodyCheckBox.AutoSize = true;
            this.htmlBodyCheckBox.Checked = true;
            this.htmlBodyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.htmlBodyCheckBox.Location = new System.Drawing.Point(307, 448);
            this.htmlBodyCheckBox.Name = "htmlBodyCheckBox";
            this.htmlBodyCheckBox.Size = new System.Drawing.Size(82, 17);
            this.htmlBodyCheckBox.TabIndex = 0;
            this.htmlBodyCheckBox.TabStop = false;
            this.htmlBodyCheckBox.Text = "HTML body";
            this.htmlBodyCheckBox.UseVisualStyleBackColor = true;
            //
            // showFilePathCheckBox
            //
            this.showFilePathCheckBox.AutoSize = true;
            this.showFilePathCheckBox.Location = new System.Drawing.Point(379, 131);
            this.showFilePathCheckBox.Name = "showFilePathCheckBox";
            this.showFilePathCheckBox.Size = new System.Drawing.Size(93, 17);
            this.showFilePathCheckBox.TabIndex = 32;
            this.showFilePathCheckBox.TabStop = false;
            this.showFilePathCheckBox.Text = "Show file path";
            this.showFilePathCheckBox.UseVisualStyleBackColor = true;
            this.showFilePathCheckBox.CheckedChanged += new System.EventHandler(this.ShowFilePathCheckBox_CheckedChanged);
            //
            // serverPortTextBox
            //
            this.serverPortTextBox.Location = new System.Drawing.Point(198, 43);
            this.serverPortTextBox.Name = "serverPortTextBox";
            this.serverPortTextBox.Size = new System.Drawing.Size(30, 20);
            this.serverPortTextBox.TabIndex = 2;
            //
            // colonLabel
            //
            this.colonLabel.AutoSize = true;
            this.colonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colonLabel.Location = new System.Drawing.Point(181, 46);
            this.colonLabel.Margin = new System.Windows.Forms.Padding(3);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(11, 13);
            this.colonLabel.TabIndex = 34;
            this.colonLabel.Text = ":";
            this.colonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // useSslCheckBox
            //
            this.useSslCheckBox.AutoSize = true;
            this.useSslCheckBox.Checked = true;
            this.useSslCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useSslCheckBox.Location = new System.Drawing.Point(237, 160);
            this.useSslCheckBox.Name = "useSslCheckBox";
            this.useSslCheckBox.Size = new System.Drawing.Size(68, 17);
            this.useSslCheckBox.TabIndex = 35;
            this.useSslCheckBox.TabStop = false;
            this.useSslCheckBox.Text = "Use SSL";
            this.useSslCheckBox.UseVisualStyleBackColor = true;
            //
            // safeExtensionCheckBox
            //
            this.safeExtensionCheckBox.AutoSize = true;
            this.safeExtensionCheckBox.Location = new System.Drawing.Point(276, 131);
            this.safeExtensionCheckBox.Name = "safeExtensionCheckBox";
            this.safeExtensionCheckBox.Size = new System.Drawing.Size(97, 17);
            this.safeExtensionCheckBox.TabIndex = 36;
            this.safeExtensionCheckBox.TabStop = false;
            this.safeExtensionCheckBox.Text = "Safe Extension";
            this.safeExtensionCheckBox.UseVisualStyleBackColor = true;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 492);
            this.Controls.Add(this.safeExtensionCheckBox);
            this.Controls.Add(this.useSslCheckBox);
            this.Controls.Add(this.colonLabel);
            this.Controls.Add(this.serverPortTextBox);
            this.Controls.Add(this.showFilePathCheckBox);
            this.Controls.Add(this.htmlBodyCheckBox);
            this.Controls.Add(this.messageGroupBox);
            this.Controls.Add(this.attachmentGroupBox);
            this.Controls.Add(this.timestampCheckBox);
            this.Controls.Add(this.ccTextBox);
            this.Controls.Add(this.ccLabel);
            this.Controls.Add(this.fileSizeLimitLabel);
            this.Controls.Add(this.fileSizeLimitTextBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.serverConnectionLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.credentialsLabel);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.serverHostnameTextBox);
            this.Controls.Add(this.serverLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP Send Email";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.attachmentGroupBox.ResumeLayout(false);
            this.messageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox serverHostnameTextBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label credentialsLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label serverConnectionLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button attachFileButton;
        private System.Windows.Forms.Button removeAttachedFileButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox fileSizeLimitTextBox;
        private System.Windows.Forms.Label fileSizeLimitLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.RichTextBox messageRichTextBox;
        private System.Windows.Forms.ListBox attachmentListBox;
        private System.Windows.Forms.Label ccLabel;
        private System.Windows.Forms.TextBox ccTextBox;
        private System.Windows.Forms.CheckBox timestampCheckBox;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button removeFormattingButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.Button textColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox attachmentGroupBox;
        private System.Windows.Forms.GroupBox messageGroupBox;
        private System.Windows.Forms.Button strikeoutButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox htmlBodyCheckBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox showFilePathCheckBox;
        private System.Windows.Forms.TextBox serverPortTextBox;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.CheckBox useSslCheckBox;
        private System.Windows.Forms.CheckBox safeExtensionCheckBox;
    }
}

