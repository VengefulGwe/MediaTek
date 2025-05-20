namespace MediaTek.view
{
    partial class FrmMediaTek
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
            this.grbLePersonnel = new System.Windows.Forms.GroupBox();
            this.btnSuppression = new System.Windows.Forms.Button();
            this.btnModification = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnAnnulPerso = new System.Windows.Forms.Button();
            this.btnEnregPerso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.btnAffAbsences = new System.Windows.Forms.Button();
            this.grbLePersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grbPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLePersonnel
            // 
            this.grbLePersonnel.Controls.Add(this.btnSuppression);
            this.grbLePersonnel.Controls.Add(this.btnModification);
            this.grbLePersonnel.Controls.Add(this.dgvPersonnel);
            this.grbLePersonnel.Location = new System.Drawing.Point(12, 12);
            this.grbLePersonnel.Name = "grbLePersonnel";
            this.grbLePersonnel.Size = new System.Drawing.Size(776, 331);
            this.grbLePersonnel.TabIndex = 0;
            this.grbLePersonnel.TabStop = false;
            this.grbLePersonnel.Text = "le personnel";
            this.grbLePersonnel.Enter += new System.EventHandler(this.grbPersonnel_Enter);
            // 
            // btnSuppression
            // 
            this.btnSuppression.Location = new System.Drawing.Point(133, 290);
            this.btnSuppression.Name = "btnSuppression";
            this.btnSuppression.Size = new System.Drawing.Size(116, 28);
            this.btnSuppression.TabIndex = 2;
            this.btnSuppression.Text = "supprimer";
            this.btnSuppression.UseVisualStyleBackColor = true;
            // 
            // btnModification
            // 
            this.btnModification.Location = new System.Drawing.Point(16, 290);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(111, 28);
            this.btnModification.TabIndex = 1;
            this.btnModification.Text = "modifier";
            this.btnModification.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 21);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.Size = new System.Drawing.Size(730, 257);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.txtService);
            this.grbPersonnel.Controls.Add(this.label5);
            this.grbPersonnel.Controls.Add(this.txtMail);
            this.grbPersonnel.Controls.Add(this.txtTel);
            this.grbPersonnel.Controls.Add(this.label4);
            this.grbPersonnel.Controls.Add(this.label3);
            this.grbPersonnel.Controls.Add(this.label2);
            this.grbPersonnel.Controls.Add(this.label1);
            this.grbPersonnel.Controls.Add(this.txtPrenom);
            this.grbPersonnel.Controls.Add(this.txtNom);
            this.grbPersonnel.Controls.Add(this.btnAnnulPerso);
            this.grbPersonnel.Controls.Add(this.btnEnregPerso);
            this.grbPersonnel.Location = new System.Drawing.Point(12, 360);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(776, 181);
            this.grbPersonnel.TabIndex = 1;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "ajouter un membre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "prénom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(82, 70);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(280, 22);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(82, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(280, 22);
            this.txtNom.TabIndex = 5;
            // 
            // btnAnnulPerso
            // 
            this.btnAnnulPerso.Location = new System.Drawing.Point(114, 147);
            this.btnAnnulPerso.Name = "btnAnnulPerso";
            this.btnAnnulPerso.Size = new System.Drawing.Size(102, 28);
            this.btnAnnulPerso.TabIndex = 4;
            this.btnAnnulPerso.Text = "annuler";
            this.btnAnnulPerso.UseVisualStyleBackColor = true;
            // 
            // btnEnregPerso
            // 
            this.btnEnregPerso.Location = new System.Drawing.Point(6, 147);
            this.btnEnregPerso.Name = "btnEnregPerso";
            this.btnEnregPerso.Size = new System.Drawing.Size(102, 28);
            this.btnEnregPerso.TabIndex = 3;
            this.btnEnregPerso.Text = "enregistrer";
            this.btnEnregPerso.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "mail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(429, 31);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(326, 22);
            this.txtTel.TabIndex = 11;
            this.txtTel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(429, 70);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(326, 22);
            this.txtMail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "service";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(82, 111);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(280, 22);
            this.txtService.TabIndex = 14;
            // 
            // btnAffAbsences
            // 
            this.btnAffAbsences.Location = new System.Drawing.Point(229, 547);
            this.btnAffAbsences.Name = "btnAffAbsences";
            this.btnAffAbsences.Size = new System.Drawing.Size(304, 33);
            this.btnAffAbsences.TabIndex = 2;
            this.btnAffAbsences.Text = "afficher les absences";
            this.btnAffAbsences.UseVisualStyleBackColor = true;
            // 
            // FrmMediaTek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.btnAffAbsences);
            this.Controls.Add(this.grbPersonnel);
            this.Controls.Add(this.grbLePersonnel);
            this.Name = "FrmMediaTek";
            this.Text = "MediaTek";
            this.grbLePersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLePersonnel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnSuppression;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnAnnulPerso;
        private System.Windows.Forms.Button btnEnregPerso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAffAbsences;
    }
}

