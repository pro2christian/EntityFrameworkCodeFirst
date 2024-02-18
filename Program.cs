using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ( var context = new ClienteContext() )
            {
                var qtdClientes = context.Clientes.Count();
                //context.Clientes.Add(new Cliente() { Nome = "CHRISTIAN2", Telefone = "88888888888", Cpf = "00000000000" });
                //context.Produto.Add(new Produto() { Nome = "Iphone X", Descricao = "Aperelho Telefonico" });
                //context.SaveChanges();
            }
        }
    }
}
