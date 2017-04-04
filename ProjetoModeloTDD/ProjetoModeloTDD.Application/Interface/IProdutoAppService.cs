using ProjetoModeloTDD.Domain.Entites;
using System.Collections.Generic;

namespace ProjetoModeloTDD.Application.Interface
{
   public interface IProdutoAppService : IAppServiceBase<Produto>
   {
        IEnumerable<Produto> BuscarPorNome(string nome);

    }
}
