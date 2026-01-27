using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TPV_OSIS.Eskariak
{
    public partial class ErreserbatuForm : Form
    {
        
        private string txandaAukeratua = null;
        private bool _editatzen = false;
        private Erreserba _erreserbaEditatzen = null;
        private int? _mahaiEditatuaId = null;

        

        
        public ErreserbatuForm()
        {
            InitializeComponent();
        }

       
        public ErreserbatuForm(Erreserba erreserba)
        {
            InitializeComponent();

            _editatzen = true;
            _erreserbaEditatzen = erreserba;
        }

        
        private void ErreserbakForm_Load(object sender, EventArgs e)
        {
            dtpData.MinDate = DateTime.Today;

            cboxBazkaria.Click += (s, ev) => AukeratuTxanda("Bazkaria");
            cboxAfaria.Click += (s, ev) => AukeratuTxanda("Afaria");

            dtpData.ValueChanged += (s, ev) => KargatuMahaiLibre();
            txtPertsonak.TextChanged += (s, ev) => KargatuMahaiLibre();

            if (_editatzen)
                KargatuDatuakEdizioan();
        }

        
        private void KargatuDatuakEdizioan()
        {
            txtIzena.Text = _erreserbaEditatzen.Izena;
            txtTelefonoa.Text = _erreserbaEditatzen.Telefonoa;
            txtPertsonak.Text = _erreserbaEditatzen.PertsonaKopurua.ToString();
            dtpData.Value = _erreserbaEditatzen.Data;

            AukeratuTxanda(_erreserbaEditatzen.Txanda);

            var erreserbaMahaiCtrl = new ErreserbaMahaiController();
            var mahaiIds = erreserbaMahaiCtrl
                .LortuMahaiakErreserbarentzat(_erreserbaEditatzen.Id);

            if (mahaiIds.Any())
                _mahaiEditatuaId = mahaiIds.First();
        }

        // ================= TXANDA =================
        private void AukeratuTxanda(string txanda)
        {
            txandaAukeratua = txanda;

            cboxBazkaria.BackColor = txanda == "Bazkaria"
                ? Color.FromArgb(31, 107, 58)
                : Color.LightGray;

            cboxAfaria.BackColor = txanda == "Afaria"
                ? Color.FromArgb(31, 107, 58)
                : Color.LightGray;

            KargatuMahaiLibre();
        }

        // ================= MAHAIAK =================
        private void KargatuMahaiLibre()
        {
            cmbMahaiak.DataSource = null;

            if (txandaAukeratua == null)
                return;

            if (!int.TryParse(txtPertsonak.Text, out int pertsonak))
                return;

            var mahaiCtrl = new MahaiakController();
            var erreserbaCtrl = new ErreserbakController();
            var erreserbaMahaiCtrl = new ErreserbaMahaiController();

            var mahaiGuztiak = mahaiCtrl.LortuMahaiak();

            var erreserbakEguneko = erreserbaCtrl
                .LortuErreserbak()
                .Where(e =>
                    e.Data.Date == dtpData.Value.Date &&
                    e.Txanda == txandaAukeratua &&
                    (!_editatzen || e.Id != _erreserbaEditatzen.Id))
                .ToList();

            var mahaiOkupatuak = erreserbakEguneko
                .SelectMany(e => erreserbaMahaiCtrl.LortuMahaiakErreserbarentzat(e.Id))
                .Distinct()
                .ToList();

            var libre = mahaiGuztiak
                .Where(m =>
                    (!mahaiOkupatuak.Contains(m.Id) || m.Id == _mahaiEditatuaId) &&
                    m.PertsonaMax >= pertsonak)
                .ToList();

            cmbMahaiak.DataSource = libre;
            cmbMahaiak.DisplayMember = "MahaiZenbakia";
            cmbMahaiak.ValueMember = "Id";

            if (_mahaiEditatuaId != null)
                cmbMahaiak.SelectedValue = _mahaiEditatuaId;
        }

        // ================= ERRESERBATU =================
        private void btnErreserbatu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIzena.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoa.Text) ||
                cmbMahaiak.SelectedItem == null ||
                string.IsNullOrEmpty(txandaAukeratua))
            {
                MessageBox.Show("Datu guztiak bete behar dira");
                return;
            }

            if (!int.TryParse(txtPertsonak.Text, out int pertsonak))
            {
                MessageBox.Show("Pertsona kopurua ez da zuzena");
                return;
            }

            int mahaiId = (int)cmbMahaiak.SelectedValue;

            var erreserbaCtrl = new ErreserbakController();
            var erreserbaMahaiCtrl = new ErreserbaMahaiController();

            // ======== EDITATU ========
            if (_editatzen)
            {
                _erreserbaEditatzen.Izena = txtIzena.Text.Trim();
                _erreserbaEditatzen.Telefonoa = txtTelefonoa.Text.Trim();
                _erreserbaEditatzen.PertsonaKopurua = pertsonak;
                _erreserbaEditatzen.Data = dtpData.Value.Date;
                _erreserbaEditatzen.Txanda = txandaAukeratua;

                erreserbaCtrl.EguneratuErreserba(_erreserbaEditatzen);
                erreserbaMahaiCtrl.EguneratuMahaiErreserban(
                    _erreserbaEditatzen.Id,
                    mahaiId
                );

                MessageBox.Show("Erreserba eguneratuta!");
                Close();
                return;
            }

            // ===== SORTU =====
            var erreserba = new Erreserba
            {
                Izena = txtIzena.Text.Trim(),
                Telefonoa = txtTelefonoa.Text.Trim(),
                PertsonaKopurua = pertsonak,
                Txanda = txandaAukeratua,
                Data = dtpData.Value.Date
            };

            var sortua = erreserbaCtrl.SortuErreserba(erreserba);

            if (sortua == null)
            {
                MessageBox.Show("Errorea erreserba sortzean");
                return;
            }

            erreserbaMahaiCtrl.GehituMahaiErreserbara(sortua.Id, mahaiId);

            MessageBox.Show("Erreserba behar bezala sortu da!");
            Close();
        }
    }
}
