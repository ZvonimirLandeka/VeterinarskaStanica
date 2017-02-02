namespace VeterinarskaStanica.Desktop
{
    partial class ZivotinjaForm
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
            this.Pasmina = new System.Windows.Forms.ComboBox();
            this.zivotinjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatumCipiranja = new System.Windows.Forms.DateTimePicker();
            this.DatumSmrti = new System.Windows.Forms.DateTimePicker();
            this.DatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SpremiPromjeneButton = new System.Windows.Forms.Button();
            this.DatumCipiranjaLabel = new System.Windows.Forms.Label();
            this.Spol = new System.Windows.Forms.ComboBox();
            this.DatumSmrtiLabel = new System.Windows.Forms.Label();
            this.DatumRodjenjaLabel = new System.Windows.Forms.Label();
            this.PolozajCipaLabel = new System.Windows.Forms.Label();
            this.BrojCipaLabel = new System.Windows.Forms.Label();
            this.SpolLabel = new System.Windows.Forms.Label();
            this.BojaLabel = new System.Windows.Forms.Label();
            this.PasminaLabel = new System.Windows.Forms.Label();
            this.VrstaLabel = new System.Windows.Forms.Label();
            this.ImeLabel = new System.Windows.Forms.Label();
            this.PolozajCipa = new System.Windows.Forms.TextBox();
            this.BrojCipa = new System.Windows.Forms.TextBox();
            this.Boja = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.TextBox();
            this.Vrsta = new System.Windows.Forms.ComboBox();
            this.vrstaZivotinjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaZivotinjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Pasmina
            // 
            this.Pasmina.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zivotinjaBindingSource, "PasminaZivotinje", true));
            this.Pasmina.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.zivotinjaBindingSource, "PasminaZivotinje", true));
            this.Pasmina.FormattingEnabled = true;
            this.Pasmina.Location = new System.Drawing.Point(161, 115);
            this.Pasmina.Name = "Pasmina";
            this.Pasmina.Size = new System.Drawing.Size(144, 21);
            this.Pasmina.TabIndex = 55;
            // 
            // zivotinjaBindingSource
            // 
            this.zivotinjaBindingSource.DataSource = typeof(VeterinarskaStanica.Model.Zivotinja);
            // 
            // DatumCipiranja
            // 
            this.DatumCipiranja.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zivotinjaBindingSource, "DatumCipiranja", true));
            this.DatumCipiranja.Location = new System.Drawing.Point(12, 244);
            this.DatumCipiranja.Name = "DatumCipiranja";
            this.DatumCipiranja.Size = new System.Drawing.Size(200, 20);
            this.DatumCipiranja.TabIndex = 53;
            // 
            // DatumSmrti
            // 
            this.DatumSmrti.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zivotinjaBindingSource, "DatumSmrti", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DatumSmrti.Location = new System.Drawing.Point(161, 377);
            this.DatumSmrti.Name = "DatumSmrti";
            this.DatumSmrti.Size = new System.Drawing.Size(144, 20);
            this.DatumSmrti.TabIndex = 52;
            // 
            // DatumRodenja
            // 
            this.DatumRodenja.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zivotinjaBindingSource, "DatumRodenja", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DatumRodenja.Location = new System.Drawing.Point(12, 377);
            this.DatumRodenja.Name = "DatumRodenja";
            this.DatumRodenja.Size = new System.Drawing.Size(143, 20);
            this.DatumRodenja.TabIndex = 51;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(230, 437);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 50;
            this.CancelButton.Text = "Odustani";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Odustani);
            // 
            // SpremiPromjeneButton
            // 
            this.SpremiPromjeneButton.Location = new System.Drawing.Point(12, 437);
            this.SpremiPromjeneButton.Name = "SpremiPromjeneButton";
            this.SpremiPromjeneButton.Size = new System.Drawing.Size(121, 23);
            this.SpremiPromjeneButton.TabIndex = 49;
            this.SpremiPromjeneButton.Text = "Spremi promjene";
            this.SpremiPromjeneButton.UseVisualStyleBackColor = true;
            this.SpremiPromjeneButton.Click += new System.EventHandler(this.Spremi);
            // 
            // DatumCipiranjaLabel
            // 
            this.DatumCipiranjaLabel.AutoSize = true;
            this.DatumCipiranjaLabel.Location = new System.Drawing.Point(9, 228);
            this.DatumCipiranjaLabel.Name = "DatumCipiranjaLabel";
            this.DatumCipiranjaLabel.Size = new System.Drawing.Size(80, 13);
            this.DatumCipiranjaLabel.TabIndex = 38;
            this.DatumCipiranjaLabel.Text = "Datum čipiranja";
            // 
            // Spol
            // 
            this.Spol.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zivotinjaBindingSource, "Spol", true));
            this.Spol.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.zivotinjaBindingSource, "Spol", true));
            this.Spol.FormattingEnabled = true;
            this.Spol.Location = new System.Drawing.Point(12, 199);
            this.Spol.Name = "Spol";
            this.Spol.Size = new System.Drawing.Size(121, 21);
            this.Spol.TabIndex = 36;
            // 
            // DatumSmrtiLabel
            // 
            this.DatumSmrtiLabel.AutoSize = true;
            this.DatumSmrtiLabel.Location = new System.Drawing.Point(158, 361);
            this.DatumSmrtiLabel.Name = "DatumSmrtiLabel";
            this.DatumSmrtiLabel.Size = new System.Drawing.Size(62, 13);
            this.DatumSmrtiLabel.TabIndex = 37;
            this.DatumSmrtiLabel.Text = "Datum smrti";
            // 
            // DatumRodjenjaLabel
            // 
            this.DatumRodjenjaLabel.AutoSize = true;
            this.DatumRodjenjaLabel.Location = new System.Drawing.Point(12, 361);
            this.DatumRodjenjaLabel.Name = "DatumRodjenjaLabel";
            this.DatumRodjenjaLabel.Size = new System.Drawing.Size(77, 13);
            this.DatumRodjenjaLabel.TabIndex = 39;
            this.DatumRodjenjaLabel.Text = "Datum rođenja";
            // 
            // PolozajCipaLabel
            // 
            this.PolozajCipaLabel.AutoSize = true;
            this.PolozajCipaLabel.Location = new System.Drawing.Point(9, 315);
            this.PolozajCipaLabel.Name = "PolozajCipaLabel";
            this.PolozajCipaLabel.Size = new System.Drawing.Size(64, 13);
            this.PolozajCipaLabel.TabIndex = 40;
            this.PolozajCipaLabel.Text = "Položaj čipa";
            // 
            // BrojCipaLabel
            // 
            this.BrojCipaLabel.AutoSize = true;
            this.BrojCipaLabel.Location = new System.Drawing.Point(9, 273);
            this.BrojCipaLabel.Name = "BrojCipaLabel";
            this.BrojCipaLabel.Size = new System.Drawing.Size(48, 13);
            this.BrojCipaLabel.TabIndex = 41;
            this.BrojCipaLabel.Text = "Broj čipa";
            // 
            // SpolLabel
            // 
            this.SpolLabel.AutoSize = true;
            this.SpolLabel.Location = new System.Drawing.Point(9, 183);
            this.SpolLabel.Name = "SpolLabel";
            this.SpolLabel.Size = new System.Drawing.Size(28, 13);
            this.SpolLabel.TabIndex = 42;
            this.SpolLabel.Text = "Spol";
            // 
            // BojaLabel
            // 
            this.BojaLabel.AutoSize = true;
            this.BojaLabel.Location = new System.Drawing.Point(9, 143);
            this.BojaLabel.Name = "BojaLabel";
            this.BojaLabel.Size = new System.Drawing.Size(28, 13);
            this.BojaLabel.TabIndex = 43;
            this.BojaLabel.Text = "Boja";
            // 
            // PasminaLabel
            // 
            this.PasminaLabel.AutoSize = true;
            this.PasminaLabel.Location = new System.Drawing.Point(158, 99);
            this.PasminaLabel.Name = "PasminaLabel";
            this.PasminaLabel.Size = new System.Drawing.Size(47, 13);
            this.PasminaLabel.TabIndex = 44;
            this.PasminaLabel.Text = "Pasmina";
            // 
            // VrstaLabel
            // 
            this.VrstaLabel.AutoSize = true;
            this.VrstaLabel.Location = new System.Drawing.Point(9, 98);
            this.VrstaLabel.Name = "VrstaLabel";
            this.VrstaLabel.Size = new System.Drawing.Size(31, 13);
            this.VrstaLabel.TabIndex = 45;
            this.VrstaLabel.Text = "Vrsta";
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(9, 11);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(24, 13);
            this.ImeLabel.TabIndex = 46;
            this.ImeLabel.Text = "Ime";
            // 
            // PolozajCipa
            // 
            this.PolozajCipa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "PolozajCipa", true));
            this.PolozajCipa.Location = new System.Drawing.Point(12, 331);
            this.PolozajCipa.Name = "PolozajCipa";
            this.PolozajCipa.Size = new System.Drawing.Size(216, 20);
            this.PolozajCipa.TabIndex = 48;
            // 
            // BrojCipa
            // 
            this.BrojCipa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "BrojCipa", true));
            this.BrojCipa.Location = new System.Drawing.Point(12, 289);
            this.BrojCipa.Name = "BrojCipa";
            this.BrojCipa.Size = new System.Drawing.Size(216, 20);
            this.BrojCipa.TabIndex = 47;
            // 
            // Boja
            // 
            this.Boja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "Boja", true));
            this.Boja.Location = new System.Drawing.Point(12, 159);
            this.Boja.Name = "Boja";
            this.Boja.Size = new System.Drawing.Size(293, 20);
            this.Boja.TabIndex = 35;
            // 
            // Ime
            // 
            this.Ime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "Ime", true));
            this.Ime.Location = new System.Drawing.Point(12, 27);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(293, 20);
            this.Ime.TabIndex = 34;
            // 
            // Vrsta
            // 
            this.Vrsta.FormattingEnabled = true;
            this.Vrsta.Location = new System.Drawing.Point(12, 115);
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.Size = new System.Drawing.Size(143, 21);
            this.Vrsta.TabIndex = 54;
            this.Vrsta.SelectedIndexChanged += new System.EventHandler(this.VrstaChanged);
            // 
            // vrstaZivotinjeBindingSource
            // 
            this.vrstaZivotinjeBindingSource.DataSource = typeof(VeterinarskaStanica.Model.VrstaZivotinje);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zivotinjaBindingSource, "Vlasnik", true));
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(293, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Vlasnik";
            // 
            // ZivotinjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 471);
            this.Controls.Add(this.Pasmina);
            this.Controls.Add(this.Vrsta);
            this.Controls.Add(this.DatumCipiranja);
            this.Controls.Add(this.DatumSmrti);
            this.Controls.Add(this.DatumRodenja);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SpremiPromjeneButton);
            this.Controls.Add(this.DatumCipiranjaLabel);
            this.Controls.Add(this.Spol);
            this.Controls.Add(this.DatumSmrtiLabel);
            this.Controls.Add(this.DatumRodjenjaLabel);
            this.Controls.Add(this.PolozajCipaLabel);
            this.Controls.Add(this.BrojCipaLabel);
            this.Controls.Add(this.SpolLabel);
            this.Controls.Add(this.BojaLabel);
            this.Controls.Add(this.PasminaLabel);
            this.Controls.Add(this.VrstaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImeLabel);
            this.Controls.Add(this.PolozajCipa);
            this.Controls.Add(this.BrojCipa);
            this.Controls.Add(this.Boja);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ime);
            this.Name = "ZivotinjaForm";
            this.Text = "Životinja";
            ((System.ComponentModel.ISupportInitialize)(this.zivotinjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaZivotinjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Pasmina;
        private System.Windows.Forms.DateTimePicker DatumCipiranja;
        private System.Windows.Forms.DateTimePicker DatumSmrti;
        private System.Windows.Forms.DateTimePicker DatumRodenja;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SpremiPromjeneButton;
        private System.Windows.Forms.Label DatumCipiranjaLabel;
        private System.Windows.Forms.ComboBox Spol;
        private System.Windows.Forms.Label DatumSmrtiLabel;
        private System.Windows.Forms.Label DatumRodjenjaLabel;
        private System.Windows.Forms.Label PolozajCipaLabel;
        private System.Windows.Forms.Label BrojCipaLabel;
        private System.Windows.Forms.Label SpolLabel;
        private System.Windows.Forms.Label BojaLabel;
        private System.Windows.Forms.Label PasminaLabel;
        private System.Windows.Forms.Label VrstaLabel;
        private System.Windows.Forms.Label ImeLabel;
        private System.Windows.Forms.TextBox PolozajCipa;
        private System.Windows.Forms.TextBox BrojCipa;
        private System.Windows.Forms.TextBox Boja;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.BindingSource zivotinjaBindingSource;
        private System.Windows.Forms.ComboBox Vrsta;
        private System.Windows.Forms.BindingSource vrstaZivotinjeBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}