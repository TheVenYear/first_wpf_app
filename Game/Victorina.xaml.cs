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
    /// Логика взаимодействия для Victorina.xaml
    /// </summary>
    public partial class Victorina : Page
    {
        int score = 0, i = 0, c = 1, j = 0;
        string[,] mas = new string[11, 5];
        string[] mas2 = new string[11];
        bool pe = false;
        public Victorina()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            back.Visibility = Visibility.Visible;
            i++;
            c++;
            qw.Text = score + "";
            mas2[j] = otvet.Text;
            j++;
            otvet.Text = mas2[j];
            ask.Text = mas[i, 0];
            num.Text = c + "/10";

            if (i == 9)
            {
                next.Visibility = Visibility.Collapsed;
                result.Visibility = Visibility.Visible;
            }

        }

        private void Otvet_KeyDown(object sender, KeyEventArgs e)
        {
            if (i != 9 && e.Key == Key.Return) Button_Click(sender, e);
            else if (e.Key == Key.Return) Result_Click(sender, e);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            c--;
            num.Text = c + "/10";
            i--;
            ask.Text = mas[i, 0];
            if (i == 0) back.Visibility = Visibility.Collapsed;
            next.Visibility = Visibility.Visible;
            result.Visibility = Visibility.Collapsed;
            j--;
            otvet.Text = mas2[j];

        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {

            for (i = 0; i < 9; i++) {
                if (mas2[i] == mas[i, 1] || mas2[i] == mas[i, 2] || mas2[i] == mas[i, 3] || mas2[i] == mas[i, 4])
                {
                    score++;
                }
            }

            if (i == 9)
            {
                next.Visibility = Visibility.Collapsed;
                result.Visibility = Visibility.Visible;
                if (otvet.Text == mas[i, 1] || otvet.Text == mas[i, 2]) score++;
            }

            next.Visibility = Visibility.Collapsed;
            otvet.Visibility = Visibility.Collapsed;
            back.Visibility = Visibility.Collapsed;
            result.Visibility = Visibility.Collapsed;
            prikol.Visibility = Visibility.Visible;
            panel.Visibility = Visibility.Collapsed;
            exit.Visibility = Visibility.Visible;
            num.Text = "Правильных: " + score + " из 10";

            if (score == 10) ask.Text = "Ну тут сразу видно 5 всей группе + автомат! (Иначе БАН)";
            if (score < 10) ask.Text = "Ну тут сразу видно 5 всей группе";
            if (score <= 8) ask.Text = "За страрание отпустите всех домой пж";
            if (score <= 3) ask.Text = "Боже просто отпустите их спары";
            if (score == 0) ask.Text = "Может хоть на какой-нибудь вопрос ответишь?";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mas[0, 0] = "Какое из следующих утверждений является тавтологией?\nA. (p v q)→q\nB.p v(q→p)\nC.p v(p→q)\nD.Оба(B) & (C)";
            mas[1, 0] = "Чем является p ^ (~ p v q)?\nA. Тавтология\nB. Противоречие\nC. Логически эквивалентно p ^ q\nD. все вышеперечисленное";
            mas[2, 0] = "Что из следующего является тавтологией?\nA. a v b → b ^ c\nB. a ^ b → b v c\nC. a v b → (b → c)\nD. Ничего из этого";
            mas[3, 0] = "Определите вывод из предпосылок Pv Q, Q → R, P → M, ˥M\nA. P ^ (R v R)\nB. P ^ (P ^ R)\nC. R ^ (P v Q)\nD. Q ^ (P v R)";
            mas[4, 0] = "Что из следующего является декларативным заявлением?\nA. Это правильно\nB. Он говорит\nC. Два не может быть четным целым числом\nD. Я люблю тебя";
            mas[5, 0] = "P → (Q → R) эквивалентно\nA. (P ^ Q) → R\nB. (P v Q) → R\nC. (P v Q) → ˥R\nD. Ничего из этого";
            mas[6, 0] = "Если F1, F2 и F3 являются пропозициональными формулами, такими, что F1 ^ F2 → F3 и F1 ^ F2 → F3 являются тавтологиями, то что из следующего ИСТИНА?\nA. И F1, и F2 - тавтологии\nB. Соединение F1 ^ F2 не выполнимо\nC. Тавтологии тоже\nD. Ничего из этого";
            mas[7, 0] = "Какие из следующих являются тавтологией?\nA. ((P v Q) ^ Q) ↔ Q\nB. ((P v Q) ^ ˥P) → Q\nC. ((P v Q) ^ P) → P\nD. Оба (A) и (B)";
            mas[8, 0] = "(P v Q) ^ (P → R) ^ (Q → R) эквивалентно:\nA. P\nB. Q\nC. R\nD. True = T";
            mas[9, 0] = "Что из следующего является ЛОЖНЫМ?\nСчитать ^ как И, v как ИЛИ, ~ как НЕТ, → как одностороннее следствие и ↔ как двухстороннее следствие?\nA. ((x → y) ^ x) → y\nB. ((~ x → y) ^ (~ x ^ ~ y)) → y\nC. (x → (x v y))\nD. ((x v y) ↔ (~ x v ~ y))";


            mas[0, 1] = "C";
            mas[1, 1] = "C";
            mas[2, 1] = "B";
            mas[3, 1] = "D";
            mas[4, 1] = "B";
            mas[5, 1] = "A";
            mas[6, 1] = "B";
            mas[7, 1] = "D";
            mas[8, 1] = "C";
            mas[9, 1] = "D";

            mas[0, 2] = "c";
            mas[1, 2] = "c";
            mas[2, 2] = "b";
            mas[3, 2] = "d";
            mas[4, 2] = "b";
            mas[5, 2] = "a";
            mas[6, 2] = "b";
            mas[7, 2] = "d";
            mas[8, 2] = "c";
            mas[9, 2] = "d";

            mas[0, 3] = "С";
            mas[1, 3] = "С";
            mas[2, 3] = "В";
            mas[4, 3] = "В";
            mas[5, 3] = "А";
            mas[6, 3] = "В";
            mas[8, 3] = "С";

            mas[0, 4] = "с";
            mas[1, 4] = "с";
            mas[2, 4] = "в";
            mas[4, 4] = "в";
            mas[5, 4] = "а";
            mas[6, 4] = "в";
            mas[8, 4] = "с";

            ask.Text = mas[0, 0];

            num.Text = c + "/10";


            if (i == 0) back.Visibility = Visibility.Collapsed;



        }
    }
}
