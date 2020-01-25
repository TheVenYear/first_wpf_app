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
using System.Windows.Threading;

namespace Game
{
    public partial class GLEB : Page
    {
        private int time = 10;
        private DispatcherTimer Timer;
        int i = 0, c, b, a, r = 15, n, x = 0, t = 0, f, mk, mg;
        double h = 0;
        Label m;
        Button[] mas = new Button[5];
        string[,] ax = new string[16, 2];
        bool p = false;
        Random rnd = new Random();
        public GLEB()
        {
            InitializeComponent();
            mas[0] = bt;
            mas[1] = bt1;
            mas[2] = bt2;
            mas[3] = bt3;
            tbcount.Text = "0 : 10";

            ax[0, 0] = "Бог";
            ax[1, 0] = "Лучший";
            ax[2, 0] = "Красавчик";
            ax[3, 0] = "Ты мне наконец-то понравился:)";
            ax[4, 0] = "Я люблю тебя";
            ax[5, 0] = "Топчик";
            ax[6, 0] = "Прикольно ты примеры выносишь, лучше бы так на пары ходил";
            ax[7, 0] = "Конечно ты ничего такой, но я все-таки лучше";
            ax[8, 0] = "Нормально для тебя";
            ax[9, 0] = "Молодец";
            ax[10, 0] = "Тупо халк";
            ax[11, 0] = "Богоподобный";
            ax[12, 0] = "Трипл килл и дабл килл";
            ax[13, 0] = "Лучший из лучших";
            ax[14, 0] = "Просто Бог в математике";
            ax[15, 0] = "Прелестный";

            ax[0, 1] = "Боже, что с тобой не так";
            ax[1, 1] = "Господь, дай мне сил не сломать этот компьютер";
            ax[2, 1] = "Ну как так то ну ты че такой не такой какойто а?";
            ax[3, 1] = "Попробуй еще раз, может хоть в этот раз ты сможешь понять что эти примеры 1 класса";
            ax[4, 1] = "Неудача";
            ax[5, 1] = "You lose";
            ax[6, 1] = "Мдааааааааааааааааааааа.........";
            ax[7, 1] = "Плохо((((";
            ax[8, 1] = "Да же я бы лучше ответил";
            ax[9, 1] = "ЕГЭ ты не сдашь";
            ax[10, 1] = "Мда мда я";
            ax[11, 1] = "Какой же ты безграмотный";
            ax[12, 1] = "ТЫ ЛУЧШИЙ (я пошутил, на самом деле ты не правильно ответил)";
            ax[13, 1] = "Рядышком";
            ax[14, 1] = "Почти верно, ну как почти, вообще не верно(";
            ax[15, 1] = "Ты старался";
        }
        void random()
        {
        m:
            Random rnd = new Random();
            a = rnd.Next(t, r);
            b = rnd.Next(t, r);
            c = rnd.Next(1, 5);
            i = rnd.Next(0, 4);
            n = rnd.Next(3, 16);
            mk = rnd.Next(0, 16);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            scorer.Text = 0 + "/15";
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
            tbcount.Visibility = Visibility.Visible;
            progbar.Visibility = Visibility.Visible;
            scorer.Visibility = Visibility.Visible;
            gifka.Visibility = Visibility.Collapsed;
            end_text_1.Visibility = Visibility.Collapsed;
            main();
        }

        void main()
        {
            int ik, k;
            tbcount.Foreground = Brushes.White;
            time = 11;
        m:
            random();

            qw.Text = Convert.ToString(a);
            qw3.Text = Convert.ToString(b);
            if (c == 1) { qw2.Text = "+"; h = a + b; }
            if (c == 2) { qw2.Text = "-"; h = a - b; }
            if (c == 3) { qw2.Text = "/"; h = (double)a / b; h = Math.Round(h, 1); if ((a == 0 && b == 0) || (a == 0 || b == 0)) goto m; }
            if (c == 4) { qw2.Text = "*"; h = a * b; }
            mas[0].Content = h + 14;
            mas[1].Content = h - 13;
            mas[2].Content = h + 6;
            mas[3].Content = h + 3;
            mas[i].Content = h;
            for (ik = 0; ik < 4; ik++)
            {
                mas[ik].Visibility = Visibility.Visible;
            }
        }
        void info()
        {
            if (mas[f].Content == mas[i].Content)
            {
                tt.Text = ax[mk, 0]; x = x + 1; progbar.Value++; ; main(); Timer_Tick(null, null);
            }
            else
            {
                tt.Text = ax[mk, 1]; x = x - 1; progbar.Value--; main(); Timer_Tick(null, null);
            }
            scorer.Text = x + "/15";
            tester();
        }
        void tester()
        {
            if (x < 0) { x = 0; scorer.Text = x + "/15"; }
            if (x >= 3) { lavel.Text = "Молодец, до двойки дотянул!"; progbar.Foreground = Brushes.Orange; r = 30; t = 10; }
            if (x >= 6) { lavel.Text = "Красава, 3 уже в кармане, немного до 4-ки осталось, может даже 5 получишь(я знаю, смешно звучит, но вдруг)"; progbar.Foreground = Brushes.Green; r = 60; t = 30; }
            if (x >= 12) { lavel.Text = "До 4ки дошел, давай еще немного подумай и дойдешь до пятерки!"; progbar.Foreground = Brushes.Blue; r = 150; t = 40; }
            if (x == 15) end_window();
            if (x < 3) { lavel.Text = ""; progbar.Foreground = Brushes.Red; }
        }
        private void Bt_Click(object sender, RoutedEventArgs e)
        {
            f = 0; info();
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            f = 1; info();
        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            f = 2; info();
        }

        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            f = 3; info();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            time--;
            if (time == 0) { progbar.Value--; x = x - 1; tt.Text = ax[mk, 1]; main(); time = 10; }
            if (x < 0) x = 0;
            scorer.Text = x + "/15";
            tester();
            if (time <= 3) tbcount.Foreground = Brushes.Red;
            tbcount.Text = string.Format("0 : {1}", time / 60, time % 60);
        }
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            r = 15;
            t = 0;
            x = 0;
            tt.Text = "";
            time = 0;
            qw.Text = "";
            qw2.Text = "";
            qw3.Text = "";
            for (i = 0; i < 4; i++)
            {
                mas[i].Content = "";
                mas[i].Visibility = Visibility.Collapsed;
            }
            progbar.Value = 0;
            scorer.Text = "0/15";
            lavel.Text = "";
            Timer.Stop();
            tbcount.Text = "0  :  10";
        }
        void end_window()
        {
            gifka.Visibility = Visibility.Visible;
            end_text_1.Visibility = Visibility.Visible;
            end_text_1.Text = "Ты выйграл, заслужил печеньку и пятерочку за одно:)";
            lol.Visibility = Visibility.Collapsed;
        }

    }
}
