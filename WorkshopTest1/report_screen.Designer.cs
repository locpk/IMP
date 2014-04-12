namespace WorkshopTest1
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
            this.TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exit_button = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.monthly_reportDBDataSet = new WorkshopTest1.monthly_reportDBDataSet();
            this.monthlyDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyDBTableAdapter = new WorkshopTest1.monthly_reportDBDataSetTableAdapters.monthlyDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_reportDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.Gold;
            this.exit_button.Location = new System.Drawing.Point(251, 712);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(103, 48);
            this.exit_button.TabIndex = 38;
            this.exit_button.Text = "Return";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ControlDark;
            reportDataSource1.Name = "report";
            reportDataSource1.Value = this.monthlyDBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WorkshopTest1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(590, 675);
            this.reportViewer1.TabIndex = 0;
            // 
            // monthly_reportDBDataSet
            // 
            this.monthly_reportDBDataSet.DataSetName = "monthly_reportDBDataSet";
            this.monthly_reportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthlyDBBindingSource
            // 
            this.monthlyDBBindingSource.DataMember = "monthlyDB";
            this.monthlyDBBindingSource.DataSource = this.monthly_reportDBDataSet;
            // 
            // monthlyDBTableAdapter
            // 
            this.monthlyDBTableAdapter.ClearBeforeFill = true;
            // 
            // report_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 788);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_screen";
            this.Text = "report_screen";
            this.Load += new System.EventHandler(this.report_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_reportDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.BindingSource TableBindingSource;
        private System.Windows.Forms.BindingSource monthlyDBBindingSource;
        private monthly_reportDBDataSet monthly_reportDBDataSet;
        private monthly_reportDBDataSetTableAdapters.monthlyDBTableAdapter monthlyDBTableAdapter;
        
    }
}