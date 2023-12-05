using solutionRoulette.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solutionRoulette
{
    public partial class Form1 : Form
    {
        int currentNumber = 1;

        public Form1()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }

        /// <summary>
        /// The Roulette starts when clicking this Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 50;
            btnAbort.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = false;
            Start();
        }

        /// <summary>
        /// The Roulette stops spinning.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Interval = 250;
            btnStop.Enabled = false;
            btnStart.Enabled = false;
            btnAbort.Enabled = false;
            btnReset.Enabled = true;
        }

        /// <summary>
        /// The Roulette spin will be aborted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbort_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnReset.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = false;
        }

        /// <summary>
        /// Roulette will be resetted, can be played again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 5;
            timer1.Enabled = false;
            timer2.Enabled = false;
            btnAbort.Enabled = false;
            btnStart.Enabled = true;
            btnReset.Enabled = false;
            pBox1.Image = Resources.kreis_grün;
            pBox2.Image = Resources.kreis_grün;
            pBox3.Image = Resources.kreis_grün;
            pBox4.Image = Resources.kreis_grün;
            pBox5.Image = Resources.kreis_grün;
            pBox6.Image = Resources.kreis_grün;
            pBox7.Image = Resources.kreis_grün;
            pBox8.Image = Resources.kreis_grün;
            pBox9.Image = Resources.kreis_grün;
            pBox10.Image = Resources.kreis_grün;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbtn1to10.Checked)
            {
                if (currentNumber < 11)
                {
                    currentNumber++;
                    Start();
                } else if (currentNumber > 10)
                {
                    currentNumber = 1;
                    Start();
                }
            }
            if (rbtn1to6.Checked)
            {
                if (currentNumber < 6)
                {
                    currentNumber++;
                    Start();
                } 
                else if (currentNumber > 5)
                {
                    currentNumber = 1;
                    Start();
                }
            }
            if (rbtnEvenNumber.Checked)
            {
                if (currentNumber < 11)
                {
                    currentNumber += 2;
                    Start();
                }
                else if (currentNumber > 10)
                {
                    currentNumber = 2;
                    Start();
                }
            }
            if (rbtnUnevenNumber.Checked)
            {
                if (currentNumber < 11)
                {
                    currentNumber += 2;
                    Start();
                }
                else if (currentNumber > 10)
                {
                    currentNumber = 1;
                    Start();
                }
            }
            if (rbtnRandomNumber.Checked)
            {
                Random a = new Random();
                currentNumber = a.Next(1, 11);
                Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval < 250)

            {
                timer1.Interval = timer1.Interval + 30;
            }
            else
            {
                
                timer1.Enabled = false;
                timer2.Enabled = false;

                if ((currentNumber) == comboBox1.SelectedIndex + 1)
                {
                    MessageBox.Show("You Won");
                    listBox1.Items.Add("Win");
                    listBox1.Items.Add(DateTime.Now);
                }


                else

                {

                    MessageBox.Show("You Lose");
                    listBox1.Items.Add("Lose");
                    listBox1.Items.Add(DateTime.Now);
                }
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int[] intervals = { 5, 30, 50, 100, 150, 200, 250, 300, 350, 400 };
            int index = Math.Max(0, Math.Min(trackBar1.Value - 1, intervals.Length - 1));
            timer1.Interval = intervals[index];

        }

        private void Start() 
        {
            PictureBox[] pictureBoxes = { pBox1, pBox2, pBox3, pBox4, pBox5, pBox6, pBox7, pBox8, pBox9, pBox10 };

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                if (i == currentNumber - 1)
                {
                    pictureBoxes[i].Image = Resources.kreis_rot;
                }
                else
                {
                    pictureBoxes[i].Image = Resources.kreis_grün;
                }
            }

        }

        private void rbtn1to6_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
        }

        private void rbtn1to10_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
        }

        private void rbtnEvenNumber_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("10");
        }

        private void rbtnUnevenNumber_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("9");
        }

        private void rbtnRandomNumber_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
        }

    }
}
