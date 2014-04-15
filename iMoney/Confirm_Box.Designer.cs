namespace iMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm_Box));
            this.no_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // no_button
            // 
            this.no_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.no_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.no_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no_button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.no_button.FlatAppearance.BorderSize = 0;
            this.no_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.no_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.no_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no_button.Image = ((System.Drawing.Image)(resources.GetObject("no_button.Image")));
            this.no_button.Location = new System.Drawing.Point(280, 178);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(68, 55);
            this.no_button.TabIndex = 2;
            this.no_button.UseVisualStyleBackColor = false;
            this.no_button.Click += new System.EventHandler(this.no_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ok_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ok_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok_button.Image = ((System.Drawing.Image)(resources.GetObject("ok_button.Image")));
            this.ok_button.Location = new System.Drawing.Point(69, 178);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(64, 55);
            this.ok_button.TabIndex = 1;
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.AutoSize = true;
            this.message.Cursor = System.Windows.Forms.Cursors.No;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(37, 90);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 24);
            this.message.TabIndex = 0;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Confirm_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(419, 278);
            this.Controls.Add(this.no_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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