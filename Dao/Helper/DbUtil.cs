using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Dao.Util
{
    public class DbUtil
    {
        public static DbParameter CreateParameter(DbCommand Cmd, string ParameterName,
            DbType Type, object Value, ParameterDirection Direction = ParameterDirection.Input)
        {
            var param = Cmd.CreateParameter();
            param.ParameterName = ParameterName;
            param.DbType = Type;
            param.Value = Value;
            param.Direction = Direction;

            return param;
        }
       
    }
}
