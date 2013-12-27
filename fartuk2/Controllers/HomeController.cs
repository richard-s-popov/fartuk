using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fartuk2.Core;
using fartuk2.Models;

namespace fartuk2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OrderFinish(Order model)
        {
            var em = new EmailMessage
                {
                    DisplayNameFrom = "ФартукиТомск",
                    From = "fartuk.tomsk@yandex.ru",
                    To = "info@rbprofit.ru",
                    Subject = "Заявка на замер",
                    Message = string.Format("Кто: {0}<br/>" +
                                            "Тел.: {1}<br/>" +
                                            "Фартук: {5}<br/>" +
                                            "Улица: {2}<br/>" +
                                            "Дом: {3}<br/>" +
                                            "Кв.: {4}<br/>",
                                            model.Name,
                                            model.Phone,
                                            model.Street,
                                            model.Home,
                                            model.Flat,
                                            model.FartukNumber)
                };

            EmailService.SendMessage(em,
                   "fartuk.tomsk@yandex.ru",
                   "123456aaa111",
                   "smtp.yandex.ru",
                   587,
                   true);

            return View();
        }
    }
}