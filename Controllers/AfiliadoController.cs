using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using morales_juan_lppa_parcial1.Business;
using morales_juan_lppa_parcial1.Data.Entities;

namespace morales_juan_lppa_parcial1.Controllers
{
    public class AfiliadoController : Controller
    {
        // GET: Afiliado
        public ActionResult Index()
        {
            AfiliadoBusiness afiliadoBusiness = new AfiliadoBusiness();
            var lista = afiliadoBusiness.Listar();
            return View(lista);
        }

        //CREAR

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Afiliado model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                var afiliadoBusiness = new AfiliadoBusiness();
                afiliadoBusiness.Agregar(model);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(model);
            }
        }

        //EDITAR
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var afiliadoBusiness = new AfiliadoBusiness();
            var afiliado = afiliadoBusiness.Get(id);
            if (afiliado == null)
            {
                return View();
            }
            return View(afiliado);
        }

        [HttpPost]
        public ActionResult Edit(Afiliado model)
        {
            if(!ModelState.IsValid || model == null)
            {
                return View();
            }
            var afiliadoBusiness = new AfiliadoBusiness();
            afiliadoBusiness.Update(model);
            return RedirectToAction("Index");
        }

        //ELIMINAR

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var afiliadoBusiness = new AfiliadoBusiness();
            var afiliado = afiliadoBusiness.Get(id);
            return View(afiliado);
        }

        [HttpPost]
        public ActionResult Delete(Afiliado model)
        {
            var afiliadoBusiness = new AfiliadoBusiness();
            afiliadoBusiness.Eliminar(model);
            return RedirectToAction("Index");
        }
    }
}