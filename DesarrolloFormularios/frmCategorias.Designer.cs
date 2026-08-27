namespace DesarrolloFormularios
{
    partial class frmCategorias
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
            lblCategorias = new Label();
            lblNombreCategoria = new Label();
            textBox1 = new TextBox();
            bntSalir = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.FlatStyle = FlatStyle.Flat;
            lblCategorias.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategorias.ForeColor = SystemColors.MenuHighlight;
            lblCategorias.Location = new Point(102, 42);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(335, 32);
            lblCategorias.TabIndex = 2;
            lblCategorias.Text = "CATEGORÍA DE PRODUCTOS";
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Location = new Point(50, 128);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(105, 15);
            lblNombreCategoria.TabIndex = 3;
            lblNombreCategoria.Text = "Nombre Categoría";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 4;
            // 
            // bntSalir
            // 
            bntSalir.Location = new Point(365, 188);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(75, 23);
            bntSalir.TabIndex = 25;
            bntSalir.Text = "Salir";
            bntSalir.UseVisualStyleBackColor = true;
            bntSalir.Click += bntSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(268, 188);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(174, 188);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(80, 188);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(433, 150);
            dataGridView1.TabIndex = 26;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(dataGridView1);
            Controls.Add(bntSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(textBox1);
            Controls.Add(lblNombreCategoria);
            Controls.Add(lblCategorias);
            Name = "frmCategorias";
            Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategorias;
        private Label lblNombreCategoria;
        private TextBox textBox1;
        private Button bntSalir;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
    }
}