using AutoMapper;
using KantorWalutowy.Data.DataBase;
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

        private void Download_BTN_Click(object sender, EventArgs e)
        {            
            var status = _download.GetData();

            if(status != null)
            {
                MessageBox.Show("Pobrano dane.");
            }
        }
    }
}
