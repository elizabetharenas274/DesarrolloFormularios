namespace DesarrolloFormularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.MdiParent = this;
            productos.Show();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.MdiParent = this;
            categorias.Show();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            ayuda.MdiParent = this;
            ayuda.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercade acercade = new frmAcercade();
            acercade.MdiParent = this;
            acercade.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas facturas = new frmFacturas();
            facturas.MdiParent = this;
            facturas.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformes informes = new frmInformes();
            informes.MdiParent = this;
            informes.Show();
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSeguridad seguridad = new frmSeguridad();
            seguridad.MdiParent = this;
            seguridad.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles roles = new frmRoles();
            roles.MdiParent = this;
            roles.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.MdiParent = this;
            empleados.Show();
        }
    }
}
