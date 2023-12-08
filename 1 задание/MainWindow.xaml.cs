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

namespace rabotadada
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Button_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(Rezult_a.Text);
            string s1 = " ";
            string s2 = " ";
            if (a == 0)
            {
                TextBlockAnswer.Text = $"нулевое число ";
            }
            else
            {
                if (a > 0) { s1 = "положительное"; }
                else { s1 = "отрицательное"; }
                if (a % 2 == 0) { s2 = "четное"; }
                else { s2 = "не четное"; }
            }
            TextBlockAnswer.Text = $"  {s1} {s2} число ";
        }
    }
}
