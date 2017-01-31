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
using System.Threading;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.Desktop
{
    public partial class LoginForm : Form
    {
        private readonly ZaposlenikService zaposlenikService;
        private string KorisnickoIme { get { return Username.Text; } }
        private string LozinkaHash { get { return Password.Text.GetHashCode().ToString(); } }
        public LoginForm()
        {
            InitializeComponent();

            zaposlenikService = new ZaposlenikService();
            DebugAutoLogin();
        }

        private void DebugAutoLogin()
        {
            Username.Text = "imarlovic";
            Password.Text = "1234";
        }

        private void PokusajPrijave(object sender, EventArgs e)
        {          
            bool loginSuccess = zaposlenikService.CheckLogin(KorisnickoIme, LozinkaHash);

            if (loginSuccess)
            {
                var prijavljeniZaposlenik = zaposlenikService.GetByKorisnickoIme(KorisnickoIme);
                Thread t = new Thread(new ThreadStart(() =>  OtvoriAplikacijuZatvoriPrijavu(prijavljeniZaposlenik) ));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                Close();
            }
            else
            {
                MessageBox.Show("Uneseno pogrešno korisničko ime ili lozinka");
            }
        }

        private void OtvoriAplikacijuZatvoriPrijavu(Zaposlenik prijavljeniZaposlenik)
        {
            Application.Run(new MainForm(prijavljeniZaposlenik));
        }
    }
}
