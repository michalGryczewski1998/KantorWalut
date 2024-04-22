using AutoMapper;
using KantorWalutowy.Data.DataBase;
using KantorWalutowy.Data.DataBase.Entities;
using KantorWalutowy.Data.DataBase.Models;
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
        private readonly IMapper _mapper;

        public DownloadServices(IMapper mapper)
        {
            _mapper = mapper;
        }

        public bool GetData()
        {
            XmlReader reader = XmlReader.Create(_url);
            List<CurrencyDto> listCurrency = new List<CurrencyDto>(); ;
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
                                CurrencyDto currency = new CurrencyDto();
                                
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
                    AddToDatabase(listCurrency);
                    return true;
                }
            }
            return false;
        }

        private void AddToDatabase(List<CurrencyDto> dtos)
        {
            using (var dbContext = new CurrencyDbContext())
            {
                foreach (var currency in dtos)
                {
                    CurrencyDto currencyDto = currency;
                    var entity = _mapper.Map<Currency>(currencyDto);

                    dbContext.Currencies.Add(entity);                    
                }
                dbContext.SaveChanges();
            }
        }
    }
}
