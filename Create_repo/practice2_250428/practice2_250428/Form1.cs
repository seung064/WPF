using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practice2_250428
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                /*
                실습1
                string apple = "사과";
                int price = 3000;
                int count = 5;
                price *= count;


                textBox1.Text = apple + count.ToString() + "개의 총 가격은" + price.ToString() + "원";
                */
                /*
                //실습2
                string a = "15";
                int b = int.Parse(a);

                textBox1.Text = a + "에 10을 더하면 " + (b + 10).ToString();
                */

                //실습3
            string notebook = "노트북";
            int price = 1200000;
            float discount = 0.15f;
            byte count = 8;

            bool isAvailable = count >= 1 ? true : false;

            double discount_price = price * (1 - discount);


            string result1 = count >= 1 ? "구매가능 : 할인 가격은" + discount_price.ToString() + "입니다." : "품절 되었습니다.";
            textBox2.Text = result1;

            string result2 = count > 5 ? "여유 있음" : "소량 남음";
            textBox3.Text = result2;


            string result3 = "상품명 :" + notebook + "," + "할인된 가격 :" + discount_price.ToString() + "원," + "재고 :" + count.ToString() + "개";
            textBox4.Text = result3;

        
        
        
        }

            private void label1_Click(object sender, EventArgs e)
            {

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


