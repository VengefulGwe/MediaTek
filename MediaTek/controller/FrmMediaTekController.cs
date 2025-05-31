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
    /// Contrôleur de FrmMediaTek
    /// </summary>
    public class FrmMediaTekController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly AccessPersonnel PersonnelAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Services
        /// </summary>
        private readonly AccessService ServiceAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmMediaTekController()
        {
            PersonnelAccess = new AccessPersonnel();
            ServiceAccess = new AccessService();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetLePersonnel()
        {
            return PersonnelAccess.GetLePersonnel();
        }

        /// <summary>
        /// Récupère et retourne les infos des services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Services> GetLesServices()
        {
            return ServiceAccess.GetLesServices();
        }

        /// <summary>
        /// Demande de suppression d'un membre du personnel
        /// </summary>
        /// <param name="personnel">objet membre à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            PersonnelAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'un membre du personnel
        /// </summary>
        /// <param name="personnel">objet membre à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            PersonnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un membre du personnel
        /// </summary>
        /// <param name="personnel">objet membre à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            PersonnelAccess.UpdatePersonnel(personnel);
        }
    }
}
