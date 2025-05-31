using MediaTek.controller;
using MediaTek.model;
using System;
using System.Windows.Forms;

namespace MediaTek.view
{
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;

        /// <summary>
        /// Conrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        /// <summary>
        /// Demande au controleur de controler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnConnect_Click(object sender, EventArgs e)
        {
            {
                String login = txtLogin.Text;
                String pwd = txtPwd.Text;
                if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
                else
                {
                    Responsable responsable = new Responsable(login, pwd);
                    if (controller.ControleAuthentification(responsable))
                    {
                        FrmMediaTek frm = new FrmMediaTek();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                    }
                }
            }
        }
    }
}
