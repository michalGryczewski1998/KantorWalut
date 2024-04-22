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
            label1 = new Label();
            Resoult_TB = new TextBox();
            Time_TB = new TextBox();
            Rate_TB = new TextBox();
            Currency_TB = new TextBox();
            Calculate_BTN = new Button();
            Calculate_CLB = new CheckedListBox();
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
            Calculate_GB.Controls.Add(label1);
            Calculate_GB.Controls.Add(Resoult_TB);
            Calculate_GB.Controls.Add(Time_TB);
            Calculate_GB.Controls.Add(Rate_TB);
            Calculate_GB.Controls.Add(Currency_TB);
            Calculate_GB.Controls.Add(Calculate_BTN);
            Calculate_GB.Controls.Add(Calculate_CLB);
            Calculate_GB.Location = new Point(535, 69);
            Calculate_GB.Name = "Calculate_GB";
            Calculate_GB.Size = new Size(253, 369);
            Calculate_GB.TabIndex = 3;
            Calculate_GB.TabStop = false;
            Calculate_GB.Text = "Obliczenia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 201);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Wynik:";
            // 
            // Resoult_TB
            // 
            Resoult_TB.Location = new Point(6, 219);
            Resoult_TB.Name = "Resoult_TB";
            Resoult_TB.Size = new Size(240, 23);
            Resoult_TB.TabIndex = 6;
            // 
            // Time_TB
            // 
            Time_TB.Location = new Point(7, 165);
            Time_TB.Name = "Time_TB";
            Time_TB.Size = new Size(100, 23);
            Time_TB.TabIndex = 5;
            // 
            // Rate_TB
            // 
            Rate_TB.Location = new Point(7, 136);
            Rate_TB.Name = "Rate_TB";
            Rate_TB.Size = new Size(100, 23);
            Rate_TB.TabIndex = 4;
            // 
            // Currency_TB
            // 
            Currency_TB.Location = new Point(7, 107);
            Currency_TB.Name = "Currency_TB";
            Currency_TB.Size = new Size(100, 23);
            Currency_TB.TabIndex = 3;
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
            // Calculate_CLB
            // 
            Calculate_CLB.FormattingEnabled = true;
            Calculate_CLB.Items.AddRange(new object[] { "Kurs PLN do USD", "Kurs Dolara do Euro", "Kurs Euro do PLN", "Kurs Dolara do PLN" });
            Calculate_CLB.Location = new Point(4, 20);
            Calculate_CLB.Name = "Calculate_CLB";
            Calculate_CLB.Size = new Size(243, 76);
            Calculate_CLB.TabIndex = 0;
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
        private CheckedListBox Calculate_CLB;
        private Label label1;
        private TextBox Resoult_TB;
        private TextBox Time_TB;
        private TextBox Rate_TB;
        private TextBox Currency_TB;
    }
}