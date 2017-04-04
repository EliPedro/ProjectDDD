using ProjetoModeloTDD.Domain.Entites;
using System.Collections.Generic;

namespace ProjetoModeloTDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspecias(IEnumerable<Cliente> clientes);
    }
}
