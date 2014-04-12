namespace WorkshopTest1
{
    partial class welcome_screen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.signup_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "iMoney Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // usernamebox
            // 
            this.usernamebox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.usernamebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernamebox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamebox.ForeColor = System.Drawing.Color.Gold;
            this.usernamebox.Location = new System.Drawing.Point(165, 207);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(116, 18);
            this.usernamebox.TabIndex = 19;
            this.usernamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernamebox.TextChanged += new System.EventHandler(this.usernamebox_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Gold;
            this.Password.Location = new System.Drawing.Point(457, 206);
            this.Password.MaxLength = 20;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(126, 18);
            this.Password.TabIndex = 20;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.UseSystemPasswordChar = true;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.ForeColor = System.Drawing.Color.Gold;
            this.login_button.Location = new System.Drawing.Point(55, 358);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(132, 49);
            this.login_button.TabIndex = 21;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.Gold;
            this.exit_button.Location = new System.Drawing.Point(457, 358);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(126, 49);
            this.exit_button.TabIndex = 22;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.signup_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signup_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.signup_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.signup_button.FlatAppearance.BorderSize = 0;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.ForeColor = System.Drawing.Color.Gold;
            this.signup_button.Location = new System.Drawing.Point(262, 358);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(132, 49);
            this.signup_button.TabIndex = 23;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // welcome_screen
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 475);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "welcome_screen";
            this.Text = "welcome_screen";
            this.Load += new System.EventHandler(this.welcome_screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button signup_button;
    }
}