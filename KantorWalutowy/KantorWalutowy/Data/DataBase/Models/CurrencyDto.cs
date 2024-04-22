using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantorWalutowy.Data.DataBase.Models
{
    public class CurrencyDto
    {
        public string CurrencyName { get; set; }
        public double Rate { get; set; }
        public DateTime Time { get; set; }
    }
}
