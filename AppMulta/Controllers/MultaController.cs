using AppMulta.Contexto;
using AppMulta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AppMulta.Controllers
{
    public class MultaController : Controller
    {
        private readonly ContextoBD _context;

        public MultaController(ContextoBD context)
        {
            _context = context;
        }

        public async Task<List<Multa>> ListaDeMutlas()
        {
            var multas = await _context.Multas.Include(v => v.Veiculo).ToListAsync();
            return multas;
        }

        public async Task Add(Multa multa)
        {
            await _context.Multas.AddAsync(multa);
        }

        public async Task AddRanger(List<Multa> multas) //adicionar uma lista de multas
        {
            await _context.Multas.AddRangeAsync(multas);
        }

        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
        }

    }


}
