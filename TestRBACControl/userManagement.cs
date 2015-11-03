using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using nKnight.RBAC.SecurityLayer;
using System.Data.Odbc;
using nKnight.RBAC;
using nKnight.RBACD.DataLayer;

namespace TestRBACControl
{
    public partial class userManagement : Form
    {
        private static string conStr = "DRIVER={MySQL ODBC 5.1 Driver};SERVER=127.0.0.1;PORT=3306;DATABASE=RBAC;USER=root;PASSWORD=jandk4014;OPTION=3";
        private static DataLayer dbl = null;
        
        public userManagement()
        {
            InitializeComponent();
            IDbConnection con = (IDbConnection)new OdbcConnection(conStr);
            con.Open();

            dbl = new DataLayer(con, DataLayer.DatabaseType.MySql);
            bool d = SecurityPrincipal.InitSecuritySystem(dbl, "Admin", "Admin");
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateUser frmCrtUsr = new frmCreateUser(dbl); //Create frmCreateUser object and send a datalayer object
                frmCrtUsr.Show();
            }
            catch (Exception)
            {   
                throw;
            }
        }

        private void roleCreation_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateSecurityGroups frmCrtSecuGrou = new frmCreateSecurityGroups(dbl); //Create an object and send a datalayer object in the constructor.
                frmCrtSecuGrou.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void userRoleMapping_Click(object sender, EventArgs e)
        {
            try
            {
                frmAssignsSecurityGroup frmAssSecuGrou = new frmAssignsSecurityGroup(dbl); //Create an object and send a datalayer object in the constructor.
                frmAssSecuGrou.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void resourcesUsed_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.ExecutablePath;//Executable path
                frmResources frmResUsed = new frmResources(dbl, path); //Create an object and send a datalayer object in the constructor.
                frmResUsed.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void roleResourceMapping_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.ExecutablePath;//Executable path
                frmResourceRoleMapping frmResRoleMap = new frmResourceRoleMapping(dbl, path); //Create an object and send a datalayer object in the constructor.
                frmResRoleMap.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
