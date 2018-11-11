using Ezekiel.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezekiel.Services.Reporsitories
{
    public interface IAmountRepository
    {
        IList<AmountLog> GetAllAmountLog();
        IList<AmountLog> LogAmount(DateTime dateTime, int amount, string messageLog, DateTime date);
    }
}
