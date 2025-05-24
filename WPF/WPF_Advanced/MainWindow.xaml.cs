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


            // [2] Content 초기 이미지 설정 // 상대경로
            imgTest2.Source = new BitmapImage(new Uri("Assets/11.jpg", UriKind.Absolute));


            //[4-3] 데이터 실행
            LoadData();

            //[5-3]
            LoadData2();
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


        //[4-2] DataGrid 데이터 입력 메서드
        private void LoadData() 
        {
            List<Person> people = new List<Person>()
            {
                new Person(){Id =1, Name = "홍길동", Age = 30, IsActive = true},
                new Person(){Id =2, Name = "이길동", Age = 20, IsActive = true},
                new Person(){Id =3, Name = "김길동", Age = 10, IsActive = true},
            };
            myDataGrid.ItemsSource = people;
        }

        //[5-2] DataGrid 데이터 입력 메서드
        private void LoadData2()
        {
            List<Person> people2 = new List<Person>()
            {
                new Person(){Id =1, Name = "홍길동", Age = 30, IsActive = true},
                new Person(){Id =2, Name = "이길동", Age = 20, IsActive = false},
                new Person(){Id =3, Name = "김길동", Age = 10, IsActive = true},
            };
            myDataGrid2.ItemsSource = people2;
        }


    }

    // [4-1] DataGrid 외부 클래스 생성
    public class Person
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
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
 * 
 * [주의]
 * - WPF 에서는 Resource 파일 접근 시 반드시 Pack URI 형식 사용 권장
 * - XAML에서는 상대경로 처럼 보여도 내부적으로 Pack URI로 해석됨
 */
#endregion

#region 2) Content 방식
/*
 * - 이미지 파일을 실행 파일(.exe)이 있는 폴더에 복사해놓고, 거기서 직접 불러오는 방식
 * 
 * 
 * when?
 * - 대표 용도 : 설명 이미지, 문서, 동영상 등 실제 파일이 필요할 때
 *  ㄴ 실행중 수정 가능 -> 유저가 설정을 바꿀 떄 (ex. 게임 세이브 데이터 저장)
 *  ㄴ 용향 이슈/ 관리 용이성
 *      ㄴ Resource : 실행 파일 크기가 점점 커짐 - 메모리 할당량 증가
 *      ㄴ Content : 실행 파일이 가볍고, 메모리 사용도 가벼워짐 -> 파일은 옆에 따로 존재하므로
 *          ㄴ 유지보수 시 Content는 파일만 바꾸면 되므로 유리
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
 * 
 * 
 * 
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

#region # 보충설명
/*
 * [정리]
 * - 앱 개발자가 미리 넣어두는 이미지 -> 빌드 시 포함되어 배포 : Resource, Content
 * - 앱 실행 중 사용자 입력으로 생긴 이미지 -> 외부 경로에 저장(DB, 서버 등) : 절대 경로(UriKind, Absolute)
 * 
 * [Resource VS Content 차이 정리]
 * 
 * # Resource
 * - 빌드 결과 : 어셈블리 안에 내장됨
 * - 경로 접근 : pack://... URI 방식
 * - 파일 존재 위치 : 실행중에는 실제 파일 없음(메모리 상에 존재)
 * - 수정/삭제 : 불가능 (읽기 전용)
 * - 대표 용도 : 아이콘, UI 배경 이미지, 버튼 배경이미지 등 정적 리소스
 * 
 * # Content
 * - 빌드 결과 : 실행파일 옆에 복사됨
 * - 경로 접근 : 상대/절대 경로 방식
 * - 파일 존재 위치 : 실행 폴더에 파일이 있음
 * - 수정/ 삭제 : 가능
 * - 대표 용도 : 설명 이미지, 문서, 동영상 등 실제 파일이 필요할 때
 *  ㄴ 실행중 수정 가능 -> 유저가 설정을 바꿀 떄 (ex. 게임 세이브 데이터 저장)
 *  ㄴ 용향 이슈/ 관리 용이성
 *      ㄴ Resource : 실행 파일 크기가 점점 커짐 - 메모리 할당량 증가
 *      ㄴ Content : 실행 파일이 가볍고, 메모리 사용도 가벼워짐 -> 파일은 옆에 따로 존재하므로
 *          ㄴ 유지보수 시 Content는 파일만 바꾸면 되므로 유리
 *          
 *          
 * [Build Action vs UriKind]
 * - Resource, Content는 '파일의 빌드 방식'에 대한 설정
 * - UriKind는 해당 파일을 어떻게 접근할지에 대한 설정 방식 일뿐
 *      ㄴ 둘은 직접적인 관련이 없다
 *      
 * Resource - Pack URI(pack://...) 사용 => UriKind.Absolute (항상)
 * Content - 상대 / 절대 경로 사용 => Relative or Absolute 사용
 * (외부 파일) - 물리 경로 or URL => 보통 Absolute 사용
 * 
 * Why? 왜 Resource를 곡 Pack URI로 써야하는가?
 * - WPF는 .exe 안에 있는 리소스 파일을 찾을 수 있도록 Pack URi라는 전용 주소 체계를 사용하는 것
 * 
 * [@ 는 언제 사용하는가?] => 일반적으로 절대경로에서 사용
 * - 주요 용도 : 
 * - 이스케이프 시퀀스(문자) 무시!
 *  ㄴ 일반 문자열에서 \ 가 이스케이프 문자로 사용되어 \n(줄바꿈) \t(탭간격) 등 나타내고
       파일 경로에서는 \ 가 "경로 구분자"로 사용되기 떄문에 \\ 두번 입력해야하는 불편함이 있음
    ㄴ @를 사용함녀 \를 한번만 입력해도 됨
        = @가 붙은 문자열을 \를 이스케이프 문자로 해석하지 않고 문자 그대로 받아들여줌

 * 
 * 
 * - 이스케이프 문자란?
 * - 프로그래밍 언어나 텍스트 형식에서 "특수한 의미"를 가지는 문자를
    일반 문자처럼 취급, 특수 문자를 표현하기 위해 사용되는 문자
 * - 보통 백슬래쉬와 함께 사용되며 일련의 이스케이프 시퀀스를 만듬
 * 
 * => 즉, 문자열 내에서 특수문자를 표현하기 위해,
 *  ㄴ "" 가 문자열의 시작과 끝을 나타내듯이
 *  ㄴ \ 도 추력시 특별한 동작을 지시하기 위해서 사용 : \t \r \n
 *  
 *  - C# 개발이 Windows 환경에 익숙하기 때문에.
 *    보통 탐색기나 프로그램에서 파일 경로를 복사해옴
 *    => 기본적으로 \(백슬래시)로 돈 경로가 제공됨
 *    
 *  - 이걸 개발자들은 보통 그대로 코드에 붙여넣기 때문에 @를 붙이는 것이 가장 빠르고 익숙한 방법
 *    
 */
#endregion

#region #2. DataGrid
/*
 * - 데이터를 표(테이블) 형태로 표시하고 조작할 수 있는 유연한 컨트롤
 *  ㄴ 엑셀처럼 행/열이 있는 표 형식의 UI
 * 
 * [특징]
 * 1) 데이터 바인딩
 *  ㄴ ItemsSource 속성을 사용하여 컬렉션(예: List<T>)에 바인딩하면,
 *     해당 컬렉션의 데이터가 자도으로 DataGrid에 표시됨
 * 2) 컬럼 자동/수동 생성 가능
 * 3) 정렬/필터/스크롤 등 기본적인 테이블 기능 지원 --> 검색 및 구현
 * 
 * when?
 * - 테이블 목록을 표 형식으로 보여줄 때
 * - 테이블 데이터를 수정하거나 삭제할 때
 * 
 * [속성]
 * - ItemSource : 보여줄 데이터 목록 - 데이터 바인딩용 컬렉션
 * - AutoGenerateColumns : 자동으로 컬럼(열) 생성 여부 (true/false) - 기본 값 : true
 * 
 * [편집 관련 속성]
 * - CanUserAddRows : 사용자가 직접 행 추가 가능 여부 - 기본 값 : true
 *  ㄴ 빈 행에 데이터를 입력하면, 새로운 데이터 항목이 DataGrid의 ItemsSource 컬렉션에 자동으로 추가 됨
 * - CanUserDeleteRows : 사용자가 직접 행 삭제 가능 여부 - 기본 값 : true
 * - CanUserSortColumns : 컬럼 정렬 허용 여부 - 기본 값 : true
 * - IsReadOnly : DataGrid 전체를 읽기 전용으로 설정 - 기본 값 - false
 * - IsReadOnly (컬럼 속성명) : 특정 컬럼만 읽기 전용 설정
 * 
 * 
 * [컬럼 생성방식]
 * - 1) AutoGenerateColumns - true:자동 / false:수동
 *  ㄴ 바이딩된 객체의 속성을 기반으로 컬럼 자동 생성! = 개발 시간 크게 단축
 *  ㄴ string, int -> TextColumn / bool -> CheckBoxColumn 자동 매핑
 *  ㄴ 빠르게 개발 가능
 *      but, 열 순서/ 헤더명/ 스타일 제어 어려움
 *          ㄴ 속성명이 그대로 나옴
 *  
 * - 2) false: 수동
 *  ㄴ <DataGrid.Columns> 요소들을 수동으로 작성해 컬럼 구성
 *  ㄴ 열의 순서, 너비, 헤더 이름 등을 명확하게 설정 가능
 *  ㄴ 텍스트 외에도 CheckBox, ComboBox 등 다양한 형태 사용가능
 *  
 * 
 * 
 * [사용자 정의 컬럼 속성 종류] - DataGrid.Columns 내부에서 사용
 * - DataGridTextColumn : 일반 텍스트 데이터를 표시하고 편집 - Binding 속성으로 데이터 원본의 속성을 지정
 * - DataGridCheckBoxColumn : bool 타입의 데이터를 체크박스로 표시
 * - DataGridComboBoxColumn : 드롭다운 선택 컬럼
 * - DataGridTemplateColumn : 셀의 내용을 원하는 WPF 컨트롤로 구성가능(버튼, 이미지 등 삽입 가능) - 가장 유연한 컬럼 타입
 *
 *
 * [행 선택 및 데이터 접근 관련 속성]
 * - SelectionMode : 단일/다중 선택 설정(single / extended)
 *  ㄴ single : 단일 행만 선택 가능
 *  ㄴ Extended : Shift/Ctrl 키 사용하여 다중 행 선택 가능
 *  
 * - SelectionUnit:
 *  ㄴ Cell : 셀 단위로 선택
 *  ㄴ FullRow : 행 전체를 선택 (가장 일반적)
 *  
 * - SelectedItem : 현재 선택된 단일 항목을 가져옴 ( 단일 선택 모드)
 * - SelectedItems : 현재 선택된 모든 항목의 컬렉션 가져옴 (다중 선택 모드)
 * - SelectedIndex : 현재 선택된 항목의 인덱스 가져옴
 */
#endregion