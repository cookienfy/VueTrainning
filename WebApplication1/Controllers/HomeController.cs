using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppForVue.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Component()
        {
            return View();
        }

        public ActionResult VueWithJQuery()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetVueData(string name)
        {

            var obj = new
            {
                id = 123,
                name = name
            };

            return Json(obj);

        }


        public ActionResult GetSelectData()
        {
            List<object> list = new List<object>();
            list.Add(new { text = "11111", value = 1 });
            list.Add(new { text = "22222", value = 2 });
            list.Add(new { text = "33333", value = 3 });
            list.Add(new { text = "44444", value = 4 });
            list.Add(new { text = "55555", value = 5 });


            return Json(new { data = list });
        }


        #region v-model trainning



        #endregion


    }
}