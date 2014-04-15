namespace iMoney
{
    partial class expense_screen
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
            this.label4 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.save_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amount_picker = new System.Windows.Forms.NumericUpDown();
            this.monthly_reportDBDataSet = new iMoney.monthly_reportDBDataSet();
            this.monthlyDB_ExBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyDB_ExTableAdapter = new iMoney.monthly_reportDBDataSetTableAdapters.monthlyDB_ExTableAdapter();
            this.tableAdapterManager = new iMoney.monthly_reportDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.amount_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_reportDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDB_ExBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 47;
            this.label4.Text = "Expense";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.Gold;
            this.exit_button.Location = new System.Drawing.Point(256, 346);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(140, 126);
            this.exit_button.TabIndex = 42;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // save_date
            // 
            this.save_date.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.save_date.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.save_date.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.save_date.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDark;
            this.save_date.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.save_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.save_date.Location = new System.Drawing.Point(262, 247);
            this.save_date.Name = "save_date";
            this.save_date.Size = new System.Drawing.Size(107, 20);
            this.save_date.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Date";
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.Gold;
            this.save_button.Location = new System.Drawing.Point(69, 346);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(140, 126);
            this.save_button.TabIndex = 41;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Amount";
            // 
            // amount_picker
            // 
            this.amount_picker.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.amount_picker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amount_picker.DecimalPlaces = 2;
            this.amount_picker.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_picker.ForeColor = System.Drawing.Color.Gold;
            this.amount_picker.Location = new System.Drawing.Point(262, 124);
            this.amount_picker.Margin = new System.Windows.Forms.Padding(0);
            this.amount_picker.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.amount_picker.Name = "amount_picker";
            this.amount_picker.Size = new System.Drawing.Size(106, 27);
            this.amount_picker.TabIndex = 39;
            this.amount_picker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount_picker.ThousandsSeparator = true;
            // 
            // monthly_reportDBDataSet
            // 
            this.monthly_reportDBDataSet.DataSetName = "monthly_reportDBDataSet";
            this.monthly_reportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthlyDB_ExBindingSource
            // 
            this.monthlyDB_ExBindingSource.DataMember = "monthlyDB_Ex";
            this.monthlyDB_ExBindingSource.DataSource = this.monthly_reportDBDataSet;
            // 
            // monthlyDB_ExTableAdapter
            // 
            this.monthlyDB_ExTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.monthlyDB_ExTableAdapter = this.monthlyDB_ExTableAdapter;
            this.tableAdapterManager.monthlyDB_InTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iMoney.monthly_reportDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // expense_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.save_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.amount_picker);
            this.Name = "expense_screen";
            this.Text = "expense_screen";
            this.Load += new System.EventHandler(this.expense_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amount_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_reportDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDB_ExBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.DateTimePicker save_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown amount_picker;
        private monthly_reportDBDataSet monthly_reportDBDataSet;
        private System.Windows.Forms.BindingSource monthlyDB_ExBindingSource;
        private monthly_reportDBDataSetTableAdapters.monthlyDB_ExTableAdapter monthlyDB_ExTableAdapter;
        private monthly_reportDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}