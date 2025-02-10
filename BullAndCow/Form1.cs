using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullAndCow
{
    public partial class Form1 : Form
    {
        private int[] number = new int[4];
        private int[] numberEntered = new int[4];

        public int[] GenerateNumber()
        {
            var rand = new Random();
            
            number[0] = rand.Next(1, 9);
            while (number[1] == number[0])
            {
                number[1] = rand.Next(1, 9);
            }
            while (number[2] == number[1] || number[2] == number[0])
            {
                number[2] = rand.Next(1, 9);
            }
            while (number[3] == number[2] || number[3] == number[1] || number[3] == number[0])
            {
                number[3] = rand.Next(1, 9);
            }
            textBox1.Text = "" + (1000 * number[0] + 100 * number[1] + 10 * number[2] + number[3]);
            return number;
        }

        public Form1()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int remainder; 
            int n = int.Parse(textBox1.Text);
            numberEntered[0] = n / 1000;
            remainder = n % 1000;
            numberEntered[1] = remainder / 100;
            remainder = remainder % 100;
            numberEntered[2] = remainder / 10;
            remainder = remainder % 10;
            numberEntered[3] = remainder;
        }
    }
}
