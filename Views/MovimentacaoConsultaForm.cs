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
    public partial class MovimentacaoConsultaForm : Form
    {
        MovimentacaoController movController = new MovimentacaoController();
        public MovimentacaoConsultaForm()
        {
            InitializeComponent();
            CarregarComboTipo();
            CarregarGrid();
        }

        // ============================================================
        // CARREGAR COMBO TIPO
        // ============================================================
        private void CarregarComboTipo()
        {
            cbTipo.Items.Add("Todos");
            cbTipo.Items.Add("Entrada");
            cbTipo.Items.Add("Saida");
            cbTipo.SelectedIndex = 0;
        }

        // ============================================================
        // CARREGAR GRID INICIAL
        // ============================================================
        private void CarregarGrid()
        {
            MovimentacoesCollection lista = movController.GetAll();
            dgvMovimentacoes.DataSource = lista;

            dgvMovimentacoes.Columns["IdMovimentacao"].HeaderText = "ID";
            dgvMovimentacoes.Columns["Tipo"].HeaderText = "Tipo";
            dgvMovimentacoes.Columns["DataMovimentacao"].HeaderText = "Data";
            dgvMovimentacoes.Columns["Quantidade"].HeaderText = "Qtd";
            dgvMovimentacoes.Columns["Observacao"].HeaderText = "Observação";

            // Esconder objeto Produto (classe inteira)
            dgvMovimentacoes.Columns["Produto"].Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string filtro = txtPesquisar.Text.Trim();
            string tipo = cbTipo.Text;

            MovimentacoesCollection lista;

            // Se o checkbox da data estiver marcado, filtra por data
            if (dtData.Checked)
            {
                lista = movController.GetByFilter(
                    $"m.DataMovimentacao = '{dtData.Value:yyyy-MM-dd}'"
                );
            }
            else
            {
                lista = movController.GetAll();
            }

            // Aplicar filtro de tipo
            if (tipo != "Todos")
            {
                lista = movController.GetByFilter($"m.Tipo = '{tipo}'");
            }

            // Filtro por texto (produto ou observação)
            if (filtro != "")
            {
                lista = movController.GetByFilter(
                    $"p.Nome LIKE '%{filtro}%' OR m.Observacao LIKE '%{filtro}%'"
                );
            }

            dgvMovimentacoes.DataSource = lista;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
