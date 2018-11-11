using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezekiel.Services.ViewModels
{
    public class AmountLog
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Amount { get; set; }
        public string MessageLog { get; set; }
        public DateTime Date { get; set; }
    }

    public class ChartData
    {
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}
