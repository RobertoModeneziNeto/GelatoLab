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
    public partial class ProdutoCadastroForm : Form
    {

        ProdutosController produtoController = new ProdutosController();
        CategoriaController categoriaController = new CategoriaController();
        FornecedorController fornecedorController = new FornecedorController();
        public ProdutoCadastroForm()
        {
            InitializeComponent();
            CarregarComboCategoria();
            CarregarComboFornecedor();
            CarregarComboTipoUnidade();
        }

        // ============================================================
        // CARREGAR COMBO DE CATEGORIA
        // ============================================================
        private void CarregarComboCategoria()
        {
            var categorias = categoriaController.GetAtivas();
            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "IdCategoria";
        }

        // ============================================================
        // CARREGAR COMBO DE FORNECEDOR
        // ============================================================
        private void CarregarComboFornecedor()
        {
            var fornecedores = fornecedorController.GetAll();
            cbFornecedor.DataSource = fornecedores;
            cbFornecedor.DisplayMember = "Nome";
            cbFornecedor.ValueMember = "IdFornecedor";
        }

        // CARREGAR TIPO DE UNIDADE
        // ============================================================
        private void CarregarComboTipoUnidade()
        {
            cbTipoUnidade.Items.Add("Unidade");
            cbTipoUnidade.Items.Add("Caixa");
            cbTipoUnidade.SelectedIndex = 0;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("O nome do produto é obrigatório.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Produtos produto = new Produtos();
            produto.Nome = txtNome.Text.Trim();
            produto.Quantidade = int.Parse(txtQuantidade.Text);
            produto.Preco = decimal.Parse(txtPreco.Text);
            produto.codBarras = txtCodBarras.Text.Trim();
            produto.TipoUnidade = cbTipoUnidade.Text;

            produto.Categoria = new Categoria()
            {
                IdCategoria = (int)cbCategoria.SelectedValue
            };

            produto.Fornecedor = new Fornecedor()
            {
                IdFornecedor = (int)cbFornecedor.SelectedValue
            };

            // Se ainda não tem ID → novo produto
            if (txtId.Text == "")
            {
                produtoController.Inserir(produto);
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            else
            {
                produto.IdProduto = int.Parse(txtId.Text);
                produtoController.Alterar(produto);
                MessageBox.Show("Produto alterado com sucesso!");
            }

            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um produto antes de excluir.");
                return;
            }

            int id = int.Parse(txtId.Text);
            produtoController.Excluir(id);

            MessageBox.Show("Produto excluído com sucesso!");
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtCodBarras.Clear();

            cbCategoria.SelectedIndex = 0;
            cbFornecedor.SelectedIndex = 0;
            cbTipoUnidade.SelectedIndex = 0;
        }

        // ============================================================
        // CARREGAR PRODUTO PARA EDIÇÃO
        // ============================================================
        public void CarregarProduto(int idProduto)
        {
            Produtos produto = produtoController.GetById(idProduto);

            if (produto != null)
            {
                txtId.Text = produto.IdProduto.ToString();
                txtNome.Text = produto.Nome;
                txtQuantidade.Text = produto.Quantidade.ToString();
                txtPreco.Text = produto.Preco.ToString("F2");
                txtCodBarras.Text = produto.codBarras;
                cbTipoUnidade.Text = produto.TipoUnidade;

                cbCategoria.SelectedValue = produto.Categoria.IdCategoria;
                cbFornecedor.SelectedValue = produto.Fornecedor.IdFornecedor;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
