using AutoMapper;
using KantorWalutowy.Calculate;
using KantorWalutowy.Data.DataBase;
using KantorWalutowy.Data.DataBase.Entities;
using KantorWalutowy.Data.Interfaces;
using KantorWalutowy.Download;
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
            RefreshList();
        }

        private void RefreshList()
        {
            using (var dbContext = new CurrencyDbContext())
            {
                var query = dbContext.Currencies
                    .Select(z => z.CurrencyName)
                    .Distinct();

                //ToDo
                //Czemu w zapytaniu niezadziałał Distinct() ?!?
                if (query != null && (fromListBox_LB.Items.Count == 0 && toListBox_LB.Items.Count == 0))
                {
                    fromListBox_LB.Items.AddRange(query.ToArray());
                    toListBox_LB.Items.AddRange(query.ToArray());

                    fromListBox_LB.Items.Add("EUR");
                    toListBox_LB.Items.Add("EUR");
                }
                else
                {
                    if (fromListBox_LB.Items.Count > 0 && toListBox_LB.Items.Count > 0)
                    {
                        MessageBox.Show("Dane już pobrane");
                    }
                    else
                    {
                        MessageBox.Show("Brak walut do wyświetlenia.");
                    }
                }

            }
        }

        private void Currency_DGW_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        private void Calculate_BTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fromListBox_LB.SelectedItem.ToString()) || string.IsNullOrEmpty(toListBox_LB.SelectedItem.ToString()) || string.IsNullOrEmpty(data_DTP.Text))
            {
                MessageBox.Show("Nie wybrano waluty podstawowej z formatki lub brak typu obliczenia !");
            }
            else
            {
                var currencyFrom = fromListBox_LB.SelectedItem.ToString();
                var currencyTo = toListBox_LB.SelectedItem.ToString();
                var time = data_DTP.Text;

                CurrencyFrom_TB.Text = currencyFrom;
                CurrencyTo_TB.Text = currencyTo;

                CurrencyCalculates currencyCalculates = new CurrencyCalculates();

                var finalResoult = currencyCalculates.Calculate(currencyFrom, currencyTo, time);

                if (finalResoult != double.MinValue)
                {
                    Resoult_TB.Text = finalResoult.ToString();
                }
                else
                {
                    Resoult_TB.Text = "Błąd podczas obliczeń";
                }
            }
        }
    }
}
