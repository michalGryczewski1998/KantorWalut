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
            ((System.ComponentModel.ISupportInitialize)Currency_DGW).BeginInit();
            Przybornik_GB.SuspendLayout();
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
            // 
            // Przybornik_GB
            // 
            Przybornik_GB.Controls.Add(Refresh_BTN);
            Przybornik_GB.Controls.Add(Download_BTN);
            Przybornik_GB.Location = new Point(533, 7);
            Przybornik_GB.Name = "Przybornik_GB";
            Przybornik_GB.Size = new Size(255, 431);
            Przybornik_GB.TabIndex = 2;
            Przybornik_GB.TabStop = false;
            Przybornik_GB.Text = "Przybornik";
            // 
            // Refresh_BTN
            // 
            Refresh_BTN.Location = new Point(6, 51);
            Refresh_BTN.Name = "Refresh_BTN";
            Refresh_BTN.Size = new Size(75, 23);
            Refresh_BTN.TabIndex = 1;
            Refresh_BTN.Text = "Odśwież";
            Refresh_BTN.UseVisualStyleBackColor = true;
            Refresh_BTN.Click += Refresh_BTN_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Przybornik_GB);
            Controls.Add(Currency_DGW);
            Name = "MainView";
            Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)Currency_DGW).EndInit();
            Przybornik_GB.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Download_BTN;
        private DataGridView Currency_DGW;
        private GroupBox Przybornik_GB;
        private Button Refresh_BTN;
    }
}