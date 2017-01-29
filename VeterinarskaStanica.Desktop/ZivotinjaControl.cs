using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinarskaStanica.BLL;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.Desktop
{
    public partial class ZivotinjaControl : UserControl
    {
        private ZivotinjaService zivotinjaService;
        private List<Zivotinja> DohvaceneZivotinje;
        private BindingList<Zivotinja> Zivotinje;

        private Stanje StanjeForme;
        private Zivotinja AktivnaZivotinja { get { return ZivotinjeList.SelectedItem as Zivotinja; } }

        public ZivotinjaControl()
        {
            zivotinjaService = new ZivotinjaService();
            InitializeComponent();

            DohvatiZivotinje();
            InicijalizirajFormu();
        }

        private void InicijalizirajFormu()
        {
            PromijeniStanje(Stanje.Pregledaj);
            Spol.DataSource = Enum.GetValues(typeof(Spol));
            Vrsta.DataSource = zivotinjaService.GetAllVrstaZivotinje();
            Pasmina.DataSource = zivotinjaService.GetAllPasminaZivotinjeByVrstaZivotinje(Vrsta.SelectedItem as VrstaZivotinje);
            PopuniZivotinju(ZivotinjeList.SelectedItem as Zivotinja);
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
                    ZivotinjeList.Enabled = true;
                    PromijeniStanjePoljaZaUredjivanje(false);
                    CancelButton.Enabled = false;
                    SpremiPromjeneButton.Enabled = false;
                    break;
                case Stanje.Uredi:
                    SearchZaposlenik.Enabled = false;
                    AddNewButton.Enabled = false;
                    UrediButton.Enabled = false;
                    ObrisiButton.Enabled = false;
                    ZivotinjeList.Enabled = false;
                    PromijeniStanjePoljaZaUredjivanje(true);
                    CancelButton.Enabled = true;
                    SpremiPromjeneButton.Enabled = true;
                    break;
                case Stanje.Dodaj:
                    SearchZaposlenik.Enabled = false;
                    AddNewButton.Enabled = false;
                    UrediButton.Enabled = false;
                    ObrisiButton.Enabled = false;
                    ZivotinjeList.Enabled = false;
                    PromijeniStanjePoljaZaUredjivanje(true);
                    CancelButton.Enabled = true;
                    SpremiPromjeneButton.Enabled = true;
                    break;
            }
        }

        private void PromijeniStanjePoljaZaUredjivanje(bool novoStanje)
        {
            Ime.Enabled = novoStanje;
            Boja.Enabled = novoStanje;
            DatumRodenja.Enabled = novoStanje;
            DatumSmrti.Enabled = novoStanje;
            BrojCipa.Enabled = novoStanje;
            PolozajCipa.Enabled = novoStanje;
            DatumCipiranja.Enabled = novoStanje;
            Spol.Enabled = novoStanje;
        }

        private void DohvatiZivotinje()
        {
            DohvaceneZivotinje = zivotinjaService.GetAll();
            FiltrirajZivotinje();
        }

        private void FiltrirajZivotinje(object sender = null, EventArgs e = null)
        {
            //Zivotinje = new BindingList<Zaposlenik>(DohvaceneZivotinje.Where(x => x.Ime.Contains(SearchZaposlenik.Text)).ToList());
            ZivotinjeList.DataSource = Zivotinje;
        }

        private void ZaposlenikOdabran(object sender, EventArgs e)
        {
            var OdabranaZivotinja = (sender as ListBox).SelectedItem as Zivotinja;

            PopuniZivotinju(OdabranaZivotinja);
        }

        private void PopuniZivotinju(Zivotinja zivotinja)
        {
            if (zivotinja == null)
                return;

            Ime.Text = zivotinja?.Ime;
            Boja.Text = zivotinja?.Boja;
            Spol.SelectedItem = zivotinja?.Spol;
            BrojCipa.Text = zivotinja?.BrojCipa;
            PolozajCipa.Text = zivotinja?.PolozajCipa;
            DatumCipiranja.Value = zivotinja.DatumCipiranja;
            DatumRodenja.Value = zivotinja.DatumRodenja;
            DatumSmrti.Value = zivotinja.DatumSmrti;

        }

        private void SpremiZivotinju(object sender, EventArgs e)
        {
            AktivnaZivotinja.Ime = Ime.Text;
            AktivnaZivotinja.Boja = Boja.Text;
            AktivnaZivotinja.Spol = (Spol)Spol.SelectedItem;
            AktivnaZivotinja.BrojCipa = BrojCipa.Text;
            AktivnaZivotinja.PolozajCipa = PolozajCipa.Text;
            AktivnaZivotinja.DatumCipiranja = DatumCipiranja.Value;
            AktivnaZivotinja.DatumRodenja = DatumRodenja.Value;
            AktivnaZivotinja.DatumSmrti = DatumSmrti.Value;

            if (AktivnaZivotinja != null && AktivnaZivotinja.Id == -1) // novi zaposlenik
            {
                zivotinjaService.Add(AktivnaZivotinja);
            }
            else if (AktivnaZivotinja != null && AktivnaZivotinja.Id != -1) // postojeći zaposlenik
            {
                zivotinjaService.Update(AktivnaZivotinja);
            }

            PromijeniStanje(Stanje.Pregledaj);
            DohvatiZivotinje();
        }

        private void DodajNovogZaposlenika(object sender, EventArgs e)
        {
            PromijeniStanje(Stanje.Dodaj);

            var NovaZivotinja = new Zivotinja();
            Zivotinje.Add(NovaZivotinja);
            ZivotinjeList.SelectedItem = NovaZivotinja;
        }

        private void Odustani(object sender, EventArgs e)
        {
            if (AktivnaZivotinja != null && AktivnaZivotinja.Id == -1) // odustani od dodavanja zaposlenika
            {
                Zivotinje.Remove(AktivnaZivotinja);

                PromijeniStanje(Stanje.Pregledaj);
            }
            else if (AktivnaZivotinja != null && AktivnaZivotinja.Id != -1) // odustani od izmjena postojećeg zaposlenika
            {
                PromijeniStanje(Stanje.Pregledaj);
            }

            PopuniZivotinju(AktivnaZivotinja);
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
            zivotinjaService.Delete(AktivnaZivotinja.Id);
            DohvatiZivotinje();
        }

        private void Vrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            var odabranaVrstaZivotinje = (sender as ComboBox).SelectedItem as VrstaZivotinje;

            Pasmina.DataSource = zivotinjaService.GetAllPasminaZivotinjeByVrstaZivotinje(odabranaVrstaZivotinje);
        }
    }
}
