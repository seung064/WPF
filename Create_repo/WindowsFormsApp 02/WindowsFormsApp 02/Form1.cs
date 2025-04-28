using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
namespace WindowsFormsApp_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            //변수의 선언
            int numOfCrew;

            //변수의 사용(값 복사)
            numOfCrew = 19;

            // 변수의 초기화
            string className = "말하기";

            //변수의 값 덮어쓰기
            className = "수학";

            //선언보다 밑에 줄에서 사용 가능
            //LineCount= 10; (x)
            int lineCount;

            // 같은 이름 사용 불가 (선언 시)
            byte buffer;
            //float buffer;

            //데이터 타입이 완전히 다르면 복사 불가
            int number = 10;
            string word = " 안녕 ";


            // number = word; (x)

            // 같은 형식에서 데이터 타입의 크기에 따라 복사 가능 or 불가능
            short word2 = 20;

            //int > short 더 큰 범위의 데이터 타입
            number = word2; // 자료형이 다르지만, 복사가능

            //변수끼리 값 복사(ㅇ)
            int var_x = 10;
            int var_y = var_x; // x-> y 로 복사

            // 사칙연산 및 괄호 활용
            int var_z = var_x * var_y;
            int result = var_z + (var_x + 5);

            //scope가 다르면 사용이 불가능(x)
            {
                int inside = 100;
            }
            // inside와 scope 가 달라서 사용불가
            // 
            test1.text = numOfCrew.GetType() + "numOfCrew" + numOfCrew.ToString() + "/r/n";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

// 연산자.
/*
 * 대입 연산자(=)
 * :변수에 값을 "할당" 할때 사용하는 연산자
 * 
 * 산술 연산자
 * 사칙연산
 * 나머지 연산 = %
 * 거듭제곱 : Math.Pow() 메서드
 */

//int a = 5;
//int b = 2;

//textbox 컨트롤은 "사용자에게 텍스트(문자열)"을 보여주기 위한 도구
//textbox.text의 자료형이 string(문자열)임
//textbox1.text = a.ToString();
//ㄴ숫자를 바로 넣을 수 없음

//#1. 형변환 방법
//Textbox1.text = (a+b).tostring()

//#2. 문자열 보간 방법
//#"{표현식}" 형태
//ㄴ 안에 있느 코드를 계산하고 자동으로 문자열을 만들어줌
//ㄴ 깔끔하고, 가독성이 좋아서 요즘 자주 사용
/*
 * textbox1.text += $"{a- b \r\n";
textbox1.text += $"{a/b \r\n";
textbox1.text += $"{a*b \r\n";
textbox1.text += $"{a+%b \r\n";

// C#에서의 거듭제곱;
    ㄴ 문법적으로 **연산자가 존재하지않음
    ㄴ Math.Pow() 라는 메서드로 사용
    ㄴ Math.Pow(밑,지수) 형태 
    ㄴ결과는 항상 double로 반환
    textbox1.text += $"{Math.Pow(a,b)} \r\n";
// 제곱근 :
    Math.Sqrt() 사용
    textbox1.text += $"{Math.Pow(c)} \r\n";

// 비교연산자
    #1. 동등 비교 : 같다 / 같지않다
    textbox1.text += $"{1==1} \r\n"; //true
    textbox1.text += $"{1==2} \r\n"; //false
    textbox1.text += $"{1!=1} \r\n"; //fa
    textbox1.text += $"{1!=2} \r\n"; //t

    #2. 크기 비교
    textbox1.text += $"{2>1} \r\n"; //t //$ = 문자열 보간
    textbox1.text += $"{2>=2} \r\n"; t
    textbox1.text += $"{2<1} \r\n"; f
    textbox1.text += $"{2=<2} \r\n"; t

//논리연산자
    !: not(참-> 거짓, 거짓-> 참)
    $$ : and
    \\ : or

//후위증강(postfix)
    - 변수를 먼저 사용하고 , 이후에 1증가/감소함
    result = num++;

//전위증강(prefix)
    result2 = ++num2;
    textbox1,text = result2.tostring() + "\r\n"; //11

// 연산자 줄여쓰기
    +=, -=



*/
namespace WindowsFormsApp_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string apple = "사과";
            int price = 3000;
            int count = 5;

            price *= count;
            

            textBox1.Text = apple.GetType() + "apple" + price.ToString() + "/r/n";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

