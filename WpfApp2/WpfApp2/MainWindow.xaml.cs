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

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double V10;
            double x = Convert.ToDouble(Edit1.Text);

            V10 = (Math.Exp(x) * Math.Tan(Math.Pow(Math.Pow(x, 2) + 5.3, 0.333)) + Math.Pow(x, 5)) / (1 + Math.Log(Math.Abs(x)));
            string v = Convert.ToString(V10);
            Edit2.Text = v;
        }
    }
}
