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
            this.monthly_DS = new WorkshopTest1.monthly_DS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.exit_button = new System.Windows.Forms.Button();
            this.TableTableAdapter = new WorkshopTest1.monthly_DSTableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_DS)).BeginInit();
            this.SuspendLayout();
            // 
            // TableBindingSource
            // 
            this.TableBindingSource.DataMember = "Table";
            this.TableBindingSource.DataSource = this.monthly_DS;
            // 
            // monthly_DS
            // 
            this.monthly_DS.DataSetName = "monthly_DS";
            this.monthly_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ControlDark;
            reportDataSource1.Name = "report_set";
            reportDataSource1.Value = this.TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WorkshopTest1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(688, 623);
            this.reportViewer1.TabIndex = 0;
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
            this.exit_button.Location = new System.Drawing.Point(293, 657);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(120, 44);
            this.exit_button.TabIndex = 38;
            this.exit_button.Text = "Return";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // TableTableAdapter
            // 
            this.TableTableAdapter.ClearBeforeFill = true;
            // 
            // report_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 727);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report_screen";
            this.Text = "report_screen";
            this.Load += new System.EventHandler(this.report_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.BindingSource TableBindingSource;
        private monthly_DS monthly_DS;
        private monthly_DSTableAdapters.TableTableAdapter TableTableAdapter;
    }
}