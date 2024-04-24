using KantorWalutowy.Data.DataBase;
using KantorWalutowy.Forms.MainView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace KantorWalutowy.Calculate
{
    public class CurrencyCalculates
    {
        public double Calculate(string name, string rate, string date)
        {
            double usdToEuro = Convert.ToDouble(rate);
            double plnToEuro = double.MinValue;
            double resoult = double.MinValue;

            using (var dbContext = new CurrencyDbContext())
            {
                var query = dbContext.Currencies.FirstOrDefault(x => x.CurrencyName == "PLN" && x.Time == Convert.ToDateTime(date));
                plnToEuro = query.Rate;
            }

            if (plnToEuro != double.MinValue && usdToEuro != double.MinValue)
            {
                resoult = usdToEuro / plnToEuro;               
            }

            if (resoult > 0 && resoult != null)
                return Math.Ceiling(resoult * 100) / 100;
            else return double.MinValue;
        }
    }
}
