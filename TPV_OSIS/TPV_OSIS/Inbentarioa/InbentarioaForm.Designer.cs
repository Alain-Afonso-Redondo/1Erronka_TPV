namespace TPV_OSIS.Inbentarioa
{
    partial class InbentarioaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flpOsagaiak;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flpOsagaiak = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();

            // ====== FLOWLAYOUT OSAGAIAK ======
            this.flpOsagaiak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOsagaiak.AutoScroll = true;
            this.flpOsagaiak.Padding = new System.Windows.Forms.Padding(20);
            this.flpOsagaiak.BackColor = System.Drawing.Color.FromArgb(245, 247, 246);

            // ====== FORM ======
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.flpOsagaiak);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inbentarioa - Osagaiak";
            this.Load += new System.EventHandler(this.InbentarioaForm_Load);

            this.ResumeLayout(false);
        }
    }
}
