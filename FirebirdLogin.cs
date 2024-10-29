using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inifiles;

namespace TestFirebird
{
    public partial class frmLogin : Form
    {
        string connectionString;
  //    "User=SYSDBA;Password=masterkey;Database=C:\\Hanke\\Interbase\\Hankeib.gdb;DataSource=localhost; Port = 3050; Dialect = 3;" +
  //          " Charset = NONE; Role =; Connection lifetime = 15; Pooling = true; MinPoolSize = 0; MaxPoolSize = 50; Packet Size = 8192; ServerType = 0;";
        FbConnection connection;

        public frmLogin()
        {
            InitializeComponent();
 
        }

        private void btnEnde_Click(object sender, EventArgs e)
        {
            Close ();

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            connectionString =  "USER="     + txtbBenutzer.Text + ";"
                +               "Password=" + txtbPassword.Text + ";"
                +               "Database=" + txtbDatabase.Text + ";"
                +               "DataSource=Localhost;"
                +               "Port=3050;"
                +               "Dialect = 3;"
                +               "Charset = NONE;"
                +               "Role =;"
                +               "Connection lifetime = 15;"
                +               "Pooling = true; MinPoolSize = 0; MaxPoolSize = 50;"
                +               "Packet Size = 8192; ServerType = 0;";

            try
            {
                connection = new FbConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BackColor = Color.Red; 
                btnStart.Visible = false;
                return;

            }
            BackColor = Color.Lime;
            btnStart.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Hide();
            frmFirebird frm = new frmFirebird(connection);
            frm.ShowDialog();
            Show ();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            IniFile ini = new IniFile();
            ini.WriteForm(this);
            
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            IniFile ini = new IniFile();
            ini.ReadForm(this);

        }
    }
}
