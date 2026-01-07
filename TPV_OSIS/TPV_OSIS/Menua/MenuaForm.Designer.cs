namespace TPV_OSIS.Menua
{
    partial class MenuaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuaForm));
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.btnEskaria = new System.Windows.Forms.Button();
            this.btnInbentarioa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
            this.pboxLogo.Location = new System.Drawing.Point(200, 40);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(400, 140);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // btnEskaria
            // 
            this.btnEskaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(48)))));
            this.btnEskaria.FlatAppearance.BorderSize = 0;
            this.btnEskaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEskaria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEskaria.ForeColor = System.Drawing.Color.White;
            this.btnEskaria.Location = new System.Drawing.Point(220, 250);
            this.btnEskaria.Name = "btnEskaria";
            this.btnEskaria.Size = new System.Drawing.Size(160, 50);
            this.btnEskaria.TabIndex = 1;
            this.btnEskaria.Text = "Eskariak";
            this.btnEskaria.UseVisualStyleBackColor = false;
            this.btnEskaria.Click += new System.EventHandler(this.btnEskaria_Click);

            // 
            // btnInbentarioa
            // 
            this.btnInbentarioa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.btnInbentarioa.FlatAppearance.BorderSize = 0;
            this.btnInbentarioa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInbentarioa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInbentarioa.ForeColor = System.Drawing.Color.White;
            this.btnInbentarioa.Location = new System.Drawing.Point(420, 250);
            this.btnInbentarioa.Name = "btnInbentarioa";
            this.btnInbentarioa.Size = new System.Drawing.Size(160, 50);
            this.btnInbentarioa.TabIndex = 2;
            this.btnInbentarioa.Text = "Inbentarioa";
            this.btnInbentarioa.UseVisualStyleBackColor = false;
            this.btnInbentarioa.Click += new System.EventHandler(this.btnInbentarioa_Click);
            // 
            // Menua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.btnEskaria);
            this.Controls.Add(this.btnInbentarioa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSIS Menua";
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Button btnEskaria;
        private System.Windows.Forms.Button btnInbentarioa;
    }
}
