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

namespace Game
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        Image[] mas = new Image[4];
        string[] text = new string[4];
        bool t = false;
        int i = 0;
        public MainMenu()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            mas[0] = IMG1;
            mas[1] = IMG2;
            mas[2] = IMG3;
            mas[3] = IMG4;
            IMG.Source = mas[i].Source;
            text[0] = "Крестики нолики";
            text[1] = "Кроссворд";
            text[2] = "Викторина";
            text[3] = "Глебкина прога";
            Gmae.Text = text[i];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                NavigationService.Navigate(new tictactoesp());
            }
            else if (i == 2)
            {
                NavigationService.Navigate(new Victorina());
            }
            else if (i == 1)
            {
                NavigationService.Navigate(new Crossword());
            }
            else if (i == 3)
            {
                NavigationService.Navigate(new GLEB());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (i < 3)
            {
                i++;
                IMG.Source = mas[i].Source;
                IMG.Stretch = mas[i].Stretch;
                Gmae.Text = text[i];
            }
            else
            {
                i = 0;
                IMG.Stretch = mas[i].Stretch;
                IMG.Source = mas[i].Source;
                Gmae.Text = text[i];
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (i > 0)
            {
                i--;
                IMG.Source = mas[i].Source;
                IMG.Stretch = mas[i].Stretch;
                Gmae.Text = text[i];
            }
            else
            {
                i = 3;
                IMG.Stretch = mas[i].Stretch;
                IMG.Source = mas[i].Source;
                Gmae.Text = text[i];
            }
        }
    }
}
