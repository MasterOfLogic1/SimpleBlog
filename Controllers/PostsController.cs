using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class PostsController:Controller
    {
        public ActionResult Index()
        {
            // This is where you would normally retrieve posts from a database
            // For now, we will return a simple view
            return Content("Hello World");
        }
    }
}