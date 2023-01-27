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
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotCourant);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numIndexMotCourant);
            this.groupBox1.Controls.Add(this.btnPrécédent);
            this.groupBox1.Controls.Add(this.btnSuivant);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 126);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtMotCourant
            // 
            this.txtMotCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotCourant.Location = new System.Drawing.Point(10, 30);
            this.txtMotCourant.Name = "txtMotCourant";
            this.txtMotCourant.ReadOnly = true;
            this.txtMotCourant.Size = new System.Drawing.Size(353, 31);
            this.txtMotCourant.TabIndex = 12;
            this.txtMotCourant.TabStop = false;
            this.txtMotCourant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 13);
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
            this.numIndexMotCourant.Location = new System.Drawing.Point(142, 84);
            this.numIndexMotCourant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numIndexMotCourant.Name = "numIndexMotCourant";
            this.numIndexMotCourant.ReadOnly = true;
            this.numIndexMotCourant.Size = new System.Drawing.Size(89, 26);
            this.numIndexMotCourant.TabIndex = 15;
            this.numIndexMotCourant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numIndexMotCourant.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // btnPrécédent
            // 
            this.btnPrécédent.Location = new System.Drawing.Point(10, 82);
            this.btnPrécédent.Name = "btnPrécédent";
            this.btnPrécédent.Size = new System.Drawing.Size(95, 28);
            this.btnPrécédent.TabIndex = 14;
            this.btnPrécédent.Text = "Précédent";
            this.btnPrécédent.UseVisualStyleBackColor = true;
            this.btnPrécédent.Click += new System.EventHandler(this.btnPrécédent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(270, 81);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(93, 28);
            this.btnSuivant.TabIndex = 12;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mot courant de la liste";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 199);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste générique de string  ";
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
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMotCourant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numIndexMotCourant;
        private System.Windows.Forms.Button btnPrécédent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Label label1;
    }
}

