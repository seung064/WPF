using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_07_switch
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        #region 실습 switch 문(요일)
        //사용자는 요일을 입력할 수 있음


        //사용자가 요일 이외의 문자열을 입력하면 오류를 출력


        // 각 요일 별로 재미난 메시지를 화면에 출력
        // ex) 월요일 입력 : "심근경색, 월요일 아침이 가장 위험! 출근을 안 해야..."




        // 스코프 제한 때문에 private void input_button_Click 에 들어가지 않음
        // 클래스 범위나 네임스페이스 범위에서 선언
        enum weekday // 요일을 정의하는 열거형 / enum + 이름
        {
            월요일,
            화요일,
            수요일,
            목요일,
            금요일,
            토요일,
            일요일
        }

        //텍스트박스의 내용이 바뀔 때 발생하는 이벤트
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // 버튼을 누를 때마다 발생하는 이벤트
        private void input_button_Click(object sender, EventArgs e) // 버튼을 누를 때마다 발생하는 이벤트
        {
            string input = textBox_input.Text; // textBox_input에 입력된 문자열을 input에 저장 

            weekday day; // 열거형 변수 day 선언

            string[] days = { "월요일", "화요일", "수요일", "목요일", "금요일", "토요일", "일요일" }; // 요일을 배열로 저장

            if (!days.Contains(input))
            {
                MessageBox.Show("오류");
                return;
            }

            // 지역변수로 쓰이는걸 막고 / Enum.Parse 메서드를 사용하여 input에 입력된 문자열을 weekday 열거형으로 변환 
            day = (weekday)Enum.Parse(typeof(weekday), input);
            // (enum타입)Enum.Parse(typeof(열거형), 문자열)
            //Enum.Parse 는 입력받은 값을 weekday.input 으로 변환하고 day에 저장함

            string message; // 메시지를 저장할 변수
            switch (day) // 요일에 따라 다른 메시지 출력
            {
                case weekday.월요일: // case + 열거형.값
                    message = "심근경색, 월요일 아침이 가장 위험! 출근을 안 해야...";
                    break;

                case weekday.화요일:
                    message = "심근경색, 화요일 아침이 가장 위험! 출근을 안 해야...";
                    break;

                case weekday.수요일:
                    message = "심근경색, 수요일 아침이 가장 위험! 출근을 안 해야...";
                    break;

                case weekday.목요일:
                    message = "심근경색, 목요일 아침이 가장 위험! 출근을 안 해야...";
                    break;

                case weekday.금요일:
                    message = "심근경색, 금요일 아침이 가장 위험! 출근을 안 해야...";
                    break;

                case weekday.토요일:
                    message = "토요일, 자유다";
                    break;

                case weekday.일요일:
                    message = "일요일, 월요병 벌써 온다";
                    break;

                default:
                    message = "오류";
                    break;
            }

            textBox_result.Text = message;
        }

        /*


enum week // 요일을 정의하는 열거형 / enum + 이름 / 이름은 하나의 자료형이 될 수 있음
        {
            월요일,
            화요일,
            수요일,
            목요일,
            금요일,
            토요일,
            일요일
        }







private void button_input2_Click(object sender, EventArgs e)
        {
            Week week = InputCheck(textBox_input.Text); // Week.Monday 반환.

            switch (week)
            {
                case Week.Monday:
                    textBox_result.Text = "심근경색, 월요일이 가장 위험, 출근은 안 해야..";
                    break;
                case Week.Tuesday:
                    textBox_result.Text = "뭔가 모를 힘듦.";
                    break;
                case Week.Wednesday:
                    textBox_result.Text = "시작이 반이다.. 반왔다.";
                    break;
                case Week.Thursday:
                    textBox_result.Text = "금요일인 줄 착각했다가 억장 무너지는 날";
                    break;
                case Week.Friday:
                    textBox_result.Text = "오늘은 신나는 기분이야 ╰(*°▽°*)╯";
                    break;
                case Week.Saturday:
                    textBox_result.Text = "기분 최고조";
                    break;
                case Week.Sunday:
                    textBox_result.Text = "현실 부정";
                    break;
                case Week.Error:
                    textBox_result.Text = "요일이 뭔지 모르시나보군요?";
                    break;
            }
        }

        // 유효성 검사.
        Week InputCheck(string message) // 내가 입력 input 글자.
        {
            switch (message)
            {
                case "월요일":
                    return Week.Monday;
                case "화요일":
                    return Week.Tuesday;
                case "수요일":
                    return Week.Wednesday;
                case "목요일":
                    return Week.Thursday;
                case "금요일":
                    return Week.Friday;
                case "토요일":
                    return Week.Saturday;
                case "일요일":
                    return Week.Sunday;
                default:
                    return Week.Error;
            }
 */
        #endregion



    }
}

