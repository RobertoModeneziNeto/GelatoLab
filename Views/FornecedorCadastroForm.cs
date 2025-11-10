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
    public partial class FornecedorCadastroForm : Form
    {
        FornecedorController controller = new FornecedorController();
        public FornecedorCadastroForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("O nome do fornecedor é obrigatório.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Nome = txtNome.Text.Trim();
            fornecedor.Cnpj = txtCnpj.Text.Trim();
            fornecedor.Telefone = txtTelefone.Text.Trim();
            fornecedor.Email = txtEmail.Text.Trim();

            // Verificar se é inserção ou edição
            if (txtId.Text == "")
            {
                controller.Inserir(fornecedor);
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
            }
            else
            {
                fornecedor.IdFornecedor = int.Parse(txtId.Text);
                controller.Alterar(fornecedor);
                MessageBox.Show("Fornecedor alterado com sucesso!");
            }

            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um fornecedor antes de excluir.");
                return;
            }

            int id = int.Parse(txtId.Text);
            controller.Excluir(id);

            MessageBox.Show("Fornecedor excluído com sucesso!");
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
            txtCnpj2.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }
    }
}
