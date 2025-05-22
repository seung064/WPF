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

namespace WPF_Advanced
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // [1] Resource 초기 이미지 설정
            imgTest.Source = new BitmapImage(new Uri("Assets/11.png", UriKind.Relative)); // 소스에는 이미지 객체만 들어감 / 이미지 객체를 만들어 Uri에 담아줘야함
            /*
             * new Uri(..) - 이미지 파일의 경로를 Uri 객체로 만듬
             * 
             * UriKind.? - .? 실행파일 기준으로 해석하겠다는 뜻
             * ㄴ Relative : 실행 파일 기준 경로
             * ㄴ Absolute : 전체 경로 명시
             * ㄴ RalativeOrAbsolute : 둘 중 맞는걸 자동 판별(거의 안씀)
             * 
             * new BitmapImage(...) - Uri를 통해 실제 이미지 객체 생성
             */


            // [2] Content 초기 이미지 설정
            imgTest2.Source = new BitmapImage(new Uri("Assets/11.jpg", UriKind.Absolute));
        }

        //[1] Resource C# 버전
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imgTest.Source = new BitmapImage(new Uri("Assets/11.png", UriKind.Relative));
        }

        // [2] Content C# 버전
        private void Btn_Content_Click(object sender, RoutedEventArgs e)
        {
            // 실행 디렉터리에 복사된 이미지 경로
            string path = "Assets/test3.png";
            imgTest2.Source = new BitmapImage(new Uri(path, UriKind.Absolute));
        }
    }
}

#region #1. Image
/*
 * WPF에서 사진, 아이콘, 일러스트 등 Bitmap 기반 이미지 리소스를 렌더링 할 때 사용하는 UI컨트롤
 * 내부적으로는 System.Windows.Controls.Image 클래스
 * 
 * [이미지 파일 관리] - 폴더에 모아서 관리
 * - Assets : 가장 보편적이고 시각적인 리소스 포함하는 느낌
 * - Images : 이미지 전용 폴더로 직관적.
 * 
 * [속성]
 * - Source : 표시할 이미지 경로 or URI
 * - Stretch : 이미지 크기 조정 방식(null, Fill, Uniform(기본 값), UniformToFill)
 * 
 */
#endregion

// [이미지 접근방식]

#region 1) Resource 방식
/*
 * 1) Resource 방식
 * - 이미지 파일을 실행 프로그램(.exe)에 포함시켜 배포하는 방식
 *  ㄴ 즉, 프로그램 안에 이미지가 "포함되어 있는" 형태라서 외부 파일을 따로 챙길 필요가 없음
 * - 수정은 불가능 하지만, 정적인 리소스(아이콘, 배경, 버튼 등)에 매우 적합함
 * 
 * [특징]
 * - 배포 간편
 * - 경로 문제 없음
 * - 유지보수가 용이
 * 
 * [방법]
 * - 솔루션 탐색기에서 이미지 추가
 * - 추가 이미지 선택 -> 속성
 *  ㄴ 빌드 작업(Build Action) => Resource로 설정
 * - 출력 디렉토리에 복사 : 필요 없음
 *  ㄴ 실행 파일이 생성되는 폴더에 이 파일을 같이 복사할 건지 설정
 *  ㄴ 복사하지 않으면 프로그램이 실행될 때 해당 파일을 찾을 수 없음
 * 
 * - XAML 또는 C# 코드에서 Source="파일명"으로 간단하게 이미지 사용 가능
 *  ㄴVS(visual studio) 프로젝트의 루트 기준 상대경로로 동작
 *  
 * [코드 작성]
 * [1] XMAL 버전
 * - 이미지가 바뀌지 않을 때, 즉 고정된 화면에 정적인 이미지를 보여 줄때
 * 
 * [2] C# 코드 버전
 * - 동적으로 이미지 제어할 때
 */
#endregion

#region 2) Content 방식
/*
 * - 이미지 파일을 실행 파일(.exe)이 있는 폴더에 복사해놓고, 거기서 직접 불러오는 방식
 * 
 * 
 * when?
 * - 사용자 이미지 업로드
 * 
 * [특징]
 * - 실행 파일 외부에 따로 존재하는 이미지
 * - 프로그램이 실행될 때 이미지 파일을 같이 복사해서 사용하는 구조
 * 
 * [방법]
 * - 이미지 추가
 * - 추가한 이미지 선택 -> 속성
 *  ㄴ 빌드 작업(Build Action) : Content
 *  ㄴ 출력 디렉토리에 복사 : Copy if newer(권장)
 *      ㄴ 그래야 실행 폴더(bin/...)에 같이 복사됨
 *      
 * [Copy to Output Directory]
 * - Do not copy : 복사안함
 * - Copy if newer : 새로고침 할때만 복사 (= 원본이 바뀌었을때)
 * - Copy always : 항상 복사
 * [
 */
#endregion

#region 3) Pack URI 방식
/*
 * - WPF 에서 Resource 방시으로 등록된 이미지 파일을 "정확하게 실별" 하고 로드 할 수 있게 해주는 전용 URI 방식
 * - WPF의 스타일, 리소스, 외부 DLL 등 다양한 곳에서 이미지와 리소르를 참조할 때 필수로 사용됨
 * 
 * [특징]
 * - Resource 방식 이미지에 대한 절대 경로 지정 가능
 * - 외부 DLL에 포함된 리소스도 접근 가능
 * - UriKind.Absolute 와 함께 사용됨(필수)
 * 
 * When?
 * - 외부 라이브러리(DLL)에 포함된 리소스 접근할 때
 * - C# 코드에서 Resource 이미지에 대해 명확한 식벽이 필요할 때
 * - 프로젝트 구조가 복잡하거나, 리소스 고유가 많을 때 안정적
 * 
 * [Pack URI 문법형식]
 * pack://application:,,,/[경로]
 * 
 * [방법]
 * 1. 이미지 추가 -> Resource 폴더, assets 폴더 등
 * 2. 속성에서 Build Action -> Resource
 * 3. 출력 디렉토리에 복사: 필요없음
 * 4. pack URI 사용해 이미지 로드
 * 
 */
#endregion