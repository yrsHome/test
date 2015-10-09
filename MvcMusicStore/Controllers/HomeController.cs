using MvcMusicStore.Models;
using MvcMusicStore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public IQuerier querier = new Querier("../Query/SqlMap.config");
        //
        // GET: /Home/

        public ActionResult Index()
        {
            GetList();
            return View();
        }
        public void GetList()
        {
            var list = querier.All<OrderQueryDataObject>("OrderList",null);
        }
    }
}
