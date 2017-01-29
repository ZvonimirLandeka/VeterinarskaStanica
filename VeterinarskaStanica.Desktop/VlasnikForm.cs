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
    public partial class VlasnikForm : Form
    {
        private VlasnikService vlasnikService;
        private Vlasnik AktivniVlasnik;
        public VlasnikForm(Vlasnik vlasnik)
        {
            InitializeComponent();

            AktivniVlasnik = vlasnik;

            InicijalizirajFormu();
        }
        private void InicijalizirajFormu()
        {
            vlasnikService = new VlasnikService();
            Spol.DataSource = Enum.GetValues(typeof(Spol));
            Popuni(AktivniVlasnik);
        }

        private void Popuni(Vlasnik vlasnik)
        {
            if (vlasnik == null)
                return;

            vlasnikBindingSource.DataSource = vlasnik;

            Spol.SelectedItem = vlasnik.Spol;
        }

        private void Spremi(object sender, EventArgs e)
        {

            AktivniVlasnik.Spol = (Spol)Spol.SelectedItem;

            if (AktivniVlasnik != null && AktivniVlasnik.Id == -1) // novi vlasnik
            {
                vlasnikService.Add(AktivniVlasnik);
            }
            else if (AktivniVlasnik != null && AktivniVlasnik.Id != -1) // postojeći vlasnik
            {
                vlasnikService.Update(AktivniVlasnik);
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
