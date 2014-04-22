namespace iMoney
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            this.save_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.username_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.newPW = new System.Windows.Forms.TextBox();
            this.oldPW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.Gold;
            this.save_button.Location = new System.Drawing.Point(57, 339);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(140, 126);
            this.save_button.TabIndex = 56;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.Gold;
            this.exit_button.Location = new System.Drawing.Point(249, 339);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(140, 126);
            this.exit_button.TabIndex = 57;
            this.exit_button.Text = "Return";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // username_box
            // 
            this.username_box.BackColor = System.Drawing.SystemColors.ControlDark;
            this.username_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_box.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.ForeColor = System.Drawing.Color.Gold;
            this.username_box.Location = new System.Drawing.Point(203, 120);
            this.username_box.MaxLength = 20;
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(186, 22);
            this.username_box.TabIndex = 58;
            this.username_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 59;
            this.label1.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 36);
            this.label4.TabIndex = 55;
            this.label4.Text = "Change Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 22);
            this.label10.TabIndex = 54;
            this.label10.Text = "New Password";
            // 
            // newPW
            // 
            this.newPW.BackColor = System.Drawing.SystemColors.ControlDark;
            this.newPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPW.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPW.ForeColor = System.Drawing.Color.Gold;
            this.newPW.Location = new System.Drawing.Point(203, 269);
            this.newPW.MaxLength = 20;
            this.newPW.Name = "newPW";
            this.newPW.Size = new System.Drawing.Size(186, 22);
            this.newPW.TabIndex = 53;
            this.newPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPW.UseSystemPasswordChar = true;
            this.newPW.Validating += new System.ComponentModel.CancelEventHandler(this.newPW_Validating);
            this.newPW.Validated += new System.EventHandler(this.newPW_Validated);
            // 
            // oldPW
            // 
            this.oldPW.BackColor = System.Drawing.SystemColors.ControlDark;
            this.oldPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldPW.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPW.ForeColor = System.Drawing.Color.Gold;
            this.oldPW.Location = new System.Drawing.Point(203, 188);
            this.oldPW.MaxLength = 20;
            this.oldPW.Name = "oldPW";
            this.oldPW.Size = new System.Drawing.Size(186, 22);
            this.oldPW.TabIndex = 51;
            this.oldPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldPW.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 52;
            this.label6.Text = "Old Password";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Change_Password
            // 
            this.AcceptButton = this.save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit_button;
            this.ClientSize = new System.Drawing.Size(447, 511);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.newPW);
            this.Controls.Add(this.oldPW);
            this.Controls.Add(this.label6);
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox newPW;
        private System.Windows.Forms.TextBox oldPW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}