using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UmbracoDemo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            IQueryable<cc> li = Enumerable.Range(1, 100).Select(i => new cc {Id = i.ToString(), I = i}).AsQueryable();

            IQueryable<IGrouping<string,cc>> gourp = li.GroupBy(c => c.Id);

            var g = gourp.Select(item => item.Key);


            return View();
        }
    }

    class cc
    {
        public string Id { get; set; }
        public int I { get; set; }
    }
}