using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoDaZo.Models
{
    public class PedidoViewModel 
    {
        public PedidoViewModel() { }
        public int ID { get; set; }
        public int IDNumeroPedido { get; set; }
        public DateTime Data { get; set; }
        public String Status { get; set; }
        
        public String NomeCliente { get; set; }
        public float ValorTotal { get; set; }
        public string MetodoPagamento { get; set; }
                
    }
}
