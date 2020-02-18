using System.Collections.Generic;
using System.Web.Mvc;
using WebAppTesteDGM.Models;

namespace WebAppTesteDGM.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            ClientsDAO cliDAO = new ClientsDAO();
            ModelState.Clear();
            return View( cliDAO.GetAllClientes());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(ClienteModel cliModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ClientsDAO cliDAO = new ClientsDAO();
                    if (cliDAO.AddClient(cliModel))
                    {
                        ViewBag.Message = "Cliente adicionado com sucesso.";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            ClientsDAO cliDAO = new ClientsDAO();
            return View(cliDAO.GetClienteById(id));
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClienteModel cliModel)
        {
            try
            {
                ClientsDAO cliDAO = new ClientsDAO();
                cliDAO.UpdateCliente(cliModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // POST: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                ClientsDAO cliDAO = new ClientsDAO();
                if (cliDAO.DeleteCliente(id))
                {
                    ViewBag.AlertMsg = "Clente excluido com sucesso.";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
