namespace ProyectoOmegaR
{
    partial class TipodeCancelacion
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DetalleBoletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OmegaRDataSet = new ProyectoOmegaR.OmegaRDataSet();
            this.boletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetalleBoletaTableAdapter = new ProyectoOmegaR.OmegaRDataSetTableAdapters.DetalleBoletaTableAdapter();
            this.boletaTableAdapter = new ProyectoOmegaR.OmegaRDataSetTableAdapters.boletaTableAdapter();
            this.DatosClienteTableAdapter = new ProyectoOmegaR.OmegaRDataSetTableAdapters.DatosClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleBoletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OmegaRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataDetalleBoleta";
            reportDataSource1.Value = this.DetalleBoletaBindingSource;
            reportDataSource2.Name = "DataDatosCliente";
            reportDataSource2.Value = this.DatosClienteBindingSource;
            reportDataSource3.Name = "DataBoleta";
            reportDataSource3.Value = this.boletaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoOmegaR.Boleta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(739, 560);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtefectivo
            // 
            this.txtefectivo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtefectivo.Location = new System.Drawing.Point(65, 59);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(139, 33);
            this.txtefectivo.TabIndex = 1;
            this.txtefectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtefectivo_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(60, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 75;
            this.label11.Text = "Efectivo:";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(295, 59);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(139, 33);
            this.txttotal.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Total a Pagar:";
            // 
            // txtcambio
            // 
            this.txtcambio.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcambio.Location = new System.Drawing.Point(543, 59);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(139, 33);
            this.txtcambio.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(538, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 79;
            this.label2.Text = "Cambio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(239, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(475, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "=";
            // 
            // DetalleBoletaBindingSource
            // 
            this.DetalleBoletaBindingSource.DataMember = "DetalleBoleta";
            this.DetalleBoletaBindingSource.DataSource = this.OmegaRDataSet;
            // 
            // OmegaRDataSet
            // 
            this.OmegaRDataSet.DataSetName = "OmegaRDataSet";
            this.OmegaRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boletaBindingSource
            // 
            this.boletaBindingSource.DataMember = "boleta";
            this.boletaBindingSource.DataSource = this.OmegaRDataSet;
            // 
            // DatosClienteBindingSource
            // 
            this.DatosClienteBindingSource.DataMember = "DatosCliente";
            this.DatosClienteBindingSource.DataSource = this.OmegaRDataSet;
            // 
            // DetalleBoletaTableAdapter
            // 
            this.DetalleBoletaTableAdapter.ClearBeforeFill = true;
            // 
            // boletaTableAdapter
            // 
            this.boletaTableAdapter.ClearBeforeFill = true;
            // 
            // DatosClienteTableAdapter
            // 
            this.DatosClienteTableAdapter.ClearBeforeFill = true;
            // 
            // TipodeCancelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(759, 677);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TipodeCancelacion";
            this.Text = "TipodeCancelacion";
            this.Load += new System.EventHandler(this.TipodeCancelacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleBoletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OmegaRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DetalleBoletaBindingSource;
        private OmegaRDataSet OmegaRDataSet;
        private System.Windows.Forms.BindingSource boletaBindingSource;
        private System.Windows.Forms.BindingSource DatosClienteBindingSource;
        private OmegaRDataSetTableAdapters.DetalleBoletaTableAdapter DetalleBoletaTableAdapter;
        private OmegaRDataSetTableAdapters.boletaTableAdapter boletaTableAdapter;
        private OmegaRDataSetTableAdapters.DatosClienteTableAdapter DatosClienteTableAdapter;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}