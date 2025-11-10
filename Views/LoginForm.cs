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
using GelatoLab.Controllers;

namespace GelatoLab.Views
{
    public partial class LoginForm : Form
    {

        UsuarioController controller = new UsuarioController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Lê o que o usuário digitou
            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (login == "" || senha == "")
            {
                MessageBox.Show("Preencha o login e a senha.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chama a controller para verificar o login
            Usuario usuario = controller.Login(login, senha);

            if (usuario == null)
            {
                MessageBox.Show("Usuário ou senha incorretos!",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Se encontrou o usuário, abre o menu principal
            this.Hide(); // Esconde a tela de login

            MenuPrincipalForm menu = new MenuPrincipalForm(usuario);
            menu.ShowDialog();

            // Após fechar o menu, fecha a tela de login também
            this.Close();
        }
    }
}
