namespace DesarrolloFormularios
{
    partial class frmProductos
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
            lblCliente = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            lblCategoria = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            bntSalir = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.FlatStyle = FlatStyle.Flat;
            lblCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.MenuHighlight;
            lblCliente.Location = new Point(208, 44);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(415, 32);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 121);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 168);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "Código referencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 209);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 258);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 298);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 6;
            label5.Text = "Cantidad en stock";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(175, 118);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(218, 23);
            txtNombreProducto.TabIndex = 7;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(175, 165);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(218, 23);
            txtCodigoProducto.TabIndex = 8;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(175, 206);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(218, 23);
            txtPrecioCompra.TabIndex = 9;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(175, 255);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(218, 23);
            txtPrecioVenta.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(175, 295);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(218, 23);
            txtStock.TabIndex = 11;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(448, 121);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(60, 15);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "Categoría";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(534, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 23);
            comboBox1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 168);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 14;
            label7.Text = "Ruta Imagen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(448, 214);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 15;
            label6.Text = "Detalles producto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(448, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(304, 150);
            dataGridView1.TabIndex = 16;
            // 
            // bntSalir
            // 
            bntSalir.Location = new Point(318, 382);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(75, 23);
            bntSalir.TabIndex = 21;
            bntSalir.Text = "Salir";
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(221, 382);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(127, 382);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(33, 382);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(lblCategoria);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtCodigoProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCliente);
            Name = "frmProductos";
            Text = "frmProductos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreProducto;
        private TextBox txtCodigoProducto;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private Label lblCategoria;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private DataGridView dataGridView1;
        private Button bntSalir;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnAgregar;
    }
}