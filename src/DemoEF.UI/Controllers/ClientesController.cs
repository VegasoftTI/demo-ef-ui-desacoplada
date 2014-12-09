using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoEF.UI.Controllers
{
    public class ClientesController : Controller
    {
        private readonly DAL.Repositorio.ClienteRepositorio _rep;

        public ClientesController()
        {
            _rep = new DAL.Repositorio.ClienteRepositorio();
        }

        public ActionResult Index()
        {
            return View(_rep.ObterTodosClientes());
        }

        public ActionResult Details(int id)
        {
            return View(_rep.ObterPorId(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DAL.Entidade.Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                    _rep.Adicionar(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_rep.ObterPorId(id));
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(DAL.Entidade.Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                    _rep.Editar(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        public ActionResult Delete(int id)
        {
            return View(_rep.ObterPorId(id));
        }

        [HttpPost]
        public ActionResult Delete(DAL.Entidade.Cliente cliente)
        {
            try
            {
                _rep.Excluir(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        protected override void Dispose(bool disposing)
        {
            _rep.Dispose();
        }
    }
}
