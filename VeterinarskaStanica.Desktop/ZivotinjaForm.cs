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
    public partial class ZivotinjaForm : Form
    {
        private ZivotinjaService zivotinjaService;

        private Zivotinja AktivnaZivotinja;

        public ZivotinjaForm(Zivotinja zivotinja)
        {
            zivotinjaService = new ZivotinjaService();
            AktivnaZivotinja = zivotinja;
            InitializeComponent();

            InicijalizirajFormu();
        }

        private void InicijalizirajFormu()
        {
            Spol.DataSource = Enum.GetValues(typeof(Spol));
            Vrsta.DataSource = zivotinjaService.GetAllVrstaZivotinje();
            Pasmina.DataSource = zivotinjaService.GetAllPasminaZivotinjeByVrstaZivotinje(Vrsta.SelectedItem as VrstaZivotinje);
            PopuniZivotinju(AktivnaZivotinja);
        }

        private void PopuniZivotinju(Zivotinja zivotinja)
        {
            if (zivotinja == null)
                return;

            zivotinjaBindingSource.DataSource = zivotinja;

            Vrsta.SelectedItem = zivotinja.VrstaZivotinje;
            Pasmina.SelectedItem = zivotinja.PasminaZivotinje;
            Spol.SelectedItem = zivotinja.Spol;

            //Ime.Text = zivotinja?.Ime;
            //Boja.Text = zivotinja?.Boja;
            //Spol.SelectedItem = zivotinja?.Spol;
            //BrojCipa.Text = zivotinja?.BrojCipa;
            //PolozajCipa.Text = zivotinja?.PolozajCipa;
            //DatumCipiranja.Value = zivotinja.DatumCipiranja;
            //DatumRodenja.Value = zivotinja.DatumRodenja;
            //DatumSmrti.Value = zivotinja.DatumSmrti;

        }

        private void Spremi(object sender, EventArgs e)
        {
            //AktivnaZivotinja.Ime = Ime.Text;
            //AktivnaZivotinja.Boja = Boja.Text;
            AktivnaZivotinja.VrstaZivotinje = Vrsta.SelectedItem as VrstaZivotinje;
            AktivnaZivotinja.PasminaZivotinje = Pasmina.SelectedItem as PasminaZivotinje;
            AktivnaZivotinja.Spol = (Spol)Spol.SelectedItem;
            //AktivnaZivotinja.BrojCipa = BrojCipa.Text;
            //AktivnaZivotinja.PolozajCipa = PolozajCipa.Text;
            //AktivnaZivotinja.DatumCipiranja = DatumCipiranja.Value;
            //AktivnaZivotinja.DatumRodenja = DatumRodenja.Value;
            //AktivnaZivotinja.DatumSmrti = DatumSmrti.Value;

            if (AktivnaZivotinja != null && AktivnaZivotinja.Id == -1) // novi zaposlenik
            {
                zivotinjaService.Add(AktivnaZivotinja);
            }
            else if (AktivnaZivotinja != null && AktivnaZivotinja.Id != -1) // postojeći zaposlenik
            {
                zivotinjaService.Update(AktivnaZivotinja);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Odustani(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void VrstaChanged(object sender, EventArgs e)
        {

        }
    }
}
