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
        private Termin AktivniTermin;
        public TerminForm(Termin termin)
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

            terminBindingSource.DataSource = AktivniTermin;

            Status.SelectedItem = AktivniTermin.Status;
            Vrsta.SelectedItem = AktivniTermin.VrstaTermina;
            if(AktivniTermin.Datum != null)
            {
                Datum.Value = AktivniTermin.Datum.Value;
                Vrijeme.Value = AktivniTermin.Datum.Value;
            }
            else
            {
                Datum.Text = "Unesi datum";
                Vrijeme.Text = "Unesi vrijeme";
            }
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
    }
}
