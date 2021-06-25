namespace StampIt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbHotykeyStamp = new System.Windows.Forms.ComboBox();
            this.tbHotkeyStamp = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbHotykeyStart = new System.Windows.Forms.ComboBox();
            this.tbHotkeyStart = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHotkey = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbDirPath = new System.Windows.Forms.TextBox();
            this.btnOpenBrowserDialog = new System.Windows.Forms.Button();
            this.StampIt = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Controls.Add(this.btnSaveSettings);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.MaximumSize = new System.Drawing.Size(354, 337);
            this.groupBox1.MinimumSize = new System.Drawing.Size(354, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.cbHotykeyStamp);
            this.flowLayoutPanel3.Controls.Add(this.tbHotkeyStamp);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(105, 208);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(243, 28);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // cbHotykeyStamp
            // 
            this.cbHotykeyStamp.FormattingEnabled = true;
            this.cbHotykeyStamp.Location = new System.Drawing.Point(3, 3);
            this.cbHotykeyStamp.Name = "cbHotykeyStamp";
            this.cbHotykeyStamp.Size = new System.Drawing.Size(94, 21);
            this.cbHotykeyStamp.TabIndex = 16;
            this.cbHotykeyStamp.Tag = "";
            this.cbHotykeyStamp.SelectedIndexChanged += new System.EventHandler(this.cbHotykeyStamp_SelectedIndexChanged);
            // 
            // tbHotkeyStamp
            // 
            this.tbHotkeyStamp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbHotkeyStamp.Location = new System.Drawing.Point(103, 3);
            this.tbHotkeyStamp.MaxLength = 1;
            this.tbHotkeyStamp.Name = "tbHotkeyStamp";
            this.tbHotkeyStamp.Size = new System.Drawing.Size(136, 20);
            this.tbHotkeyStamp.TabIndex = 15;
            this.tbHotkeyStamp.TextChanged += new System.EventHandler(this.tbHotkeyStamp_TextChanged);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(269, 308);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cbHotykeyStart);
            this.flowLayoutPanel2.Controls.Add(this.tbHotkeyStart);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(105, 164);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 28);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // cbHotykeyStart
            // 
            this.cbHotykeyStart.FormattingEnabled = true;
            this.cbHotykeyStart.Location = new System.Drawing.Point(3, 3);
            this.cbHotykeyStart.Name = "cbHotykeyStart";
            this.cbHotykeyStart.Size = new System.Drawing.Size(94, 21);
            this.cbHotykeyStart.TabIndex = 16;
            this.cbHotykeyStart.Tag = "";
            this.cbHotykeyStart.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // tbHotkeyStart
            // 
            this.tbHotkeyStart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbHotkeyStart.Location = new System.Drawing.Point(103, 3);
            this.tbHotkeyStart.MaxLength = 1;
            this.tbHotkeyStart.Name = "tbHotkeyStart";
            this.tbHotkeyStart.Size = new System.Drawing.Size(136, 20);
            this.tbHotkeyStart.TabIndex = 15;
            this.tbHotkeyStart.TextChanged += new System.EventHandler(this.tbHotkeyStart_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelHotkey);
            this.panel1.Location = new System.Drawing.Point(6, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 226);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hotkey Stamp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Where to save";
            // 
            // labelHotkey
            // 
            this.labelHotkey.AutoSize = true;
            this.labelHotkey.Location = new System.Drawing.Point(1, 59);
            this.labelHotkey.Name = "labelHotkey";
            this.labelHotkey.Size = new System.Drawing.Size(92, 13);
            this.labelHotkey.TabIndex = 14;
            this.labelHotkey.Text = "Hotkey StartTimer";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbDirPath);
            this.flowLayoutPanel1.Controls.Add(this.btnOpenBrowserDialog);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(105, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tbDirPath
            // 
            this.tbDirPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::StampIt.Properties.Settings.Default, "StoreLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDirPath.Location = new System.Drawing.Point(3, 3);
            this.tbDirPath.Name = "tbDirPath";
            this.tbDirPath.Size = new System.Drawing.Size(155, 20);
            this.tbDirPath.TabIndex = 12;
            this.tbDirPath.Text = global::StampIt.Properties.Settings.Default.StoreLocation;
            this.tbDirPath.TextChanged += new System.EventHandler(this.TbDirPath_TextChanged);
            // 
            // btnOpenBrowserDialog
            // 
            this.btnOpenBrowserDialog.Location = new System.Drawing.Point(164, 3);
            this.btnOpenBrowserDialog.Name = "btnOpenBrowserDialog";
            this.btnOpenBrowserDialog.Size = new System.Drawing.Size(75, 23);
            this.btnOpenBrowserDialog.TabIndex = 11;
            this.btnOpenBrowserDialog.Text = "Open";
            this.btnOpenBrowserDialog.UseVisualStyleBackColor = true;
            this.btnOpenBrowserDialog.Click += new System.EventHandler(this.btnOpenBrowserDialog_Click);
            // 
            // StampIt
            // 
            this.StampIt.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.StampIt.BalloonTipTitle = "Stamp It!";
            this.StampIt.Icon = ((System.Drawing.Icon)(resources.GetObject("StampIt.Icon")));
            this.StampIt.Text = "Stamp It!";
            this.StampIt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stamp It!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHotkey;
        private System.Windows.Forms.TextBox tbDirPath;
        private System.Windows.Forms.Button btnOpenBrowserDialog;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox cbHotykeyStamp;
        private System.Windows.Forms.TextBox tbHotkeyStart;
        private System.Windows.Forms.TextBox tbHotkeyStamp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ComboBox cbHotykeyStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon StampIt;
    }
}

