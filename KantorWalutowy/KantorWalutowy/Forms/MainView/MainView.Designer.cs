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
            SuspendLayout();
            // 
            // Download_BTN
            // 
            Download_BTN.Location = new Point(12, 415);
            Download_BTN.Name = "Download_BTN";
            Download_BTN.Size = new Size(75, 23);
            Download_BTN.TabIndex = 0;
            Download_BTN.Text = "Pobierz";
            Download_BTN.UseVisualStyleBackColor = true;
            Download_BTN.Click += Download_BTN_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Download_BTN);
            Name = "MainView";
            Text = "MainView";
            ResumeLayout(false);
        }

        #endregion

        private Button Download_BTN;
    }
}