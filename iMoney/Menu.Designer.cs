namespace iMoney
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.income_button = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.expense_button = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.report_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.income_button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(567, 515);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // income_button
            // 
            this.income_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.income_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.income_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.income_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.income_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.income_button.FlatAppearance.BorderSize = 0;
            this.income_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_button.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_button.ForeColor = System.Drawing.Color.Gold;
            this.income_button.Location = new System.Drawing.Point(0, 0);
            this.income_button.Name = "income_button";
            this.income_button.Size = new System.Drawing.Size(136, 515);
            this.income_button.TabIndex = 1;
            this.income_button.Text = "Income";
            this.income_button.UseVisualStyleBackColor = true;
            this.income_button.Click += new System.EventHandler(this.income_button_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.expense_button);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(428, 515);
            this.splitContainer2.SplitterDistance = 141;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // expense_button
            // 
            this.expense_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.expense_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.expense_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.expense_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expense_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.expense_button.FlatAppearance.BorderSize = 0;
            this.expense_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_button.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_button.ForeColor = System.Drawing.Color.Gold;
            this.expense_button.Location = new System.Drawing.Point(0, 0);
            this.expense_button.Name = "expense_button";
            this.expense_button.Size = new System.Drawing.Size(141, 515);
            this.expense_button.TabIndex = 2;
            this.expense_button.Text = "Expense";
            this.expense_button.UseVisualStyleBackColor = true;
            this.expense_button.Click += new System.EventHandler(this.expense_button_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.report_button);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.logout_button);
            this.splitContainer3.Size = new System.Drawing.Size(284, 515);
            this.splitContainer3.SplitterDistance = 140;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // report_button
            // 
            this.report_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.report_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.report_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.report_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.report_button.FlatAppearance.BorderSize = 0;
            this.report_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report_button.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_button.ForeColor = System.Drawing.Color.Gold;
            this.report_button.Location = new System.Drawing.Point(0, 0);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(140, 515);
            this.report_button.TabIndex = 3;
            this.report_button.Text = "Report";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logout_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.logout_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logout_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.Gold;
            this.logout_button.Location = new System.Drawing.Point(0, 0);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(141, 515);
            this.logout_button.TabIndex = 4;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(567, 515);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button income_button;
        private System.Windows.Forms.Button expense_button;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button report_button;
        private System.Windows.Forms.Button logout_button;
    }
}