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
    public partial class MovimentacaoDetalheForm : Form
    {
        MovimentacaoController movController = new MovimentacaoController();
        public MovimentacaoDetalheForm()
        {
            InitializeComponent();
        }

        public void CarregarMovimentacao(int idMovimentacao)
        {
            Movimentacoes mov = movController.GetById(idMovimentacao);

            if (mov != null)
            {
                txtId.Text = mov.IdMovimentacao.ToString();
                txtTipo.Text = mov.Tipo;
                txtData.Text = mov.DataMovimentacao.ToString("dd/MM/yyyy HH:mm");
                txtProduto.Text = mov.Produto.Nome;
                txtQuantidade.Text = mov.Quantidade.ToString();
                txtObservacao.Text = mov.Observacao;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
