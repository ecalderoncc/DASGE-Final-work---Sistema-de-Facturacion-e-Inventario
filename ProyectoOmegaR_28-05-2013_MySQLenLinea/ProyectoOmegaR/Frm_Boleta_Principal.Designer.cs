namespace ProyectoOmegaR
{
    partial class Frm_Boleta_Principal
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
            this.txttot_boleta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.btnAgregarproducto = new System.Windows.Forms.Button();
            this.btnquitarprod = new System.Windows.Forms.Button();
            this.btnbuscarprod = new System.Windows.Forms.Button();
            this.DataGVProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregarcliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txttot_boleta
            // 
            this.txttot_boleta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttot_boleta.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttot_boleta.Location = new System.Drawing.Point(706, 505);
            this.txttot_boleta.Name = "txttot_boleta";
            this.txttot_boleta.Size = new System.Drawing.Size(132, 33);
            this.txttot_boleta.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(621, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 130;
            this.label2.Text = "TOTAL:";
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(107, 15);
            this.txtcod.Name = "txtcod";
            this.txtcod.ReadOnly = true;
            this.txtcod.Size = new System.Drawing.Size(139, 33);
            this.txtcod.TabIndex = 128;
            this.txtcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 25);
            this.label11.TabIndex = 129;
            this.label11.Text = "Codigo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(88, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 25);
            this.label10.TabIndex = 121;
            this.label10.Text = "RUC:";
            // 
            // txtRUC
            // 
            this.txtRUC.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.Location = new System.Drawing.Point(145, 180);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(220, 33);
            this.txtRUC.TabIndex = 116;
            this.txtRUC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRUC_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(594, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 120;
            // 
            // txtDir
            // 
            this.txtDir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDir.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.Location = new System.Drawing.Point(145, 135);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(631, 33);
            this.txtDir.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 110;
            this.label3.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 108;
            this.label1.Text = "Razon Social:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(751, 557);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 39);
            this.btnClear.TabIndex = 117;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Location = new System.Drawing.Point(859, 557);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(165, 39);
            this.btnGrabar.TabIndex = 119;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(664, 18);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(342, 33);
            this.txtfecha.TabIndex = 136;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(573, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 135;
            this.label7.Text = "Fecha:";
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnbuscarcliente.FlatAppearance.BorderSize = 0;
            this.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarcliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarcliente.ForeColor = System.Drawing.Color.White;
            this.btnbuscarcliente.Location = new System.Drawing.Point(714, 81);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(87, 39);
            this.btnbuscarcliente.TabIndex = 137;
            this.btnbuscarcliente.Text = "Buscar";
            this.btnbuscarcliente.UseVisualStyleBackColor = false;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // cmbcliente
            // 
            this.cmbcliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(145, 85);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(490, 33);
            this.cmbcliente.TabIndex = 138;
            this.cmbcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbcliente_KeyDown);
            // 
            // btnAgregarproducto
            // 
            this.btnAgregarproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAgregarproducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarproducto.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarproducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarproducto.Location = new System.Drawing.Point(937, 359);
            this.btnAgregarproducto.Name = "btnAgregarproducto";
            this.btnAgregarproducto.Size = new System.Drawing.Size(87, 39);
            this.btnAgregarproducto.TabIndex = 140;
            this.btnAgregarproducto.Text = "Agregar";
            this.btnAgregarproducto.UseVisualStyleBackColor = false;
            this.btnAgregarproducto.Click += new System.EventHandler(this.btnAgregarproducto_Click);
            // 
            // btnquitarprod
            // 
            this.btnquitarprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnquitarprod.FlatAppearance.BorderSize = 0;
            this.btnquitarprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitarprod.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitarprod.ForeColor = System.Drawing.Color.White;
            this.btnquitarprod.Location = new System.Drawing.Point(937, 437);
            this.btnquitarprod.Name = "btnquitarprod";
            this.btnquitarprod.Size = new System.Drawing.Size(87, 39);
            this.btnquitarprod.TabIndex = 141;
            this.btnquitarprod.Text = "Quitar";
            this.btnquitarprod.UseVisualStyleBackColor = false;
            this.btnquitarprod.Click += new System.EventHandler(this.btnquitarprod_Click);
            // 
            // btnbuscarprod
            // 
            this.btnbuscarprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnbuscarprod.FlatAppearance.BorderSize = 0;
            this.btnbuscarprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarprod.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarprod.ForeColor = System.Drawing.Color.White;
            this.btnbuscarprod.Location = new System.Drawing.Point(937, 282);
            this.btnbuscarprod.Name = "btnbuscarprod";
            this.btnbuscarprod.Size = new System.Drawing.Size(87, 39);
            this.btnbuscarprod.TabIndex = 142;
            this.btnbuscarprod.Text = "Buscar";
            this.btnbuscarprod.UseVisualStyleBackColor = false;
            this.btnbuscarprod.Click += new System.EventHandler(this.btnbuscarprod_Click);
            // 
            // DataGVProductos
            // 
            this.DataGVProductos.AllowUserToAddRows = false;
            this.DataGVProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cantidad,
            this.Nombre,
            this.Unidad,
            this.PrecioUnitario,
            this.Precio});
            this.DataGVProductos.Location = new System.Drawing.Point(190, 282);
            this.DataGVProductos.Name = "DataGVProductos";
            this.DataGVProductos.Size = new System.Drawing.Size(648, 217);
            this.DataGVProductos.TabIndex = 143;
            this.DataGVProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVProductos_CellContentClick);
            this.DataGVProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVProductos_CellEnter);
            this.DataGVProductos.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVProductos_CellLeave);
            this.DataGVProductos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGVProductos_EditingControlShowing);
            this.DataGVProductos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataGVProductos_KeyUp);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 65;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // btnagregarcliente
            // 
            this.btnagregarcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnagregarcliente.FlatAppearance.BorderSize = 0;
            this.btnagregarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarcliente.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarcliente.ForeColor = System.Drawing.Color.White;
            this.btnagregarcliente.Location = new System.Drawing.Point(655, 81);
            this.btnagregarcliente.Name = "btnagregarcliente";
            this.btnagregarcliente.Size = new System.Drawing.Size(50, 39);
            this.btnagregarcliente.TabIndex = 145;
            this.btnagregarcliente.Text = "+";
            this.btnagregarcliente.UseVisualStyleBackColor = false;
            this.btnagregarcliente.Click += new System.EventHandler(this.btnagregarcliente_Click);
            // 
            // Boleta_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1113, 658);
            this.Controls.Add(this.btnagregarcliente);
            this.Controls.Add(this.DataGVProductos);
            this.Controls.Add(this.btnbuscarprod);
            this.Controls.Add(this.btnquitarprod);
            this.Controls.Add(this.btnAgregarproducto);
            this.Controls.Add(this.cmbcliente);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttot_boleta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGrabar);
            this.Name = "Boleta_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleta Principal";
            this.Load += new System.EventHandler(this.BoletaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttot_boleta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.Button btnAgregarproducto;
        private System.Windows.Forms.Button btnquitarprod;
        private System.Windows.Forms.Button btnbuscarprod;
        private System.Windows.Forms.DataGridView DataGVProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnagregarcliente;
    }
}