using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoDaZo.Models
{
    public class CatalogoDaZoContext : DbContext
    {
        public CatalogoDaZoContext(DbContextOptions<CatalogoDaZoContext>options) :base(options) { }
        public DbSet<ProdutoViewModel> Produtos { get; set; }
        public DbSet<ClienteViewModel> Cliente { get; set; }
        public DbSet<PedidoViewModel> Pedido { get; set; }
    }
}
