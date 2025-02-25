using ArchiveManagerApp.Model.App;
using System;
using System.Data;

namespace ArchiveManagerApp.Dao.Helper
{
    public class TableKeyHelper
    {
        public static string GetKey(string tableName, object add = null)
        {
            try
            {
                var key = string.Empty;

                key = AppConfig.CURRENT_USER?.Id ?? 1 + "" + tableName;

                key += Model.Helper.Util.GetMacAddress();
                key += Model.Helper.Util.GetClientIPAddress();

                key += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");         

                if (add != null)
                    key += (int)add;

                return Model.Helper.Util.MD5Hash(key);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return string.Empty;
            }
        }
    }
}
