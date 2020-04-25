using Ezekiel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Ezekiel.Services;
using Ezekiel.Services.Reporsitories;
using Ezekiel.Services.ViewModels;

namespace Ezekiel.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        AmountRepository _amountRepository;

        public HomeController()
        {
            _amountRepository = new AmountRepository();
        }

        [HttpGet]
        [Route("GetData")]
        public ActionResult GetData()
        {
            IList<AmountLog> amountLog = _amountRepository.GetAllAmountLog();

            return new JsonResult
            {
                Data = amountLog,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                MaxJsonLength = int.MaxValue
            };
        }

        [HttpGet]
        [Route("GetChartData")]
        public ActionResult GetChartData()
        {
            IList<AmountLog> amountLog = _amountRepository.GetAllAmountLog();

            IList<ChartData> gbDateLog = amountLog
                .GroupBy(d => d.Date)
                .Select(group => new ChartData
                {
                    Date = group.Key,
                    Amount = group.Sum(a => a.Amount)
                }).OrderBy(o => o.Date).ToList();

            return new JsonResult
            {
                Data = gbDateLog,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                MaxJsonLength = int.MaxValue
            };
        }

        [HttpGet]
        [Route("LogAmount")]
        public ActionResult LogAmount(DateTime dateTime, int amount, string messageLog, DateTime date)
        {
            IList<AmountLog> amountLog = _amountRepository.LogAmount(dateTime, amount, messageLog, date);

            return new JsonResult
            {
                Data = amountLog,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                MaxJsonLength = int.MaxValue
            };
        }

        public ActionResult Index()
        {
            ModelParameters param = new ModelParameters
            {
                PageName = "Dashboard",
                Info = "Shows Dashboard of Amount Logs"
            };

            return View(param);
        }

        public ActionResult Log()
        {
            ModelParameters param = new ModelParameters
            {
                PageName = "Log",
                Info = "Allows user to log amount"
            };

            return View(param);
        }

        public ActionResult About()
        {
            ModelParameters param = new ModelParameters
            {
                PageName = "About",
                Info = "This app logs your stuff. The end. :p"
            };

            return View(param);
        }
    }
}