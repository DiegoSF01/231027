using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _231027.Views;

namespace _231027
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cidadesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCidades form = new FrmCidades();
            form.Show();
        }

        private void marcaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmMarca form = new FrmMarca();
            form.Show();
        }

        private void categoriaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCategoria form = new FrmCategoria();
            form.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente form = new FrmCliente();
            form.Show();
        }
    }
}
