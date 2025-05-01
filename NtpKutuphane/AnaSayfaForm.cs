using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NtpKutuphane.AltFormlar;
using OgrenciEkleme;

namespace NtpKutuphane
{
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            KitapForm kitap = new KitapForm();
            kitap.ShowDialog();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            OgrenciForm ogrenci = new OgrenciForm();
            ogrenci.ShowDialog();
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            formKitapTur kitapTur = new formKitapTur();
            kitapTur.ShowDialog();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            formOduncKitap oduncKitap = new formOduncKitap();
            oduncKitap.ShowDialog();
        }
    }
}
