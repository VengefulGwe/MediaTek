namespace MediaTek.view
{
    partial class frmAbsences
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
            this.grbAbsences = new System.Windows.Forms.GroupBox();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnModifAbsences = new System.Windows.Forms.Button();
            this.btnSuppAbsences = new System.Windows.Forms.Button();
            this.grbAddAbsences = new System.Windows.Forms.GroupBox();
            this.btnEnregAbsence = new System.Windows.Forms.Button();
            this.btnAnnulAbsence = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.grbAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grbAddAbsences.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAbsences
            // 
            this.grbAbsences.Controls.Add(this.btnSuppAbsences);
            this.grbAbsences.Controls.Add(this.btnModifAbsences);
            this.grbAbsences.Controls.Add(this.dgvAbsences);
            this.grbAbsences.Location = new System.Drawing.Point(12, 12);
            this.grbAbsences.Name = "grbAbsences";
            this.grbAbsences.Size = new System.Drawing.Size(776, 307);
            this.grbAbsences.TabIndex = 0;
            this.grbAbsences.TabStop = false;
            this.grbAbsences.Text = "Liste d\'absences";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(15, 21);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 51;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.Size = new System.Drawing.Size(731, 246);
            this.dgvAbsences.TabIndex = 0;
            // 
            // btnModifAbsences
            // 
            this.btnModifAbsences.Location = new System.Drawing.Point(15, 273);
            this.btnModifAbsences.Name = "btnModifAbsences";
            this.btnModifAbsences.Size = new System.Drawing.Size(105, 28);
            this.btnModifAbsences.TabIndex = 1;
            this.btnModifAbsences.Text = "modifier";
            this.btnModifAbsences.UseVisualStyleBackColor = true;
            // 
            // btnSuppAbsences
            // 
            this.btnSuppAbsences.Location = new System.Drawing.Point(126, 273);
            this.btnSuppAbsences.Name = "btnSuppAbsences";
            this.btnSuppAbsences.Size = new System.Drawing.Size(105, 28);
            this.btnSuppAbsences.TabIndex = 2;
            this.btnSuppAbsences.Text = "supprimer";
            this.btnSuppAbsences.UseVisualStyleBackColor = true;
            // 
            // grbAddAbsences
            // 
            this.grbAddAbsences.Controls.Add(this.dtpFin);
            this.grbAddAbsences.Controls.Add(this.dtpDebut);
            this.grbAddAbsences.Controls.Add(this.label5);
            this.grbAddAbsences.Controls.Add(this.label4);
            this.grbAddAbsences.Controls.Add(this.txtMotif);
            this.grbAddAbsences.Controls.Add(this.txtPrenom);
            this.grbAddAbsences.Controls.Add(this.txtNom);
            this.grbAddAbsences.Controls.Add(this.label3);
            this.grbAddAbsences.Controls.Add(this.label2);
            this.grbAddAbsences.Controls.Add(this.Label1);
            this.grbAddAbsences.Controls.Add(this.btnAnnulAbsence);
            this.grbAddAbsences.Controls.Add(this.btnEnregAbsence);
            this.grbAddAbsences.Location = new System.Drawing.Point(12, 338);
            this.grbAddAbsences.Name = "grbAddAbsences";
            this.grbAddAbsences.Size = new System.Drawing.Size(776, 162);
            this.grbAddAbsences.TabIndex = 1;
            this.grbAddAbsences.TabStop = false;
            this.grbAddAbsences.Text = "ajouter une absence";
            // 
            // btnEnregAbsence
            // 
            this.btnEnregAbsence.Location = new System.Drawing.Point(15, 132);
            this.btnEnregAbsence.Name = "btnEnregAbsence";
            this.btnEnregAbsence.Size = new System.Drawing.Size(99, 24);
            this.btnEnregAbsence.TabIndex = 0;
            this.btnEnregAbsence.Text = "enregistrer";
            this.btnEnregAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAnnulAbsence
            // 
            this.btnAnnulAbsence.Location = new System.Drawing.Point(132, 132);
            this.btnAnnulAbsence.Name = "btnAnnulAbsence";
            this.btnAnnulAbsence.Size = new System.Drawing.Size(99, 24);
            this.btnAnnulAbsence.TabIndex = 1;
            this.btnAnnulAbsence.Text = "annuler";
            this.btnAnnulAbsence.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 16);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "motif";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(82, 28);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(300, 22);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(82, 64);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(300, 22);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(82, 101);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(300, 22);
            this.txtMotif.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "date de début";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "date de fin";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(515, 31);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(240, 22);
            this.dtpDebut.TabIndex = 10;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(515, 64);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(240, 22);
            this.dtpFin.TabIndex = 11;
            // 
            // frmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.grbAddAbsences);
            this.Controls.Add(this.grbAbsences);
            this.Name = "frmAbsences";
            this.Text = "Absences";
            this.grbAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grbAddAbsences.ResumeLayout(false);
            this.grbAddAbsences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAbsences;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnSuppAbsences;
        private System.Windows.Forms.Button btnModifAbsences;
        private System.Windows.Forms.GroupBox grbAddAbsences;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnAnnulAbsence;
        private System.Windows.Forms.Button btnEnregAbsence;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}