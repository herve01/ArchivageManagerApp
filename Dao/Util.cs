

using static RoadTripAgencyApp.Model.Helper.Util;

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
                case "IMAGE":
                    return ExtensionType.IMAGE;

                default:
                    return ExtensionType.PDF;
            }
        }
    }
}
