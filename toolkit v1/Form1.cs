using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toolkit_v1
{
    public partial class Form1 : Form
    {
        float timer = 0;
        int countdown = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        int timerPointer = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += timer1.Interval * 0.001f;
            textBox1.Text = timer.ToString("0.0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer = 0;
            textBox1.Text = timer.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if(listBox1.Items.Count > 0)
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count);
                textBox2.Text = listBox1.Items[studentNum].ToString();

                listBox1.Items.RemoveAt(studentNum);
            }
            else
            {
                MessageBox.Show("Please add students!!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                listBox1.Items.Add(textBox3.Text);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(textBox4.Text);
            listBox2.Items.Add(temp);



        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            float currentTime = float.Parse(listBox2.Items[timerPointer].ToString());
            currentTime -= timer2.Interval * 0.001f;
            listBox2.Items[timerPointer] = currentTime.ToString("0.0");
            if (currentTime < 0)
            {
                listBox2.Items[timerPointer] = "0";
                if(timerPointer < listBox2.Items.Count-1)
                {
                    timerPointer++;
                }
            
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox3.Text);
                textBox3.Clear();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int temp = int.Parse(textBox4.Text);
                listBox2.Items.Add(temp);
                textBox4.Text = "";
            }
        }

        private void button13_Click(object sender, EventArgs e) //start
        {
            try
            {
                countdown = Convert.ToInt32(textBox8.Text);
                timer3.Enabled = true;
            }
            catch (Exception) { }
        }

        private void button11_Click(object sender, EventArgs e) //stop
        {
            timer3.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e) //reset
        {
            countdown = 0;
            textBox8.Text = countdown.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--;
                textBox8.Text = countdown.ToString();
            }
            else
            {
                timer3.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e) //6
        {
            textBox5.Text = rnd.Next(1, 7).ToString();
        }

        private void button9_Click(object sender, EventArgs e) //8
        {
            textBox6.Text = rnd.Next(1, 9).ToString();
        }

        private void button10_Click(object sender, EventArgs e) //12
        {
            textBox7.Text = rnd.Next(1, 13).ToString();
        }
    }
}
 