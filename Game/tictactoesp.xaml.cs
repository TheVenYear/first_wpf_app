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
    /// Логика взаимодействия для tictactoesp.xaml
    /// </summary>
    public partial class tictactoesp : Page
    {
        bool l = false, w = false, game = true,geforge;
        int i = 0, j = 0, x = 0, y = 0, c = 0, z = 0;
        Button[,] b = new Button[5, 5];
        string player, pc;
        public tictactoesp()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            player = "X";
            pc = "O";
            geforge = true;
            b[0, 0] = Button1;
            b[0, 1] = Button2;
            b[0, 2] = Button3;
            b[1, 0] = Button4;
            b[1, 1] = Button5;
            b[1, 2] = Button6;
            b[2, 0] = Button7;
            b[2, 1] = Button8;
            b[2, 2] = Button9;
            for (i = 0; i < 3; i++) for (j = 0; j < 3; j++) b[i, j].Content = null;
            if (!geforge)
            {
                bot();
            }

        }

        private void random()
        {
            Random rnd = new Random();
        m:
            i = rnd.Next(0, 3);
            j = rnd.Next(0, 3);
            if (b[i, j].Content == null) b[i, j].Content = pc;
            else goto m;
        }

        void bot_checklose()
        {
            for (i = 0; i < 3; i++) if (b[i, 0].Content == b[i, 1].Content && (string)b[i, 1].Content == player && b[i, 2].Content == null) { l = true; x = i; y = 2; }
            for (i = 0; i < 3; i++) if (b[i, 1].Content == b[i, 2].Content && (string)b[i, 2].Content == player && b[i, 0].Content == null) { l = true; x = i; y = 0; }
            for (i = 0; i < 3; i++) if (b[i, 0].Content == b[i, 2].Content && (string)b[i, 2].Content == player && b[i, 1].Content == null) { l = true; x = i; y = 1; }
            for (j = 0; j < 3; j++) if (b[0, j].Content == b[1, j].Content && (string)b[1, j].Content == player && b[2, j].Content == null) { l = true; x = 2; y = j; }
            for (j = 0; j < 3; j++) if (b[1, j].Content == b[2, j].Content && (string)b[2, j].Content == player && b[0, j].Content == null) { l = true; x = 0; y = j; }
            for (j = 0; j < 3; j++) if (b[0, j].Content == b[2, j].Content && (string)b[2, j].Content == player && b[1, j].Content == null) { l = true; x = 1; y = j; }
            if (b[0, 0].Content == b[1, 1].Content && (string)b[1, 1].Content == player && b[2, 2].Content == null) { l = true; x = 2; y = 2; }
            if (b[2, 2].Content == b[1, 1].Content && (string)b[1, 1].Content == player && b[0, 0].Content == null) { l = true; x = 0; y = 0; }
            if (b[2, 2].Content == b[0, 0].Content && (string)b[0, 0].Content == player && b[1, 1].Content == null) { l = true; x = 1; y = 1; }
            if (b[0, 2].Content == b[1, 1].Content && (string)b[1, 1].Content == player && b[2, 0].Content == null) { l = true; x = 2; y = 0; }
            if (b[0, 2].Content == b[2, 0].Content && (string)b[2, 0].Content == player && b[1, 1].Content == null) { l = true; x = 1; y = 1; }
            if (b[2, 0].Content == b[1, 1].Content && (string)b[1, 1].Content == player && b[0, 2].Content == null) { l = true; x = 0; y = 2; }

        }

        void bot_checkwin()
        {
            for (i = 0; i < 3; i++) if (b[i, 0].Content == b[i, 1].Content && (string)b[i, 1].Content == pc && b[i, 2].Content == null) { w = true; c = i; z = 2; }
            for (i = 0; i < 3; i++) if (b[i, 1].Content == b[i, 2].Content && (string)b[i, 2].Content == pc && b[i, 0].Content == null) { w = true; c = i; z = 0; }
            for (i = 0; i < 3; i++) if (b[i, 0].Content == b[i, 2].Content && (string)b[i, 2].Content == pc && b[i, 1].Content == null) { w = true; c = i; z = 1; }
            for (j = 0; j < 3; j++) if (b[0, j].Content == b[1, j].Content && (string)b[1, j].Content == pc && b[2, j].Content == null) { w = true; c = 2; z = j; }
            for (j = 0; j < 3; j++) if (b[1, j].Content == b[2, j].Content && (string)b[2, j].Content == pc && b[0, j].Content == null) { w = true; c = 0; z = j; }
            for (j = 0; j < 3; j++) if (b[0, j].Content == b[2, j].Content && (string)b[2, j].Content == pc && b[1, j].Content == null) { w = true; c = 1; z = j; }
            if (b[0, 0].Content == b[1, 1].Content && (string)b[1, 1].Content == pc && b[2, 2].Content == null) { w = true; c = 2; z = 2; }
            if (b[2, 2].Content == b[1, 1].Content && (string)b[1, 1].Content == pc && b[0, 0].Content == null) { w = true; c = 0; z = 0; }
            if (b[2, 2].Content == b[0, 0].Content && (string)b[0, 0].Content == pc && b[1, 1].Content == null) { w = true; c = 1; z = 1; }
            if (b[0, 2].Content == b[1, 1].Content && (string)b[1, 1].Content == pc && b[2, 0].Content == null) { w = true; c = 2; z = 0; }
            if (b[0, 2].Content == b[2, 0].Content && (string)b[2, 0].Content == pc && b[1, 1].Content == null) { w = true; c = 1; z = 1; }
            if (b[2, 0].Content == b[1, 1].Content && (string)b[1, 1].Content == pc && b[0, 2].Content == null) { w = true; c = 0; z = 2; }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (geforge) { geforge = false; player = "O";pc = "X";}
            else if (!geforge) { geforge = true; player = "X"; pc = "O"; }
            if (!geforge) bot();
            RestartButton_Click(sender, e);
        }

        void bot_golose()
        {
            b[x, y].Content = pc;
            x = 0;
            y = 0;
        }

        void bot_gowin()
        {
            b[c, z].Content = pc;
            c = 0;
            z = 0;
            WinText.Text = "Победил компьютер";
            WinText.Visibility = Visibility.Visible;
            game = false;
        }

        void bot_center0()
        {
            var rnd = new Random();
            var vals = new int[] { 0, 2 };
        q:
            i = vals[rnd.Next(vals.Length)];
            if (b[i, 1].Content == null) b[i, 1].Content = pc;
            else
            {
                j = vals[rnd.Next(vals.Length)];
                if (b[1, j].Content == null) b[1, j].Content = pc;
                else goto q;
            }
        }
        void bot_center()
        {
            var rnd = new Random();
            var vals = new int[] { 0, 2 };
        q:
            i = vals[rnd.Next(vals.Length)];
            j = vals[rnd.Next(vals.Length)];
            if (b[i, j].Content == null) b[i, j].Content = pc;
            else goto q;
        }

        void checkdraw()
        {
            WinText.Text = "Ничья";
            WinText.Visibility = Visibility.Visible;
            game = false;
        }

        void bot()
        {
            bot_checkwin();
            bot_checklose();
            if (w) bot_gowin();
            else if (l) bot_golose();
            else if (b[0, 0].Content != null && b[0, 1].Content != null && b[0, 2].Content != null && b[1, 0].Content != null && b[1, 1].Content != null
            && b[1, 2].Content != null && b[2, 0].Content != null && b[2, 1].Content != null && b[2, 2].Content != null) checkdraw();
            else if (b[1, 1].Content == null) b[1, 1].Content = pc;
            else if (b[0, 0].Content == player && b[2, 2].Content == player) bot_center0();
            else if (b[0, 2].Content == player && b[2, 0].Content == player) bot_center0();
            else if ((b[0, 0].Content == null || b[0, 2].Content == null || b[2, 0].Content == null || b[2, 2].Content == null) && (b[1, 1].Content == player || b[1, 1].Content == pc)) bot_center();
            else if (b[0, 1].Content == player && b[1, 0].Content == player && b[0, 0].Content == null) b[0, 0].Content = pc;
            else if (b[0, 1].Content == player && b[1, 2].Content == player && b[0, 2].Content == null) b[0, 2].Content = pc;
            else if (b[2, 1].Content == player && b[1, 0].Content == player && b[2, 0].Content == null) b[2, 0].Content = pc;
            else if (b[2, 1].Content == player && b[1, 2].Content == player && b[2, 2].Content == null) b[2, 2].Content = pc;
            else random();
            l = false;
            if (b[0, 0].Content != null && b[0, 1].Content != null && b[0, 2].Content != null && b[1, 0].Content != null && b[1, 1].Content != null
            && b[1, 2].Content != null && b[2, 0].Content != null && b[2, 1].Content != null && b[2, 2].Content != null) checkdraw();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button senderb = (Button)sender;
            if (game == true && senderb.Content == null)
                {
                    senderb.Content = player;
                    bot();
            }

        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            for (i = 0; i < 3; i++) for (j = 0; j < 3; j++) b[i, j].Content = null;
            WinText.Visibility = Visibility.Hidden;
            w = false;
            game = true;
            if (!geforge) bot();
        }

    }
}