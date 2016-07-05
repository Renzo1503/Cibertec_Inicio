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
        private IDataAccess<Client> _client;

        public ClientController(IDataAccess<Client> client)
        {
            _client = client;
        }
    
        //private ClientData _client = new ClientData();
        // GET: Client

        public ActionResult Index()
        {
            //var client = new ClientData();
            ViewBag.Title = Resources.Resource.Client_Title;
            return View(_client.GetList());
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
        //public ActionResult Edit(int id)
        //{
        //    return View(_client.GetClient(id));
        //}

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
        //public ActionResult Delete(int id)
        //{
        //    var client = _client.GetClient(id);
        //    if (client == null)
        //        RedirectToAction("Index");
        //    return View(client);
        //}

        [HttpPost]
        public ActionResult Delete(Client client)
        {
            if (_client.Delete(client) > 0)
                return RedirectToAction("Index");
            return View(client);
        }

    }
}