using MediaTek.dal;
using MediaTek.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.controller
{
    /// <summary>
    /// Contrôleur de FrmAbsences
    /// </summary>
    public class FrmAbsencesController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly AccessAbsences AbsencesAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Services
        /// </summary>
        private readonly AccessMotif MotifAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmAbsencesController()
        {
            AbsencesAccess = new AccessAbsences();
            MotifAccess = new AccessMotif();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Absences> GetLesAbsences(int idpersonnel)
        {
            return AbsencesAccess.GetLesAbsences(idpersonnel);
        }

        /// <summary>
        /// Récupère et retourne les infos des services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Motif> GetLesMotifs()
        {
            return MotifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absences absence)
        {
            AbsencesAccess.DelAbsence(absence);
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absences">objet absences à ajouter</param>
        public void AddAbsence(Absences absences)
        {
            AbsencesAccess.AddAbsence(absences);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à récupérer</param>
        /// <param name="oldDatedebut">objet oldDatedebut à récuperer</param>
        /// <param name="oldDatefin">objet oldDatefin à récuperer</param>
        /// <param name="oldIdmotif">objet oldIdmotif à récupérer</param>
        public void UpdateAbsence(Absences absence, DateTime oldDatedebut, DateTime oldDatefin, int oldIdmotif)
        {
            AbsencesAccess.UpdateAbsence(absence, oldDatedebut, oldDatefin, oldIdmotif);
        }
    }
}
