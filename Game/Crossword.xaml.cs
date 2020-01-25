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
    public partial class Crossword : Page
    {
        int score = 0, i = 0, c = 1;
        TextBox[] mas = new TextBox[200];
        TextBlock[] mas2 = new TextBlock[17];
        string[,] a = new string[100, 100];
        string qwd;
        TextBlock ggnormal;
        public Crossword()
        {
            InitializeComponent();
            mas[0] = qw_3_1;
            mas[1] = qw_3_2;
            mas[2] = qw_3_3;
            mas[3] = qw_3_4;
            mas[4] = qw_3_5;
            mas[5] = qw_3_6;
            mas[6] = qw_2_6;
            mas[7] = qw_3_8;
            mas[8] = qw_3_9;
            mas[9] = qw_2_5;
            mas[10] = qw_2_4;
            mas[11] = qw_2_3;
            mas[12] = qw_2_2;
            mas[13] = qw_2_1;
            mas[14] = qw_2_8;
            mas[15] = qw_2_7;
            mas[16] = qw_8_1;
            mas[17] = qw_8_2;
            mas[18] = qw_8_3;
            mas[19] = qw_8_4;
            mas[20] = qw_8_5;
            mas[21] = qw_8_8;
            mas[22] = qw_8_7;
            mas[23] = qw_15_4;
            mas[24] = qw_15_3;
            mas[25] = qw_15_2;
            mas[26] = qw_15_1;
            mas[27] = qw_15_5;
            mas[28] = qw_7_2;
            mas[29] = qw_15_7;
            mas[30] = qw_7_1;
            mas[31] = qw_1_7;
            mas[32] = qw_7_3;
            mas[33] = qw_7_6;
            mas[34] = qw_7_5;
            mas[35] = qw_7_7;
            mas[36] = qw_1_6;
            mas[37] = qw_1_5;
            mas[38] = qw_1_4;
            mas[39] = qw_1_3;
            mas[40] = qw_1_2;
            mas[41] = qw_1_1;
            mas[42] = qw_1_12;
            mas[43] = qw_1_11;
            mas[44] = qw_1_10;
            mas[45] = qw_1_9;
            mas[46] = qw_1_8;
            mas[47] = qw_11_5;
            mas[48] = qw_5_1;
            mas[49] = qw_11_3;
            mas[50] = qw_11_2;
            mas[51] = qw_11_1;
            mas[52] = qw_14_3;
            mas[53] = qw_14_2;
            mas[54] = qw_14_5;
            mas[55] = qw_14_4;
            mas[56] = qw_14_7;
            mas[57] = qw_14_6;
            mas[58] = qw_14_8;
            mas[59] = qw_14_10;
            mas[60] = qw_14_9;
            mas[61] = qw_14_11;
            mas[62] = qw_5_3;
            mas[63] = qw_5_2;
            mas[64] = qw_5_5;
            mas[65] = qw_5_4;
            mas[66] = qw_5_7;
            mas[67] = qw_5_6;
            mas[68] = qw_5_8;
            mas[69] = qw_5_10;
            mas[70] = qw_5_9;
            mas[71] = qw_11_8;
            mas[72] = qw_11_7;
            mas[73] = qw_13_2;
            mas[74] = qw_4_1;
            mas[75] = qw_13_4;
            mas[76] = qw_13_7;
            mas[77] = qw_13_6;
            mas[78] = qw_4_4;
            mas[79] = qw_4_3;
            mas[80] = qw_4_2;
            mas[81] = qw_4_7;
            mas[82] = qw_4_6;
            mas[83] = qw_4_5;
            mas[84] = qw_4_10;
            mas[85] = qw_4_9;
            mas[86] = qw_4_8;
            mas[87] = qw_6_3;
            mas[88] = qw_6_2;
            mas[89] = qw_6_5;
            mas[90] = qw_6_4;
            mas[91] = qw_6_7;
            mas[92] = qw_6_6;
            mas[93] = qw_6_8;
            mas[94] = qw_6_10;
            mas[95] = qw_6_9;
            mas[96] = qw_9_3;
            mas[97] = qw_9_2;
            mas[98] = qw_9_1;
            mas[99] = qw_9_6;
            mas[100] = qw_9_5;
            mas[101] = qw_9_9;
            mas[102] = qw_9_8;
            mas[103] = qw_9_7;
            mas[104] = qw_9_12;
            mas[105] = qw_9_11;
            mas[106] = qw_9_10;
            mas[107] = qw_16_6;
            mas[108] = qw_16_8;
            mas[109] = qw_16_7;
            mas[110] = qw_16_9;
            mas[111] = qw_16_11;
            mas[112] = qw_16_10;
            mas[113] = qw_16_12;
            mas[114] = qw_16_1;
            mas[115] = qw_16_2;
            mas[116] = qw_16_4;
            mas[117] = qw_16_3;
            mas[118] = qw_17_9;
            mas[119] = qw_17_8;
            mas[120] = qw_17_12;
            mas[121] = qw_17_11;
            mas[122] = qw_17_10;
            mas[123] = qw_17_1;
            mas[124] = qw_17_3;
            mas[125] = qw_17_2;
            mas[126] = qw_17_6;
            mas[127] = qw_17_5;
            mas[128] = qw_12_7;
            mas[129] = qw_12_5;
            mas[130] = qw_12_6;
            mas[131] = qw_10_1;
            mas[132] = qw_12_2;
            mas[133] = qw_12_4;
            mas[134] = qw_12_3;
            mas[135] = qw_10_4;
            mas[136] = qw_10_6;
            mas[137] = qw_10_5;
            mas[138] = qw_10_9;
            mas[139] = qw_10_8;
            mas[140] = qw_10_7;
            mas[141] = qw_10_3;
            mas[142] = qw_10_2;
            mas2[0] = ot;
            mas2[1] = ot1;
            mas2[2] = ot2;
            mas2[3] = ot3;
            mas2[4] = ot4;
            mas2[5] = ot5;
            mas2[6] = ot6;
            mas2[7] = ot7;
            mas2[8] = ot8;
            mas2[9] = ot9;
            mas2[10] = ot10;
            mas2[11] = ot11;
            mas2[12] = ot12;
            mas2[13] = ot13;
            mas2[14] = ot14;
            mas2[15] = ot15;
            mas2[16] = ot16;
            a[0, 0] = "высказывание";
            a[1, 0] = "суждение";
            a[2, 0] = "отрицание";
            a[3, 0] = "коньюнкция";
            a[4, 0] = "дизьюнкция";
            a[5, 0] = "импликация";
            a[6, 0] = "посылка";
            a[7, 0] = "аргумент";
            a[8, 0] = "эквиваленция";
            a[9, 0] = "следствие";
            a[10, 0] = "предикат";
            a[11, 0] = "субьект";
            a[12, 0] = "квантор";
            a[13, 0] = "предложение";
            a[14, 0] = "множество";
            a[15, 0] = "подмножество";
            a[16, 0] = "противоречие";

            a[0, 3] = "Высказывание";
            a[1, 3] = "Суждение";
            a[2, 3] = "Отрицание";
            a[3, 3] = "конъюнкция";
            a[4, 3] = "дизъюнкция";
            a[5, 3] = "Импликация";
            a[6, 3] = "Посылка";
            a[7, 3] = "Аргумент";
            a[8, 3] = "Эквиваленция";
            a[9, 3] = "Следствие";
            a[10, 3] = "Предикат";
            a[11, 3] = "субъект";
            a[12, 3] = "Квантор";
            a[13, 3] = "Предложение";
            a[14, 3] = "Множество";
            a[15, 3] = "Подмножество";
            a[16, 3] = "Противоречие";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (i = 0; i < 143; i++)
            {
                mas[i].Visibility = Visibility.Collapsed;
            }
            for (i = 0; i < 17; i++)
            {
                mas2[i].Visibility = Visibility.Collapsed;
            }
            checke.Visibility = Visibility.Collapsed;
            rest.Visibility = Visibility.Visible;
            info.Visibility = Visibility.Visible;
            gg.Visibility = Visibility.Collapsed;

            a[0, 1] = qw_1_1.Text + qw_1_2.Text + qw_1_3.Text + qw_1_4.Text + qw_1_5.Text + qw_1_6.Text + qw_1_7.Text + qw_1_8.Text + qw_1_9.Text + qw_1_10.Text + qw_1_11.Text + qw_1_12.Text;
            a[1, 1] = qw_2_1.Text + qw_2_2.Text + qw_2_3.Text + qw_2_4.Text + qw_2_5.Text + qw_2_6.Text + qw_2_7.Text + qw_2_8.Text;
            a[2, 1] = qw_3_1.Text + qw_3_2.Text + qw_3_3.Text + qw_3_4.Text + qw_3_5.Text + qw_3_6.Text + qw_2_6.Text + qw_3_8.Text + qw_3_9.Text;
            a[3, 1] = qw_4_1.Text + qw_4_2.Text + qw_4_3.Text + qw_4_4.Text + qw_4_5.Text + qw_4_6.Text + qw_4_7.Text + qw_4_8.Text + qw_4_9.Text + qw_4_10.Text;
            a[4, 1] = qw_5_1.Text + qw_5_2.Text + qw_5_3.Text + qw_5_4.Text + qw_5_5.Text + qw_5_6.Text + qw_5_7.Text + qw_5_8.Text + qw_5_9.Text + qw_5_10.Text;
            a[5, 1] = qw_1_11.Text + qw_6_2.Text + qw_6_3.Text + qw_6_4.Text + qw_6_5.Text + qw_6_6.Text + qw_6_7.Text + qw_6_8.Text + qw_6_9.Text + qw_6_10.Text;
            a[6, 1] = qw_7_1.Text + qw_7_2.Text + qw_7_3.Text + qw_1_7.Text + qw_7_5.Text + qw_7_6.Text + qw_7_7.Text;
            a[7, 1] = qw_8_1.Text + qw_8_2.Text + qw_8_3.Text + qw_8_4.Text + qw_8_5.Text + qw_2_8.Text + qw_8_7.Text + qw_8_8.Text;
            a[8, 1] = qw_9_1.Text + qw_9_2.Text + qw_9_3.Text + qw_6_9.Text + qw_9_5.Text + qw_9_6.Text + qw_9_7.Text + qw_9_8.Text + qw_9_9.Text + qw_9_10.Text + qw_9_11.Text + qw_9_12.Text;
            a[9, 1] = qw_10_1.Text + qw_10_2.Text + qw_10_3.Text + qw_10_4.Text + qw_10_5.Text + qw_10_6.Text + qw_10_7.Text + qw_10_8.Text + qw_10_9.Text;
            a[10, 1] = qw_11_1.Text + qw_11_2.Text + qw_11_3.Text + qw_5_1.Text + qw_11_5.Text + qw_7_6.Text + qw_11_7.Text + qw_11_8.Text;
            a[11, 1] = qw_10_1.Text + qw_12_2.Text + qw_12_3.Text + qw_12_4.Text + qw_12_5.Text + qw_12_6.Text + qw_12_7.Text;
            a[12, 1] = qw_4_1.Text + qw_13_2.Text + qw_1_9.Text + qw_13_4.Text + qw_11_8.Text + qw_13_6.Text + qw_13_7.Text;
            a[13, 1] = qw_11_1.Text + qw_14_2.Text + qw_14_3.Text + qw_14_4.Text + qw_14_5.Text + qw_14_6.Text + qw_14_7.Text + qw_14_8.Text + qw_14_9.Text + qw_14_10.Text + qw_14_11.Text;
            a[14, 1] = qw_15_1.Text + qw_15_2.Text + qw_15_3.Text + qw_15_4.Text + qw_3_9.Text + qw_15_5.Text + qw_8_8.Text + qw_15_7.Text + qw_7_2.Text;
            a[15, 1] = qw_16_1.Text + qw_16_2.Text + qw_16_3.Text + qw_16_4.Text + qw_4_6.Text + qw_16_6.Text + qw_16_7.Text + qw_16_8.Text + qw_16_9.Text + qw_16_10.Text + qw_16_11.Text + qw_16_12.Text;
            a[16, 1] = qw_17_1.Text + qw_17_2.Text + qw_17_3.Text + qw_12_7.Text + qw_17_5.Text + qw_17_6.Text + qw_16_2.Text + qw_17_8.Text + qw_17_9.Text + qw_17_10.Text + qw_17_11.Text + qw_17_12.Text;

            for (i = 0; i < 17; i++)
            {
                if (a[i, 0] == a[i, 1] || a[i, 3] == a[i, 1]) { score = score + 1; info.Text = info.Text + c + ". " + a[i, 0] + "-" + a[i, 1] + "  (Правильно)" + "\n"; } else { if (a[i, 1] == "") info.Text = info.Text + c + ". " + a[i, 0] + "-" + "Вы ничего не написали." + "  (Не правильно)" + "\n"; else info.Text = info.Text + c + ". " + a[i, 0] + "-" + a[i, 1] + "   (Не правильно)" + "\n"; }
                c++;
            }
            info.Text = info.Text + "\n\n\n" + "Вы ответили правильно: " + score + "/17";

        }

        private void Rest_Click(object sender, RoutedEventArgs e)
        {
            for (i = 0; i < 143; i++)
            {
                mas[i].Visibility = Visibility.Visible;
            }
            for (i = 0; i < 17; i++)
            {
                mas2[i].Visibility = Visibility.Visible;
            }
            checke.Visibility = Visibility.Visible;
            rest.Visibility = Visibility.Collapsed;
            info.Visibility = Visibility.Collapsed;
            gg.Visibility = Visibility.Visible;
            for (i = 0; i < 143; i++)
            {
                mas[i].Text = "";
            }
            info.Text = "";
            i = 0;
            c = 1;
            score = 0;
}
    }
}