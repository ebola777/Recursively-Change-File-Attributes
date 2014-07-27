namespace RecursiveChangeFileAttrib
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    using RecursiveChangeFileAttrib.Storage;

    public partial class FormMain : Form
    {
        #region Constants

        private const double _fadingOffset = 0.03;

        #endregion

        #region Fields

        private readonly Color _fadeFromColorError = Color.FromKnownColor(KnownColor.Tomato);

        private readonly Color _fadeFromColorProcessed = Color.FromKnownColor(KnownColor.GreenYellow);

        private readonly Color _fadeToColor = Color.FromKnownColor(KnownColor.Control);

        private readonly SettingsManager<AppSettings> _settingsManager = new SettingsManager<AppSettings>();

        private AppSettings _app;

        private double _fadingColorPercent;

        private RunOptions _lastRunOptions;

        private Color _selectedDstFadeColor;

        private Color _selectedSrcFadeColor;

        #endregion

        #region Constructors and Destructors

        public FormMain()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Enums

        private enum StatusProcess
        {
            Ready,

            Processing,

            Processed,

            Error
        }

        #endregion

        #region Methods

        private static void ChangeAttrib(string path)
        {
            DateTime fileCreatedDate = File.GetCreationTime(path);

            File.SetLastWriteTime(path, fileCreatedDate);
        }

        private static bool CheckIgnore(string path)
        {
            DateTime createdDate = File.GetCreationTime(path);
            DateTime modifiedDate = File.GetLastWriteTime(path);

            return (createdDate != modifiedDate);
        }

        private static Color GetColorInterpolate(Color src, Color dst, double percent)
        {
            var r = (byte)(src.R + (dst.R - src.R) * percent);
            var g = (byte)(src.G + (dst.G - src.G) * percent);
            var b = (byte)(src.B + (dst.B - src.B) * percent);

            return Color.FromArgb(255, r, g, b);
        }

        private static IList<string> GetFileList(string dir, string pattern)
        {
            return
                pattern.Split(',')
                    .Select(filter => filter.Trim())
                    .SelectMany(filter => Directory.GetFiles(dir, filter, SearchOption.AllDirectories))
                    .ToList();
        }

        private static IList<string> GetFilteredFileList(
            IList<string> list,
            string dir,
            string filters,
            bool isEnabledFilters,
            bool isIgnoreProcessed,
            bool isWhitelist)
        {
            string[] arrFilters = null;

            // prepare filters
            if (isEnabledFilters)
            {
                arrFilters = PrepareFilters(dir, filters);
            }

            // ignore processed files
            if (isIgnoreProcessed)
            {
                list = list.Where(CheckIgnore).ToList();
            }

            // filter paths
            if (isEnabledFilters)
            {
                list = list.Where(
                    path =>
                        {
                            if (!isWhitelist)
                            {
                                return arrFilters.All(item => 0 != path.IndexOf(item, StringComparison.Ordinal));
                            }
                            return arrFilters.Any(item => 0 == path.IndexOf(item, StringComparison.Ordinal));
                        }).ToList();
            }

            return list;
        }

        private static string GetPathWithoutLeadingSlash(string path)
        {
            if ("\\" == path.Substring(0, 1))
            {
                path = path.Substring(1);
            }

            return path;
        }

        private static double GetPercent(double p)
        {
            return Math.Pow(p, 5);
        }

        private static string GetRelativePath(string filespec, string folder)
        {
            var pathUri = new Uri(filespec);

            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString(CultureInfo.InvariantCulture)))
            {
                folder += Path.DirectorySeparatorChar;
            }

            var folderUri = new Uri(folder);
            return
                Uri.UnescapeDataString(
                    folderUri.MakeRelativeUri(pathUri)
                        .ToString()
                        .Insert(0, "/")
                        .Replace('/', Path.DirectorySeparatorChar));
        }

        private static IList<string> GetRelativePathFileList(IEnumerable<string> list, string path)
        {
            return list.Select(text => GetRelativePath(text, path)).ToList();
        }

        private static string[] PrepareFilters(string dir, string filters)
        {
            return filters.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Select(
                path =>
                    {
                        path = path.Trim();

                        if ("" != path)
                        {
                            path = path.Replace('/', '\\');
                            path = GetPathWithoutLeadingSlash(path);

                            return Path.Combine(dir, path);
                        }

                        return "";
                    }).Where(path => "" != path).ToArray();
        }

        private static RunResult Run(bool isExecute, RunOptions options)
        {
            IList<string> coll = GetFileList(options.Dir, options.Patterns);
            int countFiltered = coll.Count;

            coll = GetFilteredFileList(
                coll,
                options.Dir,
                options.Filters,
                options.IsEnabledFilters,
                options.IsIgnoreProcessedFiles,
                options.IsWhitelist);

            countFiltered -= coll.Count;

            if (isExecute)
            {
                // change attributes
                foreach (string file in coll)
                {
                    ChangeAttrib(file);
                }
            }

            if (options.IsShowRelativePath)
            {
                coll = GetRelativePathFileList(coll, options.Dir);
            }

            return new RunResult { Result = coll, CountFiltered = countFiltered };
        }

        private void ExecuteOrPreview(bool isExecute)
        {
            RunResult result = null;
            var runOptions = new RunOptions
                                 {
                                     Dir = this.txtDir.Text,
                                     Patterns = this.txtPatterns.Text,
                                     Filters = this.txtFilters.Text,
                                     IsEnabledFilters = this.chkEnabledFilters.Checked,
                                     IsWhitelist = this.chkFiltersWhitelist.Checked,
                                     IsIgnoreProcessedFiles = this.chkIgnoreProcessedFiles.Checked,
                                     IsShowRelativePath = this.chkShowRelativePath.Checked
                                 };

            this.SetStatusProcess(StatusProcess.Processing);

            try
            {
                result = Run(isExecute, runOptions);

                this.SetStatusProcess(
                    StatusProcess.Processed,
                    string.Format("{0} Items. Filtered {1} Items.", result.Result.Count, result.CountFiltered));

                this._lastRunOptions = runOptions;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.SetStatusProcess(StatusProcess.Error);
            }

            this.lstFiles.DataSource = (null != result ? result.Result : null);
            this.lstFiles.SelectedIndex = -1;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SaveSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ReadSettings();
            this.InitControls();
        }

        private void InitControls()
        {
            this.tlpMain.Dock = DockStyle.Fill;

            this.timerFlashListFiles.Interval = 10;

            this.SetStatusProcess(StatusProcess.Ready);
        }

        private void ReadSettings()
        {
            this._settingsManager.Read();
            this._app = this._settingsManager.App;

            MainViewSettings mainView = this._app.MainView;
            DataSettings data = this._app.Data;

            if (null != mainView.PosSize)
            {
                this.Location = mainView.PosSize.Value.Location;
                this.Size = mainView.PosSize.Value.Size;

                // check if the form is out of screen
                if ((this.Top < 0) || (this.Left < 0)
                    || (this.Top + this.Height > Screen.PrimaryScreen.WorkingArea.Height)
                    || (this.Left + this.Width > Screen.PrimaryScreen.WorkingArea.Width))
                {
                    this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                    this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                }
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }

            this.txtDir.Text = data.Dir;
            this.txtPatterns.Text = data.Patterns;
            this.txtFilters.Text = data.Filters;
            this.chkEnabledFilters.Checked = data.IsEnabledFilters;
            this.chkFiltersWhitelist.Checked = data.IsWhitelist;
            this.chkIgnoreProcessedFiles.Checked = data.IsIgnoreProcessedFiles;
            this.chkShowRelativePath.Checked = data.IsShowRelativePath;
        }

        private void SaveSettings()
        {
            this._app.MainView = new MainViewSettings { PosSize = new Rectangle(this.Location, this.Size) };
            this._app.Data = new DataSettings
                                 {
                                     Dir = this.txtDir.Text,
                                     Patterns = this.txtPatterns.Text,
                                     Filters = this.txtFilters.Text,
                                     IsEnabledFilters = this.chkEnabledFilters.Checked,
                                     IsWhitelist = this.chkFiltersWhitelist.Checked,
                                     IsIgnoreProcessedFiles = this.chkIgnoreProcessedFiles.Checked,
                                     IsShowRelativePath = this.chkShowRelativePath.Checked
                                 };

            this._settingsManager.App = this._app;
            this._settingsManager.Save();
        }

        private void SetStatusProcess(StatusProcess status, string text = "")
        {
            switch (status)
            {
                case StatusProcess.Ready:
                    {
                        this.tsslProcess.Text = "Ready";
                    }
                    break;
                case StatusProcess.Processing:
                    {
                        this.tsslProcess.Text = "...";
                    }
                    break;
                case StatusProcess.Processed:
                    {
                        this.tsslProcess.Text = string.Format("Finished. {0}", text);

                        this.StartFadingColor(this._fadeFromColorProcessed);
                    }
                    break;
                case StatusProcess.Error:
                    {
                        this.tsslProcess.Text = string.Format("Error. {0}", text);

                        this.StartFadingColor(this._fadeFromColorError);
                    }
                    break;
            }
        }

        private void StartFadingColor(Color src)
        {
            this._selectedSrcFadeColor = this.tsslProcess.BackColor = src;
            this._selectedDstFadeColor = this._fadeToColor;
            this._fadingColorPercent = 0;
            this.timerFlashListFiles.Start();
        }

        private void btnBrowseDir_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog { SelectedPath = this.txtDir.Text };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtDir.Text = dialog.SelectedPath;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Execute?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.ExecuteOrPreview(true);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.ExecuteOrPreview(false);
        }

        private void timerFlashListFiles_Tick(object sender, EventArgs e)
        {
            if (this._fadingColorPercent >= 1)
            {
                this.tsslProcess.BackColor = this._selectedDstFadeColor;

                this.timerFlashListFiles.Stop();
            }
            else
            {
                this.tsslProcess.BackColor = GetColorInterpolate(
                    this._selectedSrcFadeColor,
                    this._selectedDstFadeColor,
                    GetPercent(this._fadingColorPercent));

                this._fadingColorPercent += _fadingOffset;
            }
        }

        private void tlpFilters_Resize(object sender, EventArgs e)
        {
            this.txtFilters.Width = (int)this.tlpFilters.ColumnStyles[1].Width;
        }

        private void tsmiListFilesCopyAllFullPath_Click(object sender, EventArgs e)
        {
            var strBuilder = new StringBuilder();

            foreach (string item in this.lstFiles.Items)
            {
                strBuilder.AppendLine(
                    (this._lastRunOptions.IsShowRelativePath
                         ? Path.Combine(this._lastRunOptions.Dir, GetPathWithoutLeadingSlash(item))
                         : item));
            }

            if (0 != strBuilder.Length)
            {
                Clipboard.SetText(strBuilder.ToString());
            }
        }

        private void tsmiListFilesCopyFullPath_Click(object sender, EventArgs e)
        {
            object value = this.lstFiles.SelectedValue;

            if (null != value)
            {
                if (null != this._lastRunOptions)
                {
                    string result = (this._lastRunOptions.IsShowRelativePath
                                         ? Path.Combine(
                                             this._lastRunOptions.Dir,
                                             GetPathWithoutLeadingSlash(value.ToString()))
                                         : value.ToString());

                    Clipboard.SetText(result);
                }
            }
        }

        private void tsmiListFilesCopyNoExt_Click(object sender, EventArgs e)
        {
            object value = this.lstFiles.SelectedValue;

            if (null != value)
            {
                Clipboard.SetText(Path.GetFileNameWithoutExtension(value.ToString()));
            }
        }

        private void tsmiListFilesCopy_Click(object sender, EventArgs e)
        {
            object value = this.lstFiles.SelectedValue;

            if (null != value)
            {
                Clipboard.SetText(Path.GetFileName(value.ToString()));
            }
        }

        #endregion

        public class RunOptions
        {
            #region Public Properties

            public string Dir { get; set; }

            public string Filters { get; set; }

            public bool IsEnabledFilters { get; set; }

            public bool IsIgnoreProcessedFiles { get; set; }

            public bool IsShowRelativePath { get; set; }

            public bool IsWhitelist { get; set; }

            public string Patterns { get; set; }

            #endregion
        }

        public class RunResult
        {
            #region Public Properties

            public int CountFiltered { get; set; }

            public IList<string> Result { get; set; }

            #endregion
        }
    }
}