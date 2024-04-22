using KantorWalutowy.Data.DataBase;
using KantorWalutowy.Data.DataBase.Entities;
using KantorWalutowy.Data.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KantorWalutowy.Download
{
    public class DownloadServices : IDownload
    {
        private readonly string _url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml";
        private readonly CurrencyDbContext _dbContext;

        public bool GetData()
        {
            XmlReader reader = XmlReader.Create(_url);
            List<Currency> listCurrency = new List<Currency>(); ;
            DateTime date = DateTime.MinValue;

            if (reader != null)
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        
                        if (reader.Name == "Cube" && reader.HasAttributes)
                        {
                            if (reader.Name == "Cube" && reader.GetAttribute("time") != null)
                            {
                                date = Convert.ToDateTime(reader.GetAttribute("time"));
                            }
                            if (reader.GetAttribute("rate") != null && reader.GetAttribute("currency") != null)
                            {
                                Currency currency = new Currency();
                                
                                currency.CurrencyName = reader.GetAttribute("currency");
                                currency.Rate = Convert.ToDouble(reader.GetAttribute("rate").Replace(".", ","));
                                currency.Time = date;
                                listCurrency.Add(currency);
                            }
                        }
                    }
                }
                if (listCurrency.Count > 0)
                {
                    return true;
                }

                //_dbContext.Currencies.Add(currency);
                //_dbContext.SaveChanges();
            }
            return false;
        }
    }
}
