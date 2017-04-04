using AutoMapper;
using ProjetoModeloTDD.Domain.Entites;
using ProjetoModeloTDD.Mvc.ViewModels;

namespace ProjetoModeloTDD.Mvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}