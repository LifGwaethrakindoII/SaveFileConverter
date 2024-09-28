using System.Text;

namespace SaveFileConverter
{
    [Serializable]
    public struct Settings
    {
        public string sourceFileExtension;
        public string targetFileExtension;
        public string filePath;

        public static bool operator ==(Settings a, Settings b)
        {
            return  a.sourceFileExtension == b.sourceFileExtension
                    && a.targetFileExtension == b.targetFileExtension
                    && a.filePath == b.filePath;
        }

        public static bool operator !=(Settings a, Settings b)
        {
            return  a.sourceFileExtension != b.sourceFileExtension
                    || a.targetFileExtension != b.targetFileExtension
                    || a.filePath != b.filePath;
        }

        public override bool Equals(object obj)
        {
            return (obj is Settings other) ? this == other : false; 
        }

        public override int GetHashCode()
        {
            // Choose a prime number (like 397 or 31) to minimize collisions
            int hash = 17;

            // Multiply the current hash by a prime number and add the field's hash code
            hash = hash * 31 + (sourceFileExtension?.GetHashCode() ?? 0);
            hash = hash * 31 + (targetFileExtension?.GetHashCode() ?? 0);
            hash = hash * 31 + (filePath?.GetHashCode() ?? 0);

            return hash;
        }

        public static Settings Default()
        {
            Settings settings = new Settings();

            settings.sourceFileExtension = SaveFileConverter.EXTENSIONS[0];
            settings.targetFileExtension = SaveFileConverter.EXTENSIONS[1];
            settings.filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            return settings;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(", Source: ");
            builder.Append(sourceFileExtension);
            builder.Append("{ Target: ");
            builder.Append(targetFileExtension);
            builder.Append(", Path: ");
            builder.Append(filePath);
            builder.Append(" }");

            return builder.ToString();
        }
    }
}
