using AutoMapper;
using KantorWalutowy.Calculate;
using KantorWalutowy.Data.DataBase;
using KantorWalutowy.Data.Interfaces;
using KantorWalutowy.Download;
using KantorWalutowy.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KantorWalutowy.Forms.MainView
{
    public partial class MainView : Form
    {
        private readonly IDownload _download;

        public MainView(IMapper mapper)
        {
            InitializeComponent();
            _download = new DownloadServices(mapper);
        }

        public MainView()
        {
            Resoult_TB.Text = string.Empty;
        }

        private void Download_BTN_Click(object sender, EventArgs e)
        {
            var status = _download.GetData();

            if (status)
            {
                MessageBox.Show("Pobrano dane.");
                AddToGridView();
            }
            else
            {
                MessageBox.Show($"Nie pobrano danych, być może dane na dzień dzisiejszy {DateTime.Now.Date} zostały już pobrane.");
            }
        }

        private void AddToGridView()
        {
            using (var dbContext = new CurrencyDbContext())
            {
                var query = dbContext.Currencies.ToList();

                Currency_DGW.DataSource = query;
            }
        }

        private void Refresh_BTN_Click(object sender, EventArgs e)
        {
            AddToGridView();
        }

        private void Currency_DGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Currency_DGW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (Currency_DGW.SelectedRows.Count > 0)
            {
                DataGridViewRow row = Currency_DGW.SelectedRows[0];

                Currency_TB.Text = row.Cells["CurrencyName"].Value.ToString();
                Rate_TB.Text = row.Cells["Rate"].Value.ToString();
                Time_TB.Text = row.Cells["Time"].Value.ToString();                
            }
        }

        private void Calculates(string? currencyName, string? currencyRate, string? currencyTime, TypeOfCalculate typeOfCalculate)
        {
            CurrencyCalculates currencyCalculates = new CurrencyCalculates(currencyName, currencyRate, currencyTime, typeOfCalculate);
        }

        private void Calculate_BTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Currency_TB.Text) || string.IsNullOrEmpty(Rate_TB.Text) || string.IsNullOrEmpty(Time_TB.Text) || Calculate_CLB.CheckedItems == null)
            {
                MessageBox.Show("Nie wybrano waluty podstawowej z formatki lub brak typu obliczenia !");
            }
            else
            {
                var name = Currency_TB.Text;
                var rate = Rate_TB.Text;
                var time = Time_TB.Text;

                if (Calculate_CLB.SelectedItem.ToString() == "Kurs PLN do USD")
                {
                    Calculates(name, rate, time, TypeOfCalculate.PLNUSD);
                }              
            }
        }

        public void CalculateResoult(double resoult)
        {            
            Resoult_TB.Text = resoult.ToString();
        }
    }
}
