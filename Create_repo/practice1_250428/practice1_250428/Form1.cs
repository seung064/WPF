
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
/*
namespace practice1_250428
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            byte retroColorRed = 20;


            short studentCount = 30;
            

            int num;

            float distanceToCanada_cm = 20;
            double spaceToMoon;
            decimal price;


            textBox1.Text = retroColorRed.GetType() + "retroColorRed" + retroColorRed.ToString() + "/r/n";
            




        }
    }
}
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


            textBox1.text = apple.GetType() + "apple" + price.ToString() + "/r/n";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
