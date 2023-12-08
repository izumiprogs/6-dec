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

namespace _5
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

            double x = Convert.ToDouble(Rezult_a.Text);
            double y = Convert.ToDouble(Rezult_b.Text);
            string s = " ";
            if (x < 0 && x > -15 && y < 0 && y > -15) { s = "да"; }
            else if (x > 0  x < -15  y > 0 || y < -15) { s = "нет"; }
            else { s = "на границе"; }
            TextBlockAnswer.Text = $"{s}";
        }
    }
}
