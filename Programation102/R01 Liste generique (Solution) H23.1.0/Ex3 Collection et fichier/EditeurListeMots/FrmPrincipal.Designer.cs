namespace EditeurListeMots
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierViderListeDeMots = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierChargerListeDeMots = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierEnregistrerListeDeMots = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSupprimerMot = new System.Windows.Forms.Button();
            this.txtNouveauMot = new System.Windows.Forms.TextBox();
            this.btnAjouterMot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotCourant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numIndexMotCourant = new System.Windows.Forms.NumericUpDown();
            this.btnPrécédent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndexMotCourant)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierViderListeDeMots,
            this.mnuFichierChargerListeDeMots,
            this.mnuFichierEnregistrerListeDeMots,
            this.mnuFichierSep1,
            this.toolStripMenuItem2});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(66, 24);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierViderListeDeMots
            // 
            this.mnuFichierViderListeDeMots.Name = "mnuFichierViderListeDeMots";
            this.mnuFichierViderListeDeMots.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierViderListeDeMots.Size = new System.Drawing.Size(302, 26);
            this.mnuFichierViderListeDeMots.Text = "&Vider la liste de mots";
            this.mnuFichierViderListeDeMots.Click += new System.EventHandler(this.mnuFichierViderListeDeMots_Click);
            // 
            // mnuFichierChargerListeDeMots
            // 
            this.mnuFichierChargerListeDeMots.Name = "mnuFichierChargerListeDeMots";
            this.mnuFichierChargerListeDeMots.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFichierChargerListeDeMots.Size = new System.Drawing.Size(302, 26);
            this.mnuFichierChargerListeDeMots.Text = "&Charger liste de mots";
            this.mnuFichierChargerListeDeMots.Click += new System.EventHandler(this.mnuFichierChargerListeDeMots_Click);
            // 
            // mnuFichierEnregistrerListeDeMots
            // 
            this.mnuFichierEnregistrerListeDeMots.Name = "mnuFichierEnregistrerListeDeMots";
            this.mnuFichierEnregistrerListeDeMots.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFichierEnregistrerListeDeMots.Size = new System.Drawing.Size(302, 26);
            this.mnuFichierEnregistrerListeDeMots.Text = "&Enregistrer liste de mots";
            this.mnuFichierEnregistrerListeDeMots.Click += new System.EventHandler(this.mnuFichierEnregistrerListeDeMots_Click);
            // 
            // mnuFichierSep1
            // 
            this.mnuFichierSep1.Name = "mnuFichierSep1";
            this.mnuFichierSep1.Size = new System.Drawing.Size(299, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(302, 26);
            this.toolStripMenuItem2.Text = "&Quitter";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // btnSupprimerMot
            // 
            this.btnSupprimerMot.Enabled = false;
            this.btnSupprimerMot.Location = new System.Drawing.Point(136, 235);
            this.btnSupprimerMot.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerMot.Name = "btnSupprimerMot";
            this.btnSupprimerMot.Size = new System.Drawing.Size(292, 28);
            this.btnSupprimerMot.TabIndex = 14;
            this.btnSupprimerMot.Text = "&Supprimer mot courant";
            this.btnSupprimerMot.UseVisualStyleBackColor = true;
            this.btnSupprimerMot.Click += new System.EventHandler(this.btnSupprimerMot_Click);
            // 
            // txtNouveauMot
            // 
            this.txtNouveauMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouveauMot.Location = new System.Drawing.Point(136, 308);
            this.txtNouveauMot.Margin = new System.Windows.Forms.Padding(4);
            this.txtNouveauMot.Name = "txtNouveauMot";
            this.txtNouveauMot.Size = new System.Drawing.Size(291, 37);
            this.txtNouveauMot.TabIndex = 13;
            // 
            // btnAjouterMot
            // 
            this.btnAjouterMot.Location = new System.Drawing.Point(136, 272);
            this.btnAjouterMot.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterMot.Name = "btnAjouterMot";
            this.btnAjouterMot.Size = new System.Drawing.Size(292, 28);
            this.btnAjouterMot.TabIndex = 12;
            this.btnAjouterMot.Text = "&Ajouter un nouveau mot";
            this.btnAjouterMot.UseVisualStyleBackColor = true;
            this.btnAjouterMot.Click += new System.EventHandler(this.btnAjouterMot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotCourant);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numIndexMotCourant);
            this.groupBox1.Controls.Add(this.btnPrécédent);
            this.groupBox1.Controls.Add(this.btnSuivant);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(496, 155);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtMotCourant
            // 
            this.txtMotCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotCourant.Location = new System.Drawing.Point(13, 37);
            this.txtMotCourant.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotCourant.Name = "txtMotCourant";
            this.txtMotCourant.ReadOnly = true;
            this.txtMotCourant.Size = new System.Drawing.Size(469, 37);
            this.txtMotCourant.TabIndex = 12;
            this.txtMotCourant.TabStop = false;
            this.txtMotCourant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Index courant";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numIndexMotCourant
            // 
            this.numIndexMotCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIndexMotCourant.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numIndexMotCourant.Location = new System.Drawing.Point(189, 103);
            this.numIndexMotCourant.Margin = new System.Windows.Forms.Padding(4);
            this.numIndexMotCourant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numIndexMotCourant.Name = "numIndexMotCourant";
            this.numIndexMotCourant.ReadOnly = true;
            this.numIndexMotCourant.Size = new System.Drawing.Size(119, 30);
            this.numIndexMotCourant.TabIndex = 15;
            this.numIndexMotCourant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numIndexMotCourant.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numIndexMotCourant.ValueChanged += new System.EventHandler(this.numIndexMotCourant_ValueChanged);
            // 
            // btnPrécédent
            // 
            this.btnPrécédent.Location = new System.Drawing.Point(13, 101);
            this.btnPrécédent.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrécédent.Name = "btnPrécédent";
            this.btnPrécédent.Size = new System.Drawing.Size(127, 34);
            this.btnPrécédent.TabIndex = 14;
            this.btnPrécédent.Text = "Précédent";
            this.btnPrécédent.UseVisualStyleBackColor = true;
            this.btnPrécédent.Click += new System.EventHandler(this.btnPrécédent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(360, 100);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(124, 34);
            this.btnSuivant.TabIndex = 12;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mot courant de la liste";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSupprimerMot);
            this.Controls.Add(this.txtNouveauMot);
            this.Controls.Add(this.btnAjouterMot);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste de chaînes et fichier ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndexMotCourant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierViderListeDeMots;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierChargerListeDeMots;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierEnregistrerListeDeMots;
        private System.Windows.Forms.ToolStripSeparator mnuFichierSep1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnSupprimerMot;
        private System.Windows.Forms.TextBox txtNouveauMot;
        private System.Windows.Forms.Button btnAjouterMot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMotCourant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numIndexMotCourant;
        private System.Windows.Forms.Button btnPrécédent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Label label1;
    }
}

