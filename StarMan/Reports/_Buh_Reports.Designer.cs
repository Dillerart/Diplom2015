namespace StarMan
{
    partial class _Buh_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Buh_Reports));
            this.DataTable5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersSSQl = new StarMan.UsersSSQl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.date_1 = new System.Windows.Forms.DateTimePicker();
            this.date_2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.DataTable5TableAdapter = new StarMan.UsersSSQlTableAdapters.DataTable5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersSSQl)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable5BindingSource
            // 
            this.DataTable5BindingSource.DataMember = "DataTable5";
            this.DataTable5BindingSource.DataSource = this.UsersSSQl;
            // 
            // UsersSSQl
            // 
            this.UsersSSQl.DataSetName = "UsersSSQl";
            this.UsersSSQl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Дата окончания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Дата начала:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StarMan.Reports.Buh_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(909, 589);
            this.reportViewer1.TabIndex = 20;
            // 
            // date_1
            // 
            this.date_1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.date_1.Location = new System.Drawing.Point(100, 7);
            this.date_1.Name = "date_1";
            this.date_1.Size = new System.Drawing.Size(175, 25);
            this.date_1.TabIndex = 19;
            // 
            // date_2
            // 
            this.date_2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.date_2.Location = new System.Drawing.Point(396, 7);
            this.date_2.Name = "date_2";
            this.date_2.Size = new System.Drawing.Size(200, 25);
            this.date_2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.button1.Location = new System.Drawing.Point(602, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataTable5TableAdapter
            // 
            this.DataTable5TableAdapter.ClearBeforeFill = true;
            // 
            // _Buh_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.date_1);
            this.Controls.Add(this.date_2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_Buh_Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выручка по бухгалтерам";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._Buh_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersSSQl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker date_1;
        private System.Windows.Forms.DateTimePicker date_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource DataTable5BindingSource;
        private UsersSSQl UsersSSQl;
        private UsersSSQlTableAdapters.DataTable5TableAdapter DataTable5TableAdapter;
    }
}