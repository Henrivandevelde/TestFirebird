using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFirebird
{
    public partial class frmTablesFieldsanData : Form
    {
        FbConnection connection;
        bool loadTablesinAction = false;
        public frmTablesFieldsanData()
        {
            InitializeComponent();
        }
        public frmTablesFieldsanData(FbConnection con)
        {
            InitializeComponent();
            this.connection = con;
            gridTables.RowHeadersVisible = false;
            LoadTables(gridTables);
        }

        private bool OpenDB()
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
        private void LoadTables(DataGridView grid)
        {
           

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
        private void LoadFields(DataGridView grid, string TableName)
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

        private void benendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void gridTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadFields(gridFields, gridTables.CurrentCell.Value.ToString());

        }
    }
}
