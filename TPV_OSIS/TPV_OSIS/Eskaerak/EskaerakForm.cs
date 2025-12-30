using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TPV_OSIS.Eskaerak
{
    public partial class EskaerakForm : Form
    {
        private string erabiltzailea;
        private List<Karritoa> karritoa = new List<Karritoa>();

        public EskaerakForm(string erabiltzailea)
        {
            InitializeComponent();
            this.erabiltzailea = erabiltzailea;
        }

        private void EskaerakForm_Load(object sender, EventArgs e)
        {
            lblErabiltzailea.Text = "Erabiltzailea: " + erabiltzailea;
            kargatuKategoriak();
        }

        // ================= KATEGORIAK =================
        private void kargatuKategoriak()
        {
            flpKategoriak.Controls.Clear();

            using (var session = NHibernateHelper.OpenSession())
            {
                var kategoriak = session.Query<Kategoriak>().ToList();

                foreach (var cat in kategoriak)
                {
                    Button btn = new Button
                    {
                        Text = cat.Izena,
                        Width = 180,
                        Height = 60,
                        BackColor = Color.FromArgb(31, 107, 58),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Tag = cat.Id
                    };

                    btn.Click += (s, e) =>
                    {
                        kargatuPlaterakKategoriko((int)btn.Tag);
                    };

                    flpKategoriak.Controls.Add(btn);
                }
            }
        }

        // ================= PLATERAK =================
        private void kargatuPlaterakKategoriko(int kategoriaId)
        {
            flpPlaterak.Controls.Clear();

            using (var session = NHibernateHelper.OpenSession())
            {
                var platerak = session.Query<Platerak>()
                    .Where(p => p.Kategoriak.Id == kategoriaId && p.Stock > 0)
                    .ToList();

                foreach (var p in platerak)
                {
                    Panel panel = new Panel
                    {
                        Width = 180,
                        Height = 100,
                        BackColor = Color.White,
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle,
                        Cursor = Cursors.Hand
                    };

                    Label lblIzena = new Label
                    {
                        Text = p.Izena,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Location = new Point(10, 10),
                        Width = 160
                    };

                    Label lblPrezioa = new Label
                    {
                        Text = $"{p.Prezioa:0.00} €",
                        Location = new Point(10, 40)
                    };

                    Label lblStock = new Label
                    {
                        Text = $"Stock: {p.Stock}",
                        Location = new Point(10, 60)
                    };

                    EventHandler clickHandler = (s, e) => gehituKarritora(p);

                    panel.Click += clickHandler;
                    lblIzena.Click += clickHandler;
                    lblPrezioa.Click += clickHandler;
                    lblStock.Click += clickHandler;

                    panel.Controls.Add(lblIzena);
                    panel.Controls.Add(lblPrezioa);
                    panel.Controls.Add(lblStock);

                    flpPlaterak.Controls.Add(panel);
                }
            }
        }


        // ================= KARRITOA =================
        private void gehituKarritora(Platerak p)
        {
            var produktua = karritoa.FirstOrDefault(x => x.PlaterakId == p.Id);

            if (produktua == null)
            {
                karritoa.Add(new Karritoa
                {
                    PlaterakId = p.Id,
                    Izena = p.Izena,
                    Prezioa = p.Prezioa,
                    Kopurua = 1
                });
            }
            else
            {
                produktua.Kopurua++;
            }

            eguneratuKarritoa();
        }

        private void eguneratuKarritoa()
        {
            flpKarritoa.Controls.Clear();

            foreach (var objetua in karritoa)
            {
                Panel panel = new Panel
                {
                    Width = 380,
                    Height = 80,
                    BackColor = Color.White,
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblIzena = new Label
                {
                    Text = objetua.Izena,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(10, 10),
                    Width = 200
                };

                Label lblKantitatea = new Label
                {
                    Text = $"x{objetua.Kopurua}",
                    ForeColor = Color.Black,
                    Location = new Point(10, 40)
                };

                Label lblPrezioaObjetuko = new Label
                {
                    Text = $"{objetua.Totala:0.00} €",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Size = new Size(55, 20),
                    Location = new Point(250, 40)
                };


                Button btnPlus = new Button
                {
                    Text = "+",
                    Location = new Point(120, 35),
                    Size = new Size(30, 25),
                    ForeColor = Color.Black
                };

                Button btnMinus = new Button
                {
                    Text = "−",
                    Location = new Point(160, 35),
                    Size = new Size(30, 25),
                    ForeColor = Color.Black
                };

                Button btnEzabatu = new Button
                {
                    Text = "x",
                    Location = new Point(310, 35),
                    Size = new Size(30, 25),
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                btnEzabatu.FlatAppearance.BorderSize = 1;
                btnEzabatu.FlatAppearance.BorderColor = Color.Black;
                btnEzabatu.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 140, 56); 
                btnEzabatu.FlatAppearance.MouseDownBackColor = Color.LightGray;
               


                btnPlus.Click += (s, e) =>
                {
                    objetua.Kopurua++;
                    eguneratuKarritoa();
                };

                btnMinus.Click += (s, e) =>
                {
                    objetua.Kopurua--;
                    if (objetua.Kopurua <= 0)
                        karritoa.Remove(objetua);
                    eguneratuKarritoa();
                };

                btnEzabatu.Click += (s, e) =>
                {
                    karritoa.Remove(objetua);
                    eguneratuKarritoa();
                };

                panel.Controls.Add(lblIzena);
                panel.Controls.Add(lblKantitatea);
                panel.Controls.Add(lblPrezioaObjetuko);
                panel.Controls.Add(btnPlus);
                panel.Controls.Add(btnMinus);
                panel.Controls.Add(btnEzabatu);

                flpKarritoa.Controls.Add(panel);
            }

            lblTotala.Text = "Totala: " + karritoa.Sum(c => c.Totala).ToString("0.00") + " €";
        }

        // ================= ESKARIA =================
        private void btnEskatu_Klik(object sender, EventArgs e)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var tx = session.BeginTransaction())
            {
                int eskariaId = session.Query<Komandak>()
                    .Select(k => (int?)k.Id)
                    .Max() ?? 0;
                eskariaId++;

                foreach (var objetua in karritoa)
                {
                    var platera = session.Get<Platerak>(objetua.PlaterakId);

                    Komandak k = new Komandak
                    {
                        Id = eskariaId,
                        Platerak = platera,
                        FakturakId = 1,
                        Kopurua = objetua.Kopurua,
                        Totala = objetua.Totala
                    };

                    session.Save(k);

                    platera.Stock -= objetua.Kopurua;
                    session.Update(platera);
                }

                var faktura = session.Get<Fakturak>(1);
                faktura.Totala += karritoa.Sum(c => c.Totala);
                session.Update(faktura);

                tx.Commit();
            }

            MessageBox.Show("Komanda behar bezala eginda");
            karritoa.Clear();
            eguneratuKarritoa();
            flpPlaterak.Controls.Clear();
        }

        private void btnTxat_Click(object sender, EventArgs e)
        {
            new TxatForm(erabiltzailea).Show();
        }
    }
}
