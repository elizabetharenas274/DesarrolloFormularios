namespace DesarrolloFormularios
{
    partial class frmFacturas
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
            label6 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            lblDescuento = new Label();
            lblTotaliva = new Label();
            lblTotalFactura = new Label();
            grbDetalleFactura = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            bntSalir = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.FlatStyle = FlatStyle.Flat;
            lblCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.MenuHighlight;
            lblCliente.Location = new Point(231, 49);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(392, 32);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "ADMINISTRACIÓN DE FACTURAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 124);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 3;
            label1.Text = "Número de factura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 157);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 194);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Empleado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 231);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Descuento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 270);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 7;
            label5.Text = "Total IVA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 309);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 8;
            label6.Text = "Total factura";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(306, 23);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(186, 191);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(306, 23);
            comboBox2.TabIndex = 11;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(186, 231);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(14, 15);
            lblDescuento.TabIndex = 12;
            lblDescuento.Text = "d";
            // 
            // lblTotaliva
            // 
            lblTotaliva.AutoSize = true;
            lblTotaliva.Location = new Point(186, 270);
            lblTotaliva.Name = "lblTotaliva";
            lblTotaliva.Size = new Size(10, 15);
            lblTotaliva.TabIndex = 13;
            lblTotaliva.Text = "i";
            // 
            // lblTotalFactura
            // 
            lblTotalFactura.AutoSize = true;
            lblTotalFactura.Location = new Point(186, 309);
            lblTotalFactura.Name = "lblTotalFactura";
            lblTotalFactura.Size = new Size(11, 15);
            lblTotalFactura.TabIndex = 14;
            lblTotalFactura.Text = "f";
            // 
            // grbDetalleFactura
            // 
            grbDetalleFactura.Location = new Point(47, 364);
            grbDetalleFactura.Name = "grbDetalleFactura";
            grbDetalleFactura.Size = new Size(743, 181);
            grbDetalleFactura.TabIndex = 15;
            grbDetalleFactura.TabStop = false;
            grbDetalleFactura.Text = "DETALLE FACTURAS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 157);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 16;
            label7.Text = "Fecha registro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(542, 201);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 17;
            label8.Text = "Estado factura";
            label8.Click += label8_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(659, 191);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(131, 23);
            comboBox3.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(659, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(131, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // bntSalir
            // 
            bntSalir.Location = new Point(691, 313);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(75, 23);
            bntSalir.TabIndex = 29;
            bntSalir.Text = "Salir";
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(581, 313);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 28;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(691, 266);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 27;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(581, 266);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 585);
            Controls.Add(bntSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(grbDetalleFactura);
            Controls.Add(lblTotalFactura);
            Controls.Add(lblTotaliva);
            Controls.Add(lblDescuento);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCliente);
            Name = "frmFacturas";
            Text = "frmFacturas";
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
        private Label label6;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label lblDescuento;
        private Label lblTotaliva;
        private Label lblTotalFactura;
        private GroupBox grbDetalleFactura;
        private Label label7;
        private Label label8;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private Button bntSalir;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnAgregar;
    }
}