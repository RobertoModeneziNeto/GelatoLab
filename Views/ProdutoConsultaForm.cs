using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GelatoLab.Models;
using GelatoLab.Controllers;

namespace GelatoLab.Views
{
    public partial class ProdutoConsultaForm : Form
    {
        ProdutosController produtoController = new ProdutosController();
        public ProdutoConsultaForm()
        {
            InitializeComponent();
            CarregarGrid();
        }

        // ============================================================
        // CARREGAR GRID
        // ============================================================
        private void CarregarGrid()
        {
            ProdutosCollection lista = produtoController.GetAll();
            dgvProdutos.DataSource = lista;

            // Renomear colunas
            dgvProdutos.Columns["IdProduto"].HeaderText = "ID";
            dgvProdutos.Columns["Nome"].HeaderText = "Produto";
            dgvProdutos.Columns["Quantidade"].HeaderText = "Qtd";
            dgvProdutos.Columns["Preco"].HeaderText = "Preço";
            dgvProdutos.Columns["codBarras"].HeaderText = "Código de Barras";
            dgvProdutos.Columns["TipoUnidade"].HeaderText = "Unidade";

            // Ocultar objetos Categoria e Fornecedor
            dgvProdutos.Columns["Categoria"].Visible = false;
            dgvProdutos.Columns["Fornecedor"].Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string texto = txtPesquisar.Text.Trim();

            if (texto == "")
            {
                MessageBox.Show("Digite um nome ou código de barras para pesquisar.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProdutosCollection lista;

            // Pesquisar por nome
            lista = produtoController.GetByName(texto);

            // Se não achou, tentar por código de barras
            if (lista.Count == 0)
                lista = produtoController.GetByCodBarras(texto);

            dgvProdutos.DataSource = lista;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int idProduto = (int)dgvProdutos.Rows[e.RowIndex].Cells["IdProduto"].Value;

            ProdutoCadastroForm tela = new ProdutoCadastroForm();
            tela.CarregarProduto(idProduto);
            tela.ShowDialog();

            CarregarGrid(); // Atualiza lista depois da edição
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
