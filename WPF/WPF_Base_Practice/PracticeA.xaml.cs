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
    /// Interaction logic for PracticeA.xaml
    /// </summary>
    public partial class PracticeA : Window
    {
        public PracticeA()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string id = txtId.Text;
            string pw = txtPw.Password;

            if(string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(pw))
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요.","경고", MessageBoxButton.OK);
                return;
            }
        }
    }
}
