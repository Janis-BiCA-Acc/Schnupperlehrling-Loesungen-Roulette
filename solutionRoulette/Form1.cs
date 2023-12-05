using solutionRoulette.Properties;
using System;
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

        private void Start()
        {
            for (int i = 1; i <= 10; i++)
            {
                ((PictureBox)Controls[$"pBox{i}"]).Image = (i == currentNumber) ? Resources.kreis_rot : Resources.kreis_grün;
            }
        }

        /// <summary>
        /// The Roulette starts when clicking this Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            timer1.Enabled = true;
            btnAbort.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbtn1to10.Checked)
            {
                if (currentNumber < 11)
                {
                    currentNumber++;
                    Start();
                }
                else if (currentNumber > 10)
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = (trackBar1.Value + 1) * 30;
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
            btnAbort.Enabled = false;
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval < 250)
            {
                timer1.Interval += 30;
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;

                string resultMessage = (currentNumber == Convert.ToInt32(comboBox1.SelectedItem)) ? "You Won" : "You Lose";
                MessageBox.Show(resultMessage);
                listBox1.Items.Add(resultMessage);
                listBox1.Items.Add(DateTime.Now);
            }

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
