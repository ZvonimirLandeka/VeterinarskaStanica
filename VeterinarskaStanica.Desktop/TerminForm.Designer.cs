namespace VeterinarskaStanica.Desktop
{
    partial class TerminForm
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
            this.Vrsta = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SpremiPromjeneButton = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.ComboBox();
            this.DatumRodjenjaLabel = new System.Windows.Forms.Label();
            this.PolozajCipaLabel = new System.Windows.Forms.Label();
            this.BrojCipaLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.BojaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasminaLabel = new System.Windows.Forms.Label();
            this.VrstaLabel = new System.Windows.Forms.Label();
            this.Iskaz = new System.Windows.Forms.TextBox();
            this.Zaposlenik = new System.Windows.Forms.TextBox();
            this.Zivotinja = new System.Windows.Forms.TextBox();
            this.Opis = new System.Windows.Forms.TextBox();
            this.Napomena = new System.Windows.Forms.TextBox();
            this.terminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Vrijeme = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.terminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Vrsta
            // 
            this.Vrsta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.terminBindingSource, "VrstaTermina", true));
            this.Vrsta.DisplayMember = "Naziv";
            this.Vrsta.FormattingEnabled = true;
            this.Vrsta.Location = new System.Drawing.Point(165, 26);
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.Size = new System.Drawing.Size(159, 21);
            this.Vrsta.TabIndex = 72;
            this.Vrsta.ValueMember = "Id";
            // 
            // Datum
            // 
            this.Datum.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.terminBindingSource, "Datum", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.Datum.Location = new System.Drawing.Point(12, 153);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(133, 20);
            this.Datum.TabIndex = 71;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(249, 573);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 70;
            this.CancelButton.Text = "Odustani";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Odustani);
            // 
            // SpremiPromjeneButton
            // 
            this.SpremiPromjeneButton.Location = new System.Drawing.Point(13, 573);
            this.SpremiPromjeneButton.Name = "SpremiPromjeneButton";
            this.SpremiPromjeneButton.Size = new System.Drawing.Size(121, 23);
            this.SpremiPromjeneButton.TabIndex = 69;
            this.SpremiPromjeneButton.Text = "Spremi promjene";
            this.SpremiPromjeneButton.UseVisualStyleBackColor = true;
            this.SpremiPromjeneButton.Click += new System.EventHandler(this.Spremi);
            // 
            // Status
            // 
            this.Status.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.terminBindingSource, "Status", true));
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(13, 26);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(144, 21);
            this.Status.TabIndex = 56;
            // 
            // DatumRodjenjaLabel
            // 
            this.DatumRodjenjaLabel.AutoSize = true;
            this.DatumRodjenjaLabel.Location = new System.Drawing.Point(12, 137);
            this.DatumRodjenjaLabel.Name = "DatumRodjenjaLabel";
            this.DatumRodjenjaLabel.Size = new System.Drawing.Size(38, 13);
            this.DatumRodjenjaLabel.TabIndex = 57;
            this.DatumRodjenjaLabel.Text = "Datum";
            // 
            // PolozajCipaLabel
            // 
            this.PolozajCipaLabel.AutoSize = true;
            this.PolozajCipaLabel.Location = new System.Drawing.Point(9, 309);
            this.PolozajCipaLabel.Name = "PolozajCipaLabel";
            this.PolozajCipaLabel.Size = new System.Drawing.Size(32, 13);
            this.PolozajCipaLabel.TabIndex = 58;
            this.PolozajCipaLabel.Text = "Iskaz";
            // 
            // BrojCipaLabel
            // 
            this.BrojCipaLabel.AutoSize = true;
            this.BrojCipaLabel.Location = new System.Drawing.Point(10, 187);
            this.BrojCipaLabel.Name = "BrojCipaLabel";
            this.BrojCipaLabel.Size = new System.Drawing.Size(28, 13);
            this.BrojCipaLabel.TabIndex = 59;
            this.BrojCipaLabel.Text = "Opis";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(10, 10);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 60;
            this.StatusLabel.Text = "Status";
            // 
            // BojaLabel
            // 
            this.BojaLabel.AutoSize = true;
            this.BojaLabel.Location = new System.Drawing.Point(12, 425);
            this.BojaLabel.Name = "BojaLabel";
            this.BojaLabel.Size = new System.Drawing.Size(59, 13);
            this.BojaLabel.TabIndex = 61;
            this.BojaLabel.Text = "Napomena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Životinja";
            // 
            // PasminaLabel
            // 
            this.PasminaLabel.AutoSize = true;
            this.PasminaLabel.Location = new System.Drawing.Point(9, 91);
            this.PasminaLabel.Name = "PasminaLabel";
            this.PasminaLabel.Size = new System.Drawing.Size(59, 13);
            this.PasminaLabel.TabIndex = 62;
            this.PasminaLabel.Text = "Zaposlenik";
            // 
            // VrstaLabel
            // 
            this.VrstaLabel.AutoSize = true;
            this.VrstaLabel.Location = new System.Drawing.Point(162, 10);
            this.VrstaLabel.Name = "VrstaLabel";
            this.VrstaLabel.Size = new System.Drawing.Size(31, 13);
            this.VrstaLabel.TabIndex = 64;
            this.VrstaLabel.Text = "Vrsta";
            // 
            // Iskaz
            // 
            this.Iskaz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terminBindingSource, "Iskaz", true));
            this.Iskaz.Location = new System.Drawing.Point(12, 325);
            this.Iskaz.Multiline = true;
            this.Iskaz.Name = "Iskaz";
            this.Iskaz.Size = new System.Drawing.Size(312, 97);
            this.Iskaz.TabIndex = 68;
            // 
            // Zaposlenik
            // 
            this.Zaposlenik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terminBindingSource, "Zaposlenik", true));
            this.Zaposlenik.Location = new System.Drawing.Point(12, 107);
            this.Zaposlenik.Name = "Zaposlenik";
            this.Zaposlenik.ReadOnly = true;
            this.Zaposlenik.Size = new System.Drawing.Size(312, 20);
            this.Zaposlenik.TabIndex = 66;
            // 
            // Zivotinja
            // 
            this.Zivotinja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terminBindingSource, "Zivotinja", true));
            this.Zivotinja.Location = new System.Drawing.Point(13, 66);
            this.Zivotinja.Name = "Zivotinja";
            this.Zivotinja.ReadOnly = true;
            this.Zivotinja.Size = new System.Drawing.Size(311, 20);
            this.Zivotinja.TabIndex = 67;
            // 
            // Opis
            // 
            this.Opis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terminBindingSource, "Opis", true));
            this.Opis.Location = new System.Drawing.Point(13, 203);
            this.Opis.Multiline = true;
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(311, 103);
            this.Opis.TabIndex = 65;
            // 
            // Napomena
            // 
            this.Napomena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terminBindingSource, "Napomena", true));
            this.Napomena.Location = new System.Drawing.Point(15, 441);
            this.Napomena.Multiline = true;
            this.Napomena.Name = "Napomena";
            this.Napomena.Size = new System.Drawing.Size(309, 60);
            this.Napomena.TabIndex = 55;
            // 
            // terminBindingSource
            // 
            this.terminBindingSource.DataSource = typeof(VeterinarskaStanica.Model.Termin);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Vrijeme";
            // 
            // Vrijeme
            // 
            this.Vrijeme.CustomFormat = "";
            this.Vrijeme.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.terminBindingSource, "Datum", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "t"));
            this.Vrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Vrijeme.Location = new System.Drawing.Point(165, 153);
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.ShowUpDown = true;
            this.Vrijeme.Size = new System.Drawing.Size(133, 20);
            this.Vrijeme.TabIndex = 71;
            // 
            // TerminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 608);
            this.Controls.Add(this.Vrsta);
            this.Controls.Add(this.Vrijeme);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SpremiPromjeneButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.DatumRodjenjaLabel);
            this.Controls.Add(this.PolozajCipaLabel);
            this.Controls.Add(this.BrojCipaLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.BojaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasminaLabel);
            this.Controls.Add(this.VrstaLabel);
            this.Controls.Add(this.Iskaz);
            this.Controls.Add(this.Zaposlenik);
            this.Controls.Add(this.Zivotinja);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.Napomena);
            this.Name = "TerminForm";
            this.Text = "TerminForm";
            ((System.ComponentModel.ISupportInitialize)(this.terminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Vrsta;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SpremiPromjeneButton;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label DatumRodjenjaLabel;
        private System.Windows.Forms.Label PolozajCipaLabel;
        private System.Windows.Forms.Label BrojCipaLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label BojaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PasminaLabel;
        private System.Windows.Forms.Label VrstaLabel;
        private System.Windows.Forms.TextBox Iskaz;
        private System.Windows.Forms.TextBox Zaposlenik;
        private System.Windows.Forms.TextBox Zivotinja;
        private System.Windows.Forms.TextBox Opis;
        private System.Windows.Forms.TextBox Napomena;
        private System.Windows.Forms.BindingSource terminBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Vrijeme;
    }
}