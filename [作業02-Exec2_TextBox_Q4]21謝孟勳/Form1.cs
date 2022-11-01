using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _作業02_Exec2_TextBox_Q4_21謝孟勳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number1 = CarTextBox.Text;
            string number2 = PeopleTextBox.Text;

            int CarNumber = 0;

            try
            {
                bool isInt = int.TryParse(number1, out CarNumber);
                if (isInt == false)
                {
                    throw new Exception("格式錯誤");
                }
            }
            catch (Exception ex)
            {

            }

            int PeopleNumber = 0;

            try
            {
                bool isInt = int.TryParse(number2, out PeopleNumber);
                if (isInt == false)
                {
                    throw new Exception("格式錯誤");
                }
            }
            catch (Exception ex)
            {

            }

            // int CarNumber = 3;  todo 轉換
            //int PeopleNumber = 2; //todo 轉換

            int SumCar = CarNumber * 200;
            int SumPeople = PeopleNumber * 60;
            int Sum = SumCar + SumPeople;

            ShowLabel.Text = $"車錢{SumCar}元 + 人數的錢{SumPeople}元 = 總共{Sum}元";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
