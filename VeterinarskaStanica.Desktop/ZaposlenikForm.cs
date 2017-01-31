using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinarskaStanica.BLL;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.Desktop
{
    public partial class ZaposlenikForm : Form
    {
        private ZaposlenikService zaposlenikService;
        private Zaposlenik AktivniZaposlenik;
        public ZaposlenikForm(Zaposlenik zaposlenik)
        {
            InitializeComponent();

            AktivniZaposlenik = zaposlenik;

            InicijalizirajFormu();
        }
        private void InicijalizirajFormu()
        {
            zaposlenikService = new ZaposlenikService();
            Spol.DataSource = Enum.GetValues(typeof(Spol));
            Popuni(AktivniZaposlenik);
        }

        private void Popuni(Zaposlenik zaposlenik)
        {
            if (zaposlenik == null)
                return;

            zaposlenikBindingSource.DataSource = zaposlenik;

            Spol.SelectedItem = zaposlenik.Spol;
        }

        private void Spremi(object sender, EventArgs e)
        {

            AktivniZaposlenik.Spol = (Spol)Spol.SelectedItem;

            if (AktivniZaposlenik != null && AktivniZaposlenik.Id == -1) // novi zaposlenik
            {
                zaposlenikService.Add(AktivniZaposlenik);
            }
            else if (AktivniZaposlenik != null && AktivniZaposlenik.Id != -1) // postojeći zaposlenik
            {
                zaposlenikService.Update(AktivniZaposlenik);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Odustani(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
