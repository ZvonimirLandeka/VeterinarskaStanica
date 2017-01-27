namespace VeterinarskaStanica.Desktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Termini = new System.Windows.Forms.TabPage();
            this.ZaposleniciTab = new System.Windows.Forms.TabPage();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ObrisiButton = new System.Windows.Forms.Button();
            this.UrediButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.SpremiPromjeneButton = new System.Windows.Forms.Button();
            this.Spol = new System.Windows.Forms.ComboBox();
            this.LozinkaLabel = new System.Windows.Forms.Label();
            this.KorisnickoImeLabel = new System.Windows.Forms.Label();
            this.OIBLabel = new System.Windows.Forms.Label();
            this.AdresaLabel = new System.Windows.Forms.Label();
            this.Lozinka = new System.Windows.Forms.TextBox();
            this.SpolLabel = new System.Windows.Forms.Label();
            this.PrezimeLabel = new System.Windows.Forms.Label();
            this.KorisnickoIme = new System.Windows.Forms.TextBox();
            this.ImeLabel = new System.Windows.Forms.Label();
            this.OIB = new System.Windows.Forms.TextBox();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.TextBox();
            this.SearchZaposlenik = new System.Windows.Forms.TextBox();
            this.ZaposleniciList = new System.Windows.Forms.ListBox();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZivotinjaTab = new System.Windows.Forms.TabPage();
            this.zivotinjaControl1 = new VeterinarskaStanica.Desktop.ZivotinjaControl();
            this.TabControl.SuspendLayout();
            this.ZaposleniciTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            this.ZivotinjaTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Termini);
            this.TabControl.Controls.Add(this.ZaposleniciTab);
            this.TabControl.Controls.Add(this.ZivotinjaTab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(843, 726);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabControl.TabIndex = 0;
            // 
            // Termini
            // 
            this.Termini.Location = new System.Drawing.Point(4, 22);
            this.Termini.Name = "Termini";
            this.Termini.Padding = new System.Windows.Forms.Padding(3);
            this.Termini.Size = new System.Drawing.Size(835, 700);
            this.Termini.TabIndex = 0;
            this.Termini.Text = "Termini";
            this.Termini.UseVisualStyleBackColor = true;
            // 
            // ZaposleniciTab
            // 
            this.ZaposleniciTab.Controls.Add(this.CancelButton);
            this.ZaposleniciTab.Controls.Add(this.ObrisiButton);
            this.ZaposleniciTab.Controls.Add(this.UrediButton);
            this.ZaposleniciTab.Controls.Add(this.AddNewButton);
            this.ZaposleniciTab.Controls.Add(this.SpremiPromjeneButton);
            this.ZaposleniciTab.Controls.Add(this.Spol);
            this.ZaposleniciTab.Controls.Add(this.LozinkaLabel);
            this.ZaposleniciTab.Controls.Add(this.KorisnickoImeLabel);
            this.ZaposleniciTab.Controls.Add(this.OIBLabel);
            this.ZaposleniciTab.Controls.Add(this.AdresaLabel);
            this.ZaposleniciTab.Controls.Add(this.Lozinka);
            this.ZaposleniciTab.Controls.Add(this.SpolLabel);
            this.ZaposleniciTab.Controls.Add(this.PrezimeLabel);
            this.ZaposleniciTab.Controls.Add(this.KorisnickoIme);
            this.ZaposleniciTab.Controls.Add(this.ImeLabel);
            this.ZaposleniciTab.Controls.Add(this.OIB);
            this.ZaposleniciTab.Controls.Add(this.Adresa);
            this.ZaposleniciTab.Controls.Add(this.Prezime);
            this.ZaposleniciTab.Controls.Add(this.Ime);
            this.ZaposleniciTab.Controls.Add(this.SearchZaposlenik);
            this.ZaposleniciTab.Controls.Add(this.ZaposleniciList);
            this.ZaposleniciTab.Location = new System.Drawing.Point(4, 22);
            this.ZaposleniciTab.Name = "ZaposleniciTab";
            this.ZaposleniciTab.Padding = new System.Windows.Forms.Padding(3);
            this.ZaposleniciTab.Size = new System.Drawing.Size(835, 700);
            this.ZaposleniciTab.TabIndex = 1;
            this.ZaposleniciTab.Text = "Zaposlenici";
            this.ZaposleniciTab.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(648, 641);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Odustani";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Odustani);
            // 
            // ObrisiButton
            // 
            this.ObrisiButton.Location = new System.Drawing.Point(290, 75);
            this.ObrisiButton.Name = "ObrisiButton";
            this.ObrisiButton.Size = new System.Drawing.Size(96, 23);
            this.ObrisiButton.TabIndex = 9;
            this.ObrisiButton.Text = "Obriši";
            this.ObrisiButton.UseVisualStyleBackColor = true;
            this.ObrisiButton.Click += new System.EventHandler(this.ObrisiZaposlenika);
            // 
            // UrediButton
            // 
            this.UrediButton.Location = new System.Drawing.Point(154, 75);
            this.UrediButton.Name = "UrediButton";
            this.UrediButton.Size = new System.Drawing.Size(96, 23);
            this.UrediButton.TabIndex = 9;
            this.UrediButton.Text = "Uredi";
            this.UrediButton.UseVisualStyleBackColor = true;
            this.UrediButton.Click += new System.EventHandler(this.OmoguciUredjivanje);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(17, 75);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(96, 23);
            this.AddNewButton.TabIndex = 9;
            this.AddNewButton.Text = "Novi zaposlenik";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.DodajNovogZaposlenika);
            // 
            // SpremiPromjeneButton
            // 
            this.SpremiPromjeneButton.Location = new System.Drawing.Point(507, 640);
            this.SpremiPromjeneButton.Name = "SpremiPromjeneButton";
            this.SpremiPromjeneButton.Size = new System.Drawing.Size(121, 23);
            this.SpremiPromjeneButton.TabIndex = 8;
            this.SpremiPromjeneButton.Text = "Spremi promjene";
            this.SpremiPromjeneButton.UseVisualStyleBackColor = true;
            this.SpremiPromjeneButton.Click += new System.EventHandler(this.SpremiZaposlenika);
            // 
            // Spol
            // 
            this.Spol.FormattingEnabled = true;
            this.Spol.Location = new System.Drawing.Point(507, 237);
            this.Spol.Name = "Spol";
            this.Spol.Size = new System.Drawing.Size(121, 21);
            this.Spol.TabIndex = 3;
            // 
            // LozinkaLabel
            // 
            this.LozinkaLabel.AutoSize = true;
            this.LozinkaLabel.Location = new System.Drawing.Point(504, 505);
            this.LozinkaLabel.Name = "LozinkaLabel";
            this.LozinkaLabel.Size = new System.Drawing.Size(44, 13);
            this.LozinkaLabel.TabIndex = 3;
            this.LozinkaLabel.Text = "Lozinka";
            // 
            // KorisnickoImeLabel
            // 
            this.KorisnickoImeLabel.AutoSize = true;
            this.KorisnickoImeLabel.Location = new System.Drawing.Point(504, 439);
            this.KorisnickoImeLabel.Name = "KorisnickoImeLabel";
            this.KorisnickoImeLabel.Size = new System.Drawing.Size(75, 13);
            this.KorisnickoImeLabel.TabIndex = 3;
            this.KorisnickoImeLabel.Text = "Korisničko ime";
            // 
            // OIBLabel
            // 
            this.OIBLabel.AutoSize = true;
            this.OIBLabel.Location = new System.Drawing.Point(504, 364);
            this.OIBLabel.Name = "OIBLabel";
            this.OIBLabel.Size = new System.Drawing.Size(25, 13);
            this.OIBLabel.TabIndex = 3;
            this.OIBLabel.Text = "OIB";
            // 
            // AdresaLabel
            // 
            this.AdresaLabel.AutoSize = true;
            this.AdresaLabel.Location = new System.Drawing.Point(504, 288);
            this.AdresaLabel.Name = "AdresaLabel";
            this.AdresaLabel.Size = new System.Drawing.Size(40, 13);
            this.AdresaLabel.TabIndex = 3;
            this.AdresaLabel.Text = "Adresa";
            // 
            // Lozinka
            // 
            this.Lozinka.Location = new System.Drawing.Point(507, 528);
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.Size = new System.Drawing.Size(216, 20);
            this.Lozinka.TabIndex = 7;
            // 
            // SpolLabel
            // 
            this.SpolLabel.AutoSize = true;
            this.SpolLabel.Location = new System.Drawing.Point(504, 211);
            this.SpolLabel.Name = "SpolLabel";
            this.SpolLabel.Size = new System.Drawing.Size(28, 13);
            this.SpolLabel.TabIndex = 3;
            this.SpolLabel.Text = "Spol";
            // 
            // PrezimeLabel
            // 
            this.PrezimeLabel.AutoSize = true;
            this.PrezimeLabel.Location = new System.Drawing.Point(504, 139);
            this.PrezimeLabel.Name = "PrezimeLabel";
            this.PrezimeLabel.Size = new System.Drawing.Size(44, 13);
            this.PrezimeLabel.TabIndex = 3;
            this.PrezimeLabel.Text = "Prezime";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.Location = new System.Drawing.Point(507, 462);
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Size = new System.Drawing.Size(216, 20);
            this.KorisnickoIme.TabIndex = 6;
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(504, 75);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(24, 13);
            this.ImeLabel.TabIndex = 3;
            this.ImeLabel.Text = "Ime";
            // 
            // OIB
            // 
            this.OIB.Location = new System.Drawing.Point(507, 387);
            this.OIB.Name = "OIB";
            this.OIB.Size = new System.Drawing.Size(216, 20);
            this.OIB.TabIndex = 5;
            // 
            // Adresa
            // 
            this.Adresa.Location = new System.Drawing.Point(507, 311);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(216, 20);
            this.Adresa.TabIndex = 4;
            // 
            // Prezime
            // 
            this.Prezime.Location = new System.Drawing.Point(507, 162);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(216, 20);
            this.Prezime.TabIndex = 2;
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(507, 98);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(216, 20);
            this.Ime.TabIndex = 1;
            // 
            // SearchZaposlenik
            // 
            this.SearchZaposlenik.Location = new System.Drawing.Point(17, 32);
            this.SearchZaposlenik.Name = "SearchZaposlenik";
            this.SearchZaposlenik.Size = new System.Drawing.Size(144, 20);
            this.SearchZaposlenik.TabIndex = 1;
            this.SearchZaposlenik.TextChanged += new System.EventHandler(this.FiltrirajZaposlenike);
            // 
            // ZaposleniciList
            // 
            this.ZaposleniciList.DataSource = this.zaposleniciBindingSource;
            this.ZaposleniciList.DisplayMember = "ImePrezimeOib";
            this.ZaposleniciList.FormattingEnabled = true;
            this.ZaposleniciList.Location = new System.Drawing.Point(17, 114);
            this.ZaposleniciList.Name = "ZaposleniciList";
            this.ZaposleniciList.Size = new System.Drawing.Size(369, 550);
            this.ZaposleniciList.TabIndex = 0;
            this.ZaposleniciList.ValueMember = "Id";
            this.ZaposleniciList.SelectedIndexChanged += new System.EventHandler(this.ZaposlenikOdabran);
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataSource = typeof(VeterinarskaStanica.Model.Zaposlenik);
            // 
            // ZivotinjaTab
            // 
            this.ZivotinjaTab.Controls.Add(this.zivotinjaControl1);
            this.ZivotinjaTab.Location = new System.Drawing.Point(4, 22);
            this.ZivotinjaTab.Name = "ZivotinjaTab";
            this.ZivotinjaTab.Padding = new System.Windows.Forms.Padding(3);
            this.ZivotinjaTab.Size = new System.Drawing.Size(835, 700);
            this.ZivotinjaTab.TabIndex = 2;
            this.ZivotinjaTab.Text = "Životinja";
            this.ZivotinjaTab.UseVisualStyleBackColor = true;
            // 
            // zivotinjaControl1
            // 
            this.zivotinjaControl1.Location = new System.Drawing.Point(6, 6);
            this.zivotinjaControl1.Name = "zivotinjaControl1";
            this.zivotinjaControl1.Size = new System.Drawing.Size(823, 688);
            this.zivotinjaControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 750);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "Veterinarska stanica";
            this.TabControl.ResumeLayout(false);
            this.ZaposleniciTab.ResumeLayout(false);
            this.ZaposleniciTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            this.ZivotinjaTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Termini;
        private System.Windows.Forms.TabPage ZaposleniciTab;
        private System.Windows.Forms.ListBox ZaposleniciList;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private System.Windows.Forms.TextBox SearchZaposlenik;
        private System.Windows.Forms.Label OIBLabel;
        private System.Windows.Forms.Label AdresaLabel;
        private System.Windows.Forms.Label PrezimeLabel;
        private System.Windows.Forms.Label ImeLabel;
        private System.Windows.Forms.TextBox OIB;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.Label KorisnickoImeLabel;
        private System.Windows.Forms.TextBox KorisnickoIme;
        private System.Windows.Forms.Label LozinkaLabel;
        private System.Windows.Forms.TextBox Lozinka;
        private System.Windows.Forms.ComboBox Spol;
        private System.Windows.Forms.Label SpolLabel;
        private System.Windows.Forms.Button SpremiPromjeneButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ObrisiButton;
        private System.Windows.Forms.Button UrediButton;
        private System.Windows.Forms.TabPage ZivotinjaTab;
        private ZivotinjaControl zivotinjaControl1;
    }
}