using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoLab.Models
{
    public class Movimentacoes
    {
        public int IdMovimentacao { get; set; }
        public string Tipo { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public Produtos Produto { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }

    }

    public class MovimentacoesCollection : List<Movimentacoes> { }
}
