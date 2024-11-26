using _231027.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231027.Views
{
    public partial class FrmProduto : Form
    {
        Categoria c;
        Marca m;
        Produto p;

        public FrmProduto()
        {
            InitializeComponent();
        }
        void limpaControles()
        {
            txtID.Clear();
            txtDescricao.Clear();
            cboCategoria.SelectedIndex = -1; ;
            cboMarca.SelectedIndex = -1;
            txtvalorVenda.Clear();
            txtEstoque.Clear();
            picFoto.ImageLocation = "";
        }
        void carregarGrid(string pesquisa)
        {
            p = new Produto()
            {
                descricao = pesquisa
            };
            dgvprodutos.DataSource = p.Consultar();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // Cria um objeto do tipo categoria e marca
            // E alimenta o comboBox
            c = new Categoria();
            cboCategoria.DataSource = c.Consultar();
            cboCategoria.DisplayMember = "categoria";
            cboCategoria.ValueMember = "id";

            m = new Marca();
            cboMarca.DataSource = m.Consultar();
            cboMarca.DisplayMember = "marca";
            cboMarca.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            // Deixa invisível colunas do Grid
            dgvprodutos.Columns["idCategoria"].Visible = false;
            dgvprodutos.Columns["idMarca"].Visible = false;
            dgvprodutos.Columns["foto"].Visible = false;
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCategoria.SelectedItem;
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMarca.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboMarca.SelectedItem;
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/foto/clientes/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void incluir_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "") return;

            p = new Produto()
            {
                descricao = txtDescricao.Text,
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                valorVenda = double.Parse(txtvalorVenda.Text),
                estoque = double.Parse(txtEstoque.Text),
                foto = picFoto.ImageLocation,
            };
            p.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void dgvprodutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvprodutos.RowCount > 0)
            {
                txtID.Text = dgvprodutos.CurrentRow.Cells["id"].Value.ToString();
                txtDescricao.Text = dgvprodutos.CurrentRow.Cells["descricao"].Value.ToString();
                cboCategoria.Text = dgvprodutos.CurrentRow.Cells["categoria"].Value.ToString();
                cboMarca.Text = dgvprodutos.CurrentRow.Cells["marca"].Value.ToString();
                txtvalorVenda.Text = dgvprodutos.CurrentRow.Cells["valorvenda"].Value.ToString();
                txtEstoque.Text = dgvprodutos.CurrentRow.Cells["estoque"].Value.ToString();
                picFoto.ImageLocation = dgvprodutos.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            p = new Produto()
            {
                id = int.Parse(txtID.Text),
                descricao = txtDescricao.Text,
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                valorVenda = double.Parse(txtvalorVenda.Text),
                estoque = double.Parse(txtEstoque.Text),
                foto = picFoto.ImageLocation,
            };
            p.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir o produto?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                p = new Produto()
                {
                    id = int.Parse(txtID.Text)
                };
                p.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }
    }
}
