namespace TPV_OSIS
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Login));

            this.txbErab = new System.Windows.Forms.TextBox();
            this.txbPasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSartu = new System.Windows.Forms.Button();
            this.lblMezua = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();

            // ===== FORM =====
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSIS TPV - Sarrera";

            // ===== LOGO =====
            this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.Location = new System.Drawing.Point(150, 20);
            this.pboxLogo.Size = new System.Drawing.Size(300, 120);
            this.pboxLogo.BackColor = System.Drawing.Color.Transparent;

            // ===== LABEL ERABILTZAILEA =====
            this.label1.Text = "Erabiltzailea";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.label1.Location = new System.Drawing.Point(200, 150);

            // ===== TXB ERABILTZAILEA =====
            this.txbErab.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbErab.Location = new System.Drawing.Point(200, 175);
            this.txbErab.Size = new System.Drawing.Size(200, 30);

            // ===== LABEL PASAHITZA =====
            this.label2.Text = "Pasahitza";
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.label2.Location = new System.Drawing.Point(200, 215);

            // ===== TXB PASAHITZA =====
            this.txbPasa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbPasa.PasswordChar = '●';
            this.txbPasa.Location = new System.Drawing.Point(200, 240);
            this.txbPasa.Size = new System.Drawing.Size(200, 30);

            // ===== BOTOIA SARTU =====
            this.btnSartu.Text = "Sartu";
            this.btnSartu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSartu.BackColor = System.Drawing.Color.FromArgb(31, 107, 58);
            this.btnSartu.ForeColor = System.Drawing.Color.White;
            this.btnSartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSartu.FlatAppearance.BorderSize = 0;
            this.btnSartu.Location = new System.Drawing.Point(200, 290);
            this.btnSartu.Size = new System.Drawing.Size(200, 35);
            this.btnSartu.Click += new System.EventHandler(this.btnSartu_Klik);

            // ===== MEZUA =====
            this.lblMezua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblMezua.ForeColor = System.Drawing.Color.Red;
            this.lblMezua.Location = new System.Drawing.Point(200, 335);
            this.lblMezua.Size = new System.Drawing.Size(200, 20);
            this.lblMezua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ===== ADD CONTROLS =====
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbErab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPasa);
            this.Controls.Add(this.btnSartu);
            this.Controls.Add(this.lblMezua);

            this.Load += new System.EventHandler(this.Login_Load);

            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txbErab;
        private System.Windows.Forms.TextBox txbPasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSartu;
        private System.Windows.Forms.Label lblMezua;
        private System.Windows.Forms.PictureBox pboxLogo;
    }
}
