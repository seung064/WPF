using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_05_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region ex)switch문
            /*
            • 동전 던지기(앞 면 또는 뒷 면) 함수를 작성
            1. 함수 이름을 적당하게 짓기
            2. 출력 자료형은 bool
            3. 입력은 bool 형 1개
            4. “난수 생성”을 검색하여 난수 생성 방법을 학습하고 int형 난수를 생성
            5. 생성된 난수와 % 연산을 이용, 연산 결과로 0 또는 1만 값이 나오도록 작성
            6. 입력 값과 연산 결과를 비교하여 둘이 같으면 true를 반환, 다르면 false를 반환
            • 1 = true, 0 = false 라고 가정
            • 함수에 true 또는 false를 입력하고 반환된 결과에 따라 “승리” 또는 “패배”로
            TextBox에 표시

            */

            if (coin())
            {
                textBox1.Text = "승리";
            }
            else
            {
                textBox1.Text = "패배";
            }





        }
      


        bool coin()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(); //난수 생성
            int result = randomNumber % 2; // 0 or 1

            if( result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
