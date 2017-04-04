using ProjetoModeloTDD.Domain.Entites;
using System.Collections.Generic;

namespace ProjetoModeloTDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
