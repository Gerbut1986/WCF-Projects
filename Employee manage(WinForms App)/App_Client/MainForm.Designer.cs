namespace App_Client
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.fioTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addrTXT = new System.Windows.Forms.TextBox();
            this.phoneTXT = new System.Windows.Forms.TextBox();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.birthTXT = new System.Windows.Forms.TextBox();
            this.salaryTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showAllEntities = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.findID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.findedBtn = new System.Windows.Forms.Button();
            this.labelReturn = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIO:";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Lime;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(0, 205);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(264, 37);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // fioTXT
            // 
            this.fioTXT.Location = new System.Drawing.Point(135, 47);
            this.fioTXT.Name = "fioTXT";
            this.fioTXT.Size = new System.Drawing.Size(100, 20);
            this.fioTXT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "DateBirth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salary:";
            // 
            // addrTXT
            // 
            this.addrTXT.Location = new System.Drawing.Point(135, 73);
            this.addrTXT.Name = "addrTXT";
            this.addrTXT.Size = new System.Drawing.Size(100, 20);
            this.addrTXT.TabIndex = 8;
            // 
            // phoneTXT
            // 
            this.phoneTXT.Location = new System.Drawing.Point(135, 99);
            this.phoneTXT.Name = "phoneTXT";
            this.phoneTXT.Size = new System.Drawing.Size(100, 20);
            this.phoneTXT.TabIndex = 9;
            // 
            // emailTXT
            // 
            this.emailTXT.Location = new System.Drawing.Point(135, 125);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(100, 20);
            this.emailTXT.TabIndex = 10;
            // 
            // birthTXT
            // 
            this.birthTXT.Location = new System.Drawing.Point(135, 151);
            this.birthTXT.Name = "birthTXT";
            this.birthTXT.Size = new System.Drawing.Size(100, 20);
            this.birthTXT.TabIndex = 11;
            // 
            // salaryTXT
            // 
            this.salaryTXT.Location = new System.Drawing.Point(135, 176);
            this.salaryTXT.Name = "salaryTXT";
            this.salaryTXT.Size = new System.Drawing.Size(100, 20);
            this.salaryTXT.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Add Emoloyer to Database";
            // 
            // showAllEntities
            // 
            this.showAllEntities.BackColor = System.Drawing.Color.Aqua;
            this.showAllEntities.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showAllEntities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllEntities.ForeColor = System.Drawing.Color.Fuchsia;
            this.showAllEntities.Location = new System.Drawing.Point(0, 425);
            this.showAllEntities.Name = "showAllEntities";
            this.showAllEntities.Size = new System.Drawing.Size(264, 27);
            this.showAllEntities.TabIndex = 14;
            this.showAllEntities.Text = "Show All Data from Employers DB";
            this.showAllEntities.UseVisualStyleBackColor = false;
            this.showAllEntities.Click += new System.EventHandler(this.showAllEntities_Click);
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.DarkRed;
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.ForeColor = System.Drawing.Color.White;
            this.findBtn.Location = new System.Drawing.Point(0, 239);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(264, 34);
            this.findBtn.TabIndex = 15;
            this.findBtn.Text = "FIND BY ID";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // findID
            // 
            this.findID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findID.Location = new System.Drawing.Point(114, 77);
            this.findID.Name = "findID";
            this.findID.Size = new System.Drawing.Size(47, 26);
            this.findID.TabIndex = 16;
            this.findID.TextChanged += new System.EventHandler(this.findID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Input ID Employer to Find";
            // 
            // findedBtn
            // 
            this.findedBtn.BackColor = System.Drawing.Color.Navy;
            this.findedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.findedBtn.Location = new System.Drawing.Point(72, 118);
            this.findedBtn.Name = "findedBtn";
            this.findedBtn.Size = new System.Drawing.Size(129, 37);
            this.findedBtn.TabIndex = 19;
            this.findedBtn.Text = "FIND";
            this.findedBtn.UseVisualStyleBackColor = false;
            this.findedBtn.Click += new System.EventHandler(this.findedBtn_Click);
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelReturn.Location = new System.Drawing.Point(72, 11);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(119, 16);
            this.labelReturn.TabIndex = 21;
            this.labelReturn.Text = "<--- Return Back";
            this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(238, -1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 23);
            this.closeBtn.TabIndex = 22;
            this.closeBtn.Text = "Х";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 260);
            this.listBox1.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 452);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.findedBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.findID);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.showAllEntities);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salaryTXT);
            this.Controls.Add(this.birthTXT);
            this.Controls.Add(this.emailTXT);
            this.Controls.Add(this.phoneTXT);
            this.Controls.Add(this.addrTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fioTXT);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Data to DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox fioTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addrTXT;
        private System.Windows.Forms.TextBox phoneTXT;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.TextBox birthTXT;
        private System.Windows.Forms.TextBox salaryTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showAllEntities;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox findID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button findedBtn;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}

