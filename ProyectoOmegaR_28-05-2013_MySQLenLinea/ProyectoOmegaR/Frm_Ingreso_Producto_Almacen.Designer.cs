namespace ProyectoOmegaR
{
    partial class Frm_Ingreso_Producto_Almacen
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
            this.lblstockactual = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // lblstockactual
            // 
            this.lblstockactual.AutoSize = true;
            this.lblstockactual.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblstockactual.ForeColor = System.Drawing.Color.White;
            this.lblstockactual.Location = new System.Drawing.Point(99, 167);
            this.lblstockactual.Name = "lblstockactual";
            this.lblstockactual.Size = new System.Drawing.Size(112, 25);
            this.lblstockactual.TabIndex = 60;
            this.lblstockactual.Text = "Stock Actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Cantidad:";
            // 
            // txt_cant
            // 
            this.txt_cant.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txt_cant.Location = new System.Drawing.Point(104, 116);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(49, 33);
            this.txt_cant.TabIndex = 58;
            // 
            // btn_limpiarIPA
            // 
            this.btn_limpiarIPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_limpiarIPA.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_limpiarIPA.ForeColor = System.Drawing.Color.White;
            this.btn_limpiarIPA.Location = new System.Drawing.Point(356, 167);
            this.btn_limpiarIPA.Name = "btn_limpiarIPA";
            this.btn_limpiarIPA.Size = new System.Drawing.Size(98, 36);
            this.btn_limpiarIPA.TabIndex = 57;
            this.btn_limpiarIPA.Text = "Limpiar";
            this.btn_limpiarIPA.UseVisualStyleBackColor = false;
            // 
            // btn_grabarIPA
            // 
            this.btn_grabarIPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_grabarIPA.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_grabarIPA.ForeColor = System.Drawing.Color.White;
            this.btn_grabarIPA.Location = new System.Drawing.Point(474, 167);
            this.btn_grabarIPA.Name = "btn_grabarIPA";
            this.btn_grabarIPA.Size = new System.Drawing.Size(98, 36);
            this.btn_grabarIPA.TabIndex = 56;
            this.btn_grabarIPA.Text = "Grabar";
            this.btn_grabarIPA.UseVisualStyleBackColor = false;
            // 
            // txt_nomprod
            // 
            this.txt_nomprod.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txt_nomprod.Location = new System.Drawing.Point(201, 68);
            this.txt_nomprod.Name = "txt_nomprod";
            this.txt_nomprod.Size = new System.Drawing.Size(89, 33);
            this.txt_nomprod.TabIndex = 55;
            // 
            // btn_buscarprod_IPA
            // 
            this.btn_buscarprod_IPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_buscarprod_IPA.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_buscarprod_IPA.ForeColor = System.Drawing.Color.White;
            this.btn_buscarprod_IPA.Location = new System.Drawing.Point(331, 69);
            this.btn_buscarprod_IPA.Name = "btn_buscarprod_IPA";
            this.btn_buscarprod_IPA.Size = new System.Drawing.Size(98, 36);
            this.btn_buscarprod_IPA.TabIndex = 54;
            this.btn_buscarprod_IPA.Text = "Buscar";
            this.btn_buscarprod_IPA.UseVisualStyleBackColor = false;
            // 
            // txt_codprod
            // 
            this.txt_codprod.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.txt_codprod.Location = new System.Drawing.Point(104, 67);
            this.txt_codprod.Name = "txt_codprod";
            this.txt_codprod.Size = new System.Drawing.Size(91, 33);
            this.txt_codprod.TabIndex = 53;
            // 
            // comboBox_almacen
            // 
            this.comboBox_almacen.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.comboBox_almacen.FormattingEnabled = true;
            this.comboBox_almacen.Location = new System.Drawing.Point(104, 16);
            this.comboBox_almacen.Name = "comboBox_almacen";
            this.comboBox_almacen.Size = new System.Drawing.Size(186, 33);
            this.comboBox_almacen.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Almacen:";
            // 
            // Frm_Ingreso_Producto_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(589, 216);
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
            this.Name = "Frm_Ingreso_Producto_Almacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso del Producto a Almacen";
            this.Load += new System.EventHandler(this.IngresoProductoAlmacen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstockactual;
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

    }
}