using MediaTek.controller;
using MediaTek.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek.view
{
    public partial class FrmAbsences : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();

        private BindingSource bdgPersonnel;

        private int idpersonnel;
        

        
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmAbsencesController controller;
        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAbsences(int idpersonnel, BindingSource bdgPersonnel)
        {
            InitializeComponent();
            this.bdgPersonnel = bdgPersonnel;
            this.idpersonnel = idpersonnel;
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmAbsencesController();
            RemplirListeAbsences(idpersonnel);
            RemplirListeMotifs();
            EnCoursDeModifAbsence(false);
        }
        /// <summary>
        /// Affiche le personnel
        /// </summary>
        private void RemplirListeAbsences(int idpersonnel)
        {
            List<Absences> lesAbsences = controller.GetLesAbsences(idpersonnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.AutoGenerateColumns = false;

            // Ajoutez et configurez les colonnes manuellement
            if (dgvAbsences.Columns.Count == 0)
            {
                // Colonne pour IdPersonnel
                DataGridViewTextBoxColumn idPersonnelColumn = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "PersonnelId", // Assurez-vous que cela correspond à la propriété de votre objet
                    HeaderText = "ID Personnel"
                };
                dgvAbsences.Columns.Add(idPersonnelColumn);

                // Colonne pour DateDebut
                DataGridViewTextBoxColumn dateDebutColumn = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Datedebut",
                    HeaderText = "Date Début"
                };
                dgvAbsences.Columns.Add(dateDebutColumn);

                // Colonne pour DateFin
                DataGridViewTextBoxColumn dateFinColumn = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Datefin",
                    HeaderText = "Date Fin"
                };
                dgvAbsences.Columns.Add(dateFinColumn);

                // Colonne pour Motif
                DataGridViewTextBoxColumn motifColumn = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Motif", // Assurez-vous que cela correspond à la propriété de votre objet
                    HeaderText = "Motif"
                };
                dgvAbsences.Columns.Add(motifColumn);
            }
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
        }

        private void dgvAbsences_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAbsences.Columns[e.ColumnIndex].Name == "datedebut" || dgvAbsences.Columns[e.ColumnIndex].Name == "datefin")
            {
                if (e.Value is DateTime)
                {
                    e.Value = ((DateTime)e.Value).ToString("yyyy-MM-dd hh:mm:ss");
                    e.FormattingApplied = true;
                }
            }
        }
        /// <summary>
        ///  Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifAbsences_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                EnCoursDeModifAbsence(true);
                Absences absence = (Absences)bdgAbsences.List[bdgAbsences.Position];
                dtpDebut.Value = absence.Datedebut;
                dtpFin.Value = absence.Datefin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuppAbsences_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absences absence = (Absences)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence du" + absence.Datedebut + " au " + absence.Datefin + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences(idpersonnel);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregAbsence_Click(object sender, EventArgs e)
        {
            
            if (!dtpDebut.Value.Equals("") && !dtpFin.Value.Equals("") && cboMotif.SelectedIndex != -1)
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                if (enCoursDeModifAbsence)
                {
                    Absences absence = (Absences)bdgAbsences.List[bdgAbsences.Position];
                    DateTime oldDatedebut = absence.Datedebut;
                    DateTime oldDatefin = absence.Datefin;
                    int oldIdmotif = absence.Motif.Idmotif;
                    absence.Datedebut = dtpDebut.Value;
                    absence.Datefin = dtpFin.Value;
                    absence.Motif = motif;
                    controller.UpdateAbsence(absence, oldDatedebut, oldDatefin, oldIdmotif);
                }
                else
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    Absences absence = new Absences(personnel, dtpDebut.Value, dtpFin.Value, motif);
                    controller.AddAbsence(absence);
                }
                RemplirListeAbsences(idpersonnel);
                EnCoursDeModifAbsence(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'une absence
        /// Vide les zones de saisie du développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifAbsence(false);
            }
        }
        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grbAbsences.Enabled = !modif;
            if (modif)
            {
                grbAbsences.Text = "modifier une absence";
            }
            else
            {
                grbAbsences.Text = "ajouter une absence";
                dtpDebut.Value = DateTime.Now;
                dtpFin.Value = DateTime.Now;
                cboMotif.SelectedIndex = -1;
            }
        }
    }
}
