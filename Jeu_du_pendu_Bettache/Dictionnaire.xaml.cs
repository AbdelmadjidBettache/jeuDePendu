using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
using static System.Collections.Specialized.BitVector32;

namespace Jeu_du_pendu_Bettache
{
    /// <summary>
    /// Logique d'interaction pour Dictionnaire.xaml
    /// </summary>
    public partial class Dictionnaire : Window
    {
        jeu_de_penduEntities jeu_de_penduEntities1= new jeu_de_penduEntities();
        public Dictionnaire()
        {
            InitializeComponent();
        }

        private void btnAccueil_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgDictionnaire.DataContext = jeu_de_penduEntities1.dictionnaires.ToList();
            LoadData();
        }

        private void LoadData()
        {
            if (cbLangue.SelectedItem != null && cbNiveau.SelectedItem != null)
            {
                string selectedLangue = ((ComboBoxItem)cbLangue.SelectedItem).Content.ToString();
                string selectedNiveau = ((ComboBoxItem)cbNiveau.SelectedItem).Content.ToString();

                // Utilisation d'Entity Framework pour charger les mots en fonction de la langue et du niveau.
                var mots = jeu_de_penduEntities1.dictionnaires
                    .Where(m => m.langue == selectedLangue && m.niveau == selectedNiveau)
                    .ToList();

                // Liaison des données au DataGrid.
                dgDictionnaire.ItemsSource = mots;
            }
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    jeu_de_penduEntities1 = new jeu_de_penduEntities1();
        //    //cbLangue.DataContext = jeu_de_penduEntities1.dictionnaires.ToList();
        //    //cbNiveau.DataContext = jeu_de_penduEntities1.dictionnaires.ToList();
        //    dgDictionnaire.DataContext = jeu_de_penduEntities1.dictionnaires.ToList();
        //}

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string motAInserer = txtMot.Text.Trim();

            // Vérifiez si le TextBox n'est pas vide.
            if (!string.IsNullOrEmpty(motAInserer))
            {
                
                dictionnaire dictionnaire = new dictionnaire();
                dictionnaire.niveau = cbNiveau.Text;
                dictionnaire.langue = cbLangue.Text;
                dictionnaire.mot = motAInserer; // Utilisez le mot extrait du TextBox.

                jeu_de_penduEntities1.dictionnaires.Add(dictionnaire);

                jeu_de_penduEntities1.SaveChanges();
                MessageBox.Show("Mot ajouté avec succès");

                // mettez à jour la liste affichée.
                LoadData();
            }
            else
            {
                MessageBox.Show("Le champ Mot ne peut pas être vide.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {

            if (dgDictionnaire.SelectedItem != null)
            {
                // Récupérez l'élément sélectionné dans le DataGrid.
                dictionnaire motASupprimer = dgDictionnaire.SelectedItem as dictionnaire;

                if (motASupprimer != null)
                {
                    // Recherchez l'élément dans la base de données en utilisant son ID.
                    dictionnaire motDansLaBase = jeu_de_penduEntities1.dictionnaires.FirstOrDefault(m => m.mot == motASupprimer.mot);

                    if (motDansLaBase != null)
                    {
                        // Supprimez l'élément de la base de données et enregistrez les modifications.
                        jeu_de_penduEntities1.dictionnaires.Remove(motDansLaBase);
                        jeu_de_penduEntities1.SaveChanges();

                        // Rafraîchissez le DataGrid.
                        dgDictionnaire.DataContext = jeu_de_penduEntities1.dictionnaires.ToList();

                        MessageBox.Show("Mot supprimé avec succès");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner le Mot à supprimer.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LoadData();
        }

        private void cbLangue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadData();
        }

        private void cbNiveau_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadData();
        }
    }
}
