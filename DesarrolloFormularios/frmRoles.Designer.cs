namespace DesarrolloFormularios
{
    partial class frmRoles
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
            dataGridView1 = new DataGridView();
            bntSalir = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            textBox1 = new TextBox();
            lblNombreCategoria = new Label();
            lblCategorias = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(184, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(433, 150);
            dataGridView1.TabIndex = 34;
            // 
            // bntSalir
            // 
            bntSalir.Location = new Point(499, 191);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(75, 23);
            bntSalir.TabIndex = 33;
            bntSalir.Text = "Salir";
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(402, 191);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(308, 191);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 31;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(214, 191);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 29;
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new Point(184, 131);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(105, 15);
            lblNombreCategoria.TabIndex = 28;
            lblNombreCategoria.Text = "Nombre Categoría";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.FlatStyle = FlatStyle.Flat;
            lblCategorias.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategorias.ForeColor = SystemColors.MenuHighlight;
            lblCategorias.Location = new Point(236, 45);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(273, 32);
            lblCategorias.TabIndex = 27;
            lblCategorias.Text = "ROLES DE EMPLEADOS";
            // 
            // frmRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(bntSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(textBox1);
            Controls.Add(lblNombreCategoria);
            Controls.Add(lblCategorias);
            Name = "frmRoles";
            Text = "frmRoles";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button bntSalir;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnAgregar;
        private TextBox textBox1;
        private Label lblNombreCategoria;
        private Label lblCategorias;
    }
}