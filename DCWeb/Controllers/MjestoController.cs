using DC.Application;
using DivingCompetition.Domain;
using DivingCompetition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DC.Web.Controllers
{
    public class MjestoController : Controller
    {
        private readonly IMjestoManagementService _service;
        public MjestoController(IMjestoManagementService service)
        {
            _service = service;
        }
        //
        // GET: /Mjesto/

        public ActionResult Index()
        {
            var  list=new List<MjestoModelDetails>();
            list.AddRange(_service.GetData().Select(m=> new MjestoModelDetails(m)));
            
            return View("MjestaList",list);
        }

        //
        // GET: /Mjesto/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Mjesto/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Mjesto/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Mjesto/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Mjesto/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Mjesto/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Mjesto/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
