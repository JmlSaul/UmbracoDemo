using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;

namespace UmbracoDemo.Custom
{
    public class MyRenderMvcController : Umbraco.Web.Mvc.RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            //model.Content.
            //do something here
            return base.Index(model);
        }
    }
}