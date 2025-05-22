using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek
{
    /// <summary>
    /// application de gestion de personnel et d'absences
    /// </summary>
    internal class NamespaceDoc
    {

    }
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new view.FrmAuthentification());
        }
    }
}
