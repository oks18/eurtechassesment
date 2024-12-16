using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Mvc.Presentation;
using sitecoretraining.Models;

namespace sitecoretraining.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var Model = new DefaultModel()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/Default/Index.cshtml", Model);
        }

        public ActionResult Index1()
        {
            var Model = new ITSolution()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/Default/ITSolution.cshtml", Model);
        }

        public ActionResult Testimonials()
        {
            var Model = new Testimonials()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/Default/Testimonials.cshtml", Model);
        }

        public ActionResult Header()
        {
            var Model = new Header()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/Default/Header.cshtml", Model);
        }

        public ActionResult Footer()
        {
            var Model = new Footer()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/Default/Footer.cshtml", Model);
        }

    }

}