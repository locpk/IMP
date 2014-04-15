namespace iMoney
{
    partial class report_screen
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.monthlyDB_InBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthly_reportDBDataSet = new iMoney.monthly_reportDBDataSet();
            this.monthlyDB_ExBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyDBInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyDBExBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyDB_InTableAdapter = new iMoney.monthly_reportDBDataSetTableAdapters.monthlyDB_InTableAdapter();
            this.monthlyDB_ExTableAdapter = new iMoney.monthly_reportDBDataSetTableAdapters.monthlyDB_ExTableAdapter();
            this.exit_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDB_InBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_reportDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDB_ExBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDBInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDBExBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthlyDB_InBindingSource
            // 
            this.monthlyDB_InBindingSource.DataMember = "monthlyDB_In";
            this.monthlyDB_InBindingSource.DataSource = this.monthly_reportDBDataSet;
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
            // monthlyDBInBindingSource
            // 
            this.monthlyDBInBindingSource.DataMember = "monthlyDB_In";
            this.monthlyDBInBindingSource.DataSource = this.monthly_reportDBDataSet;
            // 
            // monthlyDBExBindingSource
            // 
            this.monthlyDBExBindingSource.DataMember = "monthlyDB_Ex";
            this.monthlyDBExBindingSource.DataSource = this.monthly_reportDBDataSet;
            // 
            // monthlyDB_InTableAdapter
            // 
            this.monthlyDB_InTableAdapter.ClearBeforeFill = true;
            // 
            // monthlyDB_ExTableAdapter
            // 
            this.monthlyDB_ExTableAdapter.ClearBeforeFill = true;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.Gold;
            this.exit_button.Location = new System.Drawing.Point(730, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(144, 48);
            this.exit_button.TabIndex = 38;
            this.exit_button.Text = "Return";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 36);
            this.label4.TabIndex = 48;
            this.label4.Text = "Report";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "Income";
            reportDataSource1.Value = this.monthlyDB_InBindingSource;
            reportDataSource2.Name = "Expense";
            reportDataSource2.Value = this.monthlyDB_ExBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iMoney.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(881, 830);
            this.reportViewer1.TabIndex = 0;
            // 
            // report_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.exit_button;
            this.ClientSize = new System.Drawing.Size(886, 981);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_screen";
            this.Text = "report_screen";
            this.Load += new System.EventHandler(this.report_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDB_InBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_reportDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDB_ExBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDBInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDBExBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label4;
        private monthly_reportDBDataSet monthly_reportDBDataSet;
        private System.Windows.Forms.BindingSource monthlyDBInBindingSource;
        private monthly_reportDBDataSetTableAdapters.monthlyDB_InTableAdapter monthlyDB_InTableAdapter;
        private System.Windows.Forms.BindingSource monthlyDBExBindingSource;
        private monthly_reportDBDataSetTableAdapters.monthlyDB_ExTableAdapter monthlyDB_ExTableAdapter;
        private System.Windows.Forms.BindingSource monthlyDB_InBindingSource;
        private System.Windows.Forms.BindingSource monthlyDB_ExBindingSource;
        
    }
}