﻿using solutionRoulette.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
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
            btnAbort.Enabled = false;
            btnReset.Enabled = false;
            trackBar1.Value = 5;

            comboBox1.Items.Clear();
            comboBoxItems(GenerateNumberRange(1, 5));
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
            trackBar1.Enabled = false;
            comboBox1.Enabled = false;

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

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            int[] comboboxNumbers = null;

            switch (radioButton.Name)
            {
                case "rbtn1to5":
                    comboboxNumbers = GenerateNumberRange(1, 5);
                    break;
                case "rbtn1to10":
                    comboboxNumbers = GenerateNumberRange(1, 10);
                    break;
                case "rbtnEvenNumber":
                    comboboxNumbers = GenerateNumberRange(2, 10, 2);
                    break;
                case "rbtnUnevenNumber":
                    comboboxNumbers = GenerateNumberRange(1, 10, 2);
                    break;
                case "rbtnRandomNumber":
                    comboboxNumbers = GenerateNumberRange(1, 10);
                    break;
            }
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

        private int[] GenerateNumberRange(int start, int end, int step = 1)
        {
            List<int> number = new List<int>();

            for (int i = start; i <= end; i += step)
            {
                number.Add(i);
            }

            return number.ToArray();
        }
    }
}