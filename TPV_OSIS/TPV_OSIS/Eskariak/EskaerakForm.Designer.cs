namespace TPV_OSIS.Eskariak
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
            // 
            // flpKategoriak
            // 
            this.flpKategoriak.AutoScroll = true;
            this.flpKategoriak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.flpKategoriak.Location = new System.Drawing.Point(12, 50);
            this.flpKategoriak.Name = "flpKategoriak";
            this.flpKategoriak.Size = new System.Drawing.Size(200, 480);
            this.flpKategoriak.TabIndex = 5;
            // 
            // flpPlaterak
            // 
            this.flpPlaterak.AutoScroll = true;
            this.flpPlaterak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.flpPlaterak.Location = new System.Drawing.Point(220, 50);
            this.flpPlaterak.Name = "flpPlaterak";
            this.flpPlaterak.Size = new System.Drawing.Size(400, 480);
            this.flpPlaterak.TabIndex = 4;
            // 
            // grpKarritoa
            // 
            this.grpKarritoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.grpKarritoa.Controls.Add(this.flpKarritoa);
            this.grpKarritoa.Controls.Add(this.lblTotala);
            this.grpKarritoa.Controls.Add(this.btnEskatu);
            this.grpKarritoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpKarritoa.Location = new System.Drawing.Point(630, 50);
            this.grpKarritoa.Name = "grpKarritoa";
            this.grpKarritoa.Size = new System.Drawing.Size(420, 480);
            this.grpKarritoa.TabIndex = 3;
            this.grpKarritoa.TabStop = false;
            this.grpKarritoa.Text = "🛒 Karritoa";
            // 
            // flpKarritoa
            // 
            this.flpKarritoa.AutoScroll = true;
            this.flpKarritoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.flpKarritoa.Location = new System.Drawing.Point(10, 25);
            this.flpKarritoa.Name = "flpKarritoa";
            this.flpKarritoa.Size = new System.Drawing.Size(400, 350);
            this.flpKarritoa.TabIndex = 0;
            // 
            // lblTotala
            // 
            this.lblTotala.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotala.ForeColor = System.Drawing.Color.White;
            this.lblTotala.Location = new System.Drawing.Point(10, 385);
            this.lblTotala.Name = "lblTotala";
            this.lblTotala.Size = new System.Drawing.Size(400, 25);
            this.lblTotala.TabIndex = 1;
            this.lblTotala.Text = "Totala: 0.00 €";
            // 
            // btnEskatu
            // 
            this.btnEskatu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.btnEskatu.FlatAppearance.BorderSize = 0;
            this.btnEskatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEskatu.ForeColor = System.Drawing.Color.Black;
            this.btnEskatu.Location = new System.Drawing.Point(10, 430);
            this.btnEskatu.Name = "btnEskatu";
            this.btnEskatu.Size = new System.Drawing.Size(400, 35);
            this.btnEskatu.TabIndex = 2;
            this.btnEskatu.Text = "ESKATU";
            this.btnEskatu.UseVisualStyleBackColor = false;
            this.btnEskatu.Click += new System.EventHandler(this.btnEskatu_Klik);
            // 
            // btnTxat
            // 
            this.btnTxat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnTxat.FlatAppearance.BorderSize = 0;
            this.btnTxat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxat.ForeColor = System.Drawing.Color.White;
            this.btnTxat.Location = new System.Drawing.Point(950, 10);
            this.btnTxat.Name = "btnTxat";
            this.btnTxat.Size = new System.Drawing.Size(100, 30);
            this.btnTxat.TabIndex = 2;
            this.btnTxat.Text = "Txata";
            this.btnTxat.UseVisualStyleBackColor = false;
            this.btnTxat.Click += new System.EventHandler(this.btnTxat_Click);
            // 
            // lblErabiltzailea
            // 
            this.lblErabiltzailea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblErabiltzailea.Location = new System.Drawing.Point(230, 15);
            this.lblErabiltzailea.Name = "lblErabiltzailea";
            this.lblErabiltzailea.Size = new System.Drawing.Size(300, 23);
            this.lblErabiltzailea.TabIndex = 1;
            this.lblErabiltzailea.Text = "Erabiltzailea:";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::TPV_OSIS.Properties.Resources.Logo_Osis_Sales;
            this.picLogo.Location = new System.Drawing.Point(12, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // EskaerakForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1059, 540);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblErabiltzailea);
            this.Controls.Add(this.btnTxat);
            this.Controls.Add(this.grpKarritoa);
            this.Controls.Add(this.flpPlaterak);
            this.Controls.Add(this.flpKategoriak);
            this.Name = "EskaerakForm";
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
