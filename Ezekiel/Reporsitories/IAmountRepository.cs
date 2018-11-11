using Ezekiel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezekiel.Reporsitories
{
    public interface IAmountRepository
    {
        IList<AmountLog> GetAllAmountLog();
    }
}
