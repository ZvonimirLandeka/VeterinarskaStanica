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

        private List<Zaposlenik> Zaposlenici;

        public MainForm()
        {
            zaposlenikService = new ZaposlenikService();

            InitializeComponent();

            Zaposlenici = zaposlenikService.GetAll();

            ZaposleniciList.DataSource = Zaposlenici.ToList();
        }

        private void SearchZaposlenik_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearchZaposlenik.Text;

            ZaposleniciList.DataSource = Zaposlenici.Where(x => x.ImePrezimeOib.Contains(searchTerm)).ToList();
        }
    }
}
