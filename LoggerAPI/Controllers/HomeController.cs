using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoggerAPI.Models;
using Newtonsoft.Json;

namespace LoggerAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new LogDbContext())
            {
                return View(context.Logs.ToList().OrderByDescending(l => l.Date));
            }
     
        }

        [HttpPost]
        public ActionResult Log(string jsonLog)
        {
            var log = JsonConvert.DeserializeObject<Log>(jsonLog);
            log.Date = DateTime.Now; 

            using (var context = new LogDbContext())
            {
                context.Logs.Add(log);
                context.SaveChanges();
            }

            return null;
        }


    }
}