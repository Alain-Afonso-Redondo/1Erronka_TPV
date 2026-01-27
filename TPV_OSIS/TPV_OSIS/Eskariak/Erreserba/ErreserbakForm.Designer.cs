namespace TPV_OSIS.Eskariak.Erreserbak
{
    partial class ErreserbakForm
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
            this.pnlEzkerra = new System.Windows.Forms.Panel();
            this.lblErreserbak = new System.Windows.Forms.Label();
            this.flpErreserbak = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlEskuina = new System.Windows.Forms.Panel();
            this.flpMahaiak = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlBotoiak = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblTxanda = new System.Windows.Forms.Label();
            this.cmbTxanda = new System.Windows.Forms.ComboBox();
            this.btnGehitu = new System.Windows.Forms.Button();
            this.btnEditatu = new System.Windows.Forms.Button();
            this.btnEzabatu = new System.Windows.Forms.Button();

            // ===== FORM =====
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Text = "Erreserbak";
            this.BackColor = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ErreserbakForm_Load);

            
            // ======== PNL BOTOIAK ========
            
            this.pnlBotoiak.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoiak.Height = 110;
            this.pnlBotoiak.BackColor = System.Drawing.Color.White;
            this.pnlBotoiak.Padding = new System.Windows.Forms.Padding(20);

            // ====== DATA ======
            this.lblData.Text = "DATA";
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblData.Location = new System.Drawing.Point(20, 15);

            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(20, 40);
            this.dtpData.Width = 140;

            // ======== TXANDA ========
            this.lblTxanda.Text = "TXANDA";
            this.lblTxanda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTxanda.Location = new System.Drawing.Point(180, 15);

            this.cmbTxanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTxanda.Location = new System.Drawing.Point(180, 40);
            this.cmbTxanda.Width = 140;

            // ======== BOTOIAK ========
            this.btnGehitu.Text = "GEHITU";
            this.btnGehitu.Size = new System.Drawing.Size(120, 40);
            this.btnGehitu.Location = new System.Drawing.Point(360, 35);
            this.btnGehitu.BackColor = System.Drawing.Color.FromArgb(243, 134, 58);
            this.btnGehitu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGehitu.Click += new System.EventHandler(this.btnGehitu_Click);

            this.btnEditatu.Text = "EDITATU";
            this.btnEditatu.Size = new System.Drawing.Size(120, 40);
            this.btnEditatu.Location = new System.Drawing.Point(500, 35);
            this.btnEditatu.Enabled = false;
            this.btnEditatu.Click += new System.EventHandler(this.btnEditatu_Click);

            this.btnEzabatu.Text = "EZABATU";
            this.btnEzabatu.Size = new System.Drawing.Size(120, 40);
            this.btnEzabatu.Location = new System.Drawing.Point(640, 35);
            this.btnEzabatu.Enabled = false;

            this.pnlBotoiak.Controls.AddRange(new System.Windows.Forms.Control[]
            {
        this.lblData, this.dtpData,
        this.lblTxanda, this.cmbTxanda,
        this.btnGehitu, this.btnEditatu, this.btnEzabatu
            });

            
            // ========== PANEL EZKERRA ==========
            
            this.pnlEzkerra.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEzkerra.Width = 280;
            this.pnlEzkerra.BackColor = System.Drawing.Color.White;
            this.pnlEzkerra.Padding = new System.Windows.Forms.Padding(10);

            this.lblErreserbak.Text = "ERRESERBAK";
            this.lblErreserbak.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblErreserbak.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblErreserbak.Height = 30;

            this.flpErreserbak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpErreserbak.AutoScroll = true;
            this.flpErreserbak.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpErreserbak.WrapContents = false;

            this.pnlEzkerra.Controls.Add(this.flpErreserbak);
            this.pnlEzkerra.Controls.Add(this.lblErreserbak);

           
            // ========== PANEL ESKUBIA ===========
  
            this.pnlEskuina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEskuina.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);

            this.flpMahaiak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMahaiak.Padding = new System.Windows.Forms.Padding(20);
            this.flpMahaiak.AutoScroll = true;

            this.pnlEskuina.Controls.Add(this.flpMahaiak);

            
            // ========== ADD CONTROLS ==========
            
            this.Controls.Add(this.pnlEskuina);
            this.Controls.Add(this.pnlEzkerra);
            this.Controls.Add(this.pnlBotoiak);
        }


        private System.Windows.Forms.Panel pnlEzkerra;
        private System.Windows.Forms.Label lblErreserbak;
        private System.Windows.Forms.FlowLayoutPanel flpErreserbak;

        private System.Windows.Forms.Panel pnlEskuina;
        private System.Windows.Forms.FlowLayoutPanel flpMahaiak;

        private System.Windows.Forms.Panel pnlBotoiak;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblTxanda;
        private System.Windows.Forms.ComboBox cmbTxanda;
        private System.Windows.Forms.Button btnGehitu;
        private System.Windows.Forms.Button btnEditatu;
        private System.Windows.Forms.Button btnEzabatu;
    }
}
