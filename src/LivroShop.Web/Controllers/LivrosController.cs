using System.Collections.Generic;
using AutoMapper;
using LivroShop.ApplicationCore.Entities;
using LivroShop.ApplicationCore.Intrfaces.Services;
using LivroShop.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivroShop.Web.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ILivroService _context;

        public LivrosController(ILivroService context)
        {
            _context = context;
        }

        // GET: Livros
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_context.GetAll()));
        }

        // GET: Livros/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Livros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Livros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Livros/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}