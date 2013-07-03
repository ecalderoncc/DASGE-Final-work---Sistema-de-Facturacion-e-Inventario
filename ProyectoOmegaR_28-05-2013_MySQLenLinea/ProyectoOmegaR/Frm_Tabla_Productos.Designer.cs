namespace ProyectoOmegaR
{
    partial class Frm_Tabla_Productos
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
            this.grupo_cliente = new System.Windows.Forms.GroupBox();
            this.dataGrid_CLIENTES = new System.Windows.Forms.DataGrid();
            this.btn_selec_cli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_busqpro = new System.Windows.Forms.TextBox();
            this.cmb_busqtipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grupo_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // grupo_cliente
            // 
            this.grupo_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grupo_cliente.Controls.Add(this.dataGrid_CLIENTES);
            this.grupo_cliente.Controls.Add(this.btn_selec_cli);
            this.grupo_cliente.Controls.Add(this.label2);
            this.grupo_cliente.Controls.Add(this.txt_busqpro);
            this.grupo_cliente.Controls.Add(this.cmb_busqtipo);
            this.grupo_cliente.Controls.Add(this.label1);
            this.grupo_cliente.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo_cliente.ForeColor = System.Drawing.Color.White;
            this.grupo_cliente.Location = new System.Drawing.Point(6, 0);
            this.grupo_cliente.Name = "grupo_cliente";
            this.grupo_cliente.Size = new System.Drawing.Size(864, 457);
            this.grupo_cliente.TabIndex = 12;
            this.grupo_cliente.TabStop = false;
            this.grupo_cliente.Text = "Productos";
            // 
            // dataGrid_CLIENTES
            // 
            this.dataGrid_CLIENTES.AlternatingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGrid_CLIENTES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dataGrid_CLIENTES.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dataGrid_CLIENTES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_CLIENTES.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dataGrid_CLIENTES.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dataGrid_CLIENTES.DataMember = "";
            this.dataGrid_CLIENTES.FlatMode = true;
            this.dataGrid_CLIENTES.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.dataGrid_CLIENTES.ForeColor = System.Drawing.Color.White;
            this.dataGrid_CLIENTES.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dataGrid_CLIENTES.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid_CLIENTES.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dataGrid_CLIENTES.HeaderFont = new System.Drawing.Font("Segoe UI Light", 10F);
            this.dataGrid_CLIENTES.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_CLIENTES.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid_CLIENTES.Location = new System.Drawing.Point(29, 75);
            this.dataGrid_CLIENTES.Name = "dataGrid_CLIENTES";
            this.dataGrid_CLIENTES.ParentRowsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGrid_CLIENTES.ParentRowsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dataGrid_CLIENTES.ReadOnly = true;
            this.dataGrid_CLIENTES.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid_CLIENTES.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_CLIENTES.Size = new System.Drawing.Size(753, 335);
            this.dataGrid_CLIENTES.TabIndex = 14;
            this.dataGrid_CLIENTES.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid_CLIENTES_Navigate);
            // 
            // btn_selec_cli
            // 
            this.btn_selec_cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_selec_cli.FlatAppearance.BorderSize = 0;
            this.btn_selec_cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selec_cli.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selec_cli.ForeColor = System.Drawing.Color.White;
            this.btn_selec_cli.Location = new System.Drawing.Point(733, 416);
            this.btn_selec_cli.Name = "btn_selec_cli";
            this.btn_selec_cli.Size = new System.Drawing.Size(122, 32);
            this.btn_selec_cli.TabIndex = 13;
            this.btn_selec_cli.Text = "Seleccionar";
            this.btn_selec_cli.UseVisualStyleBackColor = false;
            this.btn_selec_cli.Click += new System.EventHandler(this.btn_selec_cli_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(329, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cadena a buscar:";
            // 
            // txt_busqpro
            // 
            this.txt_busqpro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_busqpro.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqpro.Location = new System.Drawing.Point(488, 26);
            this.txt_busqpro.Name = "txt_busqpro";
            this.txt_busqpro.Size = new System.Drawing.Size(173, 33);
            this.txt_busqpro.TabIndex = 11;
            this.txt_busqpro.TextChanged += new System.EventHandler(this.txt_busqpro_TextChanged);
            // 
            // cmb_busqtipo
            // 
            this.cmb_busqtipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Nombre",
            "Apellido",
            "Direccion",
            "Distrito",
            "Localidad",
            "Telefono",
            "RUC",
            "DNI",
            "Activos"});
            this.cmb_busqtipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_busqtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_busqtipo.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_busqtipo.FormattingEnabled = true;
            this.cmb_busqtipo.Items.AddRange(new object[] {
            "Nombre",
            "Unidad",
            "Costo",
            "Precio"});
            this.cmb_busqtipo.Location = new System.Drawing.Point(135, 26);
            this.cmb_busqtipo.Name = "cmb_busqtipo";
            this.cmb_busqtipo.Size = new System.Drawing.Size(183, 33);
            this.cmb_busqtipo.TabIndex = 10;
            this.cmb_busqtipo.SelectedIndexChanged += new System.EventHandler(this.cmb_busqtipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar por:";
            // 
            // Frm_Tabla_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 456);
            this.Controls.Add(this.grupo_cliente);
            this.Name = "Frm_Tabla_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla Productos";
            this.Load += new System.EventHandler(this.TablaProductos_Load);
            this.grupo_cliente.ResumeLayout(false);
            this.grupo_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CLIENTES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo_cliente;
        private System.Windows.Forms.Button btn_selec_cli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busqpro;
        private System.Windows.Forms.ComboBox cmb_busqtipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dataGrid_CLIENTES;

    }
}