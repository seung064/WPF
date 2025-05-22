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

            // #10. 데이터 바인딩
            //[2] 데이터 리스트 생성
            List<Animals> animals = new List<Animals>()
            {
                new Animals { Name = "하마", Percent = 10 },
                new Animals { Name = "타조", Percent = 90 },
                new Animals { Name = "토끼", Percent = 50 }
            };

            // #10. 데이터 바인딩
            //[3] ListBox에 데이터 바인딩
            // - ListBox는 animals 리스트의 항목 개수만큼 줄을 ㅁ나들어 화면에 표시하게됨
            listBox.ItemsSource = animals;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 선택된 라디오 버튼 확인
            string result = "";

            if (radioMale.IsChecked == true)
            {
                result = "남성을 선택했습니다.";
            }
            else if (radioFemale.IsChecked == true)
            {
                result = "여성을 선택했습니다.";
            }

            MessageBox.Show(result);
        }

        private void radioMale_Checked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("남성을 선택", "라디오 선택 결과");
        }

        private void radioFemale_Checked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("여성을 선택", "라디오 선택 결과");
        }

        // # Slider 이벤트 - 실시간 값 변화
        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (volumeText != null)
            {
                volumeText.Text = $"현재 값: {volumeSlider.Value}";
            }
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            // 체크된 항목들을 문자열로 조합
            List<string> selectedFruits = new List<string>();

            if (checkBoxApple.IsChecked == true)
            {
                selectedFruits.Add("사과");
            }

            if (checkBoxBanana.IsChecked == true)
            {
                selectedFruits.Add("바나나");
            }

            if (checkBoxOrange.IsChecked == true)
            {
                selectedFruits.Add("오렌지");
            }

            // 결과 표시
            textResult.Text = $"선택한 과일: {string.Join(", ", selectedFruits)}";
        }

        private void checkBoxState_Click(object sender, RoutedEventArgs e)
        {
            bool? state = checkBoxState.IsChecked;

            if (state == true)
            {
                textStatus.Text = "현재 상태: 체크됨 (true)";
            }
            else if (state == false)
            {
                textStatus.Text = "현재 상태: 해제됨 (false)";
            }
            else
                textStatus.Text = "현재 상태: 중간상태 (null)";
        }

        private void comboFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 선택된 항목 가져오기
            ComboBoxItem selectedItem = comboFruits.SelectedItem as ComboBoxItem;

            // WPF에서 사용되는 모든 컨트롤 요소들은 전부 "클래스"
            // ex) comboBoxItem item = new ComboBoxItem();
            //      item.Content = "사과";

            // comboFruits.SelectedItem
            // - 사용자가 선택한 항목 가져오기
            // - 사용자가 선택한 항목(SelectedItem)에서 ComboBoxItem 타입의 객체가 됨

            // as연산자
            // - 안전하게 형변환 할 수 있게 도와주는 키워드
            // - 형변환에 실패하면 'null'을 변환

            // as ComboBoxItem
            // - 이 항목이 실제로 comboboxitem 타입인지 확인하고 맞으면 그타입으로 변환해서 selectedItem에 넣어준다

            if(selectedItem != null)
            {
                string selectedText = selectedItem.Content.ToString();
                // selectedItem은 comboboxitem 클래스의 인스턴스이다
                // 그안에 있는 Content 송성 => object 타입

                textResult2.Text = $"선택한 과일: {selectedText}";
            }


        }

        // #10. listBox이벤트
        private void listColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selected = listColors.SelectedItem as ListBoxItem;

            if (selected != null)
            {
                string selectedText = selected.Content.ToString();
                textSelected.Text = $"선택한 색상 : {selectedText}";
            }
        }

        // #10. 다중 선택
        private void lsitFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<string> selectedFruits = new List<string>();

            foreach (ListBoxItem item in listFruits.SelectedItems)
            {
                selectedFruits.Add(item.Content.ToString());
            }
            textSelected.Text = $"선택한 과일 : {string.Join(",", selectedFruits)}";
        }


        // #10. 데이터 바인딩
        //[1] 데이터 바인딩용 클래스 정의
        public class Animals
        {
            public string Name { get; set; }
            public int Percent { get; set; }

        }

        private void btnNaver_Click(object sender, RoutedEventArgs e)
        {
            WebBrowser1.Navigate("https://www.naver.com");
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (WebBrowser1.CanGoBack)
                WebBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if (WebBrowser1.CanGoForward)
                WebBrowser1.GoForward();
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
 * -> 입력은 TextBox에서 가능
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
 * ㄴ 특별한 위치에만 눈금이 필요 할 때
 */
#endregion

#region #8. Check Box
/*
 * - 여러 개의 항목을 복수 선택 가능하게 할 때 사용
 * 
 * [속성]
 * - IsChecked: true, false, null 값을 가지는 bool 타입 / 체크 여부를 나타냄
 * - Checked: 체크되었을 때 발생하는 이벤트
 * - UnChecked
 * - Indeterminate: 중간 상태일 때 발생하는 이벤트
 * - IsThreeState: true로 설정하면 중간 상태까지 허용 (기본값 : false)
 */
#endregion

#region #9. ComboBox
/*
 * - 드롭다운 목록에서 항목을 하나 선택할 수 있게 해주는 컨트롤
 * - 사용자는 미리 정의된 목록 중 하나를 선택하거나, 필요 시 직접 입력도 가능
 * -
 * 
 * [속성]
 * - Items : 콤보 박스에 표시할 항목 목록
 * - SelectedItem : 현재 선택된항목 객체(보통 문자열)
 * - SelectdIndex : 선택된 항목의 인덱스
 * 
 */
#endregion

#region #10. ListBox
/*
 * - 여러개의 항목들을 목록 형태로 나열해 보여주고
 *   사용자가 하나 또는 여러 개의 항목을 선택할 수 있도록 해주는 컨트롤
 * - ComboBox : 펼쳐지는 드롭다운 (공간 절약)
 * - ListBox : 펼쳐진 채로 보임 (한눈에 보기 좋음)
 * 
 * [속성]
 * - Item : 항목을 직접 추가할 수 있음
 * - ItemSource : 외부 데이터 리스트를 바인딩 할 수 있음
 * - SelectdItem : 현재 선택된 항목 (기본 단일 선택)
 * - SelectdItems : 다중 선택 모드에서 선택된 모든 항목들
 * - SelectionMode : 선택 방식 (Single, multiple, extended)
 * 
 * [이벤트]
 * - selectionChanged : 항목이 선택되거나 해제 될때 발생하는 이벤트
 */

/*
 * 데이터 바인딩 설명
 * 1) ItemSource
 * - Listbox, ComboBox 처럼 여러 항목을 보여주는 컨트롤에 데이터를 바인딩(연결) 해주는 속성
 * 
 * -> 역할 : 연결한 리스트의 각 항목이 ListBox 안에 자동으로 하나씩 표시됨
 * 
 * 2) ItemTemplate
 * - ListBox, ComboBox 등 목록 컨트롤에서 각 항목 하나를 어떻게 보여줄지 정의하는 템플릿
 * 
 * 3) DataTemplate
 * - ItemTemplate 속성
 * - ListBox에서 각 항목이 어떻게 보일지를 정의하는 템플릿
 * - 기본적으로 항목이 ToString() 값으로 표시되지만
     DataTemplate을 사용하면, 항목마다 원하는 UI요소(TextBlock, ProgressBar, Image 등)을 조합하여 보여줌

 * 4) {Binding Nmae}
 * - 바인딩된 데이터의 Name 속성 값을 UI에 표시.
 * 
 * 5) {Binding Percnet}
 * - 바인딩된 데이터의 Percent 값을 꺼내서 ProgressBar의 Value로 넣는 것
 */
#endregion

#region #11. Web Browser
/*
 * - WPF에서 제공하는 웹 페이지를 보여주는 컨트롤
 * - Internet Explorer (IE) 웹 엔진을 기바 (22년 이후로 지원중지)
 * 
 * - edge기반 WebView2를 사용하는것이 좋다
 * 
 * why?
 * - 프로그램 안에서 웹 페이즈를 가볍게 보여주고 싶을때
 * 
 * [속성]
 * -Navigate(string url) : 지정한 웹 주소로 이동
 * - GoBack() : 뒤로 이동
 * - Go
 */
#endregion