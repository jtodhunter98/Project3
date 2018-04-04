namespace Project3
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
            this.residentSearchPage = new System.Windows.Forms.TabPage();
            this.newResidentPage = new System.Windows.Forms.TabPage();
            this.athleteOption = new System.Windows.Forms.RadioButton();
            this.scholarOption = new System.Windows.Forms.RadioButton();
            this.studentWorkerOption = new System.Windows.Forms.RadioButton();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLable = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.enterInfoBtn = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.floorLabel = new System.Windows.Forms.Label();
            this.floorInformationLabel = new System.Windows.Forms.Label();
            this.floorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newResidentBtn = new System.Windows.Forms.Button();
            this.newResidentPage.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // residentSearchPage
            // 
            this.residentSearchPage.Location = new System.Drawing.Point(4, 25);
            this.residentSearchPage.Name = "residentSearchPage";
            this.residentSearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.residentSearchPage.Size = new System.Drawing.Size(1058, 525);
            this.residentSearchPage.TabIndex = 3;
            this.residentSearchPage.Text = "Resident Search";
            this.residentSearchPage.UseVisualStyleBackColor = true;
            // 
            // newResidentPage
            // 
            this.newResidentPage.Controls.Add(this.newResidentBtn);
            this.newResidentPage.Controls.Add(this.label4);
            this.newResidentPage.Controls.Add(this.idBox);
            this.newResidentPage.Controls.Add(this.idLabel);
            this.newResidentPage.Controls.Add(this.label3);
            this.newResidentPage.Controls.Add(this.label2);
            this.newResidentPage.Controls.Add(this.floorBox);
            this.newResidentPage.Controls.Add(this.floorInformationLabel);
            this.newResidentPage.Controls.Add(this.floorLabel);
            this.newResidentPage.Controls.Add(this.athleteOption);
            this.newResidentPage.Controls.Add(this.scholarOption);
            this.newResidentPage.Controls.Add(this.studentWorkerOption);
            this.newResidentPage.Controls.Add(this.lNameBox);
            this.newResidentPage.Controls.Add(this.lNameLabel);
            this.newResidentPage.Controls.Add(this.fNameLable);
            this.newResidentPage.Controls.Add(this.fNameBox);
            this.newResidentPage.Controls.Add(this.label1);
            this.newResidentPage.Location = new System.Drawing.Point(4, 25);
            this.newResidentPage.Name = "newResidentPage";
            this.newResidentPage.Padding = new System.Windows.Forms.Padding(3);
            this.newResidentPage.Size = new System.Drawing.Size(1058, 525);
            this.newResidentPage.TabIndex = 2;
            this.newResidentPage.Text = "New Resident";
            this.newResidentPage.UseVisualStyleBackColor = true;
            // 
            // athleteOption
            // 
            this.athleteOption.AutoSize = true;
            this.athleteOption.Location = new System.Drawing.Point(241, 224);
            this.athleteOption.Name = "athleteOption";
            this.athleteOption.Size = new System.Drawing.Size(73, 21);
            this.athleteOption.TabIndex = 11;
            this.athleteOption.TabStop = true;
            this.athleteOption.Text = "Athlete";
            this.athleteOption.UseVisualStyleBackColor = true;
            this.athleteOption.CheckedChanged += new System.EventHandler(this.athleteOption_CheckedChanged);
            // 
            // scholarOption
            // 
            this.scholarOption.AutoSize = true;
            this.scholarOption.Location = new System.Drawing.Point(241, 251);
            this.scholarOption.Name = "scholarOption";
            this.scholarOption.Size = new System.Drawing.Size(103, 21);
            this.scholarOption.TabIndex = 10;
            this.scholarOption.TabStop = true;
            this.scholarOption.Text = "Scholarship";
            this.scholarOption.UseVisualStyleBackColor = true;
            this.scholarOption.CheckedChanged += new System.EventHandler(this.scholarOption_CheckedChanged);
            // 
            // studentWorkerOption
            // 
            this.studentWorkerOption.AutoSize = true;
            this.studentWorkerOption.Location = new System.Drawing.Point(241, 197);
            this.studentWorkerOption.Name = "studentWorkerOption";
            this.studentWorkerOption.Size = new System.Drawing.Size(128, 21);
            this.studentWorkerOption.TabIndex = 9;
            this.studentWorkerOption.TabStop = true;
            this.studentWorkerOption.Text = "Student Worker";
            this.studentWorkerOption.UseVisualStyleBackColor = true;
            this.studentWorkerOption.CheckedChanged += new System.EventHandler(this.studentWorkerOption_CheckedChanged);
            // 
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(241, 157);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(155, 22);
            this.lNameBox.TabIndex = 8;
            this.lNameBox.TextChanged += new System.EventHandler(this.lNameBox_TextChanged);
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(131, 162);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lNameLabel.TabIndex = 7;
            this.lNameLabel.Text = "Last Name";
            // 
            // fNameLable
            // 
            this.fNameLable.AutoSize = true;
            this.fNameLable.Location = new System.Drawing.Point(131, 120);
            this.fNameLable.Name = "fNameLable";
            this.fNameLable.Size = new System.Drawing.Size(76, 17);
            this.fNameLable.TabIndex = 6;
            this.fNameLable.Text = "First Name";
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(241, 120);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(155, 22);
            this.fNameBox.TabIndex = 4;
            this.fNameBox.TextChanged += new System.EventHandler(this.fNameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Resident";
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.LightGray;
            this.loginPage.Controls.Add(this.enterInfoBtn);
            this.loginPage.Controls.Add(this.passwordLabel);
            this.loginPage.Controls.Add(this.usernameLabel);
            this.loginPage.Controls.Add(this.passwordBox);
            this.loginPage.Controls.Add(this.usernameBox);
            this.loginPage.Location = new System.Drawing.Point(4, 25);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(1058, 525);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "Login";
            // 
            // enterInfoBtn
            // 
            this.enterInfoBtn.Location = new System.Drawing.Point(498, 335);
            this.enterInfoBtn.Name = "enterInfoBtn";
            this.enterInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.enterInfoBtn.TabIndex = 4;
            this.enterInfoBtn.Text = "Enter";
            this.enterInfoBtn.UseVisualStyleBackColor = true;
            this.enterInfoBtn.Click += new System.EventHandler(this.enterInfoBtn_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(335, 261);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(331, 198);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 17);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(411, 258);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(253, 22);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(411, 195);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(253, 22);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.loginPage);
            this.tabControl1.Controls.Add(this.newResidentPage);
            this.tabControl1.Controls.Add(this.residentSearchPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Location = new System.Drawing.Point(113, 285);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(94, 17);
            this.floorLabel.TabIndex = 12;
            this.floorLabel.Text = "Floor Number";
            // 
            // floorInformationLabel
            // 
            this.floorInformationLabel.AutoSize = true;
            this.floorInformationLabel.Location = new System.Drawing.Point(68, 302);
            this.floorInformationLabel.Name = "floorInformationLabel";
            this.floorInformationLabel.Size = new System.Drawing.Size(139, 17);
            this.floorInformationLabel.TabIndex = 13;
            this.floorInformationLabel.Text = "Student Workers 1-3";
            // 
            // floorBox
            // 
            this.floorBox.Location = new System.Drawing.Point(241, 285);
            this.floorBox.Name = "floorBox";
            this.floorBox.Size = new System.Drawing.Size(39, 22);
            this.floorBox.TabIndex = 14;
            this.floorBox.TextChanged += new System.EventHandler(this.floorBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Athletes 4-6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Scholarship 7-8";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(123, 377);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(75, 17);
            this.idLabel.TabIndex = 17;
            this.idLabel.Text = "ID Number";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(241, 372);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(91, 22);
            this.idBox.TabIndex = 18;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "New Resident";
            // 
            // newResidentBtn
            // 
            this.newResidentBtn.Location = new System.Drawing.Point(239, 424);
            this.newResidentBtn.Name = "newResidentBtn";
            this.newResidentBtn.Size = new System.Drawing.Size(142, 51);
            this.newResidentBtn.TabIndex = 20;
            this.newResidentBtn.Text = "Add Resident";
            this.newResidentBtn.UseVisualStyleBackColor = true;
            this.newResidentBtn.Click += new System.EventHandler(this.newResidentBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 572);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Dunwoody Residence Hall";
            this.newResidentPage.ResumeLayout(false);
            this.newResidentPage.PerformLayout();
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage residentSearchPage;
        private System.Windows.Forms.TabPage newResidentPage;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.Button enterInfoBtn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label fNameLable;
        private System.Windows.Forms.RadioButton athleteOption;
        private System.Windows.Forms.RadioButton scholarOption;
        private System.Windows.Forms.RadioButton studentWorkerOption;
        private System.Windows.Forms.Label floorInformationLabel;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox floorBox;
        private System.Windows.Forms.Button newResidentBtn;
        private System.Windows.Forms.Label label4;
    }
}

