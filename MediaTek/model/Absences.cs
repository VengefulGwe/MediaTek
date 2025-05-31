using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations des absences
    /// </summary>
    public class Absences
    {
        /// <summary>
        /// propriété Personnel d'Absences
        /// </summary>
        public Personnel Personnel { get; set; }
        /// <summary>
        /// propriété Datedebut d'Absences
        /// </summary>
        public DateTime Datedebut { get; set; }
        /// <summary>
        /// propriété Datefin d'Absences
        /// </summary>
        public DateTime Datefin { get; set; }
        /// <summary>
        /// propriété Motif d'Absences
        /// </summary>
        public Motif Motif { get; set; }
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absences(Personnel personnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.Personnel = personnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }
        /// <summary>
        /// propriété IdPersonnel d'Absences pour un affichage spécifique
        /// </summary>
        public int PersonnelId => Personnel.IdPersonnel;
    }
}
