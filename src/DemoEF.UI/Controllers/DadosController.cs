using System.Web.Mvc;

namespace DemoEF.UI.Controllers
{
    public class DadosController : Controller
    {
        private readonly DAL.Repositorio.ClienteRepositorio _rep;

        public DadosController()
        {
            _rep = new DAL.Repositorio.ClienteRepositorio();
        }

        public ActionResult Index()
        {
            return View(_rep.ObterTodosClientes());
        }

        protected override void Dispose(bool disposing)
        {
            _rep.Dispose();
        }
    }
}