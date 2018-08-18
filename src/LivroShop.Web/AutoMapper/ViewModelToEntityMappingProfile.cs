using AutoMapper;
using LivroShop.ApplicationCore.Entities;
using LivroShop.Web.ViewModels;

namespace LivroShop.Web.AutoMapper
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<LivroViewModel, Livro>();
        }
    }
}