using ProjetoModeloTDD.Domain.Entites;
using System.Collections.Generic;

namespace ProjetoModeloTDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
