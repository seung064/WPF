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
using System.Windows.Shapes;

namespace WPF_Base_Practice
{
    /// <summary>
    /// Interaction logic for Slider_Practice.xaml
    /// </summary>
    public partial class Slider_Practice : Window
    {
        public Slider_Practice()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = (sender as Slider).Value;

            Color color = Color.FromRgb(0, 0, 0);
            {
                
            }
        }
    }
}
