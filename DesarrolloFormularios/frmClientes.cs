using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DesarrolloFormularios
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int CustomerID, CustomerPhone;

            string CustomerName, CustomerAddress, CustomerEmail;

            CustomerID = Convert.ToInt32(txtDocumentoCliente.Text);
            CustomerName = txtNombreCliente.Text;
            CustomerAddress = txtDireccionCliente.Text;
            CustomerPhone = Convert.ToInt32(txtTelefonoCliente.Text);
            CustomerEmail = txtEmailCliente.Text;


            SqlConnection connection;
            string connectionString = "Data Source= B6-501-22;Initial Catalog=miBaseDeDatos;Integrated Security=True;Encrypt=False;";
            string query = "SELECT * FROM Customers";

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("insert into Customers(CustomerID, CustomerName, CustomerAddress, CustomerPhone, CustomerEmail) " +
                    "VALUES(@CustomerID, @CustomerName, @CustomerAddress, @CustomerPhone, @CustomerEmail)", connection);
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                cmd.Parameters.AddWithValue("@CustomerPhone", CustomerPhone);
                cmd.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);


                cmd.ExecuteNonQuery();

                // SqlDataAdapter es útil para llenar DataSets o DataTables
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable clientesTable = new DataTable();
                    adapter.Fill(clientesTable);

                    // Asignar el DataTable como origen de datos del DataGridView
                    dgvClientes.DataSource = clientesTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDocumentoCliente.Clear();
            txtNombreCliente.Clear();
            txtDireccionCliente.Clear();
            txtTelefonoCliente.Clear();
            txtEmailCliente.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int CustomerID, CustomerPhone;

            string CustomerName, CustomerAddress, CustomerEmail;

            CustomerID = Convert.ToInt32(txtDocumentoCliente.Text);
            CustomerName = txtNombreCliente.Text;
            CustomerAddress = txtDireccionCliente.Text;
            CustomerPhone = Convert.ToInt32(txtTelefonoCliente.Text);
            CustomerEmail = txtEmailCliente.Text;

            string connectionString = "Data Source= B6-501-22;Initial Catalog=miBaseDeDatos;Integrated Security=True;Encrypt=False;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Customers SET CustomerName = @CustomerName, CustomerAddress = @CustomerAddress, CustomerPhone = @CustomerPhone," +
                        "CustomerEmail = @CustomerEmail WHERE CustomerID = @CustomerID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                        cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                        cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                        cmd.Parameters.AddWithValue("@CustomerPhone", CustomerPhone);
                        cmd.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para actualizar.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }
        }
    }
}
