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
    public partial class CategoriaConsultaForm : Form
    {
        CategoriaController controller = new CategoriaController();
        public CategoriaConsultaForm()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            CategoriaCollection lista = controller.GetAll();
            dvgCategorias.DataSource = lista;

            // Renomeando colunas
            dvgCategorias.Columns["IdCategoria"].HeaderText = "ID";
            dvgCategorias.Columns["Nome"].HeaderText = "Nome";
            dvgCategorias.Columns["Descricao"].HeaderText = "Descrição";
            dvgCategorias.Columns["Ativo"].HeaderText = "Ativo";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string filtro = txtPesquisar.Text.Trim();

            if (filtro == "")
            {
                MessageBox.Show("Digite algo para pesquisar.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CategoriaCollection lista = controller.GetByName(filtro);
            dvgCategorias.DataSource = lista;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dvgCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = (int)dvgCategorias.Rows[e.RowIndex].Cells["IdCategoria"].Value;

            CategoriaCadastroForm tela = new CategoriaCadastroForm();
            tela.CarregarCategoria(id);
            tela.ShowDialog();

            // Recarregar lista depois de editar
            CarregarGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
