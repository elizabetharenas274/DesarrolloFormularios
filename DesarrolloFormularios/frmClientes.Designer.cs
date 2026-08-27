namespace DesarrolloFormularios
{
    partial class frmClientes
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
            txtNombreCliente = new TextBox();
            txtDocumentoCliente = new TextBox();
            txtDireccionCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtEmailCliente = new TextBox();
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            bntSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.FlatStyle = FlatStyle.Flat;
            lblCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.MenuHighlight;
            lblCliente.Location = new Point(242, 39);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(320, 32);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "NUEVO REGISTRO CLIENTE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(81, 104);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(81, 140);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(81, 178);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(81, 215);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "Teléfono";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(81, 258);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(199, 103);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(474, 23);
            txtNombreCliente.TabIndex = 6;
            // 
            // txtDocumentoCliente
            // 
            txtDocumentoCliente.Location = new Point(199, 139);
            txtDocumentoCliente.Name = "txtDocumentoCliente";
            txtDocumentoCliente.Size = new Size(474, 23);
            txtDocumentoCliente.TabIndex = 7;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Location = new Point(199, 177);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(474, 23);
            txtDireccionCliente.TabIndex = 8;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(199, 214);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(474, 23);
            txtTelefonoCliente.TabIndex = 9;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(199, 257);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(474, 23);
            txtEmailCliente.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 348);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(592, 154);
            dataGridView1.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(199, 303);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(293, 303);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(394, 303);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(496, 303);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // bntSalir
            // 
            bntSalir.Location = new Point(598, 303);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(75, 23);
            bntSalir.TabIndex = 16;
            bntSalir.Text = "Salir";
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 539);
            Controls.Add(bntSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
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
            Name = "frmClientes";
            Text = "frmClientes";
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
        private TextBox txtNombreCliente;
        private TextBox txtDocumentoCliente;
        private TextBox txtDireccionCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtEmailCliente;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button bntSalir;
    }
}