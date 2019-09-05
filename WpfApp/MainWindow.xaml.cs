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
using Calculator;
namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double value1 = 0;
        double value2 = 0;
        CalculatorUnderTest clc = new CalculatorUnderTest();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            value1 = double.Parse(TextBox1.Text);
            value2 = double.Parse(TextBox2.Text);
            double result = 0;
            switch(ComboBox.Text)
            {
                case "Addition":
                    result = clc.Add(value1, value2);
                    MessageBox.Show(result.ToString());
                    break;
                case "Subtraction":
                    result = clc.Minus(value1, value2);
                    MessageBox.Show(result.ToString());
                    break;
                case "Multiplication":
                    result = clc.Multiply(value1, value2);
                    MessageBox.Show(result.ToString());
                    break;
                case "Division":
                    result = clc.Divide(value1, value2);
                    MessageBox.Show(result.ToString());
                    break;
            }
        }
    }
}
