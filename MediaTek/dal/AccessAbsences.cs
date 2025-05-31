using MediaTek.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AccessAbsences
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AccessAbsences()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absences> GetLesAbsences(int idpersonnel)
        {
            List<Absences> lesAbsences = new List<Absences>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel as idpersonnel, a.datedebut as datedebut, a.datefin as datefin, m.idmotif as idmotif, ";
                req += "p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as serviceNom, ";
                req += "m.libelle ";
                req += "from absences a join personnel p on (a.idpersonnel = p.idpersonnel) ";
                req += "join motif m on (a.idmotif = m.idmotif) ";
                req += "join service s on (p.idservice = s.idservice) ";
                req += "WHERE p.idpersonnel = @idpersonnel ";
                req += "order by p.idpersonnel, a.datedebut desc;";

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, new Dictionary<string, object> { { "@idpersonnel", idpersonnel } });
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Services service = new Services((int)record[8], (string)record[9]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[4], (string)record[5], (string)record[6], (string)record[7], service);
                            Motif motif = new Motif((int)record[3], (string)record[10]);
                            Absences absence = new Absences(personnel, (DateTime)record[1], (DateTime)record[2], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }



        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet developpeur à supprimer</param>
        public void DelAbsence(Absences absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absences where idpersonnel = @idpersonnel and datedebut = @datedebut and datefin = @datefin and idmotif = @idmotif;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Personnel.IdPersonnel);
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande d'ajout une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absences absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absences(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Personnel.IdPersonnel);
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        /// <param name="oldDatedebut">objet oldDatedebut à récuperer</param>
        /// <param name="oldDatefin">objet oldDatefin à récuperer</param>
        /// <param name="oldIdmotif">objet oldIdmotif à récupérer</param>
        public void UpdateAbsence(Absences absence, DateTime oldDatedebut, DateTime oldDatefin, int oldIdmotif)
        {
            if (access.Manager != null)
            {
                string req = "update absences set datedebut = @new_datedebut, datefin = @new_datefin, idmotif = @new_idmotif ";
                req += "WHERE idpersonnel = @idpersonnel AND datedebut = @old_datedebut AND datefin = @old_datefin AND idmotif = @old_idmotif;";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Personnel.IdPersonnel);
                parameters.Add("@new_datedebut", absence.Datedebut);
                parameters.Add("@new_datefin", absence.Datefin);
                parameters.Add("@new_idmotif", absence.Motif.Idmotif);

                parameters.Add("@old_datedebut", oldDatedebut);
                parameters.Add("@old_datefin", oldDatefin);
                parameters.Add("@old_idmotif", oldIdmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
