using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Base;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class Geetings : Window
{
    public Geetings()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (HelloButton.IsChecked == true)
        {
             MessageBox.Show("Hello.");
        }
        else if (GoodbyeButton.IsChecked == true)
        {
              MessageBox.Show("Goodbye.");
        }
    }

    private void RadioButton_Checked(object sender, RoutedEventArgs e)
    {
        // 아무거나 넣어도 OK
        // 예: 선택될 때 메시지
        // MessageBox.Show("RadioButton Checked");
    }
}