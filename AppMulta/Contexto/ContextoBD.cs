using AppMulta.Models;
using System.Collections.Generic;//para que serve essas diretiva
using Microsoft.EntityFrameworkCore; //para que serve essas diretiva

namespace AppMulta.Contexto
{
    public class ContextoBD: DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
        { 
            
        }

        public DbSet<Veiculo> Veiculos { get; set;}
        public DbSet<Multa> Multas { get; set;}

    }
}
