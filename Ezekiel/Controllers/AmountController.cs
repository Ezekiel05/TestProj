using Ezekiel.Services.Reporsitories;
using Ezekiel.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace Ezekiel.Services.Controllers
{
    [System.Web.Http.RoutePrefix("Home")]
    public class AmountController : ApiController
    {
        IAmountRepository _amountRepository;
        public AmountController(IAmountRepository amountRepository)
        {
            _amountRepository = amountRepository;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetData")]
        public IList<AmountLog> GetData()
        {
            IList<AmountLog> result = _amountRepository.GetAllAmountLog();

            return result;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("LogAmount")]
        public IList<AmountLog> LogAmount(DateTime dateTime, int amount, string messageLog, DateTime date)
        {
            IList<AmountLog> result = _amountRepository.LogAmount(date, amount, messageLog, date);

            return result;
        }
    }
}
