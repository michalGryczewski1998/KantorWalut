using KantorWalutowy.Data.DataBase;
using KantorWalutowy.Enums;
using KantorWalutowy.Forms.MainView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantorWalutowy.Calculate
{
    public class CurrencyCalculates
    {
        private readonly string? _currencyName;
        private readonly string? _currencyRate;
        private readonly string? _currencyTime;
        private readonly TypeOfCalculate _typeOfCalculate;

        public CurrencyCalculates(string? currencyName, string? currencyRate, string? currencyTime, Enums.TypeOfCalculate typeOfCalculate)
        {
            _currencyName = currencyName;
            _currencyRate = currencyRate;
            _currencyTime = currencyTime;
            _typeOfCalculate = typeOfCalculate;

            StartUp();
        }

        private void StartUp()
        {
            if(_typeOfCalculate == TypeOfCalculate.PLNUSD) 
            {
                PlnToUsd();
            }
        }

        private void PlnToUsd()
        {
            double usdToEuro = Convert.ToDouble(_currencyRate);
            double plnToEuro = double.MinValue;
            double resoult = double.MinValue;

            using (var dbContext = new CurrencyDbContext())
            {
                var query = dbContext.Currencies.FirstOrDefault(m => m.CurrencyName == "PLN");
                plnToEuro = query.Rate;
            }

            if (plnToEuro != double.MinValue && usdToEuro != double.MinValue)
            {
                resoult = plnToEuro * usdToEuro;
            }

            MainView mainView = new MainView();
            mainView.CalculateResoult(resoult);
        }
    }
}
