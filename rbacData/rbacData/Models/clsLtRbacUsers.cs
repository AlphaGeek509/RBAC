using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsLyntronDynamic;
using System.Data;
using System.Data.Odbc;

namespace rbacData
{
    class clsLtRbacUsers : clsGenericModel
    {
        clsLyntronDynamic.clsLT_RBAC_USERSModel _rbacUsers;

        public clsLtRbacUsers(string connectionName, string userId = null)
            : base(connectionName, "LT_RBAC_USER", "USER_ID", userId)
        {

        }

        public clsLtRbacUsers(OdbcConnection connection, string userId = null)
             : base(connection, "LT_RBAC_USER", "USER_ID", userId)
        {

        }



        #region Properties
        public string userId{
            get { return Convert.ToString(this._rbacUsers.getFieldValue("USER_ID")); }
            set { this._rbacUsers.setFieldValue("USER_ID", value); }
        }

        public string userName{
            get { return Convert.ToString(this._rbacUsers.getFieldValue("USER_NAME")); }
            set { this._rbacUsers.setFieldValue("USER_NAME", value); }
        }

        public string password{
            get { return Convert.ToString(this._rbacUsers.getFieldValue("PASSWORD")); }
            set { this._rbacUsers.setFieldValue("PASSWORD", value); }
        }

        public string firstName{
            get { return Convert.ToString(this._rbacUsers.getFieldValue("FIRST_NAME")); }
            set { this._rbacUsers.setFieldValue("FIRST_NAME", value); }
        }

        public string lastName{
            get { return Convert.ToString(this._rbacUsers.getFieldValue("LAST_NAME")); }
            set { this._rbacUsers.setFieldValue("LAST_NAME", value); }
        }
        public bool isAuthenticated { get; set; }
        #endregion
    }
}
