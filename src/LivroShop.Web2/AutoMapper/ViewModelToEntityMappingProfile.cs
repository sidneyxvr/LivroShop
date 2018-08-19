using AutoMapper;
using LivroShop.ApplicationCore.Entities;
using LivroShop.Web2.ViewModels;

namespace LivroShop.Web2.AutoMapper
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<LivroViewModel, Livro>();
        }
    }
}