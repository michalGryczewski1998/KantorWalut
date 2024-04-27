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
        public double Calculate(string fromData, string toData, string date)
        {
            var dbContext = new CurrencyDbContext();
            double resoult = double.MinValue;

            string from = fromData;
            string to = toData == null ? "brakDanych" : toData;

            if (from == to)
            {
                resoult = 1;
            }
            else if (to.Contains("brakDanych"))
            {
                var query = dbContext.Currencies.FirstOrDefault(x => x.CurrencyName == from && x.Time.Date == Convert.ToDateTime(date));
                resoult = query.Rate;
            }
            else if (from.Contains("EUR"))
            {
                var query = dbContext.Currencies.FirstOrDefault(x => x.CurrencyName == to && x.Time.Date == Convert.ToDateTime(date));
                resoult = query.Rate;
            }
            else if (to.Contains("EUR"))
            {
                var query = dbContext.Currencies.FirstOrDefault(x => x.CurrencyName == from && x.Time.Date == Convert.ToDateTime(date));
                resoult = 1 / query.Rate;
            }
            else
            {
                var queryFrom = dbContext.Currencies.FirstOrDefault(x => x.CurrencyName == from && x.Time.Date == Convert.ToDateTime(date));
                var queryTo = dbContext.Currencies.FirstOrDefault(x => x.CurrencyName == to && x.Time.Date == Convert.ToDateTime(date));

                resoult = queryTo.Rate / queryFrom.Rate;
            }

            if (resoult > 0 && resoult != null)
                return Math.Ceiling(resoult * 100) / 100;
            else return double.MinValue;
        }
    }
}
