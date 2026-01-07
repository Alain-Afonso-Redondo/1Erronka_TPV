using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPV_OSIS.Eskariak;
using TPV_OSIS.Inbentarioa;

namespace TPV_OSIS.Menua
{
    public partial class MenuaForm : Form
    {
        string erabiltzailea;
        public MenuaForm(string erabiltzailea)
        {
            InitializeComponent();
            this.erabiltzailea = erabiltzailea;
        }

        private void btnInbentarioa_Click(object sender, EventArgs e)
        {
            new InbentarioaForm().Show();
        }

        private void btnEskaria_Click(object sender, EventArgs e)
        {
            new EskaerakForm(erabiltzailea).Show();
        }

    }


}
