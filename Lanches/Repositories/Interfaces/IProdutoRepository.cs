using Lanches.Models;

namespace Lanches.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
        Produto GetProdutoById(int produtoId);
    }
}
