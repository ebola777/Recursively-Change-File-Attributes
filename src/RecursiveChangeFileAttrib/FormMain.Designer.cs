namespace RecursiveChangeFileAttrib
{
    partial class FormMain
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpControl = new System.Windows.Forms.TableLayoutPanel();
            this.chkShowRelativePath = new System.Windows.Forms.CheckBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.chkIgnoreProcessedFiles = new System.Windows.Forms.CheckBox();
            this.tlpPattern = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipPatterns = new System.Windows.Forms.Label();
            this.txtPatterns = new System.Windows.Forms.TextBox();
            this.tlpDir = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipDir = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.btnBrowseDir = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.cmsListFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiListFilesCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListFilesCopyNoExt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListFilesCopyFullPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListFilesSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiListFilesCopyAllFullPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpFilters = new System.Windows.Forms.TableLayoutPanel();
            this.txtFilters = new System.Windows.Forms.TextBox();
            this.tlpFiltersInverse = new System.Windows.Forms.TableLayoutPanel();
            this.chkFiltersWhitelist = new System.Windows.Forms.CheckBox();
            this.chkEnabledFilters = new System.Windows.Forms.CheckBox();
            this.lblTipFilters = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tsslProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerFlashListFiles = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpControl.SuspendLayout();
            this.tlpPattern.SuspendLayout();
            this.tlpDir.SuspendLayout();
            this.cmsListFiles.SuspendLayout();
            this.tlpFilters.SuspendLayout();
            this.tlpFiltersInverse.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpControl, 0, 3);
            this.tlpMain.Controls.Add(this.tlpPattern, 0, 1);
            this.tlpMain.Controls.Add(this.tlpDir, 0, 0);
            this.tlpMain.Controls.Add(this.lstFiles, 0, 4);
            this.tlpMain.Controls.Add(this.tlpFilters, 0, 2);
            this.tlpMain.Location = new System.Drawing.Point(12, 12);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(9);
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(478, 276);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpControl
            // 
            this.tlpControl.AutoSize = true;
            this.tlpControl.ColumnCount = 4;
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControl.Controls.Add(this.chkShowRelativePath, 3, 0);
            this.tlpControl.Controls.Add(this.btnExecute, 1, 0);
            this.tlpControl.Controls.Add(this.btnPreview, 0, 0);
            this.tlpControl.Controls.Add(this.chkIgnoreProcessedFiles, 2, 0);
            this.tlpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControl.Location = new System.Drawing.Point(12, 171);
            this.tlpControl.Name = "tlpControl";
            this.tlpControl.RowCount = 1;
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControl.Size = new System.Drawing.Size(454, 29);
            this.tlpControl.TabIndex = 3;
            // 
            // chkShowRelativePath
            // 
            this.chkShowRelativePath.AutoSize = true;
            this.chkShowRelativePath.Location = new System.Drawing.Point(328, 3);
            this.chkShowRelativePath.Name = "chkShowRelativePath";
            this.chkShowRelativePath.Size = new System.Drawing.Size(120, 17);
            this.chkShowRelativePath.TabIndex = 9;
            this.chkShowRelativePath.Text = "Show Relative Path";
            this.chkShowRelativePath.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(96, 3);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 7;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(3, 3);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // chkIgnoreProcessedFiles
            // 
            this.chkIgnoreProcessedFiles.AutoSize = true;
            this.chkIgnoreProcessedFiles.Location = new System.Drawing.Point(189, 3);
            this.chkIgnoreProcessedFiles.Name = "chkIgnoreProcessedFiles";
            this.chkIgnoreProcessedFiles.Size = new System.Drawing.Size(133, 17);
            this.chkIgnoreProcessedFiles.TabIndex = 8;
            this.chkIgnoreProcessedFiles.Text = "Ignore Processed Files";
            this.chkIgnoreProcessedFiles.UseVisualStyleBackColor = true;
            // 
            // tlpPattern
            // 
            this.tlpPattern.AutoSize = true;
            this.tlpPattern.ColumnCount = 2;
            this.tlpPattern.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPattern.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPattern.Controls.Add(this.lblTipPatterns, 0, 0);
            this.tlpPattern.Controls.Add(this.txtPatterns, 1, 0);
            this.tlpPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPattern.Location = new System.Drawing.Point(12, 47);
            this.tlpPattern.Name = "tlpPattern";
            this.tlpPattern.RowCount = 1;
            this.tlpPattern.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPattern.Size = new System.Drawing.Size(454, 26);
            this.tlpPattern.TabIndex = 1;
            // 
            // lblTipPatterns
            // 
            this.lblTipPatterns.AutoSize = true;
            this.lblTipPatterns.Location = new System.Drawing.Point(3, 3);
            this.lblTipPatterns.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblTipPatterns.Name = "lblTipPatterns";
            this.lblTipPatterns.Size = new System.Drawing.Size(49, 13);
            this.lblTipPatterns.TabIndex = 3;
            this.lblTipPatterns.Text = "Patterns:";
            // 
            // txtPatterns
            // 
            this.txtPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatterns.Location = new System.Drawing.Point(58, 3);
            this.txtPatterns.Name = "txtPatterns";
            this.txtPatterns.Size = new System.Drawing.Size(393, 20);
            this.txtPatterns.TabIndex = 2;
            this.txtPatterns.Text = "txtPatterns";
            this.toolTipMain.SetToolTip(this.txtPatterns, "Search Patterns, Use \',\' to Seperate extensions, ex. *.mp3, *.wav");
            // 
            // tlpDir
            // 
            this.tlpDir.AutoSize = true;
            this.tlpDir.ColumnCount = 3;
            this.tlpDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDir.Controls.Add(this.lblTipDir, 0, 0);
            this.tlpDir.Controls.Add(this.txtDir, 1, 0);
            this.tlpDir.Controls.Add(this.btnBrowseDir, 2, 0);
            this.tlpDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDir.Location = new System.Drawing.Point(12, 12);
            this.tlpDir.Name = "tlpDir";
            this.tlpDir.RowCount = 1;
            this.tlpDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDir.Size = new System.Drawing.Size(454, 29);
            this.tlpDir.TabIndex = 0;
            // 
            // lblTipDir
            // 
            this.lblTipDir.AutoSize = true;
            this.lblTipDir.Location = new System.Drawing.Point(3, 3);
            this.lblTipDir.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblTipDir.Name = "lblTipDir";
            this.lblTipDir.Size = new System.Drawing.Size(39, 13);
            this.lblTipDir.TabIndex = 3;
            this.lblTipDir.Text = "Folder:";
            // 
            // txtDir
            // 
            this.txtDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDir.Location = new System.Drawing.Point(48, 3);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(351, 20);
            this.txtDir.TabIndex = 0;
            this.txtDir.Text = "txtDir";
            this.toolTipMain.SetToolTip(this.txtDir, "Search Folder");
            // 
            // btnBrowseDir
            // 
            this.btnBrowseDir.Location = new System.Drawing.Point(405, 3);
            this.btnBrowseDir.Name = "btnBrowseDir";
            this.btnBrowseDir.Size = new System.Drawing.Size(46, 23);
            this.btnBrowseDir.TabIndex = 1;
            this.btnBrowseDir.Text = "...";
            this.toolTipMain.SetToolTip(this.btnBrowseDir, "Browse...");
            this.btnBrowseDir.UseVisualStyleBackColor = true;
            this.btnBrowseDir.Click += new System.EventHandler(this.btnBrowseDir_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.BackColor = System.Drawing.SystemColors.Window;
            this.lstFiles.ContextMenuStrip = this.cmsListFiles;
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 206);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(454, 58);
            this.lstFiles.TabIndex = 10;
            this.toolTipMain.SetToolTip(this.lstFiles, "List of Files in the Folder");
            // 
            // cmsListFiles
            // 
            this.cmsListFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListFilesCopy,
            this.tsmiListFilesCopyNoExt,
            this.tsmiListFilesCopyFullPath,
            this.tsmiListFilesSep1,
            this.tsmiListFilesCopyAllFullPath});
            this.cmsListFiles.Name = "cmsListFiles";
            this.cmsListFiles.Size = new System.Drawing.Size(218, 98);
            // 
            // tsmiListFilesCopy
            // 
            this.tsmiListFilesCopy.Name = "tsmiListFilesCopy";
            this.tsmiListFilesCopy.Size = new System.Drawing.Size(217, 22);
            this.tsmiListFilesCopy.Text = "Copy Name";
            this.tsmiListFilesCopy.Click += new System.EventHandler(this.tsmiListFilesCopy_Click);
            // 
            // tsmiListFilesCopyNoExt
            // 
            this.tsmiListFilesCopyNoExt.Name = "tsmiListFilesCopyNoExt";
            this.tsmiListFilesCopyNoExt.Size = new System.Drawing.Size(217, 22);
            this.tsmiListFilesCopyNoExt.Text = "Copy Name (No Extension)";
            this.tsmiListFilesCopyNoExt.Click += new System.EventHandler(this.tsmiListFilesCopyNoExt_Click);
            // 
            // tsmiListFilesCopyFullPath
            // 
            this.tsmiListFilesCopyFullPath.Name = "tsmiListFilesCopyFullPath";
            this.tsmiListFilesCopyFullPath.Size = new System.Drawing.Size(217, 22);
            this.tsmiListFilesCopyFullPath.Text = "Copy Full Path";
            this.tsmiListFilesCopyFullPath.Click += new System.EventHandler(this.tsmiListFilesCopyFullPath_Click);
            // 
            // tsmiListFilesSep1
            // 
            this.tsmiListFilesSep1.Name = "tsmiListFilesSep1";
            this.tsmiListFilesSep1.Size = new System.Drawing.Size(214, 6);
            // 
            // tsmiListFilesCopyAllFullPath
            // 
            this.tsmiListFilesCopyAllFullPath.Name = "tsmiListFilesCopyAllFullPath";
            this.tsmiListFilesCopyAllFullPath.Size = new System.Drawing.Size(217, 22);
            this.tsmiListFilesCopyAllFullPath.Text = "Copy All Full Path";
            this.tsmiListFilesCopyAllFullPath.Click += new System.EventHandler(this.tsmiListFilesCopyAllFullPath_Click);
            // 
            // tlpFilters
            // 
            this.tlpFilters.AutoSize = true;
            this.tlpFilters.ColumnCount = 2;
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilters.Controls.Add(this.txtFilters, 1, 0);
            this.tlpFilters.Controls.Add(this.tlpFiltersInverse, 0, 0);
            this.tlpFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilters.Location = new System.Drawing.Point(12, 79);
            this.tlpFilters.Name = "tlpFilters";
            this.tlpFilters.RowCount = 1;
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilters.Size = new System.Drawing.Size(454, 86);
            this.tlpFilters.TabIndex = 2;
            this.tlpFilters.Resize += new System.EventHandler(this.tlpFilters_Resize);
            // 
            // txtFilters
            // 
            this.txtFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilters.Location = new System.Drawing.Point(89, 3);
            this.txtFilters.Multiline = true;
            this.txtFilters.Name = "txtFilters";
            this.txtFilters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFilters.Size = new System.Drawing.Size(362, 80);
            this.txtFilters.TabIndex = 5;
            this.txtFilters.Text = "txtFilters\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n";
            this.toolTipMain.SetToolTip(this.txtFilters, "Any Relative Path Starting with These Texts will be Filtered, Use NewLine to Sepe" +
        "rate Filters, ex. /Old/");
            this.txtFilters.WordWrap = false;
            // 
            // tlpFiltersInverse
            // 
            this.tlpFiltersInverse.AutoSize = true;
            this.tlpFiltersInverse.ColumnCount = 1;
            this.tlpFiltersInverse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltersInverse.Controls.Add(this.chkFiltersWhitelist, 0, 2);
            this.tlpFiltersInverse.Controls.Add(this.chkEnabledFilters, 0, 1);
            this.tlpFiltersInverse.Controls.Add(this.lblTipFilters, 0, 0);
            this.tlpFiltersInverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltersInverse.Location = new System.Drawing.Point(0, 0);
            this.tlpFiltersInverse.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFiltersInverse.Name = "tlpFiltersInverse";
            this.tlpFiltersInverse.RowCount = 3;
            this.tlpFiltersInverse.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFiltersInverse.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFiltersInverse.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFiltersInverse.Size = new System.Drawing.Size(86, 86);
            this.tlpFiltersInverse.TabIndex = 0;
            // 
            // chkFiltersWhitelist
            // 
            this.chkFiltersWhitelist.AutoSize = true;
            this.chkFiltersWhitelist.Location = new System.Drawing.Point(3, 63);
            this.chkFiltersWhitelist.Name = "chkFiltersWhitelist";
            this.chkFiltersWhitelist.Size = new System.Drawing.Size(66, 17);
            this.chkFiltersWhitelist.TabIndex = 4;
            this.chkFiltersWhitelist.Text = "Whitelist";
            this.chkFiltersWhitelist.UseVisualStyleBackColor = true;
            // 
            // chkEnabledFilters
            // 
            this.chkEnabledFilters.AutoSize = true;
            this.chkEnabledFilters.Location = new System.Drawing.Point(3, 34);
            this.chkEnabledFilters.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.chkEnabledFilters.Name = "chkEnabledFilters";
            this.chkEnabledFilters.Size = new System.Drawing.Size(65, 17);
            this.chkEnabledFilters.TabIndex = 3;
            this.chkEnabledFilters.Text = "Enabled";
            this.chkEnabledFilters.UseVisualStyleBackColor = true;
            // 
            // lblTipFilters
            // 
            this.lblTipFilters.AutoSize = true;
            this.lblTipFilters.Location = new System.Drawing.Point(3, 3);
            this.lblTipFilters.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.lblTipFilters.Name = "lblTipFilters";
            this.lblTipFilters.Size = new System.Drawing.Size(80, 13);
            this.lblTipFilters.TabIndex = 5;
            this.lblTipFilters.Text = "Filters (Folders):";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProcess});
            this.statusStripMain.Location = new System.Drawing.Point(0, 340);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(584, 22);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // tsslProcess
            // 
            this.tsslProcess.BackColor = System.Drawing.SystemColors.Control;
            this.tsslProcess.Name = "tsslProcess";
            this.tsslProcess.Size = new System.Drawing.Size(64, 17);
            this.tsslProcess.Text = "tsslProcess";
            // 
            // timerFlashListFiles
            // 
            this.timerFlashListFiles.Tick += new System.EventHandler(this.timerFlashListFiles_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.statusStripMain);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.Text = "Change Modified Date to Creation Date";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpControl.ResumeLayout(false);
            this.tlpControl.PerformLayout();
            this.tlpPattern.ResumeLayout(false);
            this.tlpPattern.PerformLayout();
            this.tlpDir.ResumeLayout(false);
            this.tlpDir.PerformLayout();
            this.cmsListFiles.ResumeLayout(false);
            this.tlpFilters.ResumeLayout(false);
            this.tlpFilters.PerformLayout();
            this.tlpFiltersInverse.ResumeLayout(false);
            this.tlpFiltersInverse.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblTipDir;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.TableLayoutPanel tlpDir;
        private System.Windows.Forms.Button btnBrowseDir;
        private System.Windows.Forms.TableLayoutPanel tlpPattern;
        private System.Windows.Forms.Label lblTipPatterns;
        private System.Windows.Forms.TextBox txtPatterns;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcess;
        private System.Windows.Forms.Timer timerFlashListFiles;
        private System.Windows.Forms.TableLayoutPanel tlpControl;
        private System.Windows.Forms.CheckBox chkShowRelativePath;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox chkIgnoreProcessedFiles;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.TableLayoutPanel tlpFilters;
        private System.Windows.Forms.TableLayoutPanel tlpFiltersInverse;
        private System.Windows.Forms.Label lblTipFilters;
        private System.Windows.Forms.CheckBox chkEnabledFilters;
        private System.Windows.Forms.TextBox txtFilters;
        private System.Windows.Forms.CheckBox chkFiltersWhitelist;
        private System.Windows.Forms.ContextMenuStrip cmsListFiles;
        private System.Windows.Forms.ToolStripMenuItem tsmiListFilesCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiListFilesCopyNoExt;
        private System.Windows.Forms.ToolStripMenuItem tsmiListFilesCopyFullPath;
        private System.Windows.Forms.ToolStripSeparator tsmiListFilesSep1;
        private System.Windows.Forms.ToolStripMenuItem tsmiListFilesCopyAllFullPath;
    }
}

