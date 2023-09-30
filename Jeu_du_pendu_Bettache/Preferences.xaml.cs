using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Jeu_du_pendu_Bettache
{
    /// <summary>
    /// Logique d'interaction pour Preferences.xaml
    /// </summary>
    public partial class Preferences : Window
    {
        public string SelectedLanguage { get; set; }
        public string SelectedLevel { get; set; }
        public Preferences()
        {
            InitializeComponent();
        }

        private void btnDictionnaire_Click(object sender, RoutedEventArgs e)
        {
            Dictionnaire dictionnaire = new Dictionnaire();
            dictionnaire.Show();
            this.Close();
        }

       

        private void btnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            Preferences pre = new Preferences();
            // Récupérez la langue et le niveau sélectionnés
            string langue = rbFranc.IsChecked == true ? "Français" : "Anglais";
            string niveau = "";
            if (rbFacile.IsChecked == true)
                niveau = "Facile";
            else if (rbMoyen.IsChecked == true)
                niveau = "Moyen";
            else if (rbDefficile.IsChecked == true)
                niveau = "Defficile";

            pre.SelectedLanguage = langue;
            pre.SelectedLevel = niveau;


            // Vous pouvez maintenant utiliser les valeurs "langue" et "niveau" dans votre jeu du pendu.
            // Par exemple, passez ces valeurs à la méthode qui initialise le jeu.
            Jeu_de_Pendu jeu = new Jeu_de_Pendu();
            jeu.InitialiserJeu(langue, niveau);

            // Fermez la fenêtre.
            //this.Close();
        }
    }
}
