using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Service> _services = new List<Service>
        {
            new Service("1", "نقره ای"),
            new Service("2", "طلایی"),
            new Service("3", "پلاتین"),
            new Service("4", "الماس"),
        };
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult Contact()
        // {
        //     return View();
        // }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    var email = form["email"];
        //    var message = form["message"];
        //    var service = form["service"];
        //    return Json(new { name, email, message });
        //}

        //[HttpPost]
        //public JsonResult Contact(Contact form)
        //{
        //    Console.WriteLine(form.ToString());
        //    return Json(form);
        //}
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                services= new SelectList (_services , "Id" , "Name")
            };
            return View(model);
        }
        //کد اصلی
        //[HttpPost]
        //public IActionResult Contact(Contact model)
        //{
        //    model.services = new SelectList(_services, "Id", "Name");
        //    if (!ModelState.IsValid)
        //    {
        //        ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید";
        //        return View(model);
        //    }
        //    else
        //    {
        //        ModelState.Clear();
        //        model = new Contact
        //        {
        //            services = new SelectList(_services, "Id", "Name")
        //        };
        //        ViewBag.success = "پیغام شما با موفقیت ارسال شد. باتشکر";
        //        return View(model);
        //    }
        //}


        //با صلاح دید هوش مصنوعی تغییر یافت :)
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            ModelState.Clear();
            model.services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید";
                model.services = new SelectList(_services, "Id", "Name");
                return View(model);
            }
            else
            {
                ModelState.Clear();
                ViewBag.success = "پیغام شما با موفقیت ارسال شد. باتشکر";
                model = new Contact
                {
                    services = new SelectList(_services, "Id", "Name")
                };
                return View(model);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
