using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoDaZo.Models
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel() { }
        public int ID { get; set; }
        public String Nome { get; set; }
        public String Tipo { get; set; }
        public int QuantidadeProduto { get; set; }
        public float ValorProduto { get; set; }
                
    }
}
