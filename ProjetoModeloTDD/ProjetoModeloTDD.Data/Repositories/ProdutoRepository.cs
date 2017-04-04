using System.Collections.Generic;
using ProjetoModeloTDD.Domain.Entites;
using System.Linq;
using ProjetoModeloTDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloTDD.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {          
            return db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
