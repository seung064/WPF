using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_02_array
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
             //#1. 배열
             // 같은 자료형 변수 여러개를 하나의 배열로 처리
             // 한번에 여러 값을 저장 가능
             // int num1, num2 ... 반복작업 + 변수값 할당 필요
             int[] nums = new int[8]; // 정수형 8개를 저장할 수 있는 배열
             // 구조
             // 배열의 이름 = nums
             // 자료형 : int[] -> 정수형배열
             // 배열 선언 및ㄹ 메모리 공간 확보 : nums = new[8]
             //ㄴ 8개 짜리 공간을 만듬
             // 배열의 요소(아이템) : 배열 안에 있는 데이터 하나하나
             // 배열의 위치(인덱스) : 0부터 시작
             // 배열의 길이(크기) : 요소의 개수와 동일

             //입력되는 데이터의 크기를 알 수 없을 때, 배열로 처리
             int inputCount = 10;
             int[] inputdata = new int[inputCount];
             //[20,0,0,0,0,0,0,0,0,0] 
             //배열의 각 요소에 접근, index는 0부터 시작
             inputdata[0] = 20;
             int oneOfData = inputdata[0]; // 20

             // 배열 할당 및 초기화
             int[] array1 = new int[5]; //=[0,0,0,0,0]
             int[] array2 = { 1, 2, 3, 4, 5, 6 }; //new int[6]과 유사

             // 2차원 배열(행과 열로 구성)
             //ㄴ 행 : 가로줄 , 열: 세로줄
             //ㄴ 배열안에 배열이 들어갈 수 있음
             // [,] -> 배열의 '모양'을 미리 정하는 표시 : 2차원 배열
             //{} -> 실제값을 넣는 방법
             int[,] multiArray1 = new int[3,2];
             int[,] multiArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };


             string[,] korean = new string[,]
             {
                 { "가", "나", "다"},
                 {"라","마","바" },
                 {"사", "아", "자" }
             };

             textBox1.Text = korean[0, 0];
             //가자 출력
             textBox1.Text = korean[0, 0] + korean[2, 2];
             // 3차원 배열에서 숫자 8출력
             int[,,] nums2 = new int[,,]
             {
                 {
                     { 1, 2,3 },
                     {4,5,6 },
                 },
                 {
                      { 7,8,9 },
                     { 10,11,12},
                 }
             };

             textBox2.Text = nums2[1, 0, 1].ToString();

             // 재그드(jagged) 배열
             // = 행마다 열 길이가 다름
             //[][] 중첩된 대괄호 사용
             // 첫번째 [] : 밖 배열
             // 두번째 [] : 안쪽 배열
             int[][] jaggedArray = new int[6][];
             // 행은 6으로 고정, 열은 자유로움
             jaggedArray[0] = new int[4] {1,2,3,4}; // 첫번째 줄 4개
             jaggedArray[1] = new int[3] {1,2,3}; // 두번째 줄 3개
            */


            string[][] classArray1 = new string[3][];
            classArray1[0] = new string[] { "이승민1", "이승민2" };
            classArray1[1] = new string[] { "이승민3", "이승민4", "이승민5" };
            classArray1[2] = new string[] { "이승민6" };

            textBox1.Text = $"1반 학생 목록 \r\n - {classArray1[0][0]}\r\n - {classArray1[0][1]}\r\n";
            textBox1.Text += $"2반 학생 목록 \r\n - {classArray1[1][0]}\r\n - {classArray1[1][1]}\r\n - {classArray1[1][2]}\r\n";
            textBox1.Text += $"3반 학생 목록 \r\n - {classArray1[2][0]}";
            //$은 문자열 보간 = {}안에 있는 값을 문자열로 치환해서 출력
            //textBox1.Text = "1반 학생 목록 :" + "\r\n" + "-" + jaggedArray1[0][0].ToString();
            //textBox1.Text = "1반 학생 목록 :" + "\r\n" + "-" + jaggedArray1[0][1].ToString();


            /*해설
            string[][] school_class = new stirng[3][]
            school_class[0] = new string[2] {"철희", "미애"}
            school_class[1] = new string[3] {"철수", "영미", "민수"}
            school_class[2] = new string[1] {"수빈"}


            textBox1.Text = "";
            textBox1.Text += "1반 학생 목록 : \r\n" 
            textBox1.Text += "-" school_class[0][0] + " \r\n"
            */
        }
    }
}
