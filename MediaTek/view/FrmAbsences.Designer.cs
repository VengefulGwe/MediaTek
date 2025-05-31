namespace MediaTek.view
{
    /// <summary>
    /// Classe du design de la fenêtre
    /// </summary>
    partial class FrmAbsences
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
            this.btnSuppAbsences = new System.Windows.Forms.Button();
            this.btnModifAbsences = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grbAddAbsences = new System.Windows.Forms.GroupBox();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnnulAbsence = new System.Windows.Forms.Button();
            this.btnEnregAbsence = new System.Windows.Forms.Button();
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
            // btnSuppAbsences
            // 
            this.btnSuppAbsences.Location = new System.Drawing.Point(126, 273);
            this.btnSuppAbsences.Name = "btnSuppAbsences";
            this.btnSuppAbsences.Size = new System.Drawing.Size(105, 28);
            this.btnSuppAbsences.TabIndex = 2;
            this.btnSuppAbsences.Text = "supprimer";
            this.btnSuppAbsences.UseVisualStyleBackColor = true;
            this.btnSuppAbsences.Click += new System.EventHandler(this.btnSuppAbsences_Click);
            // 
            // btnModifAbsences
            // 
            this.btnModifAbsences.Location = new System.Drawing.Point(15, 273);
            this.btnModifAbsences.Name = "btnModifAbsences";
            this.btnModifAbsences.Size = new System.Drawing.Size(105, 28);
            this.btnModifAbsences.TabIndex = 1;
            this.btnModifAbsences.Text = "modifier";
            this.btnModifAbsences.UseVisualStyleBackColor = true;
            this.btnModifAbsences.Click += new System.EventHandler(this.btnModifAbsences_Click);
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
            this.dgvAbsences.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAbsences_CellFormatting);
            // 
            // grbAddAbsences
            // 
            this.grbAddAbsences.Controls.Add(this.cboMotif);
            this.grbAddAbsences.Controls.Add(this.dtpFin);
            this.grbAddAbsences.Controls.Add(this.dtpDebut);
            this.grbAddAbsences.Controls.Add(this.label5);
            this.grbAddAbsences.Controls.Add(this.label4);
            this.grbAddAbsences.Controls.Add(this.label3);
            this.grbAddAbsences.Controls.Add(this.btnAnnulAbsence);
            this.grbAddAbsences.Controls.Add(this.btnEnregAbsence);
            this.grbAddAbsences.Location = new System.Drawing.Point(12, 338);
            this.grbAddAbsences.Name = "grbAddAbsences";
            this.grbAddAbsences.Size = new System.Drawing.Size(776, 162);
            this.grbAddAbsences.TabIndex = 1;
            this.grbAddAbsences.TabStop = false;
            this.grbAddAbsences.Text = "ajouter une absence";
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(82, 88);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(121, 24);
            this.cboMotif.TabIndex = 12;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(506, 32);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(240, 22);
            this.dtpFin.TabIndex = 11;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(142, 32);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(240, 22);
            this.dtpDebut.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "date de fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "date de début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "motif";
            // 
            // btnAnnulAbsence
            // 
            this.btnAnnulAbsence.Location = new System.Drawing.Point(132, 132);
            this.btnAnnulAbsence.Name = "btnAnnulAbsence";
            this.btnAnnulAbsence.Size = new System.Drawing.Size(99, 24);
            this.btnAnnulAbsence.TabIndex = 1;
            this.btnAnnulAbsence.Text = "annuler";
            this.btnAnnulAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulAbsence.Click += new System.EventHandler(this.btnAnnulAbsence_Click);
            // 
            // btnEnregAbsence
            // 
            this.btnEnregAbsence.Location = new System.Drawing.Point(15, 132);
            this.btnEnregAbsence.Name = "btnEnregAbsence";
            this.btnEnregAbsence.Size = new System.Drawing.Size(99, 24);
            this.btnEnregAbsence.TabIndex = 0;
            this.btnEnregAbsence.Text = "enregistrer";
            this.btnEnregAbsence.UseVisualStyleBackColor = true;
            this.btnEnregAbsence.Click += new System.EventHandler(this.btnEnregAbsence_Click);
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.grbAddAbsences);
            this.Controls.Add(this.grbAbsences);
            this.Name = "FrmAbsences";
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
        private System.Windows.Forms.Button btnAnnulAbsence;
        private System.Windows.Forms.Button btnEnregAbsence;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMotif;
    }
}