using solutionRoulette.Properties;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace solutionRoulette
{
    public partial class Form1 : Form
    {
        int currentNumber = 1;

        public Form1()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            btnAbort.Enabled = false;
            btnReset.Enabled = false;
            trackBar1.Value = 5;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");

        }

        private void Start()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == currentNumber)
                {
                    ((PictureBox)Controls[$"pBox{i}"]).Image = Resources.kreis_rot;
                }
                else
                {
                    ((PictureBox)Controls[$"pBox{i}"]).Image = Resources.kreis_grün;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            timer1.Enabled = true;
            btnAbort.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnReset.Enabled = false;
            trackBar1.Enabled = true;
            rbtnState(false);
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnReset.Enabled = true;
            btnStop.Enabled = false;
            btnAbort.Enabled = false;
            trackBar1.Enabled = false;
            comboBox1.Enabled = false;
            listBox1.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = false;
            btnAbort.Enabled = false;
            btnReset.Enabled = true;

            timer2.Enabled = true;
            timer2.Interval = timer1.Interval;
            timer1.Enabled = false;
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 5;
            timer1.Enabled = false;
            timer2.Enabled = false;
            btnAbort.Enabled = false;
            btnStart.Enabled = true;
            btnReset.Enabled = false;
            trackBar1.Enabled = false;
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
            rbtnState(true);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = (trackBar1.Value + 1) * 30;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            roulette();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval <= 1000)
            {
                timer2.Interval = timer2.Interval * 2;
                roulette();
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

        private void rbtn1to5_CheckedChanged(object sender, EventArgs e)
        {
            int[] comboboxNumbers = { 1, 2, 3, 4, 5};
            comboBoxItems(comboboxNumbers);
        }

        private void rbtn1to10_CheckedChanged(object sender, EventArgs e)
        {
            int[] comboboxNumbers = { 1, 2, 3, 4, 5, 6, 7, 8 , 9 , 10};
            comboBoxItems(comboboxNumbers);
        }

        private void rbtnEvenNumber_CheckedChanged(object sender, EventArgs e)
        {
            int[] comboboxNumbers = {2, 4, 6, 8, 10};
            comboBoxItems(comboboxNumbers);
        }

        private void rbtnUnevenNumber_CheckedChanged(object sender, EventArgs e)
        {
            int[] comboboxNumbers = { 1, 3, 5, 7, 9 };
            comboBoxItems(comboboxNumbers);
        }

        private void rbtnRandomNumber_CheckedChanged(object sender, EventArgs e)
        {
            int[] comboboxNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            comboBoxItems(comboboxNumbers);
        }

        private void rbtnState(Boolean state)
        {
            rbtn1to10.Enabled = state;
            rbtn1to5.Enabled = state;
            rbtnEvenNumber.Enabled = state;
            rbtnUnevenNumber.Enabled = state;
            rbtnRandomNumber.Enabled = state;
        }
    
        private void roulette()
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
            if (rbtn1to5.Checked)
            {
                if (currentNumber < 5)
                {
                    currentNumber++;
                    Start();
                }
                else if (currentNumber > 4)
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
    
        private void comboBoxItems(int[] comboboxNumbers)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < comboboxNumbers.Length; i++)
            {
                comboBox1.Items.Add(comboboxNumbers[i]);
            }
        }
    }
}