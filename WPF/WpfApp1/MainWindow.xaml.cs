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

namespace WpfApp1
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
            // 선택된 라디오 버튼 확인
            string result = "";

            if(radioMale.IsChecked == true)
            {
                result = "남성을 선택 했습니다.";
            }
            else if (radioFemale.IsChecked == true)
            {
                result = "여성을 선택 했습니다.";
            }

            MessageBox.Show(result);
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        /*
        //# slider
        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs)
        {
            if(volumeSlider != null)
            {
                // 슬라이더의 값이 변경될 때마다 호출되는 이벤트 핸들러
                double volume = volumeSlider.Value;
                // volume 값을 사용하여 음량 조절 등의 작업 수행
                MessageBox.Show($"현재 음량: {volume}");
            }
        }
        */
        private void volumeSlider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            List<string> selectedFruits = new List<string>();

            if(checkBoxApple.IsChecked == true)
            {
                selectedFruits.Add("사과");
            }/*
            else if (checkBoxbanana.IsChecked == true)
            {
                selectedFruits.Add("바나나");
            }
            if (checkBoxApple.IsChecked == true)
            {
                selectedFruits.Add("사과");
            }
            if (checkBoxApple.IsChecked == true)
            {
                selectedFruits.Add("사과");
            }*/
        }
    }
}

#region #1. Tab Control
/*
 *  - 웹 브라우저 처럼 탭 버튼을 눌러 다른 내용의 화면 전환.
 *  
 *  1) TabControl
 *  - 전체 탭 컨테이너
 *  - 내부의 여러개 TabItem을 가질 수 있음
 *  
 *  2) TabItem
 *  - 각각의 탭을 나타내는 항목
 *  - Header : 탭 제목
 *  - Content : 보여줄 컨텐츠(UI) 배치
*/
#endregion

#region #2. StackPanel
/*
 * - 자식 요소들을 수직 (Vertical) 또는 수평(Horizontal)방향으로 자동으로 정렬해서 배치하는 레이아웃 패널
 * - 요소들을 순서대로 쌓음
 * - 마우스 조작으로 요소이동 불가
 * 
 * [속성]
 * - Orientation : 쌓는 방향 설정 (Vertical(기본) , Horizontal)
 */

#endregion

#region #3. Grid
/*
 * - 행과 열을 나누어서 엑셀 표처럼 UI요소를 격자(Grid) 구조로 배치할 수 있는 레이아웃 패널
 * [속성]
 * - RowDefinition : 행을(가로줄) 만듬
 * - ColumnDefinition : 열을(세로줄) 만듬
 * 
 * [Height / Width]
 * - Auto : 내부요소의 크기에 맞게
 * - * : 남은 공간을 비율로 자동 분배
 * - 숫자(px) : 고정크기
 * 
 * When?
 * - 1) 요소들이 표형태로 정리 되어야할때
 * - 2) 요소들이 정확한 위치에 있어햐 할때
 * - 3) 반응형 비율 기반 배치가 필요할때
 */
#endregion

#region #4. TextBlock
/*
 * - 텍스트를 화면에 출력해주는 WPF 가장 기본적인 텍스트 표시용 컨트롤
 * - 화면 읽기 전용 텍스트를 표시할 때 사용
 * - 사용자가 직접 입력x
 */
#endregion

#region #5. GroupBox
/*
 * - 여러 개의 UI요소를 하나의 그룹으로 묶어주고, 그 그룹에 제목(label)을 붙일 수 있는 컨테이너
 * ㄴ 관련된 항목들을 시각적으로 묶어 표현할 때 사용
 */
#endregion

#region #6. RadioButton
/*
 * [속성]
 * - GroupName
 * ㄴ 여러개의 라디오 버튼이 서로 다른 그룹으로 동작하도록 구분하는 속성
 * ㄴ 같은 GroupName을 가진 버튼들 끼리는 서로 하나만 선택 가능
 * ㄴ 다른 GroupName을 부여하면 동시 선택 가능
 * 
 * Checked
 * - 라디오 버튼이 선택 될때 연결되는 이벤트 핸들러
 * 
 * IsChecked
 * - 현재 라디오 버튼의 선택 상태를 나타내는 속성
 */
#endregion



#region #7. Slider
/*
 * - 사용자가 드래그하거나 클릭해서 숫자 값을 조절 할 수 있도록 해주는 입력 컨트롤
 * - ex) 음량 조절, 밝기 조절, 비율 조절 등
 * 
 * [속성]
 * - Minimum : 최소(기본값 0)
 * - Maximum : 최대(기본값 10)
 * - Value : 현재 값(기본값은 0)
 * - Orientation : 방향 설정
 * - TickFrequency : 눈금 간격 설정
 * - IsSnapToTickEnabled : 눈금에 맞춰서 이동할지 여부 설정
 * - Ticks : 눈금 표시 여부 설정
 * ㄴ false(기본값) : 눈금 표시 안함
 * - tickplacement
 */
#endregion

#region #8. Check Box
/*
 * - 여러개의 항목을 복수 선택 가능하게 할 때 사용
 * 
 * [속성]
 * - IsChecked : true/false/null 값을 가지는 bool타입 / 체크 여부를 나타냄
 * - Checked : 체크 되었을 때 발생하는 이벤트
*/
#endregion