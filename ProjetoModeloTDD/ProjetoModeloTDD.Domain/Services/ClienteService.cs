using System;
using System.Linq;
using System.Collections.Generic;
using ProjetoModeloTDD.Domain.Entites;
using ProjetoModeloTDD.Domain.Interfaces.Repositories;
using ProjetoModeloTDD.Domain.Interfaces.Services;

namespace ProjetoModeloTDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspecias(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
 