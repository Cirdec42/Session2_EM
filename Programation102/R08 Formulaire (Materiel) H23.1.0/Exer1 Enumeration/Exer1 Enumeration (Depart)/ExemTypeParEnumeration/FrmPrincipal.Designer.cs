namespace ExemTypeParEnumeration
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
            this.btnExemple1 = new System.Windows.Forms.Button();
            this.cboChoix = new System.Windows.Forms.ComboBox();
            this.lblChoix = new System.Windows.Forms.Label();
            this.txtVotreChoix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExemple2 = new System.Windows.Forms.Button();
            this.btnExemple3 = new System.Windows.Forms.Button();
            this.btnExemple4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExemple1
            // 
            this.btnExemple1.BackColor = System.Drawing.Color.Aqua;
            this.btnExemple1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemple1.Location = new System.Drawing.Point(12, 56);
            this.btnExemple1.Name = "btnExemple1";
            this.btnExemple1.Size = new System.Drawing.Size(473, 35);
            this.btnExemple1.TabIndex = 0;
            this.btnExemple1.Text = "Exemple 1 : Solution à l\'aide nombres entiers";
            this.btnExemple1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExemple1.UseVisualStyleBackColor = false;
            this.btnExemple1.Click += new System.EventHandler(this.btnExemple1_Click);
            // 
            // cboChoix
            // 
            this.cboChoix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoix.FormattingEnabled = true;
            this.cboChoix.Items.AddRange(new object[] {
            "Gauche",
            "Droite",
            "Centre"});
            this.cboChoix.Location = new System.Drawing.Point(131, 17);
            this.cboChoix.Name = "cboChoix";
            this.cboChoix.Size = new System.Drawing.Size(121, 21);
            this.cboChoix.TabIndex = 1;
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(12, 20);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(113, 13);
            this.lblChoix.TabIndex = 2;
            this.lblChoix.Text = "Choisir un alignement :";
            // 
            // txtVotreChoix
            // 
            this.txtVotreChoix.Location = new System.Drawing.Point(364, 18);
            this.txtVotreChoix.Name = "txtVotreChoix";
            this.txtVotreChoix.ReadOnly = true;
            this.txtVotreChoix.Size = new System.Drawing.Size(121, 20);
            this.txtVotreChoix.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Votre choix est :";
            // 
            // btnExemple2
            // 
            this.btnExemple2.BackColor = System.Drawing.Color.Lime;
            this.btnExemple2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemple2.Location = new System.Drawing.Point(12, 97);
            this.btnExemple2.Name = "btnExemple2";
            this.btnExemple2.Size = new System.Drawing.Size(473, 35);
            this.btnExemple2.TabIndex = 5;
            this.btnExemple2.Text = "Exemple 2 : Solution en utilisant des constantes";
            this.btnExemple2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExemple2.UseVisualStyleBackColor = false;
            this.btnExemple2.Click += new System.EventHandler(this.btnExemple2_Click);
            // 
            // btnExemple3
            // 
            this.btnExemple3.BackColor = System.Drawing.Color.Salmon;
            this.btnExemple3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemple3.Location = new System.Drawing.Point(12, 138);
            this.btnExemple3.Name = "btnExemple3";
            this.btnExemple3.Size = new System.Drawing.Size(473, 35);
            this.btnExemple3.TabIndex = 6;
            this.btnExemple3.Text = "Exemple 3 : Solution en utilisant un type par énumération prédéfini\r\n";
            this.btnExemple3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExemple3.UseVisualStyleBackColor = false;
            this.btnExemple3.Click += new System.EventHandler(this.btnExemple3_Click);
            // 
            // btnExemple4
            // 
            this.btnExemple4.BackColor = System.Drawing.Color.Yellow;
            this.btnExemple4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemple4.Location = new System.Drawing.Point(12, 179);
            this.btnExemple4.Name = "btnExemple4";
            this.btnExemple4.Size = new System.Drawing.Size(473, 35);
            this.btnExemple4.TabIndex = 7;
            this.btnExemple4.Text = "Exemple 4 : Solution en définissant un nouveau type par énumération";
            this.btnExemple4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExemple4.UseVisualStyleBackColor = false;
            this.btnExemple4.Click += new System.EventHandler(this.btnExemple4_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 232);
            this.Controls.Add(this.btnExemple4);
            this.Controls.Add(this.btnExemple3);
            this.Controls.Add(this.btnExemple2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVotreChoix);
            this.Controls.Add(this.lblChoix);
            this.Controls.Add(this.cboChoix);
            this.Controls.Add(this.btnExemple1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type par énumération ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExemple1;
        private System.Windows.Forms.ComboBox cboChoix;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.TextBox txtVotreChoix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExemple2;
        private System.Windows.Forms.Button btnExemple3;
        private System.Windows.Forms.Button btnExemple4;
    }
}

