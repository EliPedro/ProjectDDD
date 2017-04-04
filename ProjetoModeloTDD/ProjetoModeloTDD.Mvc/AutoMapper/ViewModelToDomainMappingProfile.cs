using AutoMapper;
using ProjetoModeloTDD.Domain.Entites;
using ProjetoModeloTDD.Mvc.ViewModels;

namespace ProjetoModeloTDD.Mvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();

        }
    }
}