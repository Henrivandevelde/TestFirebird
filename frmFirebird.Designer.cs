namespace TestFirebird
{
    partial class frmFirebird
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDB = new System.Windows.Forms.Panel();
            this.gridFields = new System.Windows.Forms.DataGridView();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.gridTables = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlSQL = new System.Windows.Forms.Panel();
            this.txtbSQL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTables)).BeginInit();
            this.pnlSQL.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 754);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1257, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gridData
            // 
            this.gridData.BackgroundColor = System.Drawing.Color.White;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridData.Location = new System.Drawing.Point(0, 505);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(1257, 249);
            this.gridData.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Chartreuse;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 502);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1257, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlDB);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.pnlSQL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 474);
            this.panel1.TabIndex = 3;
            // 
            // pnlDB
            // 
            this.pnlDB.Controls.Add(this.gridFields);
            this.pnlDB.Controls.Add(this.splitter3);
            this.pnlDB.Controls.Add(this.gridTables);
            this.pnlDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDB.Location = new System.Drawing.Point(645, 0);
            this.pnlDB.Name = "pnlDB";
            this.pnlDB.Size = new System.Drawing.Size(612, 474);
            this.pnlDB.TabIndex = 2;
            // 
            // gridFields
            // 
            this.gridFields.BackgroundColor = System.Drawing.Color.White;
            this.gridFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFields.Location = new System.Drawing.Point(327, 0);
            this.gridFields.Name = "gridFields";
            this.gridFields.RowHeadersWidth = 51;
            this.gridFields.RowTemplate.Height = 24;
            this.gridFields.Size = new System.Drawing.Size(285, 474);
            this.gridFields.TabIndex = 2;
            this.gridFields.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridFields_CellMouseDown);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.Chartreuse;
            this.splitter3.Location = new System.Drawing.Point(324, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 474);
            this.splitter3.TabIndex = 1;
            this.splitter3.TabStop = false;
            // 
            // gridTables
            // 
            this.gridTables.BackgroundColor = System.Drawing.Color.White;
            this.gridTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridTables.Location = new System.Drawing.Point(0, 0);
            this.gridTables.Name = "gridTables";
            this.gridTables.RowHeadersWidth = 51;
            this.gridTables.RowTemplate.Height = 24;
            this.gridTables.Size = new System.Drawing.Size(324, 474);
            this.gridTables.TabIndex = 0;
            this.gridTables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTables_CellClick);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.PaleGreen;
            this.splitter2.Location = new System.Drawing.Point(642, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 474);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // pnlSQL
            // 
            this.pnlSQL.Controls.Add(this.txtbSQL);
            this.pnlSQL.Controls.Add(this.panel2);
            this.pnlSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSQL.Location = new System.Drawing.Point(0, 0);
            this.pnlSQL.Name = "pnlSQL";
            this.pnlSQL.Size = new System.Drawing.Size(642, 474);
            this.pnlSQL.TabIndex = 0;
            // 
            // txtbSQL
            // 
            this.txtbSQL.AllowDrop = true;
            this.txtbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbSQL.Location = new System.Drawing.Point(0, 0);
            this.txtbSQL.Multiline = true;
            this.txtbSQL.Name = "txtbSQL";
            this.txtbSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbSQL.Size = new System.Drawing.Size(642, 404);
            this.txtbSQL.TabIndex = 1;
            this.txtbSQL.TextChanged += new System.EventHandler(this.txtbSQL_TextChanged);
            this.txtbSQL.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtbSQL_DragDrop);
            this.txtbSQL.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbSQL_DragEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShowTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 70);
            this.panel2.TabIndex = 0;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(534, 13);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(75, 47);
            this.btnShowTable.TabIndex = 0;
            this.btnShowTable.Text = "Show";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // frmFirebird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 776);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFirebird";
            this.Text = "frmFirebird";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFirebird_FormClosed);
            this.Shown += new System.EventHandler(this.frmFirebird_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTables)).EndInit();
            this.pnlSQL.ResumeLayout(false);
            this.pnlSQL.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSQL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlDB;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridTables;
        private System.Windows.Forms.TextBox txtbSQL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridFields;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnShowTable;
    }
}