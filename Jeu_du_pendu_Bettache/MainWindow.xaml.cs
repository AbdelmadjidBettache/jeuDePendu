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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jeu_du_pendu_Bettache
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPreference_Click(object sender, RoutedEventArgs e)
        {
            Preferences preferences = new Preferences();
            preferences.ShowDialog();
        }

        private void btnHistorique_Click(object sender, RoutedEventArgs e)
        {
            Historique historique = new Historique();
            historique.ShowDialog();
        }

        private void btnJouer_Click(object sender, RoutedEventArgs e)
        {
            Jeu_de_Pendu jeu_De_Pendu = new Jeu_de_Pendu();
            jeu_De_Pendu.Show();
            this.Close();
        }

        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Voulez-Vous Vraiment Quitter Le Jeu?","info",MessageBoxButton.YesNo,MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }


        }
    }
}
