namespace WorkshopTest1
{
    partial class Confirm_Box
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
            this.no_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // no_button
            // 
            this.no_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.no_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.no_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.no_button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.no_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.no_button.FlatAppearance.BorderSize = 0;
            this.no_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.no_button.Location = new System.Drawing.Point(161, 181);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(47, 26);
            this.no_button.TabIndex = 23;
            this.no_button.Text = "No";
            this.no_button.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ok_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok_button.Location = new System.Drawing.Point(74, 181);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(47, 26);
            this.ok_button.TabIndex = 22;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(44, 86);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 22);
            this.message.TabIndex = 0;
            // 
            // Confirm_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 232);
            this.Controls.Add(this.no_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.message);
            this.Name = "Confirm_Box";
            this.Text = "";
            this.Load += new System.EventHandler(this.Confirm_Box_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button no_button;
    }
}