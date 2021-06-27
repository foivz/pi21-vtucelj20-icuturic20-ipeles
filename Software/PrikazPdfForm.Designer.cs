
namespace Projekt
{
    partial class PrikazPdfForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikazPdfForm));
            this.dan_odgovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izabraoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pitanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cjelinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ispitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SlanjeRezultataViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pdfReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dan_odgovorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izabraoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjelinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlanjeRezultataViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dan_odgovorBindingSource
            // 
            this.dan_odgovorBindingSource.DataSource = typeof(Projekt.Entities.dan_odgovor);
            // 
            // izabraoBindingSource
            // 
            this.izabraoBindingSource.DataSource = typeof(Projekt.Entities.izabrao);
            // 
            // pitanjeBindingSource
            // 
            this.pitanjeBindingSource.DataSource = typeof(Projekt.Entities.pitanje);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(Projekt.Entities.korisnik);
            // 
            // cjelinaBindingSource
            // 
            this.cjelinaBindingSource.DataSource = typeof(Projekt.Entities.cjelina);
            // 
            // ispitBindingSource
            // 
            this.ispitBindingSource.DataSource = typeof(Projekt.Entities.ispit);
            // 
            // SlanjeRezultataViewBindingSource
            // 
            this.SlanjeRezultataViewBindingSource.DataSource = typeof(Projekt.Repozitorij.SlanjeRezultataView);
            // 
            // pdfReportViewer
            // 
            this.pdfReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfReportViewer.DocumentMapWidth = 94;
            reportDataSource1.Name = "DaniOdgovori";
            reportDataSource1.Value = this.dan_odgovorBindingSource;
            reportDataSource2.Name = "IzabraoDS";
            reportDataSource2.Value = this.izabraoBindingSource;
            reportDataSource3.Name = "PitanjeDS";
            reportDataSource3.Value = this.pitanjeBindingSource;
            reportDataSource4.Name = "KorisnikDS";
            reportDataSource4.Value = this.korisnikBindingSource;
            reportDataSource5.Name = "CjelinaDS";
            reportDataSource5.Value = this.cjelinaBindingSource;
            reportDataSource6.Name = "IspitDS";
            reportDataSource6.Value = this.ispitBindingSource;
            reportDataSource7.Name = "PitanjeOdgovor";
            reportDataSource7.Value = this.SlanjeRezultataViewBindingSource;
            this.pdfReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.pdfReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.pdfReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.pdfReportViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.pdfReportViewer.LocalReport.DataSources.Add(reportDataSource5);
            this.pdfReportViewer.LocalReport.DataSources.Add(reportDataSource6);
            this.pdfReportViewer.LocalReport.DataSources.Add(reportDataSource7);
            this.pdfReportViewer.LocalReport.ReportEmbeddedResource = "Projekt.PdfSPitanjimaIRezultatom.rdlc";
            this.pdfReportViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfReportViewer.Name = "pdfReportViewer";
            this.pdfReportViewer.ServerReport.BearerToken = null;
            this.pdfReportViewer.Size = new System.Drawing.Size(739, 359);
            this.pdfReportViewer.TabIndex = 0;
            this.pdfReportViewer.Load += new System.EventHandler(this.pdfReportViewer_Load);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(602, 367);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(115, 27);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Završi";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // PrikazPdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 402);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pdfReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrikazPdfForm";
            this.Text = "Pdf";
            this.Load += new System.EventHandler(this.PrikazPdfForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dan_odgovorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izabraoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjelinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ispitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlanjeRezultataViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer pdfReportViewer;
        private System.Windows.Forms.BindingSource dan_odgovorBindingSource;
        private System.Windows.Forms.BindingSource izabraoBindingSource;
        private System.Windows.Forms.BindingSource pitanjeBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource cjelinaBindingSource;
        private System.Windows.Forms.BindingSource ispitBindingSource;
        private System.Windows.Forms.BindingSource SlanjeRezultataViewBindingSource;
        private System.Windows.Forms.Button okButton;
    }
}