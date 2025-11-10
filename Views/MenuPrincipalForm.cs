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
        }


    }
}
