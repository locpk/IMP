﻿namespace iMoney
{
    partial class income_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(income_screen));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.exit_button = new System.Windows.Forms.Button();
            this.save_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amount_picker = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.monthly_reportDBDataSet = new iMoney.monthly_reportDBDataSet();
            this.monthlyDB_InBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyDB_InTableAdapter = new iMoney.monthly_reportDBDataSetTableAdapters.monthlyDB_InTableAdapter();
            this.tableAdapterManager = new iMoney.monthly_reportDBDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.remark_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.amount_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_reportDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDB_InBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(568, 521);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.Gold;
            this.exit_button.Location = new System.Drawing.Point(256, 346);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(140, 126);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Return";
            this.exit_button.UseVisualStyleBackColor = false;
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
            this.save_date.Location = new System.Drawing.Point(256, 131);
            this.save_date.Name = "save_date";
            this.save_date.Size = new System.Drawing.Size(107, 20);
            this.save_date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Date";
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.Gold;
            this.save_button.Location = new System.Drawing.Point(69, 346);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(140, 126);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Amount";
            // 
            // amount_picker
            // 
            this.amount_picker.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.amount_picker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amount_picker.DecimalPlaces = 2;
            this.amount_picker.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_picker.ForeColor = System.Drawing.Color.Gold;
            this.amount_picker.Location = new System.Drawing.Point(256, 69);
            this.amount_picker.Margin = new System.Windows.Forms.Padding(0);
            this.amount_picker.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.amount_picker.Name = "amount_picker";
            this.amount_picker.Size = new System.Drawing.Size(106, 27);
            this.amount_picker.TabIndex = 1;
            this.amount_picker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount_picker.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 36);
            this.label4.TabIndex = 38;
            this.label4.Text = "Income";
            // 
            // monthly_reportDBDataSet
            // 
            this.monthly_reportDBDataSet.DataSetName = "monthly_reportDBDataSet";
            this.monthly_reportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthlyDB_InBindingSource
            // 
            this.monthlyDB_InBindingSource.DataMember = "monthlyDB_In";
            this.monthlyDB_InBindingSource.DataSource = this.monthly_reportDBDataSet;
            // 
            // monthlyDB_InTableAdapter
            // 
            this.monthlyDB_InTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.monthlyDB_InTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iMoney.monthly_reportDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Remark";
            // 
            // remark_box
            // 
            this.remark_box.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.remark_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remark_box.ForeColor = System.Drawing.Color.Gold;
            this.remark_box.Location = new System.Drawing.Point(172, 184);
            this.remark_box.Multiline = true;
            this.remark_box.Name = "remark_box";
            this.remark_box.Size = new System.Drawing.Size(212, 115);
            this.remark_box.TabIndex = 40;
            // 
            // income_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 539);
            this.Controls.Add(this.remark_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.save_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.amount_picker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "income_screen";
            this.Text = "income_screen";
            this.Load += new System.EventHandler(this.income_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amount_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_reportDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDB_InBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.DateTimePicker save_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown amount_picker;
        private System.Windows.Forms.Label label4;
        private monthly_reportDBDataSet monthly_reportDBDataSet;
        private System.Windows.Forms.BindingSource monthlyDB_InBindingSource;
        private monthly_reportDBDataSetTableAdapters.monthlyDB_InTableAdapter monthlyDB_InTableAdapter;
        private monthly_reportDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox remark_box;
        
    }
}