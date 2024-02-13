using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public class ClienteContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set;}
        //public DbSet<Pedido> Pedido { get; set;}
    }
}
