namespace DesarrolloFormularios
{
    partial class frmSeguridad
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
            bntSalir = new Button();
            btnActualizar = new Button();
            lblNombreCategoria = new Label();
            lblCategorias = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            SuspendLayout();
            // 
            // bntSalir
            // 
            bntSalir.Location = new Point(407, 321);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(75, 23);
            bntSalir.TabIndex = 41;
            bntSalir.Text = "Salir";
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(257, 321);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 39;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new Point(136, 122);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(60, 15);
            lblNombreCategoria.TabIndex = 36;
            lblNombreCategoria.Text = "Empleado";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.FlatStyle = FlatStyle.Flat;
            lblCategorias.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategorias.ForeColor = SystemColors.MenuHighlight;
            lblCategorias.Location = new Point(81, 40);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(548, 32);
            lblCategorias.TabIndex = 35;
            lblCategorias.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(229, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(340, 23);
            comboBox1.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 184);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 44;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 242);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 45;
            label2.Text = "Clave";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(229, 181);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(301, 23);
            txtUsuario.TabIndex = 46;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(229, 234);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(301, 23);
            txtClave.TabIndex = 47;
            // 
            // frmSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 450);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(bntSalir);
            Controls.Add(btnActualizar);
            Controls.Add(lblNombreCategoria);
            Controls.Add(lblCategorias);
            Name = "frmSeguridad";
            Text = "frmSeguridad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntSalir;
        private Button btnActualizar;
        private Label lblNombreCategoria;
        private Label lblCategorias;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtClave;
    }
}