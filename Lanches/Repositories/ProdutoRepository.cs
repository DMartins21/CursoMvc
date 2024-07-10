using Lanches.Context;
using Lanches.Models;
using Lanches.Repositories.Interfaces;
using System.Data.Entity;

namespace Lanches.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos;

        public Produto GetProdutoById(int produtoId) => _context.Produtos.FirstOrDefault(I => I.Id == produtoId);
    }
}
