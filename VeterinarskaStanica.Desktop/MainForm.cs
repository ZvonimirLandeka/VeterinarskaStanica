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
        private Zaposlenik PrijavljeniZaposlenik;

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

        private TerminService terminService;
        private List<Model.Termin> DohvaceniTermini;
        private BindingList<Model.Termin> Termini;
        private Termin AktivniTermin
        {
            get
            {
                return TerminiList.SelectedItem as Termin;
            }
        }





        public MainForm(Zaposlenik PrijavljeniZaposlenik)
        {
            InitializeComponent();

            this.PrijavljeniZaposlenik = PrijavljeniZaposlenik;
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

            terminService = new TerminService();
            DohvatiTermine();
            VrijemeTermin.Format = DateTimePickerFormat.Time;

            DohvatiNaslovnicu();
        }


        #region Zaposlenici

        private void DohvatiZaposlenike()
        {
            var stari = AktivniZaposlenik;

            DohvaceniZaposlenici = zaposlenikService.GetAll();
            FiltrirajZaposlenike();

            if (stari != null)
                ZaposleniciList.SelectedItem = Zaposlenici.FirstOrDefault(x => x.Id == stari.Id);
        }
        private void FiltrirajZaposlenike(object sender = null, EventArgs e = null)
        {
            Zaposlenici = new BindingList<Zaposlenik>(DohvaceniZaposlenici.Where(x => x.ToString().Contains(SearchZaposlenik.Text)).ToList());
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
            else
            {
                UrediZaposlenikaButton.Enabled = false;
                ObrisiZaposlenikaButton.Enabled = false;
            }
        }

        #endregion

        #region Zivotinje
        private void DohvatiZivotinje()
        {
            var stara = AktivnaZivotinja;

            DohvaceneZivotinje = zivotinjaService.GetAll();
            FiltrirajZivotinje();

            if (stara != null)
                ZivotinjeList.SelectedItem = Zivotinje.FirstOrDefault(x => x.Id == stara.Id);
        }

        private void FiltrirajZivotinje(object sender = null, EventArgs e = null)
        {
            Zivotinje = new BindingList<Zivotinja>(DohvaceneZivotinje.Where(x => x.ToString().Contains(SearchZivotinje.Text)).ToList());
            ZivotinjeList.DataSource = Zivotinje;
        }

        private void DodajZivotinju(object sender, EventArgs e)
        {
            var NovaZivotinja = new Zivotinja() { Vlasnik = AktivniVlasnik };

            var ZivotinjaForm = new ZivotinjaForm(NovaZivotinja);
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
            else
            {
                UrediZivotinjuButton.Enabled = false;
                ObrisiZivotinjuButton.Enabled = false;
            }
        }

        #endregion

        #region Vlasnici
        private void DohvatiVlasnike()
        {
            var stari = AktivniVlasnik;

            DohvaceniVlasnici = vlasnikService.GetAll();
            FiltrirajVlasnike();

            if (stari != null)
                VlasniciList.SelectedItem = Vlasnici.FirstOrDefault(x => x.Id == stari.Id);
        }

        private void FiltrirajVlasnike(object sender = null, EventArgs e = null)
        {
            Vlasnici = new BindingList<Vlasnik>(DohvaceniVlasnici.Where(x => x.ToString().Contains(SearchVlasnici.Text)).ToList());
            VlasniciList.DataSource = Vlasnici;
        }

        private void DodajVlasnika(object sender, EventArgs e)
        {
            var VlasnikForm = new VlasnikForm(new Vlasnik());
            var result = VlasnikForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiVlasnike();
            }
        }
        private void UrediVlasnika(object sender, EventArgs e)
        {
            var VlasnikForm = new VlasnikForm(AktivniVlasnik);
            var result = VlasnikForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiVlasnike();
            }
        }
        private void ObrisiVlasnika(object sender, EventArgs e)
        {
            vlasnikService.Delete(AktivniVlasnik.Id);
            DohvatiVlasnike();
        }

        private void VlasnikOdabran(object sender, EventArgs e)
        {
            if (AktivniVlasnik != null)
            {
                vlasnikBindingSource.DataSource = AktivniVlasnik;

                UrediVlasnikaButton.Enabled = true;
                ObrisiVlasnikaButton.Enabled = true;
            }
            else
            {
                UrediVlasnikaButton.Enabled = false;
                ObrisiVlasnikaButton.Enabled = false;
            }
        }
        #endregion

        #region Termini

        private void MakniTerminFiltere()
        {
            VlasniciFilterCombobox.SelectedIndex = -1;
            VlasniciFilterCombobox.SelectedItem = null;
            SearchTermin.ResetText();
        }
        private void DohvatiTermine()
        {
            //var stari = AktivniTermin;
            DohvaceniVlasnici = vlasnikService.GetAll();
            DohvaceniTermini = terminService.GetAll().OrderByDescending(x => x.Datum).ToList();
            FiltrirajTermine();

            //if (stari != null)
            //{
            //    //TerminiList.SelectedItem = Termini.FirstOrDefault(x => x.Id == stari.Id);
            //    TerminOdabran(null, null);
            //}

            VlasniciFilterCombobox.DataSource = DohvaceniVlasnici;
            VlasniciFilterCombobox.SelectedIndex = -1;
            VlasniciFilterCombobox.SelectedItem = null;
            VlasniciFilterCombobox.AutoCompleteCustomSource.AddRange(DohvaceniVlasnici.Select(x => x.ToString()).ToArray());
        }

        private void FiltrirajTermine(object sender = null, EventArgs e = null)
        {
            var VlasnikForFiler = VlasniciFilterCombobox.SelectedItem as Vlasnik;
            if (VlasnikForFiler != null)
            {
                SearchTermin.ResetText();
                Termini = new BindingList<Termin>(DohvaceniTermini.Where(x => x.Zivotinja.Vlasnik.Id == VlasnikForFiler.Id).ToList());
            }
            else
            {
                Termini = new BindingList<Termin>(DohvaceniTermini.Where(x => x.ToString().Contains(SearchTermin.Text)).ToList());
            }

            TerminiList.DataSource = Termini;
        }

        private void DodajTermin(object sender, EventArgs e)
        {
            var NoviTermin = new Termin() { Zivotinja = AktivnaZivotinja, Zaposlenik = PrijavljeniZaposlenik };
            var TerminForm = new TerminForm(NoviTermin);
            var result = TerminForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiTermine();
            }
        }
        private void UrediTermin(object sender, EventArgs e)
        {
            var TerminForm = new TerminForm(AktivniTermin);
            var result = TerminForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiTermine();
            }
        }
        private void ObrisiTermin(object sender, EventArgs e)
        {
            terminService.Delete(AktivniTermin.Id);
            DohvatiTermine();
        }

        private void TerminOdabran(object sender, EventArgs e)
        {
            if (AktivniTermin != null)
            {
                terminBindingSource.DataSource = AktivniTermin;
                ZahvatiList.DataSource = AktivniTermin.Zahvati;

                UrediTerminButton.Enabled = true;
                ObrisiTerminButton.Enabled = true;
            }
            else
            {
                UrediTerminButton.Enabled = false;
                ObrisiTerminButton.Enabled = false;
            }
        }

        private void ZahvatOdabran(object sender, EventArgs e)
        {
            if (AktivniTermin.Zahvati != null && AktivniTermin.Zahvati.Count > 0)
            {
                zahvatBindingSource.DataSource = ZahvatiList.SelectedItem as Zahvat;
            }
            else
            {
                zahvatBindingSource.DataSource = null;
            }
        }
        #endregion

        #region Naslovnica
        private void DohvatiNaslovnicu()
        {
            var DanasnjiTermini = terminService.GetAll().Where(x => x.Zaposlenik.Id == PrijavljeniZaposlenik.Id && x.Datum.HasValue && x.Datum.Value.Date == DateTime.Now.Date && x.Status == Model.StatusTermina.Odobren).ToList();
            DanasnjiTerminiList.DataSource = DanasnjiTermini;

            var ZatrazeniTermini = terminService.GetAll().Where(x => x.Status == Model.StatusTermina.Zatražen).ToList();
            ZatrazeniTerminiList.DataSource = ZatrazeniTermini;
        }

        private void UrediZatrazeniTermin_Click(object sender, EventArgs e)
        {
            var OdabraniZatrazeniTermin = ZatrazeniTerminiList.SelectedItem as Termin;

            var TerminForm = new TerminForm(OdabraniZatrazeniTermin);
            var result = TerminForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiNaslovnicu();
            }
        }

        private void UrediDanasnjiTermin_Click(object sender, EventArgs e)
        {
            var OdabraniDanasnjiTermin = DanasnjiTerminiList.SelectedItem as Termin;

            var TerminForm = new TerminForm(OdabraniDanasnjiTermin);
            var result = TerminForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DohvatiNaslovnicu();
            }
        }

        private void OsvjeziTermine(object sender, EventArgs e)
        {
            DohvatiNaslovnicu();
        }
        #endregion
    }
}
