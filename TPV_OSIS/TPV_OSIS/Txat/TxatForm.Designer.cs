namespace TPV_OSIS
{
    partial class TxatForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblErabiltzaile = new System.Windows.Forms.Label();
            this.txtMezuak = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnBidali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblErabiltzaile
            // 
            this.lblErabiltzaile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblErabiltzaile.Location = new System.Drawing.Point(12, 9);
            this.lblErabiltzaile.Name = "lblErabiltzaile";
            this.lblErabiltzaile.Size = new System.Drawing.Size(350, 30);
            this.lblErabiltzaile.TabIndex = 0;
            this.lblErabiltzaile.Text = "Erabiltzaile";
            // 
            // txtMezuak
            // 
            this.txtMezuak.Location = new System.Drawing.Point(12, 45);
            this.txtMezuak.Multiline = true;
            this.txtMezuak.Name = "txtMezuak";
            this.txtMezuak.ReadOnly = true;
            this.txtMezuak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMezuak.Size = new System.Drawing.Size(560, 320);
            this.txtMezuak.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 375);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(460, 22);
            this.txtInput.TabIndex = 2;
            // 
            // btnBidali
            // 
            this.btnBidali.Location = new System.Drawing.Point(480, 371);
            this.btnBidali.Name = "btnBidali";
            this.btnBidali.Size = new System.Drawing.Size(92, 30);
            this.btnBidali.TabIndex = 3;
            this.btnBidali.Text = "Bidali";
            this.btnBidali.UseVisualStyleBackColor = true;
            this.btnBidali.Click += new System.EventHandler(this.btnBidali_Klik);
            // 
            // TxatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnBidali);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtMezuak);
            this.Controls.Add(this.lblErabiltzaile);
            this.Name = "TxatForm";
            this.Text = "Txat";
            this.Load += new System.EventHandler(this.TxatForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TxatForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblErabiltzaile;
        private System.Windows.Forms.TextBox txtMezuak;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnBidali;
    }
}
