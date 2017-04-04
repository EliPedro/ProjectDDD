using ProjetoModeloTDD.Application;
using ProjetoModeloTDD.Application.Interface;
using ProjetoModeloTDD.Domain.Interfaces.Services;
using ProjetoModeloTDD.Domain.Interfaces.Repositories;
using ProjetoModeloTDD.Data.Repositories;
using ProjetoModeloTDD.Domain.Services;
using Ninject;

namespace ProjetoModeloTDD.CrossCutting
{
    public class CrossCuttingModule
    {       
        public void AddBiding(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IClienteAppService>().To<ClienteAppService>();
            kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IClienteService>().To<ClienteService>();
            kernel.Bind<IProdutoService>().To<ProdutoService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
        }
    }
}