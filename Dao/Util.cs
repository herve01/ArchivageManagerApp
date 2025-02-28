

using static ArchiveManagerApp.Model.Helper.Util;

namespace ArchiveManagerApp.Dao.AppUtil
{
    public class Util
    {
        public static ExtensionType ToExtensionType(string extension)
        {
            switch (extension)
            {
                case "PDF":
                    return ExtensionType.PDF;
                case "DOC":
                    return ExtensionType.DOC;
                case "IMAGE":
                    return ExtensionType.IMAGE;

                default:
                    return ExtensionType.PDF;
            }
        }

        public static int ToIndexImageType(string extension)
        {
            switch (extension)
            {
                case "PDF":
                    return 0;
                case "DOC":
                    return 1;
                case "IMAGE":
                    return 2;

                default:
                    return 0;
            }
        }

        public ExtensionType GetExtensionType(string extension)
        {
            switch (extension)
            {
                case ".pdf":
                    return ExtensionType.PDF;
                case ".docx":
                case ".doc":
                    return ExtensionType.DOC;
                case ".png":
                case ".jpg":
                    return ExtensionType.IMAGE;
            }
            return ExtensionType.PDF;
        }

        public int GetIndexOfExtensionImage(string extension)
        {
            switch (extension)
            {
                case ".pdf":
                    return 0;
                case ".docx":
                case ".doc":
                    return 1;
                case ".png":
                case ".jpg":
                    return 2;
            }
            return -1;
        }
    }
}
