using LivroShop.ApplicationCore.Entities;
using System.Collections.Generic;

namespace LivroShop.ApplicationCore.Intrfaces.Services
{
    public interface ILivroService
    {
        void Add(Livro livro);
        void Update(Livro livro);
        void Remove(Livro livro);
        Livro GetById(int id);
        IEnumerable<Livro> GetAll();
    }
}
