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

namespace Juste_Prix_II
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int number { get; set; }
        public string text { get; set; }
        Random Random_Number = new Random(); // Aléatoire pour le nombre
        Random Random_Article = new Random(); // Aléatoire pour l'article
        //int Number = Random_Number.Next(1, 101); // Nombre aléatoire
        int Index, Number, LA;
        //Index = Random_Article.Next(0, 6);
        int tries = 0; // Initialisation du nombre d'essais
        public string[] articles = new string[] { "Ford Mustang Sportback", "Aston Martin DB7", "Fiat Abarth 595", "Alfa Romeo C8", "Bugatti Veyron 16.4" };// "Lamborghini Aventador V12" }; // Tableau des articles
        public MainWindow()
        {
        InitializeComponent();
        DataContext = this;
        }
        private void Add_Article(object sender, RoutedEventArgs e)
        {
        LA = articles.Length;
        articles = articles.Concat(new string[] {text}).ToArray(); // Ajout d'un nouvel article.
        info.Text = LA.ToString();
        }
        private void New_Game(object sender, RoutedEventArgs e)
        {
            Index = Random_Article.Next(0, 6);
            Number = Random_Number.Next(1, 101); 
            objet.Text = $"{articles[Index]}"; //do this
        }
        private void Validate(object sender, RoutedEventArgs e)
        {
            
            if (number < 1 || number > 100) // Si le nombre n'est pas compris entre 1 & 100
            {
            info.Text = "Vous devez saisir un nombre entre 1 et 50 ...";
            }
            else
            {
                if (number < Number)
                {
                info.Text = "C'est plus, le nombre a deviner est plus grand...";
                ++tries;
                }
                else if (number > Number)
                {
                info.Text = "C'est moins, le nombre a deviner est plus petit...";
                ++tries;
                }
                else
                {
                info.Text = "Bravo vous avez gagné et deviné le nombre en : " + tries + " essai(s)...";
                }
            }
        }
    }
}
