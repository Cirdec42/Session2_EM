namespace ApplicationParcometre
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
            this.components = new System.ComponentModel.Container();
            this.txtTempsRestant = new System.Windows.Forms.TextBox();
            this.lblTempsRestant = new System.Windows.Forms.Label();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemps = new System.Windows.Forms.ToolStripMenuItem();
            this.lentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moyenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panParcomètre = new System.Windows.Forms.Panel();
            this.lblCoutParMinutes = new System.Windows.Forms.Label();
            this.panMonnaie = new System.Windows.Forms.Panel();
            this.tmrTemps = new System.Windows.Forms.Timer(this.components);
            this.cboMontant = new System.Windows.Forms.ComboBox();
            this.lblNbCents = new System.Windows.Forms.Label();
            this.btnAjouterMontant = new System.Windows.Forms.Button();
            this.panÉtat = new System.Windows.Forms.Panel();
            this.txtMontantTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.panParcomètre.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTempsRestant
            // 
            this.txtTempsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempsRestant.Location = new System.Drawing.Point(46, 24);
            this.txtTempsRestant.Name = "txtTempsRestant";
            this.txtTempsRestant.ReadOnly = true;
            this.txtTempsRestant.Size = new System.Drawing.Size(132, 62);
            this.txtTempsRestant.TabIndex = 0;
            this.txtTempsRestant.Text = "00:00";
            this.txtTempsRestant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTempsRestant
            // 
            this.lblTempsRestant.Location = new System.Drawing.Point(43, 5);
            this.lblTempsRestant.Name = "lblTempsRestant";
            this.lblTempsRestant.Size = new System.Drawing.Size(135, 16);
            this.lblTempsRestant.TabIndex = 1;
            this.lblTempsRestant.Text = "Temps restant";
            this.lblTempsRestant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuTemps});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(334, 24);
            this.mnuPrincipal.TabIndex = 4;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuTemps
            // 
            this.mnuTemps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lentToolStripMenuItem,
            this.moyenToolStripMenuItem,
            this.rapideToolStripMenuItem});
            this.mnuTemps.Name = "mnuTemps";
            this.mnuTemps.Size = new System.Drawing.Size(54, 20);
            this.mnuTemps.Text = "&Temps";
            // 
            // lentToolStripMenuItem
            // 
            this.lentToolStripMenuItem.Name = "lentToolStripMenuItem";
            this.lentToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.lentToolStripMenuItem.Tag = "1000";
            this.lentToolStripMenuItem.Text = "Lent";
            this.lentToolStripMenuItem.Click += new System.EventHandler(this.mnuTemps_Click);
            // 
            // moyenToolStripMenuItem
            // 
            this.moyenToolStripMenuItem.Checked = true;
            this.moyenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moyenToolStripMenuItem.Name = "moyenToolStripMenuItem";
            this.moyenToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.moyenToolStripMenuItem.Tag = "250";
            this.moyenToolStripMenuItem.Text = "Moyen";
            this.moyenToolStripMenuItem.Click += new System.EventHandler(this.mnuTemps_Click);
            // 
            // rapideToolStripMenuItem
            // 
            this.rapideToolStripMenuItem.Name = "rapideToolStripMenuItem";
            this.rapideToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.rapideToolStripMenuItem.Tag = "50";
            this.rapideToolStripMenuItem.Text = "Rapide";
            this.rapideToolStripMenuItem.Click += new System.EventHandler(this.mnuTemps_Click);
            // 
            // panParcomètre
            // 
            this.panParcomètre.BackColor = System.Drawing.Color.Silver;
            this.panParcomètre.Controls.Add(this.lblCoutParMinutes);
            this.panParcomètre.Controls.Add(this.panMonnaie);
            this.panParcomètre.Controls.Add(this.txtTempsRestant);
            this.panParcomètre.Controls.Add(this.lblTempsRestant);
            this.panParcomètre.Location = new System.Drawing.Point(56, 70);
            this.panParcomètre.Name = "panParcomètre";
            this.panParcomètre.Size = new System.Drawing.Size(222, 184);
            this.panParcomètre.TabIndex = 5;
            // 
            // lblCoutParMinutes
            // 
            this.lblCoutParMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoutParMinutes.Location = new System.Drawing.Point(157, 165);
            this.lblCoutParMinutes.Name = "lblCoutParMinutes";
            this.lblCoutParMinutes.Size = new System.Drawing.Size(63, 17);
            this.lblCoutParMinutes.TabIndex = 3;
            this.lblCoutParMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panMonnaie
            // 
            this.panMonnaie.BackColor = System.Drawing.Color.Gray;
            this.panMonnaie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMonnaie.Location = new System.Drawing.Point(108, 99);
            this.panMonnaie.Name = "panMonnaie";
            this.panMonnaie.Size = new System.Drawing.Size(6, 73);
            this.panMonnaie.TabIndex = 2;
            // 
            // tmrTemps
            // 
            this.tmrTemps.Interval = 250;
            this.tmrTemps.Tick += new System.EventHandler(this.tmrTemps_Tick);
            // 
            // cboMontant
            // 
            this.cboMontant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMontant.FormattingEnabled = true;
            this.cboMontant.Items.AddRange(new object[] {
            "25",
            "100",
            "200",
            "500",
            "1000",
            "2000"});
            this.cboMontant.Location = new System.Drawing.Point(157, 273);
            this.cboMontant.Name = "cboMontant";
            this.cboMontant.Size = new System.Drawing.Size(121, 24);
            this.cboMontant.TabIndex = 3;
            // 
            // lblNbCents
            // 
            this.lblNbCents.AutoSize = true;
            this.lblNbCents.Location = new System.Drawing.Point(53, 278);
            this.lblNbCents.Name = "lblNbCents";
            this.lblNbCents.Size = new System.Drawing.Size(94, 13);
            this.lblNbCents.TabIndex = 6;
            this.lblNbCents.Text = "Nombre de cents :";
            // 
            // btnAjouterMontant
            // 
            this.btnAjouterMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterMontant.Location = new System.Drawing.Point(56, 306);
            this.btnAjouterMontant.Name = "btnAjouterMontant";
            this.btnAjouterMontant.Size = new System.Drawing.Size(222, 33);
            this.btnAjouterMontant.TabIndex = 7;
            this.btnAjouterMontant.Text = "Ajouter le montant";
            this.btnAjouterMontant.UseVisualStyleBackColor = true;
            this.btnAjouterMontant.Click += new System.EventHandler(this.btnAjouterMontant_Click);
            // 
            // panÉtat
            // 
            this.panÉtat.BackColor = System.Drawing.Color.Red;
            this.panÉtat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panÉtat.Location = new System.Drawing.Point(56, 48);
            this.panÉtat.Name = "panÉtat";
            this.panÉtat.Size = new System.Drawing.Size(222, 24);
            this.panÉtat.TabIndex = 8;
            // 
            // txtMontantTotal
            // 
            this.txtMontantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontantTotal.Location = new System.Drawing.Point(227, 345);
            this.txtMontantTotal.Name = "txtMontantTotal";
            this.txtMontantTotal.ReadOnly = true;
            this.txtMontantTotal.Size = new System.Drawing.Size(51, 22);
            this.txtMontantTotal.TabIndex = 3;
            this.txtMontantTotal.Text = "0";
            this.txtMontantTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Montant total dans le parcomètre :";
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnAjouterMontant;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(334, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontantTotal);
            this.Controls.Add(this.panÉtat);
            this.Controls.Add(this.btnAjouterMontant);
            this.Controls.Add(this.lblNbCents);
            this.Controls.Add(this.cboMontant);
            this.Controls.Add(this.panParcomètre);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcomètre ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.panParcomètre.ResumeLayout(false);
            this.panParcomètre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox txtTempsRestant;
        private System.Windows.Forms.Label lblTempsRestant;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.Panel panParcomètre;
        private System.Windows.Forms.Panel panMonnaie;
        private System.Windows.Forms.Timer tmrTemps;
        private System.Windows.Forms.ComboBox cboMontant;
        private System.Windows.Forms.Label lblNbCents;
        private System.Windows.Forms.Button btnAjouterMontant;
        private System.Windows.Forms.Panel panÉtat;
        private System.Windows.Forms.ToolStripMenuItem mnuTemps;
        private System.Windows.Forms.ToolStripMenuItem lentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moyenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapideToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMontantTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCoutParMinutes;

    }
}

