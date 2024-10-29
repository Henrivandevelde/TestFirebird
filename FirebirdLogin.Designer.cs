namespace TestFirebird
{
    partial class frmLogin
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
            this.txtbDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectDatabase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbBenutzer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnEnde = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbDatabase
            // 
            this.txtbDatabase.Font = new System.Drawing.Font("Courier", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDatabase.Location = new System.Drawing.Point(114, 95);
            this.txtbDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtbDatabase.Name = "txtbDatabase";
            this.txtbDatabase.Size = new System.Drawing.Size(386, 27);
            this.txtbDatabase.TabIndex = 0;
            this.txtbDatabase.Text = "c:\\Hanke\\interbase\\hankeib.gdb";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firebird Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectDatabase
            // 
            this.btnSelectDatabase.Location = new System.Drawing.Point(508, 94);
            this.btnSelectDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectDatabase.Name = "btnSelectDatabase";
            this.btnSelectDatabase.Size = new System.Drawing.Size(32, 27);
            this.btnSelectDatabase.TabIndex = 2;
            this.btnSelectDatabase.Text = "...";
            this.btnSelectDatabase.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datenbank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Benutzer";
            // 
            // txtbBenutzer
            // 
            this.txtbBenutzer.Location = new System.Drawing.Point(118, 136);
            this.txtbBenutzer.Name = "txtbBenutzer";
            this.txtbBenutzer.Size = new System.Drawing.Size(100, 27);
            this.txtbBenutzer.TabIndex = 5;
            this.txtbBenutzer.Text = "SYSDBA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Passwort";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(121, 176);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(100, 27);
            this.txtbPassword.TabIndex = 7;
            this.txtbPassword.Text = "masterkey";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(24, 244);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(87, 74);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnEnde
            // 
            this.btnEnde.Location = new System.Drawing.Point(419, 244);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(93, 74);
            this.btnEnde.TabIndex = 10;
            this.btnEnde.Text = "Beenden";
            this.btnEnde.UseVisualStyleBackColor = true;
            this.btnEnde.Click += new System.EventHandler(this.btnEnde_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 74);
            this.button1.TabIndex = 8;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(229, 244);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 74);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(419, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 74);
            this.button3.TabIndex = 10;
            this.button3.Text = "Beenden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnEnde_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 364);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEnde);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbBenutzer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbDatabase);
            this.Font = new System.Drawing.Font("Courier", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbBenutzer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnEnde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button3;
    }
}