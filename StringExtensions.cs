namespace Sample
{
    public static class StringExtensions
    {
        public static string ToRelativePath(this string path, string basePath)
        {
            if (path == null || basePath == null)
            {
                return path;
            }

            return path.Replace(basePath + "\\", "");
            
        }
    }
}
