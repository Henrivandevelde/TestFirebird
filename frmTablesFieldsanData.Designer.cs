namespace TestFirebird
{
    partial class frmTablesFieldsanData
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.benendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlData = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtbSQL = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridTables = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.gridFields = new System.Windows.Forms.DataGridView();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.fbDataAdapter1 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.menuStrip1.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.benendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // benendenToolStripMenuItem
            // 
            this.benendenToolStripMenuItem.Name = "benendenToolStripMenuItem";
            this.benendenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.benendenToolStripMenuItem.Text = "Benenden ";
            this.benendenToolStripMenuItem.Click += new System.EventHandler(this.benendenToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 738);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1254, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.gridData);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlData.Location = new System.Drawing.Point(0, 513);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1254, 225);
            this.pnlData.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 505);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1254, 8);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.txtbSQL);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridFields);
            this.splitContainer1.Panel2.Controls.Add(this.splitter2);
            this.splitContainer1.Panel2.Controls.Add(this.gridTables);
            this.splitContainer1.Size = new System.Drawing.Size(1254, 477);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 4;
            // 
            // txtbSQL
            // 
            this.txtbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbSQL.Location = new System.Drawing.Point(0, 0);
            this.txtbSQL.Multiline = true;
            this.txtbSQL.Name = "txtbSQL";
            this.txtbSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbSQL.Size = new System.Drawing.Size(418, 477);
            this.txtbSQL.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 59);
            this.panel1.TabIndex = 1;
            // 
            // gridTables
            // 
            this.gridTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridTables.BackgroundColor = System.Drawing.Color.White;
            this.gridTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridTables.Location = new System.Drawing.Point(0, 0);
            this.gridTables.MultiSelect = false;
            this.gridTables.Name = "gridTables";
            this.gridTables.RowHeadersWidth = 51;
            this.gridTables.RowTemplate.Height = 24;
            this.gridTables.Size = new System.Drawing.Size(368, 477);
            this.gridTables.TabIndex = 0;
            this.gridTables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTables_CellClick);
            this.gridTables.SelectionChanged += new System.EventHandler(this.benendenToolStripMenuItem_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(368, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 477);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // gridFields
            // 
            this.gridFields.BackgroundColor = System.Drawing.Color.White;
            this.gridFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFields.Location = new System.Drawing.Point(371, 0);
            this.gridFields.Name = "gridFields";
            this.gridFields.RowHeadersWidth = 51;
            this.gridFields.RowTemplate.Height = 24;
            this.gridFields.Size = new System.Drawing.Size(461, 477);
            this.gridFields.TabIndex = 2;
        
            // 
            this.gridData.BackgroundColor = System.Drawing.Color.White;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(0, 0);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(1254, 225);
            this.gridData.TabIndex = 0;
            // 
            // frmTablesFieldsanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 760);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTablesFieldsanData";
            this.Text = "frmTablesFieldsanData";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem benendenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbSQL;
        private System.Windows.Forms.DataGridView gridFields;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView gridTables;
        private System.Windows.Forms.DataGridView gridData;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter fbDataAdapter1;
    }
}