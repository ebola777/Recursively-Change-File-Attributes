namespace RecursiveChangeFileAttrib.Storage
{
    using System.Drawing;

    public class AppSettings
    {
        #region Constructors and Destructors

        public AppSettings()
        {
            this.MainView = new MainViewSettings();
            this.Data = new DataSettings();
        }

        #endregion

        #region Public Properties

        public DataSettings Data { get; set; }

        public MainViewSettings MainView { get; set; }

        #endregion
    }

    public class MainViewSettings
    {
        #region Constructors and Destructors

        public MainViewSettings()
        {
            this.PosSize = null;
        }

        #endregion

        #region Public Properties

        public Rectangle? PosSize { get; set; }

        #endregion
    }

    public class DataSettings
    {
        #region Constructors and Destructors

        public DataSettings()
        {
            this.Dir = "";
            this.Patterns = @"*.mp3, *.wma, *.wav";
            this.Filters = @"\$Recycle.Bin\";
            this.IsEnabledFilters = true;
            this.IsWhitelist = false;
            this.IsIgnoreProcessedFiles = true;
            this.IsShowRelativePath = true;
        }

        #endregion

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
}