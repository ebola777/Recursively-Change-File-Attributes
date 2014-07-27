namespace RecursiveChangeFileAttrib.Utilities
{
    using System.IO;
    using System.Reflection;

    public static class FileSystemHelper
    {
        #region Public Methods and Operators

        public static void EnsurePathExists(string path)
        {
            DirectoryInfo dirInfo = Directory.GetParent(path);

            if (!dirInfo.Exists)
            {
                Directory.CreateDirectory(dirInfo.FullName);
            }
        }

        public static string GetAssemblyDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        #endregion
    }
}