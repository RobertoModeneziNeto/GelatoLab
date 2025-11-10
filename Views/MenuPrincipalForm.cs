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

namespace GelatoLab.Views
{
    public partial class MenuPrincipalForm : Form
    {
        private Usuario usuarioLogado;
        public MenuPrincipalForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;

            lblUsuarioLogado.Text = usuario.Nome;
            lblUsuarioLogado.Text = "Usuário: " + usuario.Nome;

            AplicarPermissoes();
        }

        // ============================================================
        // Controle de Permissões Admin / Funcionário
        // ============================================================
        private void AplicarPermissoes()
        {
            if (usuarioLogado.Tipo == "Funcionario")
            {
                menuItemUsuarios.Enabled = false;      // Cadastro de usuários
                menuItemCategorias.Enabled = true;
                menuItemFornecedores.Enabled = true;
                menuItemProdutos.Enabled = true;

                // Funcionário pode fazer movimentações normalmente
            }
            else if (usuarioLogado.Tipo == "Admin")
            {
                // Admin tem tudo liberado
            }
        }

        private void menuItemCategorias_Click(object sender, EventArgs e)
        {
            CategoriaCadastroForm tela = new CategoriaCadastroForm();
            tela.ShowDialog();
        }

        private void menuItemConsultaCategorias_Click(object sender, EventArgs e)
        {
            CategoriaConsultaForm tela = new CategoriaConsultaForm();
            tela.ShowDialog();
        }

        private void menuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemFornecedores_Click(object sender, EventArgs e)
        {
            FornecedorCadastroForm tela = new FornecedorCadastroForm();
            tela.ShowDialog();
        }

        private void menuItemConsultaFornecedores_Click(object sender, EventArgs e)
        {
            FornecedorConsultaForm tela = new FornecedorConsultaForm();
            tela.ShowDialog();
        }

        private void menuItemProdutos_Click(object sender, EventArgs e)
        {
            ProdutoCadastroForm tela = new ProdutoCadastroForm();
            tela.ShowDialog();
        }

        private void menuItemConsultaProdutos_Click(object sender, EventArgs e)
        {
            ProdutoConsultaForm tela = new ProdutoConsultaForm();
            tela.ShowDialog();
        }

        private void menuItemMovimentacao_Click(object sender, EventArgs e)
        {
            MovimentacaoForm tela = new MovimentacaoForm();
            tela.ShowDialog();
        }
    }
}
