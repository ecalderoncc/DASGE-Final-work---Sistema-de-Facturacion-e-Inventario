namespace ProyectoOmegaR
{
    partial class IngresoProductoAlmacen
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.btn_limpiarIPA = new System.Windows.Forms.Button();
            this.btn_grabarIPA = new System.Windows.Forms.Button();
            this.txt_nomprod = new System.Windows.Forms.TextBox();
            this.btn_buscarprod_IPA = new System.Windows.Forms.Button();
            this.txt_codprod = new System.Windows.Forms.TextBox();
            this.comboBox_almacen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstockactual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cantidad:";
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(201, 208);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(49, 20);
            this.txt_cant.TabIndex = 25;
            // 
            // btn_limpiarIPA
            // 
            this.btn_limpiarIPA.Location = new System.Drawing.Point(430, 247);
            this.btn_limpiarIPA.Name = "btn_limpiarIPA";
            this.btn_limpiarIPA.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiarIPA.TabIndex = 24;
            this.btn_limpiarIPA.Text = "Limpiar";
            this.btn_limpiarIPA.UseVisualStyleBackColor = true;
            this.btn_limpiarIPA.Click += new System.EventHandler(this.btn_limpiarIPA_Click);
            // 
            // btn_grabarIPA
            // 
            this.btn_grabarIPA.Location = new System.Drawing.Point(511, 247);
            this.btn_grabarIPA.Name = "btn_grabarIPA";
            this.btn_grabarIPA.Size = new System.Drawing.Size(75, 23);
            this.btn_grabarIPA.TabIndex = 23;
            this.btn_grabarIPA.Text = "Grabar";
            this.btn_grabarIPA.UseVisualStyleBackColor = true;
            this.btn_grabarIPA.Click += new System.EventHandler(this.btn_grabarIPA_Click);
            // 
            // txt_nomprod
            // 
            this.txt_nomprod.Location = new System.Drawing.Point(298, 153);
            this.txt_nomprod.Name = "txt_nomprod";
            this.txt_nomprod.Size = new System.Drawing.Size(89, 20);
            this.txt_nomprod.TabIndex = 19;
            // 
            // btn_buscarprod_IPA
            // 
            this.btn_buscarprod_IPA.Location = new System.Drawing.Point(393, 151);
            this.btn_buscarprod_IPA.Name = "btn_buscarprod_IPA";
            this.btn_buscarprod_IPA.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarprod_IPA.TabIndex = 18;
            this.btn_buscarprod_IPA.Text = "Buscar";
            this.btn_buscarprod_IPA.UseVisualStyleBackColor = true;
            this.btn_buscarprod_IPA.Click += new System.EventHandler(this.btn_buscar_produc_IPA_Click);
            // 
            // txt_codprod
            // 
            this.txt_codprod.Location = new System.Drawing.Point(201, 153);
            this.txt_codprod.Name = "txt_codprod";
            this.txt_codprod.Size = new System.Drawing.Size(91, 20);
            this.txt_codprod.TabIndex = 17;
            this.txt_codprod.TextChanged += new System.EventHandler(this.txt_codprod_TextChanged);
            // 
            // comboBox_almacen
            // 
            this.comboBox_almacen.FormattingEnabled = true;
            this.comboBox_almacen.Location = new System.Drawing.Point(201, 119);
            this.comboBox_almacen.Name = "comboBox_almacen";
            this.comboBox_almacen.Size = new System.Drawing.Size(91, 21);
            this.comboBox_almacen.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Almacen:";
            // 
            // lblstockactual
            // 
            this.lblstockactual.AutoSize = true;
            this.lblstockactual.Location = new System.Drawing.Point(489, 156);
            this.lblstockactual.Name = "lblstockactual";
            this.lblstockactual.Size = new System.Drawing.Size(71, 13);
            this.lblstockactual.TabIndex = 27;
            this.lblstockactual.Text = "Stock Actual:";
            // 
            // IngresoProductoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 353);
            this.Controls.Add(this.lblstockactual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.btn_limpiarIPA);
            this.Controls.Add(this.btn_grabarIPA);
            this.Controls.Add(this.txt_nomprod);
            this.Controls.Add(this.btn_buscarprod_IPA);
            this.Controls.Add(this.txt_codprod);
            this.Controls.Add(this.comboBox_almacen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IngresoProductoAlmacen";
            this.Text = "IngresoProductoAlmacen";
            this.Load += new System.EventHandler(this.IngresoProductoAlmacen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.Button btn_limpiarIPA;
        private System.Windows.Forms.Button btn_grabarIPA;
        private System.Windows.Forms.TextBox txt_nomprod;
        private System.Windows.Forms.Button btn_buscarprod_IPA;
        private System.Windows.Forms.TextBox txt_codprod;
        private System.Windows.Forms.ComboBox comboBox_almacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstockactual;
    }
}