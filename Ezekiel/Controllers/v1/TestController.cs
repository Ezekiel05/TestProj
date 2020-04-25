using Ezekiel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Ezekiel.Services;
using Ezekiel.Services.Reporsitories;
using Ezekiel.Services.ViewModels;
using System.Web.Http;

namespace Ezekiel.Controllers
{
    //[RoutePrefix("Home")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TestController : ApiController
    {
        AmountRepository _amountRepository;

        public TestController()
        {
            _amountRepository = new AmountRepository();
        }

        [HttpGet]
        [Route("GetData")]
        public IHttpActionResult GetData()
        {
            IList<AmountLog> result = _amountRepository.GetAllAmountLog();

            return Ok(result);
        }

        [HttpGet]
        [Route("GetChartData")]
        public IList<ChartData> GetChartData()
        {
            IList<AmountLog> amountLog = _amountRepository.GetAllAmountLog();

            IList<ChartData> result = amountLog
                .GroupBy(d => d.Date)
                .Select(group => new ChartData
                {
                    Date = group.Key,
                    Amount = group.Sum(a => a.Amount)
                }).ToList();

            return result;
        }

        [HttpGet]
        [Route("LogAmount")]
        public IHttpActionResult LogAmount(DateTime dateTime, int amount, string messageLog, DateTime date)
        {
            IList<AmountLog> result = _amountRepository.LogAmount(dateTime, amount, messageLog, date);

            return Ok(result);
        }
    }
}