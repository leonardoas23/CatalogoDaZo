using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoDaZo.Models
{
    public class ClienteViewModel
    {
        public ClienteViewModel() { }
        
        public int ID { get; set; }
        public int IDPedido { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Endereco { get; set; }
        public String Foto { get; set; }
        public int Telefone { get; set; }
        public float DividaTotal { get; set; }
        
                
    }
}
