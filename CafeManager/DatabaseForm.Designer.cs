namespace CafeManager
{
    partial class DatabaseForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRetoreDatabase = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.btnBackupDatabase = new System.Windows.Forms.Button();
            this.btnSelectDefaultDbPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAutoBackup = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblSqlInfo = new System.Windows.Forms.Label();
            this.lblDatabaseInfo = new System.Windows.Forms.Label();
            this.lblTablesInfo = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(902, 445);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Back up manager";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox3);
            this.groupBox9.Controls.Add(this.groupBox5);
            this.groupBox9.Enabled = false;
            this.groupBox9.Location = new System.Drawing.Point(16, 280);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(870, 148);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnRetoreDatabase);
            this.groupBox3.Location = new System.Drawing.Point(15, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 110);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database restore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "To restore the database from a backup file, press the left button";
            // 
            // btnRetoreDatabase
            // 
            this.btnRetoreDatabase.Image = global::CafeManager.Properties.Resources.ImportDB_70px;
            this.btnRetoreDatabase.Location = new System.Drawing.Point(6, 19);
            this.btnRetoreDatabase.Name = "btnRetoreDatabase";
            this.btnRetoreDatabase.Size = new System.Drawing.Size(89, 79);
            this.btnRetoreDatabase.TabIndex = 0;
            this.btnRetoreDatabase.UseVisualStyleBackColor = true;
            this.btnRetoreDatabase.Click += new System.EventHandler(this.btnRestoreDatabase_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblBackupPath);
            this.groupBox5.Controls.Add(this.btnBackupDatabase);
            this.groupBox5.Controls.Add(this.btnSelectDefaultDbPath);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.chkAutoBackup);
            this.groupBox5.Location = new System.Drawing.Point(441, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 110);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.Location = new System.Drawing.Point(132, 86);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(265, 13);
            this.lblBackupPath.TabIndex = 3;
            this.lblBackupPath.Text = "C:\\CafeManagerBackup";
            // 
            // btnBackupDatabase
            // 
            this.btnBackupDatabase.Image = global::CafeManager.Properties.Resources.BackupDB_70px;
            this.btnBackupDatabase.Location = new System.Drawing.Point(23, 19);
            this.btnBackupDatabase.Name = "btnBackupDatabase";
            this.btnBackupDatabase.Size = new System.Drawing.Size(89, 79);
            this.btnBackupDatabase.TabIndex = 0;
            this.btnBackupDatabase.UseVisualStyleBackColor = true;
            this.btnBackupDatabase.Click += new System.EventHandler(this.btnBackupDatabase_Click);
            // 
            // btnSelectDefaultDbPath
            // 
            this.btnSelectDefaultDbPath.Location = new System.Drawing.Point(135, 60);
            this.btnSelectDefaultDbPath.Name = "btnSelectDefaultDbPath";
            this.btnSelectDefaultDbPath.Size = new System.Drawing.Size(262, 23);
            this.btnSelectDefaultDbPath.TabIndex = 1;
            this.btnSelectDefaultDbPath.Text = "Select the dedault address for saving the backup file";
            this.btnSelectDefaultDbPath.UseVisualStyleBackColor = true;
            this.btnSelectDefaultDbPath.Click += new System.EventHandler(this.btnSelectDefaultDbPath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "To back up the database, press the left button";
            // 
            // chkAutoBackup
            // 
            this.chkAutoBackup.AutoSize = true;
            this.chkAutoBackup.Location = new System.Drawing.Point(135, 39);
            this.chkAutoBackup.Name = "chkAutoBackup";
            this.chkAutoBackup.Size = new System.Drawing.Size(262, 17);
            this.chkAutoBackup.TabIndex = 0;
            this.chkAutoBackup.Text = "Automatically back up upon exiting the application";
            this.chkAutoBackup.UseVisualStyleBackColor = true;
            this.chkAutoBackup.Click += new System.EventHandler(this.chkAutoBackup_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblSqlInfo);
            this.groupBox8.Controls.Add(this.lblDatabaseInfo);
            this.groupBox8.Controls.Add(this.lblTablesInfo);
            this.groupBox8.Location = new System.Drawing.Point(16, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(870, 100);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            // 
            // lblSqlInfo
            // 
            this.lblSqlInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqlInfo.ForeColor = System.Drawing.Color.Red;
            this.lblSqlInfo.Location = new System.Drawing.Point(12, 39);
            this.lblSqlInfo.Name = "lblSqlInfo";
            this.lblSqlInfo.Size = new System.Drawing.Size(270, 24);
            this.lblSqlInfo.TabIndex = 3;
            this.lblSqlInfo.Text = "SQLServer is not installed or Available";
            this.lblSqlInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatabaseInfo
            // 
            this.lblDatabaseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseInfo.ForeColor = System.Drawing.Color.Red;
            this.lblDatabaseInfo.Location = new System.Drawing.Point(303, 39);
            this.lblDatabaseInfo.Name = "lblDatabaseInfo";
            this.lblDatabaseInfo.Size = new System.Drawing.Size(270, 24);
            this.lblDatabaseInfo.TabIndex = 7;
            this.lblDatabaseInfo.Text = "Database is not exist";
            this.lblDatabaseInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTablesInfo
            // 
            this.lblTablesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablesInfo.ForeColor = System.Drawing.Color.Red;
            this.lblTablesInfo.Location = new System.Drawing.Point(586, 39);
            this.lblTablesInfo.Name = "lblTablesInfo";
            this.lblTablesInfo.Size = new System.Drawing.Size(270, 24);
            this.lblTablesInfo.TabIndex = 8;
            this.lblTablesInfo.Text = "Tables are not exist";
            this.lblTablesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(16, 125);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(870, 149);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnCreateTable);
            this.groupBox2.Location = new System.Drawing.Point(441, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 110);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Table create";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Please press the left button to create Tables.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tables must be created on the system once.";
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Image = global::CafeManager.Properties.Resources.AddTable_70px;
            this.btnCreateTable.Location = new System.Drawing.Point(6, 19);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(89, 79);
            this.btnCreateTable.TabIndex = 0;
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateDatabase);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 110);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database create";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please press the left button to create Database.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Database must be created on the system once.";
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Image = global::CafeManager.Properties.Resources.AddDB_70px;
            this.btnCreateDatabase.Location = new System.Drawing.Point(6, 19);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(89, 79);
            this.btnCreateDatabase.TabIndex = 0;
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 470);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database manager";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBackupDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAutoBackup;
        private System.Windows.Forms.Button btnSelectDefaultDbPath;
        private System.Windows.Forms.Label lblBackupPath;
        private System.Windows.Forms.Label lblSqlInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRetoreDatabase;
        private System.Windows.Forms.Label lblDatabaseInfo;
        private System.Windows.Forms.Label lblTablesInfo;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateDatabase;
    }
}