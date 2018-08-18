using LivroShop.ApplicationCore.Entities;
using LivroShop.Infrastructure.Data;
using LivroShop.ApplicationCore.Intrfaces.Repositories;

namespace LivroShop.Infrastructure.Repositories
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public LivroRepository(LivroShopContext context)
            : base(context)
        {

        }
    }
}
