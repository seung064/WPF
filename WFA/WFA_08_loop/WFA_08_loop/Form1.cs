using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WFA_08_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region 반복문 강의

            #region #1. 일반 반복문 강의 & 예제
            /*
            어떤 코드를 정해진 횟수만큼 반복 실행할 때 사용
              
            구조
            for (초기식; 조건식; 증감식)
            {
                반복할 코드
            }

            초기식 : 변수 선언 or 초기화
            조건식 : 반복할 조건 -> true면 계속 실행
            증감식 : 변수 값을 변화시켜 반복 실행 제어 -> ++/--
            */

            //ex1) 0-5 출력
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i); // i를 줄바꿈으로 출력
            }

            Console.WriteLine("------------------------------");

            //ex2) 5-1출력
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i); // i를 줄바꿈으로 출력
            }

            Console.WriteLine("------------------------------");

            //ex3) 1-n까지의 합
            int n = 10;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i; // = sum += i;
                Console.WriteLine("현재 i의 값 :" + i + "\r\n" + "현재합계 :" + sum + "\r\n");
            }

            Console.WriteLine("------------------------------");

            // Quiz 1~20 중에 짝수 일 때의 합 구하기
            // Hint 1) 1- 20까지 숫자를 반복
            // hint 2) 현재 반복 숫자가 짝수라면 (변수)에 더하기
            // hint 3) for문 안에 if문 조합을 해보세요

            int num = 20;
            int sums = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sums += i;
                }
                else
                { sums += 0; }

            }
            Console.WriteLine(sums);


            Console.WriteLine("------------------------------");

            /*
             * Quiz2)
             * 1부터 100까지의 수중
             * 3의 배수이지만 5의 배수는 아닌 수" 만 모두 출력,
             * 마지막에 그 개수와 총합 출력
             * */

            int d = 100;
            int count = 0;
            for (int i = 1; i <= d; i++)
            {
                if (i % 3 == 0 && !(i % 5 == 0))
                {
                    Console.WriteLine(i);
                    count++;               // 개수 증가
                    sum += i;              // 총합에 더하기
                }
            }
            Console.WriteLine($"개수 : {count}");
            Console.WriteLine($"총합 : {sum}");


            Console.WriteLine("------------------------------");

            //ex4) 중첩 for문
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }

            Console.WriteLine("------------------------------");

            // Quiz 3) 구구단 2단부터 9단까지 출력
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i}x{j}={i * j}");
                }
            }

            Console.WriteLine("------------------------------");


            // Quiz 4) 별찍기
            // *이 4개 까지 반복
            for (int i = 1; i <= 4; i++) // i가 칸수
            {
                for (int j = 3; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++) //j가 별수
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------");

            //Quiz 5) 별 찍기 lv.2
            // 피라미드식
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 3; j >= i; j--) // 공백출력
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                for (int j = i; j <= 3; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------");



            #endregion
            #region #2. 배열 반복문 강의 & 예제
            /*
            * 배열 - 반복문을 사용하는 이유
            * ㄴ 하나하나 출력하기에 너무 비효율적
            * */

            // before
            string[] fruits = { "사과", "바나나", "포도", "딸기" };
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);
            Console.WriteLine(fruits[3]);
            Console.WriteLine("------------------------------");

            // after
            string[] fruits2 = { "사과", "바나나", "포도", "딸기" };
            for (int i = 0; i < fruits2.Length; i++)
            {
                Console.WriteLine(fruits2[i]);
            }

            Console.WriteLine("------------------------------");
            // foreach 문 사용
            // 배열의 모든 항목(요소)을 "처음부터 끝까지 하나씩" 꺼내며 반복 실행하는 문법
            // 배열을 순회하면서 각 요소에 대해 "동일한 작업"을 수행할 때 사용
            // "순서가 있는 구조 반복"에 적합

            /*foreach문 = foreach(자료형 변수명 in 배열이름)
            {
                배열의 항목 하나씩 사용
            }
            */

            //ex1) 위 예제 foreach 버전
            string[] fruits3 = { "사과", "바나나", "포도", "딸기" };
            foreach (string fruit in fruits) // fruit라는 변수를 선언 + fruits의 값을 순서대로 받아옴
            {
                Console.WriteLine(fruit);
              }

            Console.WriteLine("------------------------------");

            //ex2) for문 버전
            int[] scores = { 85, 90, 78, 92, 88 }; // 배열크기는 5

            int sum4 = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                sum4 += scores[i];
            }
            double average = (double)sum4 / scores.Length;

            Console.WriteLine("총합 : " + sum4);
            Console.WriteLine("평균 : " + average);


            Console.WriteLine("------------------------------");

            //Quiz1)
            //ex2를 foreach로 바꾸기
            int[] scores1 = { 85, 90, 78, 92, 88 };
            int sum5 = 0;
            foreach (int score in scores1)
            {
                sum5 = sum5 +score;
            }
            double average1 = (double)sum5 / scores1.Length;

            Console.WriteLine("총합 : " + sum5);
            Console.WriteLine("평균 : " + average1);

            Console.WriteLine("------------------------------");

           

        }

        /*
        예제

        • 가짜 성적표 만들기 
        1. 학생수를 입력
        2. 입력된 학생 수 만큼 0~100점 사이의 랜덤한 점수를 생성하고 각 학생
        에게 점수를 할당
        3. 학생의 이름은 “학생1”, “학생2”, ... 와 같이 숫자만 붙여서 표기
        4. 모든 학생에 대해 “학생1의 점수: 42점” 과 같은 형태로 결과를 표시
        • 이름과 성적을 입력하면 위와 같은 문자열을 만들어주는 함수를 작성하여 사용
         */
        //학생수 입력받음
        private void button1_Click(object sender, EventArgs e) 
        {
            //버튼을 누를때마다 폼 초기화
            textBox_result.Text = ""; // 결과창 비우고 시작

            //난수 생성기(객체) 생성
            Random rand = new Random();
            int studentCount = 0; // 학생수 초기화

            // 입력값을 숫자로 변환

            bool success = int.TryParse(textBox_input.Text, out studentCount);

            if(success)
            {
                // 학생명 이라는 학생수 만큼의 배열공간
                string[] studentNames = new string[studentCount];

                // 학생 점수라는 학생수 만큼의 배열공간
                int[] studentScore = new int[studentCount];

                for(int i=0; i < studentCount; i++)
                {
                    // 학생 이름을 배열에 저장
                    studentNames[i] = $"학생{i + 1}";
                    // 학생 점수를 랜덤으로 생성하여 배열에 저장
                    studentScore[i] = rand.Next(0, 101); // 0-100점 / rand.Next는
                    // 결과 출력
                    textBox_result.Text += $"{studentNames[i]}의 점수 : {studentScore[i]}점\r\n";
                }
            }
            else
            {
                MessageBox.Show("숫자입력"); // 예외처리
            }



        }








    }

        /*
        해설
        1. 학생수 입력 받고(클릭)

        private void button1_Click(object sender, EventArgs e)
        {
            7. 결과창 비우고 시작
            textBox_result.Text = **;

            
            2. 숫자를 입력했을 때, 실행 :
            난수 생성
            Random rand = new Random();
            int studentCount = 0;

            bool success = int.TryParse(textBox_input.Text, out studentCount); // true / studentCount: 10 저장

            //int.TryParse(string 입력값, out 변수명(number))
            //사용자 입력이 숫자인지 안전하게 확인해주는 메서드
            // 문자열을 숫자로 변환할 때, 변환이 가능한 경우에만 값을 저장하고, true를 반환
            // 변환에 실패하더라도 오류를 발생시키지 않고 false를 반환함.
            // 문자열을 int로 바꿔보려고 시도해서, 성공하면 그 값을 number 저장하고 true를 반환한다
            // tryParse()는 성공여부와 변환된 값을 동시에 반환해야 하기 때문에 두개의 값을 반환해야함
            // 그래서 bool은 리턴값, 정수 결과는 out키워드를 사용해서 바깥변수에 저장하는 구조

            if(success)
            {
                //3. 학생명(이름)을 담는 그릇 (입력된 학생 크기만큼 배열 공간 확보)
                string[] studentNames = new string[studentCount]
                
                //4. 학생 점수를 담는 그릇
                int[] studentScore = new int[studentCount];
                
                for(int i = 0; i < studentCount; i++)
                {
                    studentNames[i-1] = $"학생{i}";
                    studentNames[i-1] = read.Next(0,101) // 0-100점
                
                    textBox_result.Text +=
                }
                
            }
            else
            {
                textBox_result.Text = " 예외처리"
            }
        }
        //5. 결과 출력문 함수 선언
        string CombieNamAndScore(string name, int score)
        {
            
        }

        */



        #endregion
        #endregion
    }

