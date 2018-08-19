using AutoMapper;

namespace LivroShop.Web2.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config => {
                config.AddProfile(new EntityToViewModelMappingProfile());
                config.AddProfile(new ViewModelToEntityMappingProfile());
            });
        }
    }
}
