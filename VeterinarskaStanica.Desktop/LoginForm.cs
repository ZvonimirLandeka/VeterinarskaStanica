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

namespace VeterinarskaStanica.Desktop
{
    public partial class LoginForm : Form
    {
        private readonly ZaposlenikService zaposlenikService;
        public LoginForm()
        {
            InitializeComponent();

            zaposlenikService = new ZaposlenikService();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {          
            string KorisnickoIme = Username.Text;
            string LozinkaHash = Password.Text.GetHashCode().ToString();

            bool loginSuccess = zaposlenikService.CheckLogin(KorisnickoIme, LozinkaHash);

            if (loginSuccess)
            {
                Thread t = new Thread(new ThreadStart(OpenApplication));

                t.Start();

                Close();
            }
            else
            {
                MessageBox.Show("Uneseno pogrešno korisničko ime ili lozinka");
            }
        }

        private void OpenApplication()
        {
            Application.Run(new MainForm());
        }
    }
}
