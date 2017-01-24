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
            this.ZaposleniciList = new System.Windows.Forms.ListBox();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchZaposlenik = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.ZaposleniciTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Termini);
            this.TabControl.Controls.Add(this.ZaposleniciTab);
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
            // ZaposleniciList
            // 
            this.ZaposleniciList.DataSource = this.zaposlenikBindingSource;
            this.ZaposleniciList.DisplayMember = "ImePrezimeOib";
            this.ZaposleniciList.FormattingEnabled = true;
            this.ZaposleniciList.Location = new System.Drawing.Point(17, 75);
            this.ZaposleniciList.Name = "ZaposleniciList";
            this.ZaposleniciList.Size = new System.Drawing.Size(369, 589);
            this.ZaposleniciList.TabIndex = 0;
            this.ZaposleniciList.ValueMember = "Id";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(VeterinarskaStanica.Model.Zaposlenik);
            // 
            // SearchZaposlenik
            // 
            this.SearchZaposlenik.Location = new System.Drawing.Point(17, 32);
            this.SearchZaposlenik.Name = "SearchZaposlenik";
            this.SearchZaposlenik.Size = new System.Drawing.Size(144, 20);
            this.SearchZaposlenik.TabIndex = 1;
            this.SearchZaposlenik.TextChanged += new System.EventHandler(this.SearchZaposlenik_TextChanged);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Termini;
        private System.Windows.Forms.TabPage ZaposleniciTab;
        private System.Windows.Forms.ListBox ZaposleniciList;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.TextBox SearchZaposlenik;
    }
}