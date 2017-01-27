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

        private Stanje StanjeForme;

        private Zaposlenik AktivniZaposlenik { get { return ZaposleniciList.SelectedItem as Zaposlenik; } }

        public MainForm()
        {
            zaposlenikService = new ZaposlenikService();
            InitializeComponent();

            DohvatiZaposlenike();
            InicijalizirajFormu();
        }

        private void InicijalizirajFormu()
        {
            PromijeniStanje(Stanje.Pregledaj);
            Spol.DataSource = Enum.GetValues(typeof(Spol));
            PopuniZaposlenika(ZaposleniciList.SelectedItem as Zaposlenik);
        }

        private void PromijeniStanje(Stanje NovoStanje)
        {
            StanjeForme = NovoStanje;

            switch (StanjeForme)
            {
                case Stanje.Pregledaj:
                    SearchZaposlenik.Enabled = true;
                    AddNewButton.Enabled = true;
                    UrediButton.Enabled = true;
                    ObrisiButton.Enabled = true;
                    ZaposleniciList.Enabled = true;
                    PromijeniStanjePoljaZaUredjivanje(false);
                    CancelButton.Enabled = false;
                    SpremiPromjeneButton.Enabled = false;
                    break;
                case Stanje.Uredi:
                    SearchZaposlenik.Enabled = false;
                    AddNewButton.Enabled = false;
                    UrediButton.Enabled = false;
                    ObrisiButton.Enabled = false;
                    ZaposleniciList.Enabled = false;
                    PromijeniStanjePoljaZaUredjivanje(true);
                    CancelButton.Enabled = true;
                    SpremiPromjeneButton.Enabled = true;
                    break;
                case Stanje.Dodaj:
                    SearchZaposlenik.Enabled = false;
                    AddNewButton.Enabled = false;
                    UrediButton.Enabled = false;
                    ObrisiButton.Enabled = false;
                    ZaposleniciList.Enabled = false;
                    PromijeniStanjePoljaZaUredjivanje(true);
                    CancelButton.Enabled = true;
                    SpremiPromjeneButton.Enabled = true;
                    break;
            }
        }

        private void PromijeniStanjePoljaZaUredjivanje(bool novoStanje)
        {
            Ime.Enabled = novoStanje;
            Prezime.Enabled = novoStanje;
            Adresa.Enabled = novoStanje;
            OIB.Enabled = novoStanje;
            KorisnickoIme.Enabled = novoStanje;
            Lozinka.Enabled = novoStanje;
            Spol.Enabled = novoStanje;
        }

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

        private void ZaposlenikOdabran(object sender, EventArgs e)
        {
            var OdabraniZaposlenik = (sender as ListBox).SelectedItem as Zaposlenik;

            PopuniZaposlenika(OdabraniZaposlenik);
        }

        private void PopuniZaposlenika(Zaposlenik zaposlenik)
        {
            Ime.Text = zaposlenik.Ime;
            Prezime.Text = zaposlenik.Prezime;
            Spol.SelectedItem = zaposlenik.Spol;
            Adresa.Text = zaposlenik.Adresa;
            OIB.Text = zaposlenik.OIB;
            KorisnickoIme.Text = zaposlenik.KorisnickoIme;
            Lozinka.Text = "";
        }

        private void SpremiZaposlenika(object sender, EventArgs e)
        {
            AktivniZaposlenik.Ime = Ime.Text;
            AktivniZaposlenik.Prezime = Prezime.Text;
            AktivniZaposlenik.Spol = (Spol)Spol.SelectedItem;
            AktivniZaposlenik.Adresa = Adresa.Text;
            AktivniZaposlenik.OIB = OIB.Text;
            AktivniZaposlenik.KorisnickoIme = KorisnickoIme.Text;

            if (Lozinka.Text.Length > 0)
            {
                AktivniZaposlenik.Lozinka = Lozinka.Text;
            }
            else
            {
                AktivniZaposlenik.Lozinka = null;
            }


            if (AktivniZaposlenik != null && AktivniZaposlenik.Id == -1) // novi zaposlenik
            {
                zaposlenikService.Create(AktivniZaposlenik);
            }
            else if (AktivniZaposlenik != null && AktivniZaposlenik.Id != -1) // postojeći zaposlenik
            {
                zaposlenikService.Update(AktivniZaposlenik);
            }

            PromijeniStanje(Stanje.Pregledaj);
            DohvatiZaposlenike();
        }

        private void DodajNovogZaposlenika(object sender, EventArgs e)
        {
            PromijeniStanje(Stanje.Dodaj);

            var NoviZaposlenik = new Zaposlenik();
            Zaposlenici.Add(NoviZaposlenik);
            ZaposleniciList.SelectedItem = NoviZaposlenik;
        }

        private void Odustani(object sender, EventArgs e)
        {
            if(AktivniZaposlenik != null && AktivniZaposlenik.Id == -1) // odustani od dodavanja zaposlenika
            {
                Zaposlenici.Remove(AktivniZaposlenik);

                PromijeniStanje(Stanje.Pregledaj);
            }
            else if (AktivniZaposlenik != null && AktivniZaposlenik.Id != -1) // odustani od izmjena postojećeg zaposlenika
            {
                PromijeniStanje(Stanje.Pregledaj);
            }

            PopuniZaposlenika(AktivniZaposlenik);
        }

        public enum Stanje
        {
            Pregledaj,
            Uredi,
            Dodaj
        }

        private void OmoguciUredjivanje(object sender, EventArgs e)
        {
            PromijeniStanje(Stanje.Uredi);
        }

        private void ObrisiZaposlenika(object sender, EventArgs e)
        {
            zaposlenikService.Delete(AktivniZaposlenik.Id);
            DohvatiZaposlenike();
        }
    }
}
