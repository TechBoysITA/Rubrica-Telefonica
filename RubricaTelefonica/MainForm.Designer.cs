namespace RubricaTelefonica
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.numbersGridView = new System.Windows.Forms.DataGridView();
            this.TelephoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.aggiungiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rimuoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numbersGridView)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // numbersGridView
            // 
            this.numbersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numbersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numbersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numbersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TelephoneNumber,
            this.Name,
            this.Surname});
            this.numbersGridView.Location = new System.Drawing.Point(0, 24);
            this.numbersGridView.Name = "numbersGridView";
            this.numbersGridView.Size = new System.Drawing.Size(531, 309);
            this.numbersGridView.TabIndex = 0;
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.HeaderText = "Numero telefonico";
            this.TelephoneNumber.Name = "TelephoneNumber";
            this.TelephoneNumber.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Nome";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Cognome";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiToolStripMenuItem,
            this.rimuoviToolStripMenuItem,
            this.modificaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(531, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // aggiungiToolStripMenuItem
            // 
            this.aggiungiToolStripMenuItem.Name = "aggiungiToolStripMenuItem";
            this.aggiungiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aggiungiToolStripMenuItem.Text = "&Aggiungi";
            // 
            // rimuoviToolStripMenuItem
            // 
            this.rimuoviToolStripMenuItem.Name = "rimuoviToolStripMenuItem";
            this.rimuoviToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.rimuoviToolStripMenuItem.Text = "&Rimuovi";
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modificaToolStripMenuItem.Text = "&Modifica";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 332);
            this.Controls.Add(this.numbersGridView);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Text = "Rubrica telefonica";
            ((System.ComponentModel.ISupportInitialize)(this.numbersGridView)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView numbersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelephoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem aggiungiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rimuoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
    }
}

