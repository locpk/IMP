namespace iMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register_screen));
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
            this.phone_selector = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancel_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // First_name
            // 
            this.First_name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.First_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.First_name.ForeColor = System.Drawing.Color.Gold;
            this.First_name.Location = new System.Drawing.Point(309, 105);
            this.First_name.MaxLength = 10;
            this.First_name.Name = "First_name";
            this.First_name.Size = new System.Drawing.Size(116, 13);
            this.First_name.TabIndex = 2;
            this.First_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.First_name.Validating += new System.ComponentModel.CancelEventHandler(this.First_name_Validating);
            this.First_name.Validated += new System.EventHandler(this.First_name_Validated);
            // 
            // Last_name
            // 
            this.Last_name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Last_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Last_name.ForeColor = System.Drawing.Color.Gold;
            this.Last_name.Location = new System.Drawing.Point(309, 145);
            this.Last_name.MaxLength = 10;
            this.Last_name.Name = "Last_name";
            this.Last_name.Size = new System.Drawing.Size(116, 13);
            this.Last_name.TabIndex = 3;
            this.Last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Last_name.Validating += new System.ComponentModel.CancelEventHandler(this.Last_name_Validating);
            this.Last_name.Validated += new System.EventHandler(this.Last_name_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // Phone_number
            // 
            this.Phone_number.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Phone_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phone_number.ForeColor = System.Drawing.Color.Gold;
            this.Phone_number.Location = new System.Drawing.Point(409, 180);
            this.Phone_number.MaxLength = 11;
            this.Phone_number.Name = "Phone_number";
            this.Phone_number.Size = new System.Drawing.Size(116, 13);
            this.Phone_number.TabIndex = 5;
            this.Phone_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone_number.Leave += new System.EventHandler(this.Phone_number_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Numer";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.ForeColor = System.Drawing.Color.Gold;
            this.Email.Location = new System.Drawing.Point(309, 218);
            this.Email.MaxLength = 20;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(116, 13);
            this.Email.TabIndex = 6;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            this.Email.Validated += new System.EventHandler(this.Email_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birthday";
            // 
            // birthday
            // 
            this.birthday.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.birthday.ForeColor = System.Drawing.Color.Gold;
            this.birthday.Location = new System.Drawing.Point(309, 301);
            this.birthday.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.birthday.Name = "birthday";
            this.birthday.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(1980, 1, 1, 0, 0, 0, 0), new System.DateTime(1980, 1, 7, 0, 0, 0, 0));
            this.birthday.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(225, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 57);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // malebutton
            // 
            this.malebutton.AutoSize = true;
            this.malebutton.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malebutton.Location = new System.Drawing.Point(309, 274);
            this.malebutton.Name = "malebutton";
            this.malebutton.Size = new System.Drawing.Size(59, 22);
            this.malebutton.TabIndex = 8;
            this.malebutton.TabStop = true;
            this.malebutton.Text = "Male";
            this.malebutton.UseVisualStyleBackColor = true;
            // 
            // femalebutton
            // 
            this.femalebutton.AutoSize = true;
            this.femalebutton.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalebutton.Location = new System.Drawing.Point(409, 274);
            this.femalebutton.Name = "femalebutton";
            this.femalebutton.Size = new System.Drawing.Size(74, 22);
            this.femalebutton.TabIndex = 9;
            this.femalebutton.TabStop = true;
            this.femalebutton.Text = "Female";
            this.femalebutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.ForeColor = System.Drawing.Color.Gold;
            this.Password.Location = new System.Drawing.Point(309, 247);
            this.Password.MaxLength = 20;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(116, 13);
            this.Password.TabIndex = 7;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.UseSystemPasswordChar = true;
            this.Password.Validating += new System.ComponentModel.CancelEventHandler(this.Password_Validating);
            this.Password.Validated += new System.EventHandler(this.Password_Validated);
            // 
            // phone_selector
            // 
            this.phone_selector.BackColor = System.Drawing.SystemColors.ControlDark;
            this.phone_selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phone_selector.ForeColor = System.Drawing.Color.Orange;
            this.phone_selector.FormattingEnabled = true;
            this.phone_selector.Items.AddRange(new object[] {
            "US +1",
            "CN +86"});
            this.phone_selector.Location = new System.Drawing.Point(309, 177);
            this.phone_selector.Name = "phone_selector";
            this.phone_selector.Size = new System.Drawing.Size(75, 20);
            this.phone_selector.TabIndex = 4;
            this.phone_selector.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Username";
            // 
            // usernamebox
            // 
            this.usernamebox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.usernamebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernamebox.ForeColor = System.Drawing.Color.Gold;
            this.usernamebox.Location = new System.Drawing.Point(309, 70);
            this.usernamebox.MaxLength = 10;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(116, 13);
            this.usernamebox.TabIndex = 1;
            this.usernamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernamebox.TextChanged += new System.EventHandler(this.usernamebox_TextChanged);
            this.usernamebox.Validating += new System.ComponentModel.CancelEventHandler(this.usernamebox_Validating);
            this.usernamebox.Validated += new System.EventHandler(this.usernamebox_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gender";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            this.errorProvider8.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider8.Icon")));
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancel_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.ForeColor = System.Drawing.Color.Gold;
            this.cancel_button.Image = ((System.Drawing.Image)(resources.GetObject("cancel_button.Image")));
            this.cancel_button.Location = new System.Drawing.Point(461, 487);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(64, 57);
            this.cancel_button.TabIndex = 12;
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 36);
            this.label9.TabIndex = 48;
            this.label9.Text = "Sign Up";
            // 
            // register_screen
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(747, 589);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phone_selector);
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
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "register_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ComboBox phone_selector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label9;
    }
}

