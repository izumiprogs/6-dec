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
using static System.Math;

namespace _4
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
            double b = Convert.ToDouble(Rezult_b.Text);
            double c = Convert.ToDouble(Rezult_c.Text);
            double m, k, y = 0;
            m = (a + b * b) / c;
            k = m / 3;
            if (k == 1) { y = Exp(m + c); }
            if (k == 0) { y = Log(a / b); }
            if (k == 2) { y = Sqrt(Abs(Pow(a + b, 2) + c)); }
            TextBlockAnswer.Text = $"y={y}";
        }
    }
}
