using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFA_04_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*실습.함수
• 아래 내용을 참고하여 적당한 이름의 함수를 구현
1. int 형 숫자 두 개를 입력 받기
2.첫 번째 입력 값을 두 번째 입력 값으로 나눔
3.나눠진 값은 배열의 첫 번째 요소에 저장
4.나머지 값은 배열의 두 번째 요소에 저장
• 나머지 연산은 % 를 이용(필요시 검색)
 5.위 배열을 반환
1.Form1()에서 위 함수를 사용하고 TextBox에 결과 값을 출력
2.결과를 push 하고 Repo.링크를 슬랙 댓글로 제출*/

            /*
            //함수 실행
            int num = 200;
            int result = Add(100, num);
            */


            /*
                        int[] nums = Add(48, 8);
                        // textBox1.Text = "몫 :" + nums[0].ToString() + "\r\n" + "나머지 : " + nums[1].ToString();
                        textBox1.Text = "몫 : " + nums[0].ToString() + "\r\n";
                        textBox1.Text += "나머지 : " + nums[1].ToString() + "\r\n";
            */

            string[,] data = new string[,] {
                {"홍길동", "포도", "복숭아", "바나나"},
                {"아무개", "사과", "수박", "오렌지"},
                {"손오공", "바나나", "사과", "오렌지" }
            };

            data[0,3] = data[0,3].Replace("바나나", "바나나(유기농)").ToString();
            data[2,1] = data[2,1].Replace("바나나", "바나나(유기농)").ToString();
            data[,1] = data[2,1].Replace("바나나", "바나나(유기농)").ToString();
            data[2,1] = data[2,1].Replace("바나나", "바나나(유기농)").ToString();
            data[2,1] = data[2,1].Replace("바나나", "바나나(유기농)").ToString();
            data[2,1] = data[2,1].Replace("바나나", "바나나(유기농)").ToString();
            data[2,1] = data[2,1].Replace("바나나", "바나나(유기농)").ToString();
            
           
            

        textBox1.Text = data[0, 3] + ":" + data[0, 1] + "/";




        }


        //함수
        //-특정 작업을 수행하기 위해 독립적으로 설계된 코드 집합

        //구조
        //자료형 : 이함수가 돌려준 값(return값)의 타입
        // -add 함수명
        // int , int y = parameter
        // 함수 선언시 함수가 받아야하는 입력값(매개변수)
        // 함수에 전달되는 외부데이터
        // 용어 정리
        // 함수 정의(선언) = 함수를 생성
        // 함수 호출 = 함수를 사용

        // return = 반환값
        // 함수 내부코드의 최종 결과값
        // 함수 본문에서 최종 결과를 저장하고 돌려주는 키워드 
        // return 키워드를 만나면 함수 실행 중단

        /*함수 선언
        //return 값이 있는 함수
        int Add(int x, int y)
        {
            return x + y;
        }

        //#2. return 없는 함수
        // void

        void Nothing()
        {
            textBox1.Text += "Nothing";
        }
        */
/*
        int[] Add(int x, int y)
        {
            int divide = x / y;
            int remainder = x % y;

            return new int[] { divide, remainder };
        }
*/
        




    }
}
