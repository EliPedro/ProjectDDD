using ProjetoModeloTDD.Application.Interface;
using ProjetoModeloTDD.Domain.Entites;
using ProjetoModeloTDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloTDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspecias()
        {
            return _clienteService.ObterClientesEspecias(_clienteService.GetAll());
        }
    }
}
