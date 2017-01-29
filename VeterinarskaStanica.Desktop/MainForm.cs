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
    public partial class MainForm : Form
    {
        private ZaposlenikService zaposlenikService;
        private List<Zaposlenik> DohvaceniZaposlenici;
        private BindingList<Zaposlenik> Zaposlenici;
        private Zaposlenik AktivniZaposlenik
        {
            get
            {
                return ZaposleniciList.SelectedItem as Zaposlenik;
            }
        }


        private ZivotinjaService zivotinjaService;
        private List<Zivotinja> DohvaceneZivotinje;
        private BindingList<Zivotinja> Zivotinje;
        private Zivotinja AktivnaZivotinja
        {
            get
            {
                return ZivotinjeList.SelectedItem as Zivotinja;
            }
        }


        private VlasnikService vlasnikService;
        private List<Vlasnik> DohvaceniVlasnici;
        private BindingList<Vlasnik> Vlasnici;
        private Vlasnik AktivniVlasnik
        {
            get
            {
                return VlasniciList.SelectedItem as Vlasnik;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            InicijalizirajFormu();
        }

        private void InicijalizirajFormu()
        {
            zaposlenikService = new ZaposlenikService();
            DohvatiZaposlenike();

            zivotinjaService = new ZivotinjaService();
            DohvatiZivotinje();

            vlasnikService = new VlasnikService();
            DohvatiVlasnike();
        }


        #region Zaposlenici
        private void DohvatiZaposlenike()
        {
            DohvaceniZaposlenici = zaposlenikService.GetAll();
            FiltrirajZaposlenike();
        }
        private void FiltrirajZaposlenike(object sender = null, EventArgs e = null)
        {
            Zaposlenici = new BindingList<Zaposlenik>(DohvaceniZaposlenici.Where(x => x.ImePrezimeOib.Contains(SearchZaposlenik.Text)).ToList());
            ZaposleniciList.DataSource = Zaposlenici;
        }
        private void DodajZaposlenika(object sender, EventArgs e)
        {
            var ZaposlenikForm = new ZaposlenikForm(new Zaposlenik());
            var result = ZaposlenikForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiZaposlenike();
            }
        }

        private void UrediZaposlenika(object sender, EventArgs e)
        {
            var ZaposlenikForm = new ZaposlenikForm(AktivniZaposlenik);
            var result = ZaposlenikForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiZaposlenike();
            }
        }

        private void ObrisiZaposlenika(object sender, EventArgs e)
        {
            zaposlenikService.Delete(AktivniZaposlenik.Id);
            DohvatiZaposlenike();
        }
        private void ZaposlenikOdabran(object sender, EventArgs e)
        {
            if (AktivniZaposlenik != null)
            {
                zaposlenikBindingSource.DataSource = AktivniZaposlenik;

                UrediZaposlenikaButton.Enabled = true;
                ObrisiZaposlenikaButton.Enabled = true;
            }
        }

        #endregion

        #region Zivotinje
        private void DohvatiZivotinje()
        {
            DohvaceneZivotinje = zivotinjaService.GetAll();
            FiltrirajZivotinje();
        }

        private void FiltrirajZivotinje(object sender = null, EventArgs e = null)
        {
            Zivotinje = new BindingList<Zivotinja>(DohvaceneZivotinje.Where(x => x.Ime.Contains(SearchZaposlenik.Text)).ToList());
            ZivotinjeList.DataSource = Zivotinje;
        }

        private void DodajZivotinju(object sender, EventArgs e)
        {
            var ZivotinjaForm = new ZivotinjaForm(new Zivotinja());
            var result = ZivotinjaForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiZivotinje();
            }
        }
        private void UrediZivotinju(object sender, EventArgs e)
        {
            var ZivotinjaForm = new ZivotinjaForm(AktivnaZivotinja);
            var result = ZivotinjaForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiZivotinje();
            }
        }
        private void ObrisiZivotinju(object sender, EventArgs e)
        {
            zivotinjaService.Delete(AktivnaZivotinja.Id);
            DohvatiZivotinje();
        }

        private void ZivotinjaOdabrana(object sender, EventArgs e)
        {
            if (AktivnaZivotinja != null)
            {
                zivotinjaBindingSource.DataSource = AktivnaZivotinja;

                UrediZivotinjuButton.Enabled = true;
                ObrisiZivotinjuButton.Enabled = true;
            }
        }

        #endregion

        #region Vlasnici
        private void DohvatiVlasnike()
        {
            DohvaceneZivotinje = zivotinjaService.GetAll();
            FiltrirajVlasnike();
        }

        private void FiltrirajVlasnike(object sender = null, EventArgs e = null)
        {
            Zivotinje = new BindingList<Zivotinja>(DohvaceneZivotinje.Where(x => x.Ime.Contains(SearchZaposlenik.Text)).ToList());
            ZivotinjeList.DataSource = Zivotinje;
        }

        private void DodajVlasnika(object sender, EventArgs e)
        {
            var ZivotinjaForm = new ZivotinjaForm(new Zivotinja());
            var result = ZivotinjaForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiZivotinje();
            }
        }
        private void UrediVlasnika(object sender, EventArgs e)
        {
            var ZivotinjaForm = new ZivotinjaForm(AktivnaZivotinja);
            var result = ZivotinjaForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiZivotinje();
            }
        }
        private void ObrisiVlasnika(object sender, EventArgs e)
        {
            zivotinjaService.Delete(AktivnaZivotinja.Id);
            DohvatiZivotinje();
        }

        private void VlasnikaOdabran(object sender, EventArgs e)
        {
            if (AktivnaZivotinja != null)
            {
                zivotinjaBindingSource.DataSource = AktivnaZivotinja;

                UrediZivotinjuButton.Enabled = true;
                ObrisiZivotinjuButton.Enabled = true;
            }
        }
        #endregion
    }
}
