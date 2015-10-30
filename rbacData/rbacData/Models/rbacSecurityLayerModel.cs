using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace rbacData
{
    class rbacSecurityLayerModel : clsLtRbacUsers
    {
        OdbcConnection _connection { get; set; }
        clsLtRbacUsers _user {get; set;}
        

        //public rbacSecurityLayerModel(OdbcConnection connection) {
        //    _connection = connection;
        //}


        /// <summary>
        /// Attempt to authenticate the user and instantiate the clsLtRbacUsers Model as a property
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public void authenticate(OdbcConnection connection, string userId, string password)
        {
            _connection = connection;
            clsLtRbacUsers _rbacUser = new clsLtRbacUsers(_connection);
            List<dynamic> userModel = _rbacUser.getModelsByFieldWhere(typeof(clsLyntronDynamic.clsLT_RBAC_USERSModel), "USER_NAME", userId.ToUpper());

            foreach (clsLyntronDynamic.clsLT_RBAC_USERSModel user in userModel)
            {
                if (user.getFieldValue("PASSWORD") == password)
                {
                    this._user = new clsLtRbacUsers(_connection, user.getFieldValue("USER_ID"));
                    this._user.isAuthenticated = true;
                }
            }
        }
    }
}
