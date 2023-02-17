namespace ExemFormulaire
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialExemple1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpécialExemple2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cboInstruments = new System.Windows.Forms.ComboBox();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulaire principal de l\'application. Utiliser le menu Spécial pour afficher d\'a" +
    "utres formulaires";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuSpécial});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(452, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuSpécial
            // 
            this.mnuSpécial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpécialExemple1,
            this.mnuSpécialExemple2});
            this.mnuSpécial.Name = "mnuSpécial";
            this.mnuSpécial.Size = new System.Drawing.Size(56, 20);
            this.mnuSpécial.Text = "&Spécial";
            // 
            // mnuSpécialExemple1
            // 
            this.mnuSpécialExemple1.Name = "mnuSpécialExemple1";
            this.mnuSpécialExemple1.Size = new System.Drawing.Size(284, 22);
            this.mnuSpécialExemple1.Text = "Afficher un autre formulaire exemple #1";
            this.mnuSpécialExemple1.Click += new System.EventHandler(this.mnuSpécialExemple1_Click);
            // 
            // mnuSpécialExemple2
            // 
            this.mnuSpécialExemple2.Name = "mnuSpécialExemple2";
            this.mnuSpécialExemple2.Size = new System.Drawing.Size(284, 22);
            this.mnuSpécialExemple2.Text = "Afficher un autre formulaire exemple #2";
            this.mnuSpécialExemple2.Click += new System.EventHandler(this.mnuSpécialExemple2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choisir un instrument pour l\'exemple #2 :";
            // 
            // cboInstruments
            // 
            this.cboInstruments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstruments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInstruments.FormattingEnabled = true;
            this.cboInstruments.Items.AddRange(new object[] {
            "Bass",
            "Guitar",
            "Piano",
            "Saxophone",
            "Xylophone"});
            this.cboInstruments.Location = new System.Drawing.Point(15, 159);
            this.cboInstruments.Name = "cboInstruments";
            this.cboInstruments.Size = new System.Drawing.Size(425, 33);
            this.cboInstruments.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 214);
            this.Controls.Add(this.cboInstruments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autres formulaires ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécial;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialExemple1;
        private System.Windows.Forms.ToolStripMenuItem mnuSpécialExemple2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboInstruments;
    }
}

