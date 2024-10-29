using System;
using System.Collections;
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
using FirebirdSql;
using FirebirdSql.Data.FirebirdClient;

namespace TestFirebird
{

    public partial class Form1 : Form
    {
        string connectionString = 
        "User=SYSDBA;Password=masterkey;Database=C:\\Hanke\\Interbase\\Hankeib.gdb;DataSource=localhost; Port = 3050; Dialect = 3; Charset = NONE; Role =; Connection lifetime = 15; Pooling = true; MinPoolSize = 0; MaxPoolSize = 50; Packet Size = 8192; ServerType = 0;";
        FbConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new FbConnection(connectionString);
            connection.Open();
            connection.Close();
            LoadTables(gridTables);
           
 
        }

        private bool OpenDB ()
        {
            if (connection.State != ConnectionState.Open) { return true; }
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            return true;

        }

        private void LoadTables (DataGridView grid)
        {
            if (!OpenDB()) return;

            using (var command = new FbCommand("SELECT RDB$RELATION_NAME AS TABELLEN FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG=0", connection))
            {
                using (var adapter = new FbDataAdapter(command))
                {
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet, "Customers");
                    grid.DataSource = dataSet.Tables["Customers"];
                }
            }
            connection.Close();
            grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void LoadFields (DataGridView grid, string TableName)
        {
            string ursql = "SELECT RDB$FIELD_NAME FROM RDB$RELATION_FIELDS WHERE RDB$RELATION_NAME = 'xxx'";
            string sql = ursql.Replace("xxx", TableName);
            if (!OpenDB()) return;

            using (var command = new FbCommand(sql, connection))
            {
                using (var adapter = new FbDataAdapter(command))
                {
                    var dataSet = new DataSet();
                    try
                    {
                        adapter.Fill(dataSet, "Customers");
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show(ex.Message); 
                        return; 
                    }    

                    grid.DataSource = dataSet.Tables["Customers"];
                }
            }
            connection.Close();
            grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void FillDataGrid(string query, DataGridView grid)
        {
            if (!OpenDB()) return;

            using (var command = new FbCommand(query, connection))
            {
                using (var adapter = new FbDataAdapter(command))
                {
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet, "Customers");
                    grid.DataSource = dataSet.Tables["Customers"];
                }
            }
            connection.Close();
            grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void LoadDataIntoDataGridView(string query = "SELECT kndnr, name, vorname FROM ADRESSENIB order by name")
        {

            {
                OpenDB();
                
                using (var command = new FbCommand(query, connection))
                {
                    using (var adapter = new FbDataAdapter(command))
                    {
                        var dataSet = new DataSet();
                        try
                        {
                            adapter.Fill(dataSet, "Customers");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        dataGridView1.DataSource = dataSet.Tables["Customers"];
                    }
                }
                connection.Close();
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbSQL.Clear();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView (txtbSQL.Text);
            FillDataGrid(txtbSQL.Text, dataGridView1);
        }

        private void loadFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFields(gridFields, "ARTIKELIB");
        }

        private void gridTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadFields(gridFields, gridTables.CurrentCell.Value.ToString());
            gridFields.AutoResizeColumns(
        DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
