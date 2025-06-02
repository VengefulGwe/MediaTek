using MediaTek.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les services attitrés
    /// </summary>
    public class AccessService
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AccessService()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Services> GetLesServices()
        {
            List<Services> lesServices = new List<Services>();
            if (access.Manager != null)
            {
                string req = "select * from service order by nom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Services service = new Services((int)record[0], (string)record[1]);
                            lesServices.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }

    }
}
