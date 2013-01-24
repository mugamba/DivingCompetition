using DivingCompetition.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DivingCompetition.Models;
using NHibernate.Criterion;

namespace DivingCompetition.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var testEntity = NhSession.Current.CreateCriteria<TestEntity>()
                .List<TestEntity>();

            return View("List", testEntity);
        }


        // GET: /Home/Details/5

        public ActionResult Details(Guid id)
        {
            var testEntity = NhSession.Current.CreateCriteria<TestEntity>()
               .Add(Expression.Eq("Id", id))
               .UniqueResult<TestEntity>();

            return View(testEntity);
        }


        // GET: /Home/Create

        public ActionResult Create()
        {
            var newEntity = new TestEntity();
            return View(newEntity);
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(TestEntity testEntity)
        {
            try
            {
                NhSession.Current.Save(testEntity);
                NhSession.Current.Flush();

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(Guid id)
        {
            var testEntity = NhSession.Current.CreateCriteria<TestEntity>()
                .Add(Expression.Eq("Id", id))
                .UniqueResult<TestEntity>();

            return View("Edit", testEntity);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(Guid id, TestEntity testEntity)
        {
            try
            {
                NhSession.Current.Save(testEntity);
                NhSession.Current.Flush();
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                var testEntity = NhSession.Current.CreateCriteria<TestEntity>()
              .Add(Expression.Eq("Id", id))
              .UniqueResult<TestEntity>();
                if (testEntity != null)
                {
                    NhSession.Current.Delete(testEntity);
                    NhSession.Current.Flush();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
              
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
