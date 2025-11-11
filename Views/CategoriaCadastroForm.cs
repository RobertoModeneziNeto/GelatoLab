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
    public partial class CategoriaCadastroForm : Form
    {
        CategoriaController controller = new CategoriaController();

        public CategoriaCadastroForm()
        {
            InitializeComponent();

            cbAtivo.Items.Add("1");
            cbAtivo.Items.Add("0");
            cbAtivo.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome da categoria.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria categoria = new Categoria();
            categoria.Nome = txtNome.Text.Trim();
            categoria.Descricao = txtDescricao.Text.Trim();
            categoria.Ativo = int.Parse(cbAtivo.Text);

            // Verifica se é novo cadastro ou edição
            if (txtId.Text == "")
            {
                controller.Inserir(categoria);
                MessageBox.Show("Categoria cadastrada com sucesso!");
            }
            else
            {
                categoria.IdCategoria = int.Parse(txtId.Text);
                controller.Alterar(categoria);
                MessageBox.Show("Categoria alterada com sucesso!");
            }

            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione uma categoria primeiro.");
                return;
            }

            int id = int.Parse(txtId.Text);
            controller.Excluir(id);

            MessageBox.Show("Categoria excluída com sucesso!");

            LimparCampos();
        }

     

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            cbAtivo.SelectedIndex = 0;
        }

        public void CarregarCategoria(int id)
        {
            Categoria categoria = controller.GetById(id);

            if (categoria != null)
            {
                txtId.Text = categoria.IdCategoria.ToString();
                txtNome.Text = categoria.Nome;
                txtDescricao.Text = categoria.Descricao;
                cbAtivo.Text = categoria.Ativo.ToString();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
