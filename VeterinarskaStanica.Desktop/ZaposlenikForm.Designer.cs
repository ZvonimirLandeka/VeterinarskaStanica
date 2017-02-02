namespace VeterinarskaStanica.Desktop
{
    partial class ZaposlenikForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SpremiPromjeneButton = new System.Windows.Forms.Button();
            this.Spol = new System.Windows.Forms.ComboBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(226, 363);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "Odustani";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Odustani);
            // 
            // SpremiPromjeneButton
            // 
            this.SpremiPromjeneButton.Location = new System.Drawing.Point(12, 363);
            this.SpremiPromjeneButton.Name = "SpremiPromjeneButton";
            this.SpremiPromjeneButton.Size = new System.Drawing.Size(121, 23);
            this.SpremiPromjeneButton.TabIndex = 25;
            this.SpremiPromjeneButton.Text = "Spremi promjene";
            this.SpremiPromjeneButton.UseVisualStyleBackColor = true;
            this.SpremiPromjeneButton.Click += new System.EventHandler(this.Spremi);
            // 
            // Spol
            // 
            this.Spol.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.zaposlenikBindingSource, "Spol", true));
            this.Spol.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zaposlenikBindingSource, "Spol", true));
            this.Spol.FormattingEnabled = true;
            this.Spol.Location = new System.Drawing.Point(12, 111);
            this.Spol.Name = "Spol";
            this.Spol.Size = new System.Drawing.Size(121, 21);
            this.Spol.TabIndex = 13;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(VeterinarskaStanica.Model.Zaposlenik);
            // 
            // LozinkaLabel
            // 
            this.LozinkaLabel.AutoSize = true;
            this.LozinkaLabel.Location = new System.Drawing.Point(9, 296);
            this.LozinkaLabel.Name = "LozinkaLabel";
            this.LozinkaLabel.Size = new System.Drawing.Size(44, 13);
            this.LozinkaLabel.TabIndex = 14;
            this.LozinkaLabel.Text = "Lozinka";
            // 
            // KorisnickoImeLabel
            // 
            this.KorisnickoImeLabel.AutoSize = true;
            this.KorisnickoImeLabel.Location = new System.Drawing.Point(9, 257);
            this.KorisnickoImeLabel.Name = "KorisnickoImeLabel";
            this.KorisnickoImeLabel.Size = new System.Drawing.Size(75, 13);
            this.KorisnickoImeLabel.TabIndex = 15;
            this.KorisnickoImeLabel.Text = "Korisničko ime";
            // 
            // OIBLabel
            // 
            this.OIBLabel.AutoSize = true;
            this.OIBLabel.Location = new System.Drawing.Point(9, 211);
            this.OIBLabel.Name = "OIBLabel";
            this.OIBLabel.Size = new System.Drawing.Size(25, 13);
            this.OIBLabel.TabIndex = 16;
            this.OIBLabel.Text = "OIB";
            // 
            // AdresaLabel
            // 
            this.AdresaLabel.AutoSize = true;
            this.AdresaLabel.Location = new System.Drawing.Point(9, 140);
            this.AdresaLabel.Name = "AdresaLabel";
            this.AdresaLabel.Size = new System.Drawing.Size(40, 13);
            this.AdresaLabel.TabIndex = 17;
            this.AdresaLabel.Text = "Adresa";
            // 
            // Lozinka
            // 
            this.Lozinka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Lozinka", true));
            this.Lozinka.Location = new System.Drawing.Point(12, 312);
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.Size = new System.Drawing.Size(289, 20);
            this.Lozinka.TabIndex = 24;
            this.Lozinka.UseSystemPasswordChar = true;
            // 
            // SpolLabel
            // 
            this.SpolLabel.AutoSize = true;
            this.SpolLabel.Location = new System.Drawing.Point(9, 95);
            this.SpolLabel.Name = "SpolLabel";
            this.SpolLabel.Size = new System.Drawing.Size(28, 13);
            this.SpolLabel.TabIndex = 18;
            this.SpolLabel.Text = "Spol";
            // 
            // PrezimeLabel
            // 
            this.PrezimeLabel.AutoSize = true;
            this.PrezimeLabel.Location = new System.Drawing.Point(9, 52);
            this.PrezimeLabel.Name = "PrezimeLabel";
            this.PrezimeLabel.Size = new System.Drawing.Size(44, 13);
            this.PrezimeLabel.TabIndex = 19;
            this.PrezimeLabel.Text = "Prezime";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "KorisnickoIme", true));
            this.KorisnickoIme.Location = new System.Drawing.Point(12, 273);
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Size = new System.Drawing.Size(289, 20);
            this.KorisnickoIme.TabIndex = 23;
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(9, 7);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(24, 13);
            this.ImeLabel.TabIndex = 20;
            this.ImeLabel.Text = "Ime";
            // 
            // OIB
            // 
            this.OIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "OIB", true));
            this.OIB.Location = new System.Drawing.Point(12, 227);
            this.OIB.Name = "OIB";
            this.OIB.Size = new System.Drawing.Size(289, 20);
            this.OIB.TabIndex = 22;
            // 
            // Adresa
            // 
            this.Adresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Adresa", true));
            this.Adresa.Location = new System.Drawing.Point(12, 156);
            this.Adresa.Multiline = true;
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(289, 43);
            this.Adresa.TabIndex = 21;
            // 
            // Prezime
            // 
            this.Prezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Prezime", true));
            this.Prezime.Location = new System.Drawing.Point(12, 68);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(289, 20);
            this.Prezime.TabIndex = 12;
            // 
            // Ime
            // 
            this.Ime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "Ime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Ime.Location = new System.Drawing.Point(12, 23);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(289, 20);
            this.Ime.TabIndex = 11;
            // 
            // ZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 398);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SpremiPromjeneButton);
            this.Controls.Add(this.Spol);
            this.Controls.Add(this.LozinkaLabel);
            this.Controls.Add(this.KorisnickoImeLabel);
            this.Controls.Add(this.OIBLabel);
            this.Controls.Add(this.AdresaLabel);
            this.Controls.Add(this.Lozinka);
            this.Controls.Add(this.SpolLabel);
            this.Controls.Add(this.PrezimeLabel);
            this.Controls.Add(this.KorisnickoIme);
            this.Controls.Add(this.ImeLabel);
            this.Controls.Add(this.OIB);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.Ime);
            this.Name = "ZaposlenikForm";
            this.Text = "Zaposlenik";
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SpremiPromjeneButton;
        private System.Windows.Forms.ComboBox Spol;
        private System.Windows.Forms.Label LozinkaLabel;
        private System.Windows.Forms.Label KorisnickoImeLabel;
        private System.Windows.Forms.Label OIBLabel;
        private System.Windows.Forms.Label AdresaLabel;
        private System.Windows.Forms.TextBox Lozinka;
        private System.Windows.Forms.Label SpolLabel;
        private System.Windows.Forms.Label PrezimeLabel;
        private System.Windows.Forms.TextBox KorisnickoIme;
        private System.Windows.Forms.Label ImeLabel;
        private System.Windows.Forms.TextBox OIB;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
    }
}