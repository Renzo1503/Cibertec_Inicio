using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        private ClientData _client = new ClientData();
        // GET: Client
        public ActionResult Index()
        {
            var client = new ClientData();
            return View(client.GetList());
        }

        //Crear nuevo cliente
        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]  //Si no se pone esto habra dos metodos create
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        //Modificar cliente
        public ActionResult Edit(int id)
        {
            Client client = _client.GetList().Find(x => x.ID == id);
            return View(client);
        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {                
                _client.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }


        //Eliminar cliente
        public ActionResult Delete(int id)
        {
            Client client = _client.GetList().Find(x => x.ID == id);
            return View(client);
        }

        [HttpPost]
        public ActionResult Delete(Client client)
        {            
            _client.Delete(client);
            return RedirectToAction("Index");            
        }

    }
}