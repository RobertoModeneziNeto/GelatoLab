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
    public partial class UsuarioCadastroForm : Form
    {
        UsuarioController controller = new UsuarioController();
        public UsuarioCadastroForm()
        {
            InitializeComponent();
            CarregarComboTipo();
        }

        private void CarregarComboTipo()
        {
            cbTipo.Items.Add("Admin");
            cbTipo.Items.Add("Funcionario");
            cbTipo.SelectedIndex = 0;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" ||
                txtLogin.Text.Trim() == "" ||
                txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = new Usuario();

            usuario.Nome = txtNome.Text.Trim();
            usuario.Login = txtLogin.Text.Trim();
            usuario.Senha = txtSenha.Text.Trim();
            usuario.Tipo = cbTipo.Text;

            if (txtId.Text == "")
            {
                controller.Inserir(usuario);
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            else
            {
                usuario.IdUsuario = int.Parse(txtId.Text);
                controller.Alterar(usuario);
                MessageBox.Show("Usuário alterado com sucesso!");
            }

            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um usuário primeiro.");
                return;
            }

            int id = int.Parse(txtId.Text);
            controller.Excluir(id);

            MessageBox.Show("Usuário excluído com sucesso!");
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
            txtLogin.Clear();
            txtSenha.Clear();
            cbTipo.SelectedIndex = 0;
        }
        public void CarregarUsuario(int idUsuario)
        {
            Usuario usuario = controller.GetById(idUsuario);

            if (usuario != null)
            {
                txtId.Text = usuario.IdUsuario.ToString();
                txtNome.Text = usuario.Nome;
                txtLogin.Text = usuario.Login;
                txtSenha.Text = usuario.Senha;
                cbTipo.Text = usuario.Tipo;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
