namespace ApplicationDistributrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.picDistributrice = new System.Windows.Forms.PictureBox();
            this.grpBreuvage = new System.Windows.Forms.GroupBox();
            this.btnObtenirUnTheGlace = new System.Windows.Forms.Button();
            this.btnObtenirUnJusDePommes = new System.Windows.Forms.Button();
            this.btnObtenirUn7Up = new System.Windows.Forms.Button();
            this.btnObtenirUnCoke = new System.Windows.Forms.Button();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.grpInfosMachine = new System.Windows.Forms.GroupBox();
            this.txtEtat = new System.Windows.Forms.TextBox();
            this.txtNbTheGlace = new System.Windows.Forms.TextBox();
            this.lblTheGlace = new System.Windows.Forms.Label();
            this.txtNbJusDePommes = new System.Windows.Forms.TextBox();
            this.lblJusPomme = new System.Windows.Forms.Label();
            this.txtNb7Up = new System.Windows.Forms.TextBox();
            this.lbl7Up = new System.Windows.Forms.Label();
            this.txtNbCokes = new System.Windows.Forms.TextBox();
            this.lblCokes = new System.Windows.Forms.Label();
            this.btnRecharger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDistributrice)).BeginInit();
            this.grpBreuvage.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.grpInfosMachine.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDistributrice
            // 
            this.picDistributrice.ErrorImage = global::ApplicationDistributrice.Properties.Resources.imageDistributrice;
            this.picDistributrice.Image = ((System.Drawing.Image)(resources.GetObject("picDistributrice.Image")));
            this.picDistributrice.Location = new System.Drawing.Point(12, 40);
            this.picDistributrice.Name = "picDistributrice";
            this.picDistributrice.Size = new System.Drawing.Size(184, 272);
            this.picDistributrice.TabIndex = 2;
            this.picDistributrice.TabStop = false;
            // 
            // grpBreuvage
            // 
            this.grpBreuvage.Controls.Add(this.btnObtenirUnTheGlace);
            this.grpBreuvage.Controls.Add(this.btnObtenirUnJusDePommes);
            this.grpBreuvage.Controls.Add(this.btnObtenirUn7Up);
            this.grpBreuvage.Controls.Add(this.btnObtenirUnCoke);
            this.grpBreuvage.Location = new System.Drawing.Point(208, 36);
            this.grpBreuvage.Name = "grpBreuvage";
            this.grpBreuvage.Size = new System.Drawing.Size(232, 160);
            this.grpBreuvage.TabIndex = 0;
            this.grpBreuvage.TabStop = false;
            this.grpBreuvage.Text = "Breuvage";
            // 
            // btnObtenirUnTheGlace
            // 
            this.btnObtenirUnTheGlace.Location = new System.Drawing.Point(16, 120);
            this.btnObtenirUnTheGlace.Name = "btnObtenirUnTheGlace";
            this.btnObtenirUnTheGlace.Size = new System.Drawing.Size(200, 24);
            this.btnObtenirUnTheGlace.TabIndex = 3;
            this.btnObtenirUnTheGlace.Text = "Obtenir un thé glacé";
            this.btnObtenirUnTheGlace.Click += new System.EventHandler(this.btnObtenirUnTheGlace_Click);
            // 
            // btnObtenirUnJusDePommes
            // 
            this.btnObtenirUnJusDePommes.Location = new System.Drawing.Point(16, 88);
            this.btnObtenirUnJusDePommes.Name = "btnObtenirUnJusDePommes";
            this.btnObtenirUnJusDePommes.Size = new System.Drawing.Size(200, 24);
            this.btnObtenirUnJusDePommes.TabIndex = 2;
            this.btnObtenirUnJusDePommes.Text = "Obtenir un jus de pomme";
            this.btnObtenirUnJusDePommes.Click += new System.EventHandler(this.btnObtenirUnJusDePommes_Click);
            // 
            // btnObtenirUn7Up
            // 
            this.btnObtenirUn7Up.Location = new System.Drawing.Point(16, 56);
            this.btnObtenirUn7Up.Name = "btnObtenirUn7Up";
            this.btnObtenirUn7Up.Size = new System.Drawing.Size(200, 24);
            this.btnObtenirUn7Up.TabIndex = 1;
            this.btnObtenirUn7Up.Text = "Obtenir un 7up";
            this.btnObtenirUn7Up.Click += new System.EventHandler(this.btnObtenirUn7Up_Click);
            // 
            // btnObtenirUnCoke
            // 
            this.btnObtenirUnCoke.Location = new System.Drawing.Point(16, 24);
            this.btnObtenirUnCoke.Name = "btnObtenirUnCoke";
            this.btnObtenirUnCoke.Size = new System.Drawing.Size(200, 24);
            this.btnObtenirUnCoke.TabIndex = 0;
            this.btnObtenirUnCoke.Text = "Obtenir un Coke";
            this.btnObtenirUnCoke.Click += new System.EventHandler(this.btnObtenirUnCoke_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(450, 24);
            this.mnuPrincipal.TabIndex = 3;
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
            this.mnuFichierQuitter.Text = "Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // grpInfosMachine
            // 
            this.grpInfosMachine.Controls.Add(this.txtEtat);
            this.grpInfosMachine.Controls.Add(this.txtNbTheGlace);
            this.grpInfosMachine.Controls.Add(this.lblTheGlace);
            this.grpInfosMachine.Controls.Add(this.txtNbJusDePommes);
            this.grpInfosMachine.Controls.Add(this.lblJusPomme);
            this.grpInfosMachine.Controls.Add(this.txtNb7Up);
            this.grpInfosMachine.Controls.Add(this.lbl7Up);
            this.grpInfosMachine.Controls.Add(this.txtNbCokes);
            this.grpInfosMachine.Controls.Add(this.lblCokes);
            this.grpInfosMachine.Location = new System.Drawing.Point(207, 202);
            this.grpInfosMachine.Name = "grpInfosMachine";
            this.grpInfosMachine.Size = new System.Drawing.Size(232, 150);
            this.grpInfosMachine.TabIndex = 4;
            this.grpInfosMachine.TabStop = false;
            this.grpInfosMachine.Text = "Infos sur la machine";
            // 
            // txtEtat
            // 
            this.txtEtat.Location = new System.Drawing.Point(47, 119);
            this.txtEtat.Name = "txtEtat";
            this.txtEtat.ReadOnly = true;
            this.txtEtat.Size = new System.Drawing.Size(156, 20);
            this.txtEtat.TabIndex = 17;
            // 
            // txtNbTheGlace
            // 
            this.txtNbTheGlace.Location = new System.Drawing.Point(147, 89);
            this.txtNbTheGlace.Name = "txtNbTheGlace";
            this.txtNbTheGlace.ReadOnly = true;
            this.txtNbTheGlace.Size = new System.Drawing.Size(56, 20);
            this.txtNbTheGlace.TabIndex = 16;
            this.txtNbTheGlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTheGlace
            // 
            this.lblTheGlace.Location = new System.Drawing.Point(45, 87);
            this.lblTheGlace.Name = "lblTheGlace";
            this.lblTheGlace.Size = new System.Drawing.Size(96, 16);
            this.lblTheGlace.TabIndex = 15;
            this.lblTheGlace.Text = "Thé  glacé :";
            // 
            // txtNbJusDePommes
            // 
            this.txtNbJusDePommes.Location = new System.Drawing.Point(147, 64);
            this.txtNbJusDePommes.Name = "txtNbJusDePommes";
            this.txtNbJusDePommes.ReadOnly = true;
            this.txtNbJusDePommes.Size = new System.Drawing.Size(56, 20);
            this.txtNbJusDePommes.TabIndex = 14;
            this.txtNbJusDePommes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblJusPomme
            // 
            this.lblJusPomme.Location = new System.Drawing.Point(45, 64);
            this.lblJusPomme.Name = "lblJusPomme";
            this.lblJusPomme.Size = new System.Drawing.Size(96, 16);
            this.lblJusPomme.TabIndex = 13;
            this.lblJusPomme.Text = "Jus de pommes :";
            // 
            // txtNb7Up
            // 
            this.txtNb7Up.Location = new System.Drawing.Point(147, 40);
            this.txtNb7Up.Name = "txtNb7Up";
            this.txtNb7Up.ReadOnly = true;
            this.txtNb7Up.Size = new System.Drawing.Size(56, 20);
            this.txtNb7Up.TabIndex = 12;
            this.txtNb7Up.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl7Up
            // 
            this.lbl7Up.Location = new System.Drawing.Point(45, 40);
            this.lbl7Up.Name = "lbl7Up";
            this.lbl7Up.Size = new System.Drawing.Size(96, 16);
            this.lbl7Up.TabIndex = 11;
            this.lbl7Up.Text = "7 Up :";
            // 
            // txtNbCokes
            // 
            this.txtNbCokes.Location = new System.Drawing.Point(147, 16);
            this.txtNbCokes.Name = "txtNbCokes";
            this.txtNbCokes.ReadOnly = true;
            this.txtNbCokes.Size = new System.Drawing.Size(56, 20);
            this.txtNbCokes.TabIndex = 10;
            this.txtNbCokes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCokes
            // 
            this.lblCokes.Location = new System.Drawing.Point(45, 20);
            this.lblCokes.Name = "lblCokes";
            this.lblCokes.Size = new System.Drawing.Size(96, 16);
            this.lblCokes.TabIndex = 9;
            this.lblCokes.Text = "Cokes :";
            // 
            // btnRecharger
            // 
            this.btnRecharger.Location = new System.Drawing.Point(12, 319);
            this.btnRecharger.Name = "btnRecharger";
            this.btnRecharger.Size = new System.Drawing.Size(184, 32);
            this.btnRecharger.TabIndex = 5;
            this.btnRecharger.Text = "Recharger la machine";
            this.btnRecharger.UseVisualStyleBackColor = true;
            this.btnRecharger.Click += new System.EventHandler(this.btnRecharger_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(450, 364);
            this.Controls.Add(this.btnRecharger);
            this.Controls.Add(this.grpInfosMachine);
            this.Controls.Add(this.picDistributrice);
            this.Controls.Add(this.grpBreuvage);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine Distributrice ";
            ((System.ComponentModel.ISupportInitialize)(this.picDistributrice)).EndInit();
            this.grpBreuvage.ResumeLayout(false);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.grpInfosMachine.ResumeLayout(false);
            this.grpInfosMachine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
       // private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Button btnObtenirUnTheGlace;
        private System.Windows.Forms.Button btnObtenirUnCoke;
        private System.Windows.Forms.Button btnObtenirUn7Up;
        private System.Windows.Forms.Button btnObtenirUnJusDePommes;
        private System.Windows.Forms.GroupBox grpBreuvage;
        private System.Windows.Forms.PictureBox picDistributrice;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.GroupBox grpInfosMachine;
        private System.Windows.Forms.TextBox txtEtat;
        private System.Windows.Forms.TextBox txtNbTheGlace;
        private System.Windows.Forms.Label lblTheGlace;
        private System.Windows.Forms.TextBox txtNbJusDePommes;
        private System.Windows.Forms.Label lblJusPomme;
        private System.Windows.Forms.TextBox txtNb7Up;
        private System.Windows.Forms.Label lbl7Up;
        private System.Windows.Forms.TextBox txtNbCokes;
        private System.Windows.Forms.Label lblCokes;
        private System.Windows.Forms.Button btnRecharger;
    }
}

