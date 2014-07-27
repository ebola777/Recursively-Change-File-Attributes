namespace RecursiveChangeFileAttrib.Utilities
{
    using System.IO;

    using Newtonsoft.Json;

    public static class Json<TSettings>
        where TSettings : new()
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Populate settings from file to settings
        /// </summary>
        /// <param name="path">Source</param>
        /// <param name="settings">Destination</param>
        public static void Populate(string path, TSettings settings)
        {
            if (File.Exists(path))
            {
                JsonConvert.PopulateObject(File.ReadAllText(path), settings);
            }
        }

        /// <summary>
        ///     Read settings from file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static TSettings Read(string path)
        {
            var serializer = new JsonSerializer();
            TSettings settings;

            if (File.Exists(path))
            {
                using (StreamReader file = File.OpenText(path))
                {
                    settings = (TSettings)serializer.Deserialize(file, typeof(TSettings));
                }
            }
            else
            {
                settings = new TSettings();
            }

            return settings;
        }

        /// <summary>
        ///     Write settings to file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="settings"></param>
        /// <param name="serializer"></param>
        public static void Write(string path, TSettings settings, JsonSerializer serializer)
        {
            using (StreamWriter file = File.CreateText(path))
            {
                serializer.Serialize(file, settings);
            }
        }

        #endregion
    }
}