using CodeFirstApprochMVC.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace CodeFirstApprochMVC.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var data = db.Employees.ToList();
            return View(data);
        }
    }
}