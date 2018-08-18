using LivroShop.ApplicationCore.Entities;
using LivroShop.ApplicationCore.Intrfaces.Repositories;
using LivroShop.ApplicationCore.Intrfaces.Services;
using System;
using System.Collections.Generic;

namespace LivroShop.ApplicationCore.Services
{
    public class LivroService : ILivroService
    { 
        private readonly ILivroRepository _context;

        public LivroService(ILivroRepository context)
        {
            _context = context;
        }

        public void Add(Livro livro)
        {
            _context.Add(livro);
        }

        public IEnumerable<Livro> GetAll()
        {
            return _context.GetAll();
        }

        public Livro GetById(int id)
        {
            return _context.GetById(id);
        }

        public void Remove(Livro livro)
        {
            _context.Remove(livro);
        }

        public void Update(Livro livro)
        {
            _context.Update(livro);
        }
    }
}
