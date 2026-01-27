using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace TPV_OSIS.Eskariak
{
    public partial class MahaiakForm : Form
    {
        string erabiltzailea;
        private int mahaiaZabalera;
        private int mahaiaAltuera;
        private bool hasieraEginda = false;

        public MahaiakForm(string erabiltzailea)
        {
            InitializeComponent();
            this.erabiltzailea = erabiltzailea;
        }

        private void MahaiakForm_Load(object sender, EventArgs e)
        {
            var culture = new CultureInfo("eu-ES");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            EguneratuDataEuskera();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            KalkulatuMahaiTamainak();
            kargatuMahaiak();
            hasieraEginda = true;
        }

        private static readonly CultureInfo euskalCulture = new CultureInfo("eu-ES");

        private void EguneratuDataEuskera()
        {
            string txt = dtimeData.Value.ToString("dddd, dd MMMM yyyy", euskalCulture);
            lblDataEuskera.Text = char.ToUpper(txt[0]) + txt.Substring(1);
        }

        private void dtimeData_ValueChanged(object sender, EventArgs e)
        {
            EguneratuDataEuskera();
        }

        private void KalkulatuMahaiTamainak()
        {
            int w = flpMahaiak.ClientSize.Width;
            int cols = Math.Max(4, w / 300);
            mahaiaZabalera = Math.Min(260, Math.Max(190, (w / cols) - 32));
            mahaiaAltuera = (int)(mahaiaZabalera * 0.7);
        }

        private void kargatuMahaiak()
        {
            flpMahaiak.Controls.Clear();
            var controller = new MahaiakController();

            foreach (var mahai in controller.LortuMahaiak())
                flpMahaiak.Controls.Add(mahaiaSortu(mahai));
        }

        private Control mahaiaSortu(Mahaiak mahai)
        {
            Panel p = new Panel
            {
                Width = mahaiaZabalera,
                Height = mahaiaAltuera,
                BackColor = Color.White,
                Margin = new Padding(16),
                Padding = new Padding(14)
            };

            p.Paint += (s, e) =>
                ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle,
                    Color.FromArgb(224, 224, 224), ButtonBorderStyle.Solid);

            Label l1 = new Label
            {
                Text = $"MAHAIA {mahai.MahaiZenbakia}",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(29, 80, 91),
                Dock = DockStyle.Top,
                Height = 30
            };

            Label l2 = new Label
            {
                Text = $"{mahai.PertsonaMax} pertsona",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.DimGray,
                Dock = DockStyle.Top
            };

            Label l3 = new Label
            {
                Text = "LIBRE",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(28, 95, 43),
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.BottomRight
            };

            p.Controls.Add(l3);
            p.Controls.Add(l2);
            p.Controls.Add(l1);

            return p;
        }

        private void btnAukeratu_Click(object sender, EventArgs e)
        {
            new EskaerakForm(erabiltzailea).Show();
        }

        private void lblDataEuskera_Click(object sender, EventArgs e)
        {
            using (Form f = new Form())
            {
                f.StartPosition = FormStartPosition.Manual;
                f.Size = new Size(260, 220);
                f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                f.ShowInTaskbar = false;

                // Posición del label en pantalla
                Point pos = lblDataEuskera.PointToScreen(Point.Empty);

                // Colocar el popup justo debajo del label
                f.Location = new Point(
                    pos.X,
                    pos.Y + lblDataEuskera.Height + 4
                );

                DateTimePicker p = new DateTimePicker
                {
                    Dock = DockStyle.Fill,
                    Value = dtimeData.Value,
                    Font = new Font("Segoe UI", 10F),
                    Format = DateTimePickerFormat.Long
                };

                p.ValueChanged += (s, ev) =>
                {
                    dtimeData.Value = p.Value;
                    f.Close();
                };

                f.Controls.Add(p);
                f.ShowDialog(this);
            }
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (!hasieraEginda) return;

            KalkulatuMahaiTamainak();
            foreach (Control c in flpMahaiak.Controls)
            {
                c.Width = mahaiaZabalera;
                c.Height = mahaiaAltuera;
            }
        }
    }
}
