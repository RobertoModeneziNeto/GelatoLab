using GelatoLab.Controllers;
using GelatoLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GelatoLab.Views
{
    public partial class MovimentacaoForm : Form
    {
        MovimentacaoController movController = new MovimentacaoController();
        ProdutosController produtoController = new ProdutosController();
        public MovimentacaoForm()
        {
            InitializeComponent();
            CarregarComboTipo();
            CarregarComboProdutos();
            dtData.Value = DateTime.Now;
        }

        // ============================================================
        // CARREGAR COMBO TIPO
        // ============================================================
        private void CarregarComboTipo()
        {
            cbTipo.Items.Add("Entrada");
            cbTipo.Items.Add("Saida");
            cbTipo.SelectedIndex = 0;
        }

        // ============================================================
        // CARREGAR PRODUTOS
        // ============================================================
        private void CarregarComboProdutos()
        {
            var produtos = produtoController.GetAll();
            cbProduto.DataSource = produtos;
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "IdProduto";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Trim() == "")
            {
                MessageBox.Show("Informe a quantidade.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Movimentacoes mov = new Movimentacoes();

            mov.Tipo = cbTipo.Text;
            mov.DataMovimentacao = dtData.Value;
            mov.Quantidade = int.Parse(txtQuantidade.Text);
            mov.Observacao = txtObservacao.Text.Trim();

            mov.Produto = new Produtos()
            {
                IdProduto = (int)cbProduto.SelectedValue
            };

            movController.Inserir(mov);  // Atualiza estoque automaticamente

            MessageBox.Show("Movimentação registrada com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtQuantidade.Clear();
            txtObservacao.Clear();

            cbTipo.SelectedIndex = 0;
            cbProduto.SelectedIndex = 0;
            dtData.Value = DateTime.Now;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
