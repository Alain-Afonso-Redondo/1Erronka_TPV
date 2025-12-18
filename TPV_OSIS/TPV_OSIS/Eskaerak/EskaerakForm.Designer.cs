namespace TPV_OSIS.Eskaerak
{
    partial class EskaerakForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flpKategoriak = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlaterak = new System.Windows.Forms.FlowLayoutPanel();
            this.grpKarritoa = new System.Windows.Forms.GroupBox();
            this.flpKarritoa = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotala = new System.Windows.Forms.Label();
            this.btnEskatu = new System.Windows.Forms.Button();
            this.btnTxat = new System.Windows.Forms.Button();
            this.lblErabiltzailea = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();

            this.grpKarritoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();

            // ===== FORM =====
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            // ===== LOGO =====
            this.picLogo.Image = global::TPV_OSIS.Properties.Resources.Logo_Osis_Sales;
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.Location = new System.Drawing.Point(12, 5);
            this.picLogo.Size = new System.Drawing.Size(200, 40);

            // ===== ERABILTZAILEA =====
            this.lblErabiltzailea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblErabiltzailea.Location = new System.Drawing.Point(230, 15);
            this.lblErabiltzailea.Size = new System.Drawing.Size(300, 23);
            this.lblErabiltzailea.Text = "Erabiltzailea:";

            // ===== TXAT =====
            this.btnTxat.Text = "Txata";
            this.btnTxat.BackColor = System.Drawing.Color.FromArgb(31, 107, 58);
            this.btnTxat.ForeColor = System.Drawing.Color.White;
            this.btnTxat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxat.FlatAppearance.BorderSize = 0;
            this.btnTxat.Location = new System.Drawing.Point(950, 10);
            this.btnTxat.Size = new System.Drawing.Size(100, 30);
            this.btnTxat.Click += new System.EventHandler(this.btnTxat_Click);

            // ===== KATEGORIAK =====
            this.flpKategoriak.Location = new System.Drawing.Point(12, 50);
            this.flpKategoriak.Size = new System.Drawing.Size(200, 480);
            this.flpKategoriak.AutoScroll = true;
            this.flpKategoriak.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);

            // ===== PLATERAK =====
            this.flpPlaterak.Location = new System.Drawing.Point(220, 50);
            this.flpPlaterak.Size = new System.Drawing.Size(400, 480);
            this.flpPlaterak.AutoScroll = true;
            this.flpPlaterak.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            // ===== KARRITOA =====
            this.grpKarritoa.Text = "🛒 Karritoa";
            this.grpKarritoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpKarritoa.Location = new System.Drawing.Point(630, 50);
            this.grpKarritoa.Size = new System.Drawing.Size(420, 480);
            this.grpKarritoa.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);

            // ===== FLP KARRITOA =====
            this.flpKarritoa.Location = new System.Drawing.Point(10, 25);
            this.flpKarritoa.Size = new System.Drawing.Size(400, 350);
            this.flpKarritoa.AutoScroll = true;
            this.flpKarritoa.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.grpKarritoa.Controls.Add(this.flpKarritoa);

            // ===== TOTALA =====
            this.lblTotala.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotala.ForeColor = System.Drawing.Color.White;
            this.lblTotala.Location = new System.Drawing.Point(10, 385);
            this.lblTotala.Size = new System.Drawing.Size(400, 25);
            this.lblTotala.Text = "Totala: 0.00 €";
            this.grpKarritoa.Controls.Add(this.lblTotala);

            // ===== ESKATU =====
            this.btnEskatu.Text = "ESKATU";
            this.btnEskatu.BackColor = System.Drawing.Color.FromArgb(242, 140, 56);
            this.btnEskatu.ForeColor = System.Drawing.Color.Black;
            this.btnEskatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEskatu.FlatAppearance.BorderSize = 0;
            this.btnEskatu.Location = new System.Drawing.Point(10, 430);
            this.btnEskatu.Size = new System.Drawing.Size(400, 35);
            this.btnEskatu.Click += new System.EventHandler(this.btnEskatu_Klik);
            this.grpKarritoa.Controls.Add(this.btnEskatu);

            // ===== FORM =====
            this.ClientSize = new System.Drawing.Size(1060, 561);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblErabiltzailea);
            this.Controls.Add(this.btnTxat);
            this.Controls.Add(this.grpKarritoa);
            this.Controls.Add(this.flpPlaterak);
            this.Controls.Add(this.flpKategoriak);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSIS TPV - Eskariak";
            this.Load += new System.EventHandler(this.EskaerakForm_Load);

            this.grpKarritoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.FlowLayoutPanel flpKategoriak;
        private System.Windows.Forms.FlowLayoutPanel flpPlaterak;
        private System.Windows.Forms.FlowLayoutPanel flpKarritoa;
        private System.Windows.Forms.GroupBox grpKarritoa;
        private System.Windows.Forms.Label lblTotala;
        private System.Windows.Forms.Button btnEskatu;
        private System.Windows.Forms.Button btnTxat;
        private System.Windows.Forms.Label lblErabiltzailea;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
