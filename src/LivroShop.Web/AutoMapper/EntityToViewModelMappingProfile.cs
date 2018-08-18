using AutoMapper;
using LivroShop.ApplicationCore.Entities;
using LivroShop.Web.ViewModels;

namespace LivroShop.Web.AutoMapper
{
    public class EntityToViewModelMappingProfile : Profile
    {
        public EntityToViewModelMappingProfile()
        {
            CreateMap<Livro, LivroViewModel>(); 
        }
    }
}