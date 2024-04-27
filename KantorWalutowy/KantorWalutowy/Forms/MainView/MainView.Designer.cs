namespace KantorWalutowy.Forms.MainView
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Download_BTN = new Button();
            Currency_DGW = new DataGridView();
            Przybornik_GB = new GroupBox();
            Refresh_BTN = new Button();
            Calculate_GB = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            toListBox_LB = new ListBox();
            fromListBox_LB = new ListBox();
            label1 = new Label();
            Resoult_TB = new TextBox();
            CurrencyTo_TB = new TextBox();
            CurrencyFrom_TB = new TextBox();
            Calculate_BTN = new Button();
            data_DTP = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)Currency_DGW).BeginInit();
            Przybornik_GB.SuspendLayout();
            Calculate_GB.SuspendLayout();
            SuspendLayout();
            // 
            // Download_BTN
            // 
            Download_BTN.Location = new Point(6, 22);
            Download_BTN.Name = "Download_BTN";
            Download_BTN.Size = new Size(75, 23);
            Download_BTN.TabIndex = 0;
            Download_BTN.Text = "Pobierz";
            Download_BTN.UseVisualStyleBackColor = true;
            Download_BTN.Click += Download_BTN_Click;
            // 
            // Currency_DGW
            // 
            Currency_DGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Currency_DGW.Location = new Point(3, 5);
            Currency_DGW.Name = "Currency_DGW";
            Currency_DGW.Size = new Size(526, 433);
            Currency_DGW.TabIndex = 1;
            Currency_DGW.CellContentClick += Currency_DGW_CellContentClick;
            // 
            // Przybornik_GB
            // 
            Przybornik_GB.Controls.Add(Refresh_BTN);
            Przybornik_GB.Controls.Add(Download_BTN);
            Przybornik_GB.Location = new Point(533, 7);
            Przybornik_GB.Name = "Przybornik_GB";
            Przybornik_GB.Size = new Size(255, 56);
            Przybornik_GB.TabIndex = 2;
            Przybornik_GB.TabStop = false;
            Przybornik_GB.Text = "Przybornik";
            // 
            // Refresh_BTN
            // 
            Refresh_BTN.Location = new Point(87, 22);
            Refresh_BTN.Name = "Refresh_BTN";
            Refresh_BTN.Size = new Size(75, 23);
            Refresh_BTN.TabIndex = 1;
            Refresh_BTN.Text = "Odśwież";
            Refresh_BTN.UseVisualStyleBackColor = true;
            Refresh_BTN.Click += Refresh_BTN_Click;
            // 
            // Calculate_GB
            // 
            Calculate_GB.Controls.Add(data_DTP);
            Calculate_GB.Controls.Add(label4);
            Calculate_GB.Controls.Add(label3);
            Calculate_GB.Controls.Add(label2);
            Calculate_GB.Controls.Add(toListBox_LB);
            Calculate_GB.Controls.Add(fromListBox_LB);
            Calculate_GB.Controls.Add(label1);
            Calculate_GB.Controls.Add(Resoult_TB);
            Calculate_GB.Controls.Add(CurrencyTo_TB);
            Calculate_GB.Controls.Add(CurrencyFrom_TB);
            Calculate_GB.Controls.Add(Calculate_BTN);
            Calculate_GB.Location = new Point(535, 69);
            Calculate_GB.Name = "Calculate_GB";
            Calculate_GB.Size = new Size(253, 369);
            Calculate_GB.TabIndex = 3;
            Calculate_GB.TabStop = false;
            Calculate_GB.Text = "Obliczenia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 162);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 12;
            label4.Text = "Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 133);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 11;
            label3.Text = "WalutaDocelowa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 104);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 10;
            label2.Text = "Waluta pierwotna:";
            // 
            // toListBox_LB
            // 
            toListBox_LB.FormattingEnabled = true;
            toListBox_LB.ItemHeight = 15;
            toListBox_LB.Location = new Point(127, 19);
            toListBox_LB.Name = "toListBox_LB";
            toListBox_LB.Size = new Size(120, 79);
            toListBox_LB.TabIndex = 9;
            // 
            // fromListBox_LB
            // 
            fromListBox_LB.FormattingEnabled = true;
            fromListBox_LB.ItemHeight = 15;
            fromListBox_LB.Location = new Point(5, 19);
            fromListBox_LB.Name = "fromListBox_LB";
            fromListBox_LB.Size = new Size(120, 79);
            fromListBox_LB.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 199);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Wynik:";
            // 
            // Resoult_TB
            // 
            Resoult_TB.Location = new Point(55, 191);
            Resoult_TB.Name = "Resoult_TB";
            Resoult_TB.Size = new Size(191, 23);
            Resoult_TB.TabIndex = 6;
            // 
            // CurrencyTo_TB
            // 
            CurrencyTo_TB.Location = new Point(127, 133);
            CurrencyTo_TB.Name = "CurrencyTo_TB";
            CurrencyTo_TB.Size = new Size(119, 23);
            CurrencyTo_TB.TabIndex = 4;
            // 
            // CurrencyFrom_TB
            // 
            CurrencyFrom_TB.Location = new Point(127, 104);
            CurrencyFrom_TB.Name = "CurrencyFrom_TB";
            CurrencyFrom_TB.Size = new Size(119, 23);
            CurrencyFrom_TB.TabIndex = 3;
            // 
            // Calculate_BTN
            // 
            Calculate_BTN.Location = new Point(6, 340);
            Calculate_BTN.Name = "Calculate_BTN";
            Calculate_BTN.Size = new Size(75, 23);
            Calculate_BTN.TabIndex = 2;
            Calculate_BTN.Text = "Oblicz";
            Calculate_BTN.UseVisualStyleBackColor = true;
            Calculate_BTN.Click += Calculate_BTN_Click;
            // 
            // data_DTP
            // 
            data_DTP.Format = DateTimePickerFormat.Short;
            data_DTP.Location = new Point(55, 162);
            data_DTP.Name = "data_DTP";
            data_DTP.Size = new Size(192, 23);
            data_DTP.TabIndex = 13;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Calculate_GB);
            Controls.Add(Przybornik_GB);
            Controls.Add(Currency_DGW);
            Name = "MainView";
            Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)Currency_DGW).EndInit();
            Przybornik_GB.ResumeLayout(false);
            Calculate_GB.ResumeLayout(false);
            Calculate_GB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Download_BTN;
        private DataGridView Currency_DGW;
        private GroupBox Przybornik_GB;
        private Button Refresh_BTN;
        private GroupBox Calculate_GB;
        private Button Calculate_BTN;
        private Label label1;
        private TextBox Resoult_TB;
        private TextBox CurrencyTo_TB;
        private TextBox CurrencyFrom_TB;
        private ListBox fromListBox_LB;
        private ListBox toListBox_LB;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker data_DTP;
    }
}