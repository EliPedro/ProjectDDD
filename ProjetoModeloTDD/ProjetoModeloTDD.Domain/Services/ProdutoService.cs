using ProjetoModeloTDD.Domain.Entites;
using ProjetoModeloTDD.Domain.Interfaces.Repositories;
using ProjetoModeloTDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloTDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
