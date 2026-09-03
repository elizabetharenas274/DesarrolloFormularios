namespace DesarrolloFormularios
{
    partial class frmInformes
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            grbTipodeReporte = new GroupBox();
            rbtPantalla = new RadioButton();
            rbtPDF = new RadioButton();
            rbtExcel = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            grbTipodeReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.FlatStyle = FlatStyle.Flat;
            lblCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.MenuHighlight;
            lblCliente.Location = new Point(226, 39);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(348, 32);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "INFORMES DE FACTURACIÓN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 117);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 4;
            label1.Text = "SELECCIONE INFORME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 117);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "ORDENAR POR";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(523, 114);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(212, 23);
            comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 189);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 189);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 9;
            label4.Text = "Fecha final";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(193, 183);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(530, 183);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(121, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // grbTipodeReporte
            // 
            grbTipodeReporte.Controls.Add(rbtExcel);
            grbTipodeReporte.Controls.Add(rbtPDF);
            grbTipodeReporte.Controls.Add(rbtPantalla);
            grbTipodeReporte.Location = new Point(162, 233);
            grbTipodeReporte.Name = "grbTipodeReporte";
            grbTipodeReporte.Size = new Size(477, 66);
            grbTipodeReporte.TabIndex = 12;
            grbTipodeReporte.TabStop = false;
            // 
            // rbtPantalla
            // 
            rbtPantalla.AutoSize = true;
            rbtPantalla.Location = new Point(19, 25);
            rbtPantalla.Name = "rbtPantalla";
            rbtPantalla.Size = new Size(83, 19);
            rbtPantalla.TabIndex = 0;
            rbtPantalla.TabStop = true;
            rbtPantalla.Text = "En pantalla";
            rbtPantalla.UseVisualStyleBackColor = true;
            // 
            // rbtPDF
            // 
            rbtPDF.AutoSize = true;
            rbtPDF.Location = new Point(187, 25);
            rbtPDF.Name = "rbtPDF";
            rbtPDF.Size = new Size(46, 19);
            rbtPDF.TabIndex = 1;
            rbtPDF.TabStop = true;
            rbtPDF.Text = "PDF";
            rbtPDF.UseVisualStyleBackColor = true;
            // 
            // rbtExcel
            // 
            rbtExcel.AutoSize = true;
            rbtExcel.Location = new Point(347, 25);
            rbtExcel.Name = "rbtExcel";
            rbtExcel.Size = new Size(51, 19);
            rbtExcel.TabIndex = 2;
            rbtExcel.TabStop = true;
            rbtExcel.Text = "Excel";
            rbtExcel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(227, 342);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 13;
            button1.Text = "Generar informe";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(424, 342);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 14;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(113, 401);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(584, 150);
            dataGridView1.TabIndex = 15;
            // 
            // frmInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 581);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grbTipodeReporte);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCliente);
            Name = "frmInformes";
            Text = "frmInformes";
            grbTipodeReporte.ResumeLayout(false);
            grbTipodeReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private GroupBox grbTipodeReporte;
        private RadioButton rbtExcel;
        private RadioButton rbtPDF;
        private RadioButton rbtPantalla;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
    }
}