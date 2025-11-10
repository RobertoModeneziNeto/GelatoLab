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
    public partial class UsuarioConsultaForm : Form
    {
        UsuarioController controller = new UsuarioController();
        public UsuarioConsultaForm()
        {
            InitializeComponent();
            CarregarGrid();
        }

        // ============================================================
        // CARREGAR GRID INICIAL
        // ============================================================
        private void CarregarGrid()
        {
            UsuarioCollection lista = controller.GetAll();
            dgvUsuarios.DataSource = lista;

            dgvUsuarios.Columns["IdUsuario"].HeaderText = "ID";
            dgvUsuarios.Columns["Nome"].HeaderText = "Nome";
            dgvUsuarios.Columns["Login"].HeaderText = "Login";
            dgvUsuarios.Columns["Senha"].HeaderText = "Senha";
            dgvUsuarios.Columns["Tipo"].HeaderText = "Tipo";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string filtro = txtPesquisar.Text.Trim();

            if (filtro == "")
            {
                MessageBox.Show("Digite um nome ou login para pesquisar.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Primeiro tenta pelo nome
            UsuarioCollection lista = controller.GetByName(filtro);

            // Se não achou nada, tenta pelo login
            if (lista.Count == 0)
                lista = controller.GetByLogin(filtro);

            dgvUsuarios.DataSource = lista;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int idUsuario = (int)dgvUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value;

            UsuarioCadastroForm tela = new UsuarioCadastroForm();
            tela.CarregarUsuario(idUsuario);
            tela.ShowDialog();

            // Atualiza após edição
            CarregarGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
