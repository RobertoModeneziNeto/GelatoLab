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
    public partial class FornecedorConsultaForm : Form
    {
        FornecedorController controller = new FornecedorController();
        public FornecedorConsultaForm()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            FornecedorCollection lista = controller.GetAll();
            dgvFornecedores.DataSource = lista;

            // Renomear colunas
            dgvFornecedores.Columns["IdFornecedor"].HeaderText = "ID";
            dgvFornecedores.Columns["Nome"].HeaderText = "Nome";
            dgvFornecedores.Columns["Cnpj"].HeaderText = "CNPJ";
            dgvFornecedores.Columns["Telefone"].HeaderText = "Telefone";
            dgvFornecedores.Columns["Email"].HeaderText = "Email";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string texto = txtPesquisar.Text.Trim();

            if (texto == "")
            {
                MessageBox.Show("Digite um nome ou CNPJ para pesquisar.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Primeiro tenta buscar pelo nome
            var lista = controller.GetByName(texto);

            // Se não achou nada, tenta buscar por CNPJ
            if (lista.Count == 0)
                lista = controller.GetByCnpj(texto);

            dgvFornecedores.DataSource = lista;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = (int)dgvFornecedores.Rows[e.RowIndex].Cells["IdFornecedor"].Value;

            FornecedorCadastroForm tela = new FornecedorCadastroForm();
            tela.CarregarFornecedor(id);
            tela.ShowDialog();

            CarregarGrid(); // atualizar após editar
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
