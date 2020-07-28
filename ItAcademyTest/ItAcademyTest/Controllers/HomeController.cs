using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItAcademyTest.Models;
using ItAcademyTest.SomeLogic;

namespace ItAcademyTest.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Find(TestModel tm)
        {
            if (ModelState.IsValid)
            {

                int[] arr = Logic.ArrIntCreate(tm.Size, tm.MinValue, tm.MaxValue);

                Logic.MySort(arr);

                tm.ArrayOfInt = arr;

                if (Logic.IsThereAnyAnswer(arr, tm.xValue))
                {
                    tm.NumberOfFirstElementAboveX = Logic.bsearch(arr, tm.xValue);

                    return View(tm);
                }
                else
                {
                    return NoAnswer(tm);
                }

            }
            else 
            {
                return Redirect("/Home/WrongInput");
            }            
        }



        public ActionResult NoAnswer(TestModel tm)
        {
            ViewBag.Ob = tm;
            return View("NoAnswer");
        }



        public ActionResult WrongInput()
        {
            return View();
        }




    }
}