using Lanches.Context;
using Lanches.Models;
using Lanches.Repositories.Interfaces;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace Lanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }



        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
