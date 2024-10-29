namespace TestFirebird
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbSQL = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gridTables = new System.Windows.Forms.DataGridView();
            this.gridFields = new System.Windows.Forms.DataGridView();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 754);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 58);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1048, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lade Daten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 432);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 322);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtbSQL
            // 
            this.txtbSQL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtbSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbSQL.Location = new System.Drawing.Point(0, 190);
            this.txtbSQL.Multiline = true;
            this.txtbSQL.Name = "txtbSQL";
            this.txtbSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbSQL.ShortcutsEnabled = false;
            this.txtbSQL.Size = new System.Drawing.Size(477, 227);
            this.txtbSQL.TabIndex = 3;
            this.txtbSQL.Text = "SELECT RBS$FIELD_NAME FROM RDB$RELATION_FIELDS";
            this.txtbSQL.WordWrap = false;
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(12, 43);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(84, 47);
            this.btnGO.TabIndex = 4;
            this.btnGO.Text = "Go";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(116, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gridTables
            // 
            this.gridTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTables.Location = new System.Drawing.Point(522, 31);
            this.gridTables.MultiSelect = false;
            this.gridTables.Name = "gridTables";
            this.gridTables.RowHeadersVisible = false;
            this.gridTables.RowHeadersWidth = 51;
            this.gridTables.RowTemplate.Height = 24;
            this.gridTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridTables.ShowEditingIcon = false;
            this.gridTables.Size = new System.Drawing.Size(240, 386);
            this.gridTables.TabIndex = 6;
            this.gridTables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTables_CellClick);
            // 
            // gridFields
            // 
            this.gridFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFields.Location = new System.Drawing.Point(794, 31);
            this.gridFields.Name = "gridFields";
            this.gridFields.RowHeadersVisible = false;
            this.gridFields.RowHeadersWidth = 51;
            this.gridFields.RowTemplate.Height = 24;
            this.gridFields.Size = new System.Drawing.Size(240, 386);
            this.gridFields.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFieldsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadFieldsToolStripMenuItem
            // 
            this.loadFieldsToolStripMenuItem.Name = "loadFieldsToolStripMenuItem";
            this.loadFieldsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.loadFieldsToolStripMenuItem.Text = "LoadFields";
            this.loadFieldsToolStripMenuItem.Click += new System.EventHandler(this.loadFieldsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 812);
            this.Controls.Add(this.gridFields);
            this.Controls.Add(this.gridTables);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtbSQL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbSQL;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView gridTables;
        private System.Windows.Forms.DataGridView gridFields;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadFieldsToolStripMenuItem;
    }
}

