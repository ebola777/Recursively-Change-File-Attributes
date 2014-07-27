namespace RecursiveChangeFileAttrib.Storage
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    using Newtonsoft.Json;

    using RecursiveChangeFileAttrib.Utilities;

    public class SettingsManager<TSettings>
        where TSettings : new()
    {
        #region Constants

        private const string FILE_SETTINGS = @"settings.json";

        #endregion

        #region Fields

        private readonly string _path;

        #endregion

        #region Constructors and Destructors

        public SettingsManager()
        {
            string dirAsm = FileSystemHelper.GetAssemblyDirectory();

            this._path = Path.Combine(dirAsm, FILE_SETTINGS);
        }

        #endregion

        #region Public Properties

        public TSettings App { get; set; }

        #endregion

        #region Public Methods and Operators

        public void Read()
        {
            if (File.Exists(this._path))
            {
                try
                {
                    this.App = Json<TSettings>.Read(this._path);
                }
                catch (Exception)
                {
                    this.App = new TSettings();
                }
            }
            else
            {
                this.App = new TSettings();
            }
        }

        public void Save()
        {
            var serializer = new JsonSerializer { Formatting = Formatting.Indented };

            try
            {
                Json<TSettings>.Write(this._path, this.App, serializer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}