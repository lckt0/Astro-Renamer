
namespace Astro_Renamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.originalStrBox = new System.Windows.Forms.TextBox();
            this.renamedStrBox = new System.Windows.Forms.MaskedTextBox();
            this.originalStrLabel = new System.Windows.Forms.Label();
            this.renamedStrLabel = new System.Windows.Forms.Label();
            this.groupValues = new System.Windows.Forms.GroupBox();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.rnResources = new System.Windows.Forms.CheckBox();
            this.rnAsmblyInfo = new System.Windows.Forms.CheckBox();
            this.allBox = new System.Windows.Forms.CheckBox();
            this.rnEventdef = new System.Windows.Forms.CheckBox();
            this.rnField = new System.Windows.Forms.CheckBox();
            this.rnProperty = new System.Windows.Forms.CheckBox();
            this.rnFile = new System.Windows.Forms.CheckBox();
            this.rnMdule = new System.Windows.Forms.CheckBox();
            this.rnAsmbly = new System.Windows.Forms.CheckBox();
            this.rnMethod = new System.Windows.Forms.CheckBox();
            this.rnClass = new System.Windows.Forms.CheckBox();
            this.rnString = new System.Windows.Forms.CheckBox();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.panelGroup = new System.Windows.Forms.GroupBox();
            this.fileLocationLabel = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.fileLocationBox = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelProgress = new System.Windows.Forms.GroupBox();
            this.logsLabel = new System.Windows.Forms.Label();
            this.processProgress = new System.Windows.Forms.ProgressBar();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupValues.SuspendLayout();
            this.groupOptions.SuspendLayout();
            this.panelGroup.SuspendLayout();
            this.panelProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // originalStrBox
            // 
            this.originalStrBox.Location = new System.Drawing.Point(8, 49);
            this.originalStrBox.Margin = new System.Windows.Forms.Padding(4);
            this.originalStrBox.Name = "originalStrBox";
            this.originalStrBox.Size = new System.Drawing.Size(329, 22);
            this.originalStrBox.TabIndex = 20;
            // 
            // renamedStrBox
            // 
            this.renamedStrBox.Location = new System.Drawing.Point(8, 101);
            this.renamedStrBox.Margin = new System.Windows.Forms.Padding(4);
            this.renamedStrBox.Name = "renamedStrBox";
            this.renamedStrBox.Size = new System.Drawing.Size(329, 22);
            this.renamedStrBox.TabIndex = 7;
            // 
            // originalStrLabel
            // 
            this.originalStrLabel.AutoSize = true;
            this.originalStrLabel.Location = new System.Drawing.Point(4, 30);
            this.originalStrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originalStrLabel.Name = "originalStrLabel";
            this.originalStrLabel.Size = new System.Drawing.Size(91, 16);
            this.originalStrLabel.TabIndex = 2;
            this.originalStrLabel.Text = "Original Value";
            // 
            // renamedStrLabel
            // 
            this.renamedStrLabel.AutoSize = true;
            this.renamedStrLabel.Location = new System.Drawing.Point(4, 81);
            this.renamedStrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.renamedStrLabel.Name = "renamedStrLabel";
            this.renamedStrLabel.Size = new System.Drawing.Size(105, 16);
            this.renamedStrLabel.TabIndex = 3;
            this.renamedStrLabel.Text = "Renamed Value";
            // 
            // groupValues
            // 
            this.groupValues.Controls.Add(this.originalStrLabel);
            this.groupValues.Controls.Add(this.renamedStrLabel);
            this.groupValues.Controls.Add(this.originalStrBox);
            this.groupValues.Controls.Add(this.renamedStrBox);
            this.groupValues.Location = new System.Drawing.Point(16, 15);
            this.groupValues.Margin = new System.Windows.Forms.Padding(4);
            this.groupValues.Name = "groupValues";
            this.groupValues.Padding = new System.Windows.Forms.Padding(4);
            this.groupValues.Size = new System.Drawing.Size(347, 151);
            this.groupValues.TabIndex = 4;
            this.groupValues.TabStop = false;
            this.groupValues.Text = "Values";
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.rnResources);
            this.groupOptions.Controls.Add(this.rnAsmblyInfo);
            this.groupOptions.Controls.Add(this.allBox);
            this.groupOptions.Controls.Add(this.rnEventdef);
            this.groupOptions.Controls.Add(this.rnField);
            this.groupOptions.Controls.Add(this.rnProperty);
            this.groupOptions.Controls.Add(this.rnFile);
            this.groupOptions.Controls.Add(this.rnMdule);
            this.groupOptions.Controls.Add(this.rnAsmbly);
            this.groupOptions.Controls.Add(this.rnMethod);
            this.groupOptions.Controls.Add(this.rnClass);
            this.groupOptions.Controls.Add(this.rnString);
            this.groupOptions.Location = new System.Drawing.Point(16, 174);
            this.groupOptions.Margin = new System.Windows.Forms.Padding(4);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Padding = new System.Windows.Forms.Padding(4);
            this.groupOptions.Size = new System.Drawing.Size(208, 276);
            this.groupOptions.TabIndex = 5;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Options";
            // 
            // rnResources
            // 
            this.rnResources.AutoSize = true;
            this.rnResources.Checked = true;
            this.rnResources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnResources.Location = new System.Drawing.Point(8, 241);
            this.rnResources.Margin = new System.Windows.Forms.Padding(4);
            this.rnResources.Name = "rnResources";
            this.rnResources.Size = new System.Drawing.Size(150, 20);
            this.rnResources.TabIndex = 11;
            this.rnResources.Text = "Rename Resources";
            this.rnResources.UseVisualStyleBackColor = true;
            // 
            // rnAsmblyInfo
            // 
            this.rnAsmblyInfo.AutoSize = true;
            this.rnAsmblyInfo.Checked = true;
            this.rnAsmblyInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnAsmblyInfo.Location = new System.Drawing.Point(8, 220);
            this.rnAsmblyInfo.Margin = new System.Windows.Forms.Padding(4);
            this.rnAsmblyInfo.Name = "rnAsmblyInfo";
            this.rnAsmblyInfo.Size = new System.Drawing.Size(168, 20);
            this.rnAsmblyInfo.TabIndex = 10;
            this.rnAsmblyInfo.Text = "Rename Assembly Info";
            this.rnAsmblyInfo.UseVisualStyleBackColor = true;
            // 
            // allBox
            // 
            this.allBox.AutoSize = true;
            this.allBox.Checked = true;
            this.allBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.allBox.Location = new System.Drawing.Point(149, -1);
            this.allBox.Margin = new System.Windows.Forms.Padding(4);
            this.allBox.Name = "allBox";
            this.allBox.Size = new System.Drawing.Size(44, 20);
            this.allBox.TabIndex = 9;
            this.allBox.Text = "All";
            this.allBox.UseVisualStyleBackColor = true;
            this.allBox.Click += new System.EventHandler(this.allBox_Click);
            // 
            // rnEventdef
            // 
            this.rnEventdef.AutoSize = true;
            this.rnEventdef.Checked = true;
            this.rnEventdef.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnEventdef.Location = new System.Drawing.Point(8, 137);
            this.rnEventdef.Margin = new System.Windows.Forms.Padding(4);
            this.rnEventdef.Name = "rnEventdef";
            this.rnEventdef.Size = new System.Drawing.Size(125, 20);
            this.rnEventdef.TabIndex = 8;
            this.rnEventdef.Text = "Rename Events";
            this.rnEventdef.UseVisualStyleBackColor = true;
            // 
            // rnField
            // 
            this.rnField.AutoSize = true;
            this.rnField.Checked = true;
            this.rnField.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnField.Location = new System.Drawing.Point(8, 116);
            this.rnField.Margin = new System.Windows.Forms.Padding(4);
            this.rnField.Name = "rnField";
            this.rnField.Size = new System.Drawing.Size(121, 20);
            this.rnField.TabIndex = 7;
            this.rnField.Text = "Rename Fields";
            this.rnField.UseVisualStyleBackColor = true;
            // 
            // rnProperty
            // 
            this.rnProperty.AutoSize = true;
            this.rnProperty.Checked = true;
            this.rnProperty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnProperty.Location = new System.Drawing.Point(8, 95);
            this.rnProperty.Margin = new System.Windows.Forms.Padding(4);
            this.rnProperty.Name = "rnProperty";
            this.rnProperty.Size = new System.Drawing.Size(146, 20);
            this.rnProperty.TabIndex = 6;
            this.rnProperty.Text = "Rename Properties";
            this.rnProperty.UseVisualStyleBackColor = true;
            // 
            // rnFile
            // 
            this.rnFile.AutoSize = true;
            this.rnFile.Checked = true;
            this.rnFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnFile.Location = new System.Drawing.Point(8, 74);
            this.rnFile.Margin = new System.Windows.Forms.Padding(4);
            this.rnFile.Name = "rnFile";
            this.rnFile.Size = new System.Drawing.Size(146, 20);
            this.rnFile.TabIndex = 5;
            this.rnFile.Text = "Rename File Name";
            this.rnFile.UseVisualStyleBackColor = true;
            // 
            // rnMdule
            // 
            this.rnMdule.AutoSize = true;
            this.rnMdule.Checked = true;
            this.rnMdule.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnMdule.Location = new System.Drawing.Point(8, 158);
            this.rnMdule.Margin = new System.Windows.Forms.Padding(4);
            this.rnMdule.Name = "rnMdule";
            this.rnMdule.Size = new System.Drawing.Size(169, 20);
            this.rnMdule.TabIndex = 4;
            this.rnMdule.Text = "Rename Module Name";
            this.rnMdule.UseVisualStyleBackColor = true;
            // 
            // rnAsmbly
            // 
            this.rnAsmbly.AutoSize = true;
            this.rnAsmbly.Checked = true;
            this.rnAsmbly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnAsmbly.Location = new System.Drawing.Point(8, 53);
            this.rnAsmbly.Margin = new System.Windows.Forms.Padding(4);
            this.rnAsmbly.Name = "rnAsmbly";
            this.rnAsmbly.Size = new System.Drawing.Size(184, 20);
            this.rnAsmbly.TabIndex = 3;
            this.rnAsmbly.Text = "Rename Assembly Name";
            this.rnAsmbly.UseVisualStyleBackColor = true;
            // 
            // rnMethod
            // 
            this.rnMethod.AutoSize = true;
            this.rnMethod.Checked = true;
            this.rnMethod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnMethod.Location = new System.Drawing.Point(8, 178);
            this.rnMethod.Margin = new System.Windows.Forms.Padding(4);
            this.rnMethod.Name = "rnMethod";
            this.rnMethod.Size = new System.Drawing.Size(176, 20);
            this.rnMethod.TabIndex = 2;
            this.rnMethod.Text = "Rename Method Names";
            this.rnMethod.UseVisualStyleBackColor = true;
            // 
            // rnClass
            // 
            this.rnClass.AutoSize = true;
            this.rnClass.Checked = true;
            this.rnClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnClass.Location = new System.Drawing.Point(8, 32);
            this.rnClass.Margin = new System.Windows.Forms.Padding(4);
            this.rnClass.Name = "rnClass";
            this.rnClass.Size = new System.Drawing.Size(165, 20);
            this.rnClass.TabIndex = 1;
            this.rnClass.Text = "Rename Class Names";
            this.rnClass.UseVisualStyleBackColor = true;
            // 
            // rnString
            // 
            this.rnString.AutoSize = true;
            this.rnString.Checked = true;
            this.rnString.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rnString.Location = new System.Drawing.Point(8, 199);
            this.rnString.Margin = new System.Windows.Forms.Padding(4);
            this.rnString.Name = "rnString";
            this.rnString.Size = new System.Drawing.Size(125, 20);
            this.rnString.TabIndex = 0;
            this.rnString.Text = "Rename Strings";
            this.rnString.UseVisualStyleBackColor = true;
            // 
            // creditsLabel
            // 
            this.creditsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(809, 450);
            this.creditsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(128, 16);
            this.creditsLabel.TabIndex = 6;
            this.creditsLabel.Text = "Credits: LockT#2434";
            // 
            // panelGroup
            // 
            this.panelGroup.Controls.Add(this.fileLocationLabel);
            this.panelGroup.Controls.Add(this.btnSelectFile);
            this.panelGroup.Controls.Add(this.fileLocationBox);
            this.panelGroup.Controls.Add(this.btnExit);
            this.panelGroup.Controls.Add(this.btnStart);
            this.panelGroup.Location = new System.Drawing.Point(371, 15);
            this.panelGroup.Margin = new System.Windows.Forms.Padding(4);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Padding = new System.Windows.Forms.Padding(4);
            this.panelGroup.Size = new System.Drawing.Size(580, 151);
            this.panelGroup.TabIndex = 7;
            this.panelGroup.TabStop = false;
            this.panelGroup.Text = "Panel";
            // 
            // fileLocationLabel
            // 
            this.fileLocationLabel.AutoSize = true;
            this.fileLocationLabel.Location = new System.Drawing.Point(4, 42);
            this.fileLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileLocationLabel.Name = "fileLocationLabel";
            this.fileLocationLabel.Size = new System.Drawing.Size(83, 16);
            this.fileLocationLabel.TabIndex = 4;
            this.fileLocationLabel.Text = "File Location";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectFile.Location = new System.Drawing.Point(8, 116);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(51, 28);
            this.btnSelectFile.TabIndex = 11;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // fileLocationBox
            // 
            this.fileLocationBox.AllowDrop = true;
            this.fileLocationBox.Location = new System.Drawing.Point(8, 62);
            this.fileLocationBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileLocationBox.Name = "fileLocationBox";
            this.fileLocationBox.Size = new System.Drawing.Size(563, 22);
            this.fileLocationBox.TabIndex = 4;
            this.fileLocationBox.Text = "Drag and Drop File";
            this.fileLocationBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(453, 116);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(327, 116);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 28);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Rename";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelProgress
            // 
            this.panelProgress.Controls.Add(this.logsLabel);
            this.panelProgress.Controls.Add(this.processProgress);
            this.panelProgress.Controls.Add(this.logListBox);
            this.panelProgress.Location = new System.Drawing.Point(232, 174);
            this.panelProgress.Margin = new System.Windows.Forms.Padding(4);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Padding = new System.Windows.Forms.Padding(4);
            this.panelProgress.Size = new System.Drawing.Size(719, 276);
            this.panelProgress.TabIndex = 8;
            this.panelProgress.TabStop = false;
            this.panelProgress.Text = "Progress";
            // 
            // logsLabel
            // 
            this.logsLabel.AutoSize = true;
            this.logsLabel.Location = new System.Drawing.Point(4, 28);
            this.logsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logsLabel.Name = "logsLabel";
            this.logsLabel.Size = new System.Drawing.Size(37, 16);
            this.logsLabel.TabIndex = 9;
            this.logsLabel.Text = "Logs";
            // 
            // processProgress
            // 
            this.processProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processProgress.Location = new System.Drawing.Point(8, 239);
            this.processProgress.Margin = new System.Windows.Forms.Padding(4);
            this.processProgress.Name = "processProgress";
            this.processProgress.Size = new System.Drawing.Size(703, 28);
            this.processProgress.TabIndex = 14;
            // 
            // logListBox
            // 
            this.logListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 16;
            this.logListBox.Items.AddRange(new object[] {
            "Waiting for logger..."});
            this.logListBox.Location = new System.Drawing.Point(8, 48);
            this.logListBox.Margin = new System.Windows.Forms.Padding(4);
            this.logListBox.Name = "logListBox";
            this.logListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.logListBox.Size = new System.Drawing.Size(701, 180);
            this.logListBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 454);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Note: AsmInfo Don\'t Works";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.groupValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astro Renamer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupValues.ResumeLayout(false);
            this.groupValues.PerformLayout();
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originalStrBox;
        private System.Windows.Forms.MaskedTextBox renamedStrBox;
        private System.Windows.Forms.Label originalStrLabel;
        private System.Windows.Forms.Label renamedStrLabel;
        private System.Windows.Forms.GroupBox groupValues;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.CheckBox rnString;
        private System.Windows.Forms.CheckBox rnClass;
        private System.Windows.Forms.CheckBox rnMethod;
        private System.Windows.Forms.CheckBox rnMdule;
        private System.Windows.Forms.CheckBox rnAsmbly;
        private System.Windows.Forms.CheckBox rnFile;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.GroupBox panelGroup;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox fileLocationBox;
        private System.Windows.Forms.GroupBox panelProgress;
        private System.Windows.Forms.ProgressBar processProgress;
        private System.Windows.Forms.Label fileLocationLabel;
        private System.Windows.Forms.Label logsLabel;
        private System.Windows.Forms.CheckBox rnEventdef;
        private System.Windows.Forms.CheckBox rnField;
        private System.Windows.Forms.CheckBox rnProperty;
        private System.Windows.Forms.CheckBox allBox;
        public System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.CheckBox rnAsmblyInfo;
        private System.Windows.Forms.CheckBox rnResources;
        private System.Windows.Forms.Label label1;
    }
}

