﻿namespace VeterinarskaStanica.Desktop
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
            this.ObrisiZaposlenikaButton = new System.Windows.Forms.Button();
            this.UrediZaposlenikaButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.LozinkaLabel = new System.Windows.Forms.Label();
            this.KorisnickoImeLabel = new System.Windows.Forms.Label();
            this.OIBLabel = new System.Windows.Forms.Label();
            this.AdresaLabel = new System.Windows.Forms.Label();
            this.Lozinka = new System.Windows.Forms.TextBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpolLabel = new System.Windows.Forms.Label();
            this.PrezimeLabel = new System.Windows.Forms.Label();
            this.KorisnickoIme = new System.Windows.Forms.TextBox();
            this.ImeLabel = new System.Windows.Forms.Label();
            this.OIB = new System.Windows.Forms.TextBox();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.TextBox();
            this.SearchZaposlenik = new System.Windows.Forms.TextBox();
            this.ZaposleniciList = new System.Windows.Forms.ListBox();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZivotinjaTab = new System.Windows.Forms.TabPage();
            this.zivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatumCipiranjaLabel = new System.Windows.Forms.Label();
            this.DatumSmrtiLabel = new System.Windows.Forms.Label();
            this.DatumRodjenjaLabel = new System.Windows.Forms.Label();
            this.PolozajCipaLabel = new System.Windows.Forms.Label();
            this.BrojCipaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BojaLabel = new System.Windows.Forms.Label();
            this.PasminaLabel = new System.Windows.Forms.Label();
            this.VrstaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PolozajCipa = new System.Windows.Forms.TextBox();
            this.BrojCipa = new System.Windows.Forms.TextBox();
            this.Boja = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ObrisiZivotinjuButton = new System.Windows.Forms.Button();
            this.UrediZivotinjuButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ZivotinjeList = new System.Windows.Forms.ListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.ZaposleniciTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            this.ZivotinjaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
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
            this.ZaposleniciTab.Controls.Add(this.ObrisiZaposlenikaButton);
            this.ZaposleniciTab.Controls.Add(this.UrediZaposlenikaButton);
            this.ZaposleniciTab.Controls.Add(this.AddNewButton);
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
            this.ZaposleniciTab.Controls.Add(this.textBox6);
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
            // ObrisiZaposlenikaButton
            // 
            this.ObrisiZaposlenikaButton.Enabled = false;
            this.ObrisiZaposlenikaButton.Location = new System.Drawing.Point(290, 75);
            this.ObrisiZaposlenikaButton.Name = "ObrisiZaposlenikaButton";
            this.ObrisiZaposlenikaButton.Size = new System.Drawing.Size(96, 23);
            this.ObrisiZaposlenikaButton.TabIndex = 9;
            this.ObrisiZaposlenikaButton.Text = "Obriši";
            this.ObrisiZaposlenikaButton.UseVisualStyleBackColor = true;
            this.ObrisiZaposlenikaButton.Click += new System.EventHandler(this.ObrisiZaposlenika);
            // 
            // UrediZaposlenikaButton
            // 
            this.UrediZaposlenikaButton.Enabled = false;
            this.UrediZaposlenikaButton.Location = new System.Drawing.Point(154, 75);
            this.UrediZaposlenikaButton.Name = "UrediZaposlenikaButton";
            this.UrediZaposlenikaButton.Size = new System.Drawing.Size(96, 23);
            this.UrediZaposlenikaButton.TabIndex = 9;
            this.UrediZaposlenikaButton.Text = "Uredi";
            this.UrediZaposlenikaButton.UseVisualStyleBackColor = true;
            this.UrediZaposlenikaButton.Click += new System.EventHandler(this.UrediZaposlenika);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(17, 75);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(96, 23);
            this.AddNewButton.TabIndex = 9;
            this.AddNewButton.Text = "Novi zaposlenik";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.DodajZaposlenika);
            // 
            // LozinkaLabel
            // 
            this.LozinkaLabel.AutoSize = true;
            this.LozinkaLabel.Location = new System.Drawing.Point(431, 381);
            this.LozinkaLabel.Name = "LozinkaLabel";
            this.LozinkaLabel.Size = new System.Drawing.Size(44, 13);
            this.LozinkaLabel.TabIndex = 3;
            this.LozinkaLabel.Text = "Lozinka";
            // 
            // KorisnickoImeLabel
            // 
            this.KorisnickoImeLabel.AutoSize = true;
            this.KorisnickoImeLabel.Location = new System.Drawing.Point(431, 342);
            this.KorisnickoImeLabel.Name = "KorisnickoImeLabel";
            this.KorisnickoImeLabel.Size = new System.Drawing.Size(75, 13);
            this.KorisnickoImeLabel.TabIndex = 3;
            this.KorisnickoImeLabel.Text = "Korisničko ime";
            // 
            // OIBLabel
            // 
            this.OIBLabel.AutoSize = true;
            this.OIBLabel.Location = new System.Drawing.Point(431, 303);
            this.OIBLabel.Name = "OIBLabel";
            this.OIBLabel.Size = new System.Drawing.Size(25, 13);
            this.OIBLabel.TabIndex = 3;
            this.OIBLabel.Text = "OIB";
            // 
            // AdresaLabel
            // 
            this.AdresaLabel.AutoSize = true;
            this.AdresaLabel.Location = new System.Drawing.Point(431, 232);
            this.AdresaLabel.Name = "AdresaLabel";
            this.AdresaLabel.Size = new System.Drawing.Size(40, 13);
            this.AdresaLabel.TabIndex = 3;
            this.AdresaLabel.Text = "Adresa";
            // 
            // Lozinka
            // 
            this.Lozinka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Lozinka", true));
            this.Lozinka.Location = new System.Drawing.Point(434, 397);
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.ReadOnly = true;
            this.Lozinka.Size = new System.Drawing.Size(302, 20);
            this.Lozinka.TabIndex = 7;
            this.Lozinka.UseSystemPasswordChar = true;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(VeterinarskaStanica.Model.Zaposlenik);
            // 
            // SpolLabel
            // 
            this.SpolLabel.AutoSize = true;
            this.SpolLabel.Location = new System.Drawing.Point(431, 192);
            this.SpolLabel.Name = "SpolLabel";
            this.SpolLabel.Size = new System.Drawing.Size(28, 13);
            this.SpolLabel.TabIndex = 3;
            this.SpolLabel.Text = "Spol";
            // 
            // PrezimeLabel
            // 
            this.PrezimeLabel.AutoSize = true;
            this.PrezimeLabel.Location = new System.Drawing.Point(431, 153);
            this.PrezimeLabel.Name = "PrezimeLabel";
            this.PrezimeLabel.Size = new System.Drawing.Size(44, 13);
            this.PrezimeLabel.TabIndex = 3;
            this.PrezimeLabel.Text = "Prezime";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "KorisnickoIme", true));
            this.KorisnickoIme.Location = new System.Drawing.Point(434, 358);
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            this.KorisnickoIme.Size = new System.Drawing.Size(302, 20);
            this.KorisnickoIme.TabIndex = 6;
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(431, 114);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(24, 13);
            this.ImeLabel.TabIndex = 3;
            this.ImeLabel.Text = "Ime";
            // 
            // OIB
            // 
            this.OIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "OIB", true));
            this.OIB.Location = new System.Drawing.Point(434, 319);
            this.OIB.Name = "OIB";
            this.OIB.ReadOnly = true;
            this.OIB.Size = new System.Drawing.Size(302, 20);
            this.OIB.TabIndex = 5;
            // 
            // Adresa
            // 
            this.Adresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Adresa", true));
            this.Adresa.Location = new System.Drawing.Point(434, 248);
            this.Adresa.Multiline = true;
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            this.Adresa.Size = new System.Drawing.Size(302, 51);
            this.Adresa.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Spol", true));
            this.textBox6.Location = new System.Drawing.Point(434, 208);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(302, 20);
            this.textBox6.TabIndex = 2;
            // 
            // Prezime
            // 
            this.Prezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Prezime", true));
            this.Prezime.Location = new System.Drawing.Point(434, 169);
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Size = new System.Drawing.Size(302, 20);
            this.Prezime.TabIndex = 2;
            // 
            // Ime
            // 
            this.Ime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Ime", true));
            this.Ime.Location = new System.Drawing.Point(434, 130);
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Size = new System.Drawing.Size(302, 20);
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
            this.ZivotinjaTab.Controls.Add(this.DatumCipiranjaLabel);
            this.ZivotinjaTab.Controls.Add(this.DatumSmrtiLabel);
            this.ZivotinjaTab.Controls.Add(this.DatumRodjenjaLabel);
            this.ZivotinjaTab.Controls.Add(this.PolozajCipaLabel);
            this.ZivotinjaTab.Controls.Add(this.BrojCipaLabel);
            this.ZivotinjaTab.Controls.Add(this.label1);
            this.ZivotinjaTab.Controls.Add(this.BojaLabel);
            this.ZivotinjaTab.Controls.Add(this.PasminaLabel);
            this.ZivotinjaTab.Controls.Add(this.VrstaLabel);
            this.ZivotinjaTab.Controls.Add(this.label2);
            this.ZivotinjaTab.Controls.Add(this.PolozajCipa);
            this.ZivotinjaTab.Controls.Add(this.textBox9);
            this.ZivotinjaTab.Controls.Add(this.textBox8);
            this.ZivotinjaTab.Controls.Add(this.textBox7);
            this.ZivotinjaTab.Controls.Add(this.BrojCipa);
            this.ZivotinjaTab.Controls.Add(this.Boja);
            this.ZivotinjaTab.Controls.Add(this.textBox4);
            this.ZivotinjaTab.Controls.Add(this.textBox5);
            this.ZivotinjaTab.Controls.Add(this.textBox3);
            this.ZivotinjaTab.Controls.Add(this.textBox2);
            this.ZivotinjaTab.Controls.Add(this.ObrisiZivotinjuButton);
            this.ZivotinjaTab.Controls.Add(this.UrediZivotinjuButton);
            this.ZivotinjaTab.Controls.Add(this.button3);
            this.ZivotinjaTab.Controls.Add(this.textBox1);
            this.ZivotinjaTab.Controls.Add(this.ZivotinjeList);
            this.ZivotinjaTab.Location = new System.Drawing.Point(4, 22);
            this.ZivotinjaTab.Name = "ZivotinjaTab";
            this.ZivotinjaTab.Padding = new System.Windows.Forms.Padding(3);
            this.ZivotinjaTab.Size = new System.Drawing.Size(835, 700);
            this.ZivotinjaTab.TabIndex = 2;
            this.ZivotinjaTab.Text = "Životinja";
            this.ZivotinjaTab.UseVisualStyleBackColor = true;
            // 
            // zivotinjaBindingSource
            // 
            this.zivotinjaBindingSource.DataSource = typeof(VeterinarskaStanica.Model.Zivotinja);
            // 
            // DatumCipiranjaLabel
            // 
            this.DatumCipiranjaLabel.AutoSize = true;
            this.DatumCipiranjaLabel.Location = new System.Drawing.Point(419, 279);
            this.DatumCipiranjaLabel.Name = "DatumCipiranjaLabel";
            this.DatumCipiranjaLabel.Size = new System.Drawing.Size(80, 13);
            this.DatumCipiranjaLabel.TabIndex = 60;
            this.DatumCipiranjaLabel.Text = "Datum čipiranja";
            // 
            // DatumSmrtiLabel
            // 
            this.DatumSmrtiLabel.AutoSize = true;
            this.DatumSmrtiLabel.Location = new System.Drawing.Point(568, 412);
            this.DatumSmrtiLabel.Name = "DatumSmrtiLabel";
            this.DatumSmrtiLabel.Size = new System.Drawing.Size(62, 13);
            this.DatumSmrtiLabel.TabIndex = 59;
            this.DatumSmrtiLabel.Text = "Datum smrti";
            // 
            // DatumRodjenjaLabel
            // 
            this.DatumRodjenjaLabel.AutoSize = true;
            this.DatumRodjenjaLabel.Location = new System.Drawing.Point(422, 412);
            this.DatumRodjenjaLabel.Name = "DatumRodjenjaLabel";
            this.DatumRodjenjaLabel.Size = new System.Drawing.Size(77, 13);
            this.DatumRodjenjaLabel.TabIndex = 61;
            this.DatumRodjenjaLabel.Text = "Datum rođenja";
            // 
            // PolozajCipaLabel
            // 
            this.PolozajCipaLabel.AutoSize = true;
            this.PolozajCipaLabel.Location = new System.Drawing.Point(419, 366);
            this.PolozajCipaLabel.Name = "PolozajCipaLabel";
            this.PolozajCipaLabel.Size = new System.Drawing.Size(64, 13);
            this.PolozajCipaLabel.TabIndex = 62;
            this.PolozajCipaLabel.Text = "Položaj čipa";
            // 
            // BrojCipaLabel
            // 
            this.BrojCipaLabel.AutoSize = true;
            this.BrojCipaLabel.Location = new System.Drawing.Point(419, 324);
            this.BrojCipaLabel.Name = "BrojCipaLabel";
            this.BrojCipaLabel.Size = new System.Drawing.Size(48, 13);
            this.BrojCipaLabel.TabIndex = 63;
            this.BrojCipaLabel.Text = "Broj čipa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Spol";
            // 
            // BojaLabel
            // 
            this.BojaLabel.AutoSize = true;
            this.BojaLabel.Location = new System.Drawing.Point(419, 194);
            this.BojaLabel.Name = "BojaLabel";
            this.BojaLabel.Size = new System.Drawing.Size(28, 13);
            this.BojaLabel.TabIndex = 65;
            this.BojaLabel.Text = "Boja";
            // 
            // PasminaLabel
            // 
            this.PasminaLabel.AutoSize = true;
            this.PasminaLabel.Location = new System.Drawing.Point(568, 150);
            this.PasminaLabel.Name = "PasminaLabel";
            this.PasminaLabel.Size = new System.Drawing.Size(47, 13);
            this.PasminaLabel.TabIndex = 66;
            this.PasminaLabel.Text = "Pasmina";
            // 
            // VrstaLabel
            // 
            this.VrstaLabel.AutoSize = true;
            this.VrstaLabel.Location = new System.Drawing.Point(419, 149);
            this.VrstaLabel.Name = "VrstaLabel";
            this.VrstaLabel.Size = new System.Drawing.Size(31, 13);
            this.VrstaLabel.TabIndex = 67;
            this.VrstaLabel.Text = "Vrsta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Ime";
            // 
            // PolozajCipa
            // 
            this.PolozajCipa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "PolozajCipa", true));
            this.PolozajCipa.Location = new System.Drawing.Point(422, 382);
            this.PolozajCipa.Name = "PolozajCipa";
            this.PolozajCipa.ReadOnly = true;
            this.PolozajCipa.Size = new System.Drawing.Size(216, 20);
            this.PolozajCipa.TabIndex = 70;
            // 
            // BrojCipa
            // 
            this.BrojCipa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "BrojCipa", true));
            this.BrojCipa.Location = new System.Drawing.Point(422, 340);
            this.BrojCipa.Name = "BrojCipa";
            this.BrojCipa.ReadOnly = true;
            this.BrojCipa.Size = new System.Drawing.Size(216, 20);
            this.BrojCipa.TabIndex = 69;
            // 
            // Boja
            // 
            this.Boja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "Boja", true));
            this.Boja.Location = new System.Drawing.Point(422, 210);
            this.Boja.Name = "Boja";
            this.Boja.ReadOnly = true;
            this.Boja.Size = new System.Drawing.Size(293, 20);
            this.Boja.TabIndex = 57;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "PasminaZivotinje", true));
            this.textBox4.Location = new System.Drawing.Point(571, 165);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 56;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "Spol", true));
            this.textBox5.Location = new System.Drawing.Point(422, 250);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(143, 20);
            this.textBox5.TabIndex = 56;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "VrstaZivotinje", true));
            this.textBox3.Location = new System.Drawing.Point(422, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 56;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "Ime", true));
            this.textBox2.Location = new System.Drawing.Point(422, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(293, 20);
            this.textBox2.TabIndex = 56;
            // 
            // ObrisiZivotinjuButton
            // 
            this.ObrisiZivotinjuButton.Enabled = false;
            this.ObrisiZivotinjuButton.Location = new System.Drawing.Point(290, 61);
            this.ObrisiZivotinjuButton.Name = "ObrisiZivotinjuButton";
            this.ObrisiZivotinjuButton.Size = new System.Drawing.Size(96, 23);
            this.ObrisiZivotinjuButton.TabIndex = 35;
            this.ObrisiZivotinjuButton.Text = "Obriši";
            this.ObrisiZivotinjuButton.UseVisualStyleBackColor = true;
            this.ObrisiZivotinjuButton.Click += new System.EventHandler(this.ObrisiZivotinju);
            // 
            // UrediZivotinjuButton
            // 
            this.UrediZivotinjuButton.Enabled = false;
            this.UrediZivotinjuButton.Location = new System.Drawing.Point(154, 61);
            this.UrediZivotinjuButton.Name = "UrediZivotinjuButton";
            this.UrediZivotinjuButton.Size = new System.Drawing.Size(96, 23);
            this.UrediZivotinjuButton.TabIndex = 34;
            this.UrediZivotinjuButton.Text = "Uredi";
            this.UrediZivotinjuButton.UseVisualStyleBackColor = true;
            this.UrediZivotinjuButton.Click += new System.EventHandler(this.UrediZivotinju);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Nova životinja";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DodajZivotinju);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 32;
            // 
            // ZivotinjeList
            // 
            this.ZivotinjeList.DisplayMember = "ImePrezimeOib";
            this.ZivotinjeList.FormattingEnabled = true;
            this.ZivotinjeList.Location = new System.Drawing.Point(17, 100);
            this.ZivotinjeList.Name = "ZivotinjeList";
            this.ZivotinjeList.Size = new System.Drawing.Size(369, 550);
            this.ZivotinjeList.TabIndex = 31;
            this.ZivotinjeList.ValueMember = "Id";
            this.ZivotinjeList.SelectedIndexChanged += new System.EventHandler(this.ZivotinjaOdabrana);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "DatumCipiranja", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.textBox7.Location = new System.Drawing.Point(422, 295);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(216, 20);
            this.textBox7.TabIndex = 69;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "DatumRodenja", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.textBox8.Location = new System.Drawing.Point(422, 428);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(143, 20);
            this.textBox8.TabIndex = 69;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "DatumSmrti", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.textBox9.Location = new System.Drawing.Point(571, 428);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(143, 20);
            this.textBox9.TabIndex = 69;
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
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            this.ZivotinjaTab.ResumeLayout(false);
            this.ZivotinjaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
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
        private System.Windows.Forms.Label SpolLabel;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button ObrisiZaposlenikaButton;
        private System.Windows.Forms.Button UrediZaposlenikaButton;
        private System.Windows.Forms.TabPage ZivotinjaTab;
        private System.Windows.Forms.Button ObrisiZivotinjuButton;
        private System.Windows.Forms.Button UrediZivotinjuButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox ZivotinjeList;
        private System.Windows.Forms.BindingSource zivotinjaBindingSource;
        private System.Windows.Forms.Label DatumCipiranjaLabel;
        private System.Windows.Forms.Label DatumSmrtiLabel;
        private System.Windows.Forms.Label DatumRodjenjaLabel;
        private System.Windows.Forms.Label PolozajCipaLabel;
        private System.Windows.Forms.Label BrojCipaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BojaLabel;
        private System.Windows.Forms.Label PasminaLabel;
        private System.Windows.Forms.Label VrstaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PolozajCipa;
        private System.Windows.Forms.TextBox BrojCipa;
        private System.Windows.Forms.TextBox Boja;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
    }
}