using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int term = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            term++;
            if (term % 2 != 0)
            {
                button1.Text = "X";
            }
            else if (term % 2 == 0)
            {
                button1.Text = "O";
            }

            if ((button1.Text == button2.Text && button2.Text == button3.Text) || (button4.Text == button5.Text && button5.Text == button6.Text) ||
                (button7.Text == button8.Text && button8.Text == button9.Text) || (button1.Text == button4.Text && button4.Text == button7.Text)
                || (button2.Text == button5.Text && button5.Text == button8.Text) || (button3.Text == button6.Text && button6.Text == button9.Text)
                || (button1.Text == button5.Text && button5.Text == button9.Text) || (button3.Text == button5.Text && button5.Text == button7.Text))
            {
                MessageBox.Show("Win!");
            }
            else
            {
                if (term == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            term++;
            if (term % 2 != 0)
            {
                button2.Text = "X";
            }
            else if (term % 2 == 0)
            {
                button2.Text = "O";
            }

            if ((button1.Text == button2.Text && button2.Text == button3.Text) || (button4.Text == button5.Text && button5.Text == button6.Text) ||
                (button7.Text == button8.Text && button8.Text == button9.Text) || (button1.Text == button4.Text && button4.Text == button7.Text)
                || (button2.Text == button5.Text && button5.Text == button8.Text) || (button3.Text == button6.Text && button6.Text == button9.Text)
                || (button1.Text == button5.Text && button5.Text == button9.Text) || (button3.Text == button5.Text && button5.Text == button7.Text))
            {
                MessageBox.Show("Win!");
            }
            else
            {
                if (term == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            term++;
            if (term % 2 != 0)
            {
                button3.Text = "X";
            }
            else if (term % 2 == 0)
            {
                button3.Text = "O";
            }

            if ((button1.Text == button2.Text && button2.Text == button3.Text) || (button4.Text == button5.Text && button5.Text == button6.Text) ||
                (button7.Text == button8.Text && button8.Text == button9.Text) || (button1.Text == button4.Text && button4.Text == button7.Text)
                || (button2.Text == button5.Text && button5.Text == button8.Text) || (button3.Text == button6.Text && button6.Text == button9.Text)
                || (button1.Text == button5.Text && button5.Text == button9.Text) || (button3.Text == button5.Text && button5.Text == button7.Text))
            {
                MessageBox.Show("Win!");
            }
            else
            {
                if (term == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            term++;
            if (term % 2 != 0)
            {
                button6.Text = "X";
            }
            else if (term % 2 == 0)
            {
                button6.Text = "O";
            }

            if ((button1.Text == button2.Text && button2.Text == button3.Text) || (button4.Text == button5.Text && button5.Text == button6.Text) ||
                (button7.Text == button8.Text && button8.Text == button9.Text) || (button1.Text == button4.Text && button4.Text == button7.Text)
                || (button2.Text == button5.Text && button5.Text == button8.Text) || (button3.Text == button6.Text && button6.Text == button9.Text)
                || (button1.Text == button5.Text && button5.Text == button9.Text) || (button3.Text == button5.Text && button5.Text == button7.Text))
            {
                MessageBox.Show("Win!");
            }
            else
            {
                if (term == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            term++;
            if (term % 2 != 0)
            {
                button5.Text = "X";
            }
            else if (term % 2 == 0)
            {
                button5.Text = "O";
            }

            if ((button1.Text == button2.Text && button2.Text == button3.Text) || (button4.Text == button5.Text && button5.Text == button6.Text) ||
                (button7.Text == button8.Text && button8.Text == button9.Text) || (button1.Text == button4.Text && button4.Text == button7.Text)
                || (button2.Text == button5.Text && button5.Text == button8.Text) || (button3.Text == button6.Text && button6.Text == button9.Text)
                || (button1.Text == button5.Text && button5.Text == button9.Text) || (button3.Text == button5.Text && button5.Text == button7.Text))
            {
                MessageBox.Show("Win!");
            }
            else
            {
                if (term == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            term++;
            if (term % 2 != 0)
            {
                button4.Text = "X";
            }
            else if (term % 2 == 0)
            {
                button4.Text = "O";
            }

            if ((button1.Text == button2.Text && button2.Text == button3.Text) || (button4.Text == button5.Text && button5.Text == button6.Text) ||
                (button7.Text == button8.Text && button8.Text == button9.Text) || (button1.Text == button4.Text && button4.Text == button7.Text)
                || (button2.Text == button5.Text && button5.Text == button8.Text) || (button3.Text == button6.Text && button6.Text == button9.Text)
                || (button1.Text == button5.Text && button5.Text == button9.Text) || (button3.Text == button5.Text && button5.Text == button7.Text))
            {
                MessageBox.Show("Win!");
            }
            else
            {
                if (term == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            term++;
            if (term % 2 != 0)
            {
                button9.Text = "X";
            }
            else if (term % 2 == 0)
            {
                button9.Text = "O";
            }

            if ((button1.Text == button2.Text && button2.Text == button3.Text) || (button4.Text == button5.Text && button5.Text == button6.Text) ||
                 (button7.Text == button8.Text && button8.Text == button9.Text) || (button1.Text == button4.Text && button4.Text == button7.Text)
                 || (button2.Text == button5.Text && button5.Text == button8.Text) || (button3.Text == button6.Text && button6.Text == button9.Text)
                 || (button1.Text == button5.Text && button5.Text == button9.Text) || (button3.Text == button5.Text && button5.Text == button7.Text))
            {
                MessageBox.Show("Win!");
            }
            else
            {
                if (term == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            term++;
            if (term % 2 != 0)
            {
                button8.Text = "X";
            }
            else if (term % 2 == 0)
            {
                button8.Text = "O";
            }

            if ((button1.Text == button2.Text && button2.Text == button3.Text) || (button4.Text == button5.Text && button5.Text == button6.Text) ||
                (button7.Text == button8.Text && button8.Text == button9.Text) || (button1.Text == button4.Text && button4.Text == button7.Text)
                || (button2.Text == button5.Text && button5.Text == button8.Text) || (button3.Text == button6.Text && button6.Text == button9.Text)
                || (button1.Text == button5.Text && button5.Text == button9.Text) || (button3.Text == button5.Text && button5.Text == button7.Text))
            {
                MessageBox.Show("Win!");
            }
            else
            {
                if (term == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            term++;
            if (term % 2 != 0)
            {
                button7.Text = "X";
            }
            else if (term % 2 == 0)
            {
                button7.Text = "O";
            }

            if ((button1.Text == button2.Text && button2.Text == button3.Text) || (button4.Text == button5.Text && button5.Text == button6.Text) ||
                (button7.Text == button8.Text && button8.Text == button9.Text) || (button1.Text == button4.Text && button4.Text == button7.Text)
                || (button2.Text == button5.Text && button5.Text == button8.Text) || (button3.Text == button6.Text && button6.Text == button9.Text)
                || (button1.Text == button5.Text && button5.Text == button9.Text) || (button3.Text == button5.Text && button5.Text == button7.Text))
            {
                MessageBox.Show("Win!");
            }
            else
            {
                if (term == 9)
                {
                    MessageBox.Show("Draw!");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
        }
    }
}

