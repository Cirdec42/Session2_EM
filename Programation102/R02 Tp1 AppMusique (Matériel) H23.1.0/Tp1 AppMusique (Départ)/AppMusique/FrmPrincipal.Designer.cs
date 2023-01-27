namespace AppDeMusique
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierRecharger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierSeparateur = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierSpécial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpérationMélanger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpérationSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpérationMeilleursMorceaux = new System.Windows.Forms.ToolStripMenuItem();
            this.lblArtiste = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.lblMorceau = new System.Windows.Forms.Label();
            this.lblArtisteCourant = new System.Windows.Forms.Label();
            this.lblAlbumCourant = new System.Windows.Forms.Label();
            this.lblTitreCourant = new System.Windows.Forms.Label();
            this.lblDuréeCourante = new System.Windows.Forms.Label();
            this.lblMorceauCourant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCote = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstMorceaux = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuFichierSpécial});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(357, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierRecharger,
            this.mnuFichierSeparateur,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Tag = "H15PC";
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierRecharger
            // 
            this.mnuFichierRecharger.Name = "mnuFichierRecharger";
            this.mnuFichierRecharger.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuFichierRecharger.Size = new System.Drawing.Size(250, 22);
            this.mnuFichierRecharger.Text = "Recharger la bibliothèque";
            this.mnuFichierRecharger.Click += new System.EventHandler(this.mnuFichierRecharger_Click);
            // 
            // mnuFichierSeparateur
            // 
            this.mnuFichierSeparateur.Name = "mnuFichierSeparateur";
            this.mnuFichierSeparateur.Size = new System.Drawing.Size(247, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(250, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuFichierSpécial
            // 
            this.mnuFichierSpécial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpérationMélanger,
            this.mnuOpérationSupprimer,
            this.mnuOpérationMeilleursMorceaux});
            this.mnuFichierSpécial.Name = "mnuFichierSpécial";
            this.mnuFichierSpécial.Size = new System.Drawing.Size(56, 20);
            this.mnuFichierSpécial.Text = "Spécial";
            // 
            // mnuOpérationMélanger
            // 
            this.mnuOpérationMélanger.Name = "mnuOpérationMélanger";
            this.mnuOpérationMélanger.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuOpérationMélanger.Size = new System.Drawing.Size(276, 22);
            this.mnuOpérationMélanger.Text = "&Mélanger les morceaux";
            this.mnuOpérationMélanger.Click += new System.EventHandler(this.mnuOpérationMélanger_Click);
            // 
            // mnuOpérationSupprimer
            // 
            this.mnuOpérationSupprimer.Name = "mnuOpérationSupprimer";
            this.mnuOpérationSupprimer.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuOpérationSupprimer.Size = new System.Drawing.Size(276, 22);
            this.mnuOpérationSupprimer.Text = "Supprimer ce morceau";
            this.mnuOpérationSupprimer.Click += new System.EventHandler(this.mnuOpérationSupprimer_Click);
            // 
            // mnuOpérationMeilleursMorceaux
            // 
            this.mnuOpérationMeilleursMorceaux.Name = "mnuOpérationMeilleursMorceaux";
            this.mnuOpérationMeilleursMorceaux.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuOpérationMeilleursMorceaux.Size = new System.Drawing.Size(276, 22);
            this.mnuOpérationMeilleursMorceaux.Text = "&Conserver meilleurs morceaux";
            this.mnuOpérationMeilleursMorceaux.Click += new System.EventHandler(this.mnuOpérationMeilleursMorceaux_Click);
            // 
            // lblArtiste
            // 
            this.lblArtiste.BackColor = System.Drawing.Color.Transparent;
            this.lblArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtiste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblArtiste.Location = new System.Drawing.Point(24, 102);
            this.lblArtiste.Name = "lblArtiste";
            this.lblArtiste.Size = new System.Drawing.Size(59, 22);
            this.lblArtiste.TabIndex = 0;
            this.lblArtiste.Text = "&Artiste :";
            // 
            // lblAlbum
            // 
            this.lblAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblAlbum.Location = new System.Drawing.Point(24, 148);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(59, 20);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Al&bum :";
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTitre.Location = new System.Drawing.Point(24, 193);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(59, 20);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "&Titre :";
            // 
            // lblDuree
            // 
            this.lblDuree.BackColor = System.Drawing.Color.Transparent;
            this.lblDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblDuree.Location = new System.Drawing.Point(24, 237);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(59, 20);
            this.lblDuree.TabIndex = 6;
            this.lblDuree.Text = "&Durée :";
            // 
            // picAlbum
            // 
            this.picAlbum.Location = new System.Drawing.Point(8, 8);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(120, 120);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlbum.TabIndex = 5;
            this.picAlbum.TabStop = false;
            // 
            // lblMorceau
            // 
            this.lblMorceau.BackColor = System.Drawing.Color.Transparent;
            this.lblMorceau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorceau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblMorceau.Location = new System.Drawing.Point(24, 326);
            this.lblMorceau.Name = "lblMorceau";
            this.lblMorceau.Size = new System.Drawing.Size(70, 15);
            this.lblMorceau.TabIndex = 8;
            this.lblMorceau.Text = "&Morceau :";
            // 
            // lblArtisteCourant
            // 
            this.lblArtisteCourant.BackColor = System.Drawing.Color.Black;
            this.lblArtisteCourant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArtisteCourant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteCourant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblArtisteCourant.Location = new System.Drawing.Point(89, 99);
            this.lblArtisteCourant.Name = "lblArtisteCourant";
            this.lblArtisteCourant.Size = new System.Drawing.Size(240, 25);
            this.lblArtisteCourant.TabIndex = 6;
            this.lblArtisteCourant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArtisteCourant.Click += new System.EventHandler(this.lblArtisteCourant_Click);
            // 
            // lblAlbumCourant
            // 
            this.lblAlbumCourant.BackColor = System.Drawing.Color.Black;
            this.lblAlbumCourant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlbumCourant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumCourant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAlbumCourant.Location = new System.Drawing.Point(89, 143);
            this.lblAlbumCourant.Name = "lblAlbumCourant";
            this.lblAlbumCourant.Size = new System.Drawing.Size(240, 25);
            this.lblAlbumCourant.TabIndex = 11;
            this.lblAlbumCourant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitreCourant
            // 
            this.lblTitreCourant.BackColor = System.Drawing.Color.Black;
            this.lblTitreCourant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitreCourant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCourant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitreCourant.Location = new System.Drawing.Point(89, 188);
            this.lblTitreCourant.Name = "lblTitreCourant";
            this.lblTitreCourant.Size = new System.Drawing.Size(240, 25);
            this.lblTitreCourant.TabIndex = 12;
            this.lblTitreCourant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDuréeCourante
            // 
            this.lblDuréeCourante.BackColor = System.Drawing.Color.Black;
            this.lblDuréeCourante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDuréeCourante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuréeCourante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDuréeCourante.Location = new System.Drawing.Point(89, 232);
            this.lblDuréeCourante.Name = "lblDuréeCourante";
            this.lblDuréeCourante.Size = new System.Drawing.Size(58, 25);
            this.lblDuréeCourante.TabIndex = 13;
            this.lblDuréeCourante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMorceauCourant
            // 
            this.lblMorceauCourant.BackColor = System.Drawing.Color.Black;
            this.lblMorceauCourant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMorceauCourant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorceauCourant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMorceauCourant.Location = new System.Drawing.Point(89, 320);
            this.lblMorceauCourant.Name = "lblMorceauCourant";
            this.lblMorceauCourant.Size = new System.Drawing.Size(58, 25);
            this.lblMorceauCourant.TabIndex = 14;
            this.lblMorceauCourant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(24, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "&Cote :";
            // 
            // lblCote
            // 
            this.lblCote.BackColor = System.Drawing.Color.Black;
            this.lblCote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCote.Location = new System.Drawing.Point(89, 276);
            this.lblCote.Name = "lblCote";
            this.lblCote.Size = new System.Drawing.Size(58, 25);
            this.lblCote.TabIndex = 16;
            this.lblCote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.picAlbum);
            this.panel1.Location = new System.Drawing.Point(180, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 135);
            this.panel1.TabIndex = 10;
            // 
            // lstMorceaux
            // 
            this.lstMorceaux.BackColor = System.Drawing.Color.Black;
            this.lstMorceaux.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMorceaux.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstMorceaux.FormattingEnabled = true;
            this.lstMorceaux.ItemHeight = 19;
            this.lstMorceaux.Location = new System.Drawing.Point(27, 395);
            this.lstMorceaux.Name = "lstMorceaux";
            this.lstMorceaux.Size = new System.Drawing.Size(302, 213);
            this.lstMorceaux.TabIndex = 17;
            this.lstMorceaux.SelectedIndexChanged += new System.EventHandler(this.LstMorceaux_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(24, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "&Liste de lecture :";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AppMusique.Properties.Resources.SmartPhoneN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(357, 660);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstMorceaux);
            this.Controls.Add(this.lblCote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMorceauCourant);
            this.Controls.Add(this.lblDuréeCourante);
            this.Controls.Add(this.lblTitreCourant);
            this.Controls.Add(this.lblAlbumCourant);
            this.Controls.Add(this.lblArtisteCourant);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMorceau);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblArtiste);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App de musique  ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuOpérationMeilleursMorceaux;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Label lblArtiste;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.PictureBox picAlbum;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierSpécial;
        private System.Windows.Forms.Label lblMorceau;
        private System.Windows.Forms.Label lblArtisteCourant;
        private System.Windows.Forms.Label lblAlbumCourant;
        private System.Windows.Forms.Label lblTitreCourant;
        private System.Windows.Forms.Label lblDuréeCourante;
        private System.Windows.Forms.Label lblMorceauCourant;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierRecharger;
        private System.Windows.Forms.ToolStripSeparator mnuFichierSeparateur;
        private System.Windows.Forms.ToolStripMenuItem mnuOpérationMélanger;
        private System.Windows.Forms.ToolStripMenuItem mnuOpérationSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstMorceaux;
        private System.Windows.Forms.Label label2;
    }
}

