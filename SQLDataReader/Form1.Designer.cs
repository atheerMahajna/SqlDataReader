namespace SQLDataReader
{
    partial class Form1
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
            this.btnReadFromSql = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelRes = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.btnAdd2Sql = new System.Windows.Forms.Button();
            this.labTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secondlibrary = new System.Windows.Forms.RadioButton();
            this.mainlibrary = new System.Windows.Forms.RadioButton();
            this.userNameLab = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.btnDeleteFSql = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadFromSql
            // 
            this.btnReadFromSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReadFromSql.Location = new System.Drawing.Point(623, 280);
            this.btnReadFromSql.Name = "btnReadFromSql";
            this.btnReadFromSql.Size = new System.Drawing.Size(133, 37);
            this.btnReadFromSql.TabIndex = 23;
            this.btnReadFromSql.Text = "Select";
            this.btnReadFromSql.UseVisualStyleBackColor = true;
            this.btnReadFromSql.Click += new System.EventHandler(this.btnReadFromSql_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(555, 54);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(200, 22);
            this.TimePicker.TabIndex = 22;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(2, 148);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 21;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(106, 448);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(28, 17);
            this.labelRes.TabIndex = 20;
            this.labelRes.Text = ".....";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labDate.Location = new System.Drawing.Point(12, 114);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(64, 25);
            this.labDate.TabIndex = 19;
            this.labDate.Text = "Date :";
            // 
            // btnAdd2Sql
            // 
            this.btnAdd2Sql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd2Sql.Location = new System.Drawing.Point(463, 227);
            this.btnAdd2Sql.Name = "btnAdd2Sql";
            this.btnAdd2Sql.Size = new System.Drawing.Size(133, 37);
            this.btnAdd2Sql.TabIndex = 15;
            this.btnAdd2Sql.Text = "Insert";
            this.btnAdd2Sql.UseVisualStyleBackColor = true;
            this.btnAdd2Sql.Click += new System.EventHandler(this.btnAdd2Sql_Click);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labTime.Location = new System.Drawing.Point(555, 29);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(67, 25);
            this.labTime.TabIndex = 18;
            this.labTime.Text = "Time :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secondlibrary);
            this.groupBox1.Controls.Add(this.mainlibrary);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(315, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Library :";
            // 
            // secondlibrary
            // 
            this.secondlibrary.AutoSize = true;
            this.secondlibrary.Location = new System.Drawing.Point(7, 56);
            this.secondlibrary.Name = "secondlibrary";
            this.secondlibrary.Size = new System.Drawing.Size(128, 29);
            this.secondlibrary.TabIndex = 1;
            this.secondlibrary.TabStop = true;
            this.secondlibrary.Text = "Secondary";
            this.secondlibrary.UseVisualStyleBackColor = true;
            // 
            // mainlibrary
            // 
            this.mainlibrary.AutoSize = true;
            this.mainlibrary.Location = new System.Drawing.Point(7, 25);
            this.mainlibrary.Name = "mainlibrary";
            this.mainlibrary.Size = new System.Drawing.Size(76, 29);
            this.mainlibrary.TabIndex = 0;
            this.mainlibrary.TabStop = true;
            this.mainlibrary.Text = "Main";
            this.mainlibrary.UseVisualStyleBackColor = true;
            // 
            // userNameLab
            // 
            this.userNameLab.AutoSize = true;
            this.userNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userNameLab.Location = new System.Drawing.Point(13, 29);
            this.userNameLab.Name = "userNameLab";
            this.userNameLab.Size = new System.Drawing.Size(121, 25);
            this.userNameLab.TabIndex = 16;
            this.userNameLab.Text = "User Name :";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(18, 57);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(100, 22);
            this.textUserName.TabIndex = 14;
            // 
            // btnDeleteFSql
            // 
            this.btnDeleteFSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeleteFSql.Location = new System.Drawing.Point(463, 280);
            this.btnDeleteFSql.Name = "btnDeleteFSql";
            this.btnDeleteFSql.Size = new System.Drawing.Size(135, 37);
            this.btnDeleteFSql.TabIndex = 24;
            this.btnDeleteFSql.Tag = "v";
            this.btnDeleteFSql.Text = "Delete";
            this.btnDeleteFSql.UseVisualStyleBackColor = true;
            this.btnDeleteFSql.Click += new System.EventHandler(this.btnDeleteFSql_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.Location = new System.Drawing.Point(623, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 37);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Tag = "v";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtID.Location = new System.Drawing.Point(176, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(42, 25);
            this.txtID.TabIndex = 27;
            this.txtID.Text = "ID :";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(176, 54);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleteFSql);
            this.Controls.Add(this.btnReadFromSql);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.btnAdd2Sql);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userNameLab);
            this.Controls.Add(this.textUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFromSql;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Button btnAdd2Sql;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton secondlibrary;
        private System.Windows.Forms.RadioButton mainlibrary;
        private System.Windows.Forms.Label userNameLab;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Button btnDeleteFSql;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox textBoxID;
    }
}

