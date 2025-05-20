using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_07_enum_if
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 실습 Enum + if 문(가위 바위 보)
        /*
        가위바위보 게임
        1. 가위, 바위, 보에 대한 버튼을 3개 생성
        2. 셋 중 아무 버튼이나 “클릭하면” 컴퓨터도 가위, 바위, 보 중 하나를 랜
        덤하게 선택.
        3. 컴퓨터가 무엇을 선택했는지 화면에 표시하고, 사용자가 선택한 것과 
        비교하여 승패를 가름.
        ❖승리한쪽에는1점추가/ 무승부는변화없음.
        4. 사용자와 컴퓨터의 점수를 표시하고 먼저 3점을 얻는 쪽이 최종 승리
        5. 한쪽이 3점을 얻는 순간 점수 초기화 하기.
        */
        

        Random random = new Random(); // 랜덤 객체 생성

        enum RPSChoice
        {
            가위 = 1,
            바위 = 2,
            보 = 3
        }

        enum RPSResult
        {
            승리 = 1,
            패배 = 0
        }


        int personpoint = 0;
        int computerpoint = 0;
        private void a_Click(object sender, EventArgs e)
        {
            // 2
            int computerChoice = random.Next(1, 4);
            // 3
            textBox_result.Text = $"컴퓨터의 선택 : {(RPSChoice)computerChoice}\n";
            textBox_result.Text += "\n";
            
            if (computerChoice == 1)
            {
                textBox_result.Text += "\r\n비겼습니다.";
            }
            else if (computerChoice == 2)
            {
                textBox_result.Text += "\r\n졌습니다.";
                computerpoint++;
            }
            else
            { 
                textBox_result.Text += "\r\n이겼습니다.";
                personpoint++;
            }
            //4
            textBox_result.Text += $"\r\n현재 점수 - 사람: {personpoint}, 컴퓨터: {computerpoint}";
            //5
            CheckForWinner();
        }

        private void b_Click(object sender, EventArgs e)
        {
            int computerChoice = random.Next(1, 4);
            textBox_result.Text = $"컴퓨터의 선택 : {(RPSChoice)computerChoice}\n";
            textBox_result.Text += "\n";

            if (computerChoice == 1)
            {
                textBox_result.Text += "\r\n이겼습니다.";
                personpoint++;
            }
            else if (computerChoice == 2)
            {
                textBox_result.Text += "\r\n비겼습니다.";
            }
            else
            {
                textBox_result.Text += "\r\n졌습니다.";
                computerpoint++;
            }
            textBox_result.Text += $"\r\n현재 점수 - 사람: {personpoint}, 컴퓨터: {computerpoint}";
            CheckForWinner();
        }

        private void c_Click(object sender, EventArgs e)
        {
            int computerChoice = random.Next(1, 4);
            textBox_result.Text = $"컴퓨터의 선택 : {(RPSChoice)computerChoice} \n";
            textBox_result.Text += "\n";
           
            if (computerChoice == 1)
            {
                textBox_result.Text += "\r\n졌습니다.";
                computerpoint++;
            }
            else if (computerChoice == 2)
            {
                textBox_result.Text += "\r\n이겼습니다.";
                personpoint++;
            }
            else
            {
                textBox_result.Text += "\r\n비겼습니다.";
            }
            textBox_result.Text += $"\r\n현재 점수 - 사람: {personpoint}, 컴퓨터: {computerpoint}";
        }

        private void CheckForWinner()
        {
            if (personpoint >= 3)
            {
                MessageBox.Show("사람이 승리하였습니다!");
                ResetGame(); // 게임 초기화
            }
            else if (computerpoint >= 3)
            {
                MessageBox.Show("컴퓨터가 승리하였습니다!");
                ResetGame(); // 게임 초기화
            }

        }

        //5
        private void ResetGame()
        {
            personpoint = 0;
            computerpoint = 0;
            textBox_result.Text = "게임이 초기화되었습니다.";
        }
        /*
        RPSResult personresult(int personpoint)
        {
            personpoint = 0;
            if (personpoint >= 3)
            {
                MessageBox.Show("사람이 승리하였습니다.");
                return RPSResult.승리;
            }
            return RPSResult.패배;
        }

        RPSResult computerresult(int computerpoint)
        {
            computerpoint = 0;
            if (computerpoint >= 3)
            {
                MessageBox.Show("컴퓨터가 승리하였습니다.");
                return RPSResult.패배;
            }
            return RPSResult.승리;
        }
        */
        #endregion
    }
}
