using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Packaging;
using System.Linq;
using System.Reflection.Emit;
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
    /// Logique d'interaction pour Jeu_de_Pendu.xaml
    /// </summary>
    public partial class Jeu_de_Pendu : Window
    {
        private Stopwatch chrono;
        private bool aGagne;
        string langue;
        string niveau;
        private List<ImageSource> imagesPendu = new List<ImageSource>();
        private int tentativesRestantes;
        private string motSecret;
        private int score;
        private int erreurs;
        private jeu_de_penduEntities dbContext = new jeu_de_penduEntities();
       


        private List<Button> clickedButtons = new List<Button>();

        public Jeu_de_Pendu()
        {
            InitializeComponent();
            InitializeImages();
            UpdatePenduImage();
            
        }
        private string GetRandomWord()
        {
            // Récupérez un mot aléatoire depuis la base de données en utilisant Entity Framework.
            var randomWord = dbContext.dictionnaires
                .OrderBy(r => Guid.NewGuid()) 
                .Select(r => r.mot.ToUpper())
                .FirstOrDefault();

            return randomWord;
        }

        public void InitialiserJeu(string langue, string niveau)
        {
            this.langue = langue;
            this.niveau = niveau;
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

        private void btnDebut_Click(object sender, RoutedEventArgs e)
        {
            //MessageBoxResult result = MessageBox.Show("Voulez-vous commencer à jouer?", "Info", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //if (result == MessageBoxResult.Yes)
            //{
            erreurs = 0;
            chrono = new Stopwatch();
            // On cliquons sur "Débuter le jeu", chargez un mot aléatoire depuis la base de données.
            motSecret = GetRandomWord();
                lblMot.Content = new string('_', motSecret.Length);
                score = 0;
                tentativesRestantes = 6;
                lblScore.Content = score.ToString();
                aGagne = false;


                foreach (Button item in clickedButtons)
                {
                    item.IsEnabled = true;
                }


                //InitialiserJeu(selectedLangue, selectedNiveau);
                //MessageBox.Show("Tapez une lettre pour trouver le mot.");
            //}
        }

        private void InitializeImages()
        {
            // Ajoutez les chemins d'accès aux images du pendu dans la liste
            imagesPendu.Add(new BitmapImage(new Uri("err06.jpg", UriKind.Relative))); // Image 0 tentatives
            imagesPendu.Add(new BitmapImage(new Uri("err05.jpg", UriKind.Relative))); // Image 1 tentative
            imagesPendu.Add(new BitmapImage(new Uri("err04.jpg", UriKind.Relative))); // Image 2 tentatives
            imagesPendu.Add(new BitmapImage(new Uri("err03.jpg", UriKind.Relative))); // Image 3 tentatives
            imagesPendu.Add(new BitmapImage(new Uri("err02.jpg", UriKind.Relative))); // Image 4 tentatives
            imagesPendu.Add(new BitmapImage(new Uri("err01.jpg", UriKind.Relative))); // Image 5 tentatives
            imagesPendu.Add(new BitmapImage(new Uri("acceuil.jpg", UriKind.Relative))); // Image 6 tentatives
        }

        private void UpdatePenduImage()
        {
            // Mettez à jour l'image du pendu en fonction des tentatives restantes
            if (tentativesRestantes >= 0 && tentativesRestantes < imagesPendu.Count)
            {
                image.Source = imagesPendu[tentativesRestantes];
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            DateTime timeEnd;
            TimeSpan timeSpent;

            DateTime startDate = DateTime.Now;

            if (!aGagne) // Vérifiez si le joueur a déjà gagné
            {
                // Gérez le clic sur les boutons de lettre.
                Button button = (Button)sender;
                clickedButtons.Add(button);
                char lettre = button.Content.ToString()[0];

                button.IsEnabled = false;

                if (motSecret.Contains(lettre))
                {
                    // La lettre est dans le mot secret.
                    // Mettez à jour l'affichage du mot.
                    char[] motAffiche = lblMot.Content.ToString().ToCharArray();
                    bool lettreTrouvee = false; 

                    for (int i = 0; i < motSecret.Length; i++)
                    {
                        if (motSecret[i] == lettre)
                        {
                            motAffiche[i] = lettre;
                            lettreTrouvee = true; // Marquez la lettre comme trouvée.
                        }
                    }

                    lblMot.Content = new string(motAffiche);

                    if (!lblMot.Content.ToString().Contains('_'))
                    {
                        // Le joueur a trouvé le mot.
                        score += 5; 
                        lblScore.Content = score.ToString();
                        
                        aGagne = true; // Marquez que le joueur a gagné

                        chrono.Stop();
                        timeSpent = chrono.Elapsed;
                        historique histor = new historique();

                        
                        histor.mot = motSecret;
                        histor.pointage = score;
                        histor.erreurs = tentativesRestantes;
                        histor.date = startDate;
                        histor.temps = timeSpent;
                        histor.resultat = "Succes";
                        dbContext.historiques.Add(histor);
                        dbContext.SaveChanges();
                        MessageBox.Show("Bravo! Vous avez gagné.");
                    }

                  
                }

                else
                {
                    erreurs++;
                    // La lettre n'est pas dans le mot secret.
                    tentativesRestantes--; // Décrémentez le compteur de tentatives
                    UpdatePenduImage(); // Mettez à jour l'image du pendu

                    if (tentativesRestantes == 0)
                    {
                        chrono.Stop();
                        timeSpent = chrono.Elapsed;
                        historique histori = new historique();

                        histori.mot = motSecret;
                        histori.pointage = score;
                        histori.erreurs = tentativesRestantes;
                        histori.date = startDate;
                        histori.temps = timeSpent;
                        histori.resultat = "Echec";
                        dbContext.historiques.Add(histori);
                        dbContext.SaveChanges();
                        // Le joueur a épuisé toutes les tentatives, vous pouvez gérer la fin du jeu ici.
                        MessageBox.Show("Vous avez perdu ! Le mot était : " + motSecret);
                       
                    }
                }
            }
        }




    }
}
