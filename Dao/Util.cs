

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
    }
}
