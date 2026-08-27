namespace DesarrolloFormularios
{
    partial class frmEmpleados
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
            bntSalir = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            txtEmailCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtDocumentoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.FlatStyle = FlatStyle.Flat;
            lblCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.MenuHighlight;
            lblCliente.Location = new Point(205, 44);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(414, 32);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // bntSalir
            // 
            bntSalir.Location = new Point(612, 278);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(75, 23);
            bntSalir.TabIndex = 32;
            bntSalir.Text = "Salir";
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(531, 278);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 29;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(447, 278);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 338);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(592, 171);
            dataGridView1.TabIndex = 27;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(213, 264);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(206, 23);
            txtEmailCliente.TabIndex = 26;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(213, 221);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(206, 23);
            txtTelefonoCliente.TabIndex = 25;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Location = new Point(213, 184);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(206, 23);
            txtDireccionCliente.TabIndex = 24;
            // 
            // txtDocumentoCliente
            // 
            txtDocumentoCliente.Location = new Point(213, 146);
            txtDocumentoCliente.Name = "txtDocumentoCliente";
            txtDocumentoCliente.Size = new Size(206, 23);
            txtDocumentoCliente.TabIndex = 23;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(213, 110);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(474, 23);
            txtNombreCliente.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(95, 265);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 21;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(95, 222);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 20;
            label4.Text = "Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(95, 185);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 19;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(95, 147);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 18;
            label2.Text = "Documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(95, 111);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 17;
            label1.Text = "Nombre empleado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(447, 149);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 33;
            label6.Text = "Rol";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(447, 187);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 35;
            label7.Text = "F. Ingreso";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(447, 229);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 36;
            label8.Text = "F. Retiro";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(520, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 23);
            dateTimePicker1.TabIndex = 37;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(520, 223);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(167, 23);
            dateTimePicker2.TabIndex = 38;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(520, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 23);
            comboBox1.TabIndex = 39;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(bntSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtDireccionCliente);
            Controls.Add(txtDocumentoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCliente);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Button bntSalir;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private TextBox txtEmailCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtDocumentoCliente;
        private TextBox txtNombreCliente;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
    }
}