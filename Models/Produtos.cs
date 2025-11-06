using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoLab.Models
{
    public class Produtos
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public decimal Preco { get; set; }

        public string codBarras { get; set; }

        public Categoria Categoria { get; set; }

        public Fornecedor Fornecedor { get; set; }

    }
}
