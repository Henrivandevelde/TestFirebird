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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using inifiles;

namespace TestFirebird
{

    public partial class frmFirebird : Form
    {
        FbConnection connection;

        IniFile ini = new IniFile();    
        public frmFirebird()
        {
            InitializeComponent();
        }

        public frmFirebird(FbConnection con)
        {
            InitializeComponent();
            connection = con;
            gridTables.RowHeadersVisible = false;
            gridTables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            gridFields.RowHeadersVisible = false;
            gridFields.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            gridData.RowHeadersVisible = false;
            gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            LoadTables(gridTables);
           
            
        }
        private void frmFirebird_Shown(object sender, EventArgs e)
        {
            ini.ReadForm(this);

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


            using (var command = new FbCommand("SELECT RDB$RELATION_NAME AS TABLES FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG=0", connection))
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
            string ursql = "SELECT RDB$FIELD_NAME AS FIELDS FROM RDB$RELATION_FIELDS WHERE RDB$RELATION_NAME = 'xxx'";
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
        
        private void execQuery (string query)
        {
            txtbSQL.Clear();
            txtbSQL.Text = query;
            if (!OpenDB()) return;
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

                    gridData.DataSource = dataSet.Tables["Customers"];
                }
            }
            connection.Close();
            gridData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        private void LoadData (string TableName)
        {
            string sql = "select * from " + TableName;
            execQuery (sql);

        }



        private void gridTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadFields(gridFields, gridTables.CurrentCell.Value.ToString());

        }


        private void gridTables_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData(gridTables.CurrentCell.Value.ToString());

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbSQL.Clear();
        }

        private void gridFields_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridFields.DoDragDrop(gridFields.CurrentCell.Value.ToString(), DragDropEffects.Copy |
                DragDropEffects.Move);
        }

        private void txtbSQL_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtbSQL_DragDrop(object sender, DragEventArgs e)
        {
            txtbSQL.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            execQuery (txtbSQL.Text);
        }

        private void frmFirebird_FormClosed(object sender, FormClosedEventArgs e)
        {
            ini.WriteForm(this);
           
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

 
        private void txtbSQL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadData(gridTables.CurrentCell.Value.ToString());
        }

    }
}
