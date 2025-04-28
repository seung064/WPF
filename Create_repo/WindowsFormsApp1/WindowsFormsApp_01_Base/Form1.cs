// # 기본 구조파악

// using 키워드 : namespace를 가져온다는 의미
//네임스페이스란 여러클래스들을 논리적으로 묶은 공간


using System;
// 가장 기본적인 .net 네임스페이스,.console, math 등 자주 쓰이는 클래스들이 포함되어 있음 
using System.Collections.Generic;  
using System.ComponentModel; 
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; //문자열 네임스페이스
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_01_Base //프젝이름
{
    public partial class Form1 : Form
    //Form1이라는 이름의 클래스, Form에서 상속받음
    //.net에서 제공하는 기본 윈도우 창인 form클래스를 상속받아 윈도우 창의 기본동작과 속성을 물려받음
    //ㄴ partial : 이 클래스는 코드가 여러파일로 나눠져 있음을 의미
    {
        public Form1()
        //Form1 클래스의 생성자
        {
            InitializeComponent();
        //폼에 포함된 UI요소들을 초기화하는 메서드 호출
        //버튼, 텍스트박스등 디자인 도구에서 만든 컨트롤들을 실제로 생성하고 속성 설정하는 코드들이 있음
        //폼이 실행될 때, 꼭 호출되어야 윈도우 폼이 제대로 보임
        }
    }
}
