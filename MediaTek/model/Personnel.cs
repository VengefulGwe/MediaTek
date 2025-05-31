using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.model
{ 
    /// <summary>
    /// Classe métier interne pour mémoriser les informations du personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Services service)
        {
            this.IdPersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        /// <summary>
        /// propriété IdPersonnel de Personnel
        /// </summary>
        public int IdPersonnel { get; set; }
        /// <summary>
        /// propriété Nom de Personnel
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// propriété Prenom de Personnel
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// propriété Tel de Personnel
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// propriété Mail de Personnel
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// propriété Service de Personnel
        /// </summary>
        public Services Service { get; set; }
    }
}
