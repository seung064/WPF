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
            ColorChange();
        }

        private void ColorType(object sender, RoutedEventArgs e)
        {
            ColorChange();
        }

        private void ColorChange()
        {
            byte r = (byte)Slider_R.Value;
            byte g = (byte)Slider_G.Value;
            byte b = (byte)Slider_B.Value;

            R_Point.Content = r.ToString();
            G_Point.Content = g.ToString();
            B_Point.Content = b.ToString();

            Color color = Color.FromRgb((byte)r, (byte)g, (byte)b);
            MainPanel.Background = new SolidColorBrush(color);

            if (Original.IsChecked == true)
            {
                MainPanel.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            }
            else if (GrayTone.IsChecked == true)
            {
                byte gray = (byte)((r + g + b) / 3);
                MainPanel.Background = new SolidColorBrush(Color.FromRgb(gray, gray, gray));
            }
            else if (Invert.IsChecked == true)
            {
                MainPanel.Background = new SolidColorBrush(Color.FromRgb((byte)(255 - r), (byte)(255 - g), (byte)(255 - b)));
            }

            /*
             * RGB 값은 0~255 범위
             * C#의 Byte 타입은 0~255 범위의 정수 값
             * 
             */
        }

    }
}


