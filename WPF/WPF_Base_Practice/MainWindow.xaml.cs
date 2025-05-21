using System.IO;
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

namespace WPF_Base_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var users = new Dictionary<string, string>
            {
                {"system", "1234" },
                {"admin", "1111" }
            };

            string user = id.Text;
            string pw = password.Text;

            if (users.ContainsKey(user) && users[user] == pw)
            {
                MessageBox.Show("로그인 성공");
            }
            else if (id == null || password == null)
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요.");
            }
            else if (!users.ContainsKey(user))
            {
                MessageBox.Show("");
            }
        }
    }
}
