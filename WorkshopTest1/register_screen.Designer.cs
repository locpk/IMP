namespace WorkshopTest1
{
    partial class register_screen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.First_name = new System.Windows.Forms.TextBox();
            this.Last_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.malebutton = new System.Windows.Forms.RadioButton();
            this.femalebutton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // First_name
            // 
            this.First_name.Location = new System.Drawing.Point(311, 81);
            this.First_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.First_name.MaxLength = 10;
            this.First_name.Name = "First_name";
            this.First_name.Size = new System.Drawing.Size(116, 21);
            this.First_name.TabIndex = 1;
            this.First_name.Validating += new System.ComponentModel.CancelEventHandler(this.First_name_Validating);
            this.First_name.Validated += new System.EventHandler(this.First_name_Validated);
            // 
            // Last_name
            // 
            this.Last_name.Location = new System.Drawing.Point(311, 135);
            this.Last_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Last_name.MaxLength = 10;
            this.Last_name.Name = "Last_name";
            this.Last_name.Size = new System.Drawing.Size(116, 21);
            this.Last_name.TabIndex = 3;
            this.Last_name.Validating += new System.ComponentModel.CancelEventHandler(this.Last_name_Validating);
            this.Last_name.Validated += new System.EventHandler(this.Last_name_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // Phone_number
            // 
            this.Phone_number.Location = new System.Drawing.Point(394, 189);
            this.Phone_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Phone_number.MaxLength = 11;
            this.Phone_number.Name = "Phone_number";
            this.Phone_number.Size = new System.Drawing.Size(116, 21);
            this.Phone_number.TabIndex = 5;
            this.Phone_number.Leave += new System.EventHandler(this.Phone_number_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Numer";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(311, 237);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(116, 21);
            this.Email.TabIndex = 7;
            this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            this.Email.Validated += new System.EventHandler(this.Email_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birthday";
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(300, 317);
            this.birthday.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.birthday.Name = "birthday";
            this.birthday.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(1980, 1, 1, 0, 0, 0, 0), new System.DateTime(1980, 1, 7, 0, 0, 0, 0));
            this.birthday.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 579);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Creat Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // malebutton
            // 
            this.malebutton.AutoSize = true;
            this.malebutton.Location = new System.Drawing.Point(278, 532);
            this.malebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.malebutton.Name = "malebutton";
            this.malebutton.Size = new System.Drawing.Size(52, 20);
            this.malebutton.TabIndex = 12;
            this.malebutton.TabStop = true;
            this.malebutton.Text = "Male";
            this.malebutton.UseVisualStyleBackColor = true;
            // 
            // femalebutton
            // 
            this.femalebutton.AutoSize = true;
            this.femalebutton.Location = new System.Drawing.Point(341, 532);
            this.femalebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.femalebutton.Name = "femalebutton";
            this.femalebutton.Size = new System.Drawing.Size(63, 20);
            this.femalebutton.TabIndex = 13;
            this.femalebutton.TabStop = true;
            this.femalebutton.Text = "Female";
            this.femalebutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(311, 276);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password.MaxLength = 20;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(116, 21);
            this.Password.TabIndex = 15;
            this.Password.UseSystemPasswordChar = true;
            this.Password.Validating += new System.ComponentModel.CancelEventHandler(this.Password_Validating);
            this.Password.Validated += new System.EventHandler(this.Password_Validated);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+1 US",
            "+86 CN"});
            this.comboBox1.Location = new System.Drawing.Point(311, 188);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Username";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(311, 36);
            this.usernamebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(116, 21);
            this.usernamebox.TabIndex = 18;
            this.usernamebox.TextChanged += new System.EventHandler(this.usernamebox_TextChanged);
            this.usernamebox.Validating += new System.ComponentModel.CancelEventHandler(this.usernamebox_Validating);
            this.usernamebox.Validated += new System.EventHandler(this.usernamebox_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gender";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // register_screen
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(749, 637);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.femalebutton);
            this.Controls.Add(this.malebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Phone_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Last_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.First_name);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "register_screen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox First_name;
        private System.Windows.Forms.TextBox Last_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Phone_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar birthday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton malebutton;
        private System.Windows.Forms.RadioButton femalebutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
    }
}

