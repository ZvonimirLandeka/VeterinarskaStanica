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
    public partial class TerminForm : Form
    {
        private TerminService terminService;
        private Model.Termin AktivniTermin;
        private Zahvat UredjivaniZahvat;
        private IList<Zahvat> ZahvatiNaTerminu { get { return (terminBindingSource.DataSource as Model.Termin).Zahvati; } }
        private BindingList<Zahvat> ZahvatiNaTerminuBindingList;
        public TerminForm(Model.Termin termin)
        {
            InitializeComponent();

            AktivniTermin = termin;

            InicijalizirajFormu();
        }
        private void InicijalizirajFormu()
        {
            Vrijeme.Format = DateTimePickerFormat.Time;
            terminService = new TerminService();
            Status.DataSource = Enum.GetValues(typeof(StatusTermina));
            Vrsta.DataSource = terminService.GetAllVrstaTermina();
            Popuni();
        }

        private void Popuni()
        {
            if (AktivniTermin == null)
                return;

            if (AktivniTermin.Zahvati == null || AktivniTermin.Zahvati.Count == 0)
            {
                AktivniTermin.Zahvati = new List<Zahvat>();
            }
            else
            {
                OmoguciUredjivanjeZahvata(true);
            }

            terminBindingSource.DataSource = AktivniTermin;

            ZahvatiNaTerminuBindingList = new BindingList<Zahvat>(AktivniTermin.Zahvati);

            ZahvatiList.DataSource = ZahvatiNaTerminuBindingList;

            ZahvatNaziv.DataBindings.Add("Text", ZahvatiNaTerminuBindingList, "Naziv");
            ZahvatNapomena.DataBindings.Add("Text", ZahvatiNaTerminuBindingList, "Napomena");

            Status.SelectedItem = AktivniTermin.Status;
            Vrsta.SelectedItem = AktivniTermin.VrstaTermina;
            if(AktivniTermin.Datum != null)
            {
                Datum.Value = AktivniTermin.Datum.Value;
                Vrijeme.Value = AktivniTermin.Datum.Value;
            }
        }

        private void NoviZahvat(object sender, EventArgs e)
        {
            var noviZahvat = new Zahvat() { Naziv = "Unesi naziv" };
            zahvatBindingSource.DataSource = noviZahvat;
            ZahvatiNaTerminuBindingList.Add(noviZahvat);
            ZahvatiList.SelectedItem = noviZahvat;

            ZahvatNaziv.Focus();

            OmoguciUredjivanjeZahvata(true);
        }

        private void SpremiZahvat(object sender, EventArgs e)
        {
            var zahvat = zahvatBindingSource.DataSource as Zahvat;
            ZahvatiNaTerminuBindingList.Remove(UredjivaniZahvat);
            ZahvatiNaTerminuBindingList.Add(zahvatBindingSource.DataSource as Zahvat);
        }

        private void ObrisiZahvat(object sender, EventArgs e)
        {   
            if(ZahvatiList.Items.Count > 0)
            {
                var zahvat = ZahvatiList.SelectedItem as Zahvat;
                ZahvatiNaTerminuBindingList.Remove(zahvat);
            }
        }

        private void ZahvatOdabran(object sender, EventArgs e)
        {
            if (AktivniTermin.Zahvati != null && AktivniTermin.Zahvati.Count > 0)
            {
                zahvatBindingSource.DataSource = ZahvatiList.SelectedItem as Zahvat;
                UredjivaniZahvat = ZahvatiList.SelectedItem as Zahvat;
                OmoguciUredjivanjeZahvata(true);
            }
            else
            {
                zahvatBindingSource.DataSource = new Zahvat();
                OmoguciUredjivanjeZahvata(false);
            }
        }

        private void OmoguciUredjivanjeZahvata(bool stanje)
        {
            ZahvatNapomena.Enabled = stanje;
            ZahvatNaziv.Enabled = stanje;
        }

        private void Spremi(object sender, EventArgs e)
        {

            //AktivniTermin.Status = (StatusTermina)Status.SelectedItem;

            if(Datum.Value != null && Vrijeme.Value != null)
            {
                AktivniTermin.Datum = Datum.Value.Date + Vrijeme.Value.TimeOfDay;
            }
            

            if (AktivniTermin != null && AktivniTermin.Id == -1) // novi termin
            {
                terminService.Add(AktivniTermin);
            }
            else if (AktivniTermin != null && AktivniTermin.Id != -1) // postojeći termin
            {
                terminService.Update(AktivniTermin);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Odustani(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AzurirajZahvat(object sender, EventArgs e)
        {
            var zahvat = ZahvatiList.SelectedItem as Zahvat;
            ZahvatiList.DataSource = null;
            ZahvatiList.DataSource = ZahvatiNaTerminuBindingList;
            ZahvatiList.SelectedItem = zahvat;
        }
    }
}
