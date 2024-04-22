using AutoMapper;
using KantorWalutowy.Data.DataBase.Entities;
using KantorWalutowy.Data.DataBase.Models;
using KantorWalutowy.Forms.MainView;

namespace KantorWalutowy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.CurrentInputLanguage.Equals("pl-PL");

            var config = new MapperConfiguration(m =>
            {
                m.CreateMap<CurrencyDto, Currency>();
            });

            IMapper mapper = config.CreateMapper();

            Application.Run(new MainView(mapper));
        }
    }
}