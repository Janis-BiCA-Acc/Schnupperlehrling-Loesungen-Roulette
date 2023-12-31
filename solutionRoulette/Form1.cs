﻿using solutionRoulette.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace solutionRoulette
{
    public partial class Roulette : Form
    {
        int currentNumber = 1;
        decimal accountBalance = 0;
        string rbtnChecked = "";

        public Roulette()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            btnAbort.Enabled = false;
            btnReset.Enabled = false;
            txtBoxBalance.Enabled = false;
            trackBar1.Value = 5;

            rbtnChecked = rbtn1to5.Name;

            setAccountBalance(1000);

            comboBoxItems(generateNumberRange(1, 5));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            timer1.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnAbort.Enabled = true;
            btnReset.Enabled = false;
            btnClearLog.Enabled = false;
            trackBar1.Enabled = true;
            nmrSpinInput.Enabled = false;
            comboBox1.Enabled = false;
            rbtnState(false);

            setAccountBalance(0 - nmrSpinInput.Value);

            if (comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add("*----------------------------------------------------------------------*");
                listBox1.Items.Add("New Game: -" + nmrSpinInput.Value + "Fr.-");
            }
            else
            {
                listBox1.Items.Add("*----------------------------------------------------------------------*");
                listBox1.Items.Add("Free Game");
            }

            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnStop.Enabled = false;
            btnAbort.Enabled = false;
            btnReset.Enabled = true;
            trackBar1.Enabled = false;
            comboBox1.Enabled = false;

            setAccountBalance(nmrSpinInput.Value);
            listBox1.Items.Add("Game Aborted");
            listBox1.Items.Add("*----------------------------------------------------------------------*");
            listBox1.Items.Add("");

            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnAbort.Enabled = false;
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
            btnStart.Enabled = true;
            btnReset.Enabled = false;
            btnClearLog.Enabled = true;
            nmrSpinInput.Enabled = true;
            comboBox1.Enabled = true;
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

            if(decimal.Parse(txtBoxBalance.Text.Split(' ')[0]) < nmrSpinInput.Value)
            {
                nmrSpinInput.Value = decimal.Parse(txtBoxBalance.Text.Split(' ')[0]);
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = (trackBar1.Value + 1) * 30;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rouletteMode();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval <= 1000)
            {
                timer2.Interval = timer2.Interval * 2;
                rouletteMode();
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;

                string resultMessage;
                    
                if(comboBox1.SelectedItem != null)
                {
                    if (currentNumber == Convert.ToInt32(comboBox1.SelectedItem))
                    {
                        resultMessage = "You Won";
                        setAccountBalance(calculateWinningValue());
                        
                        MessageBox.Show(resultMessage);

                        listBox1.Items.Add(resultMessage);
                        listBox1.Items.Add("Amount won: " + calculateWinningValue() + "Fr.-");
                    }
                    else
                    {
                        resultMessage = "You Lose";
                        listBox1.Items.Add(resultMessage);
                    }

                    listBox1.Items.Add("New Accountbalance: " + getAccountBalance().ToString() + "Fr.-");
                    listBox1.Items.Add("*----------------------------------------------------------------------*");
                    listBox1.Items.Add("");
                }
                else
                {
                    listBox1.Items.Add("*----------------------------------------------------------------------*");
                    listBox1.Items.Add("");
                    MessageBox.Show("No Winner");
                }
                listBox1.TopIndex = listBox1.Items.Count - 1;
                btnReset.Enabled = true;
            }
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            int[] comboboxNumbers = null;

            switch (radioButton.Name)
            {
                case "rbtn1to5":
                    comboboxNumbers = generateNumberRange(1, 5);
                    break;
                case "rbtn1to10":
                    comboboxNumbers = generateNumberRange(1, 10);
                    break;
                case "rbtnEvenNumber":
                    comboboxNumbers = generateNumberRange(2, 10, 2);
                    break;
                case "rbtnUnevenNumber":
                    comboboxNumbers = generateNumberRange(1, 10, 2);
                    break;
                case "rbtnRandomNumber":
                    comboboxNumbers = generateNumberRange(1, 10);
                    break;
            }
            rbtnChecked = radioButton.Name;

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
    
        private void comboBoxItems(int[] comboboxNumbers)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < comboboxNumbers.Length; i++)
            {
                comboBox1.Items.Add(comboboxNumbers[i]);
            }
        }

        private int[] generateNumberRange(int start, int end, int step = 1)
        {
            List<int> number = new List<int>();

            for (int i = start; i <= end; i += step)
            {
                number.Add(i);
            }

            return number.ToArray();
        }

        private void setAccountBalance(decimal gainedValue)
        {
            if(comboBox1.SelectedItem != null)
            {
                accountBalance = gainedValue + accountBalance;

                txtBoxBalance.Text = accountBalance.ToString() + " Fr.-";
            }

            if (txtBoxBalance.Text == string.Empty)
            {
                accountBalance = 1000;
                txtBoxBalance.Text = accountBalance.ToString() + " Fr.-";
            }
        }

        private decimal getAccountBalance()
        {
            return accountBalance;
        }

        private void spinCost_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.Parse(txtBoxBalance.Text.Split(' ')[0]) < nmrSpinInput.Value)
            {
                MessageBox.Show("Zu wenig Geld");
                nmrSpinInput.Value = decimal.Parse(txtBoxBalance.Text.Split(' ')[0]);
            }
        }

        private void rouletteMode()
        {
            if (rbtn1to10.Checked)
            {
                if (currentNumber < 10)
                {
                    currentNumber++;
                    rouletteSpinner();
                }
                else if (currentNumber > 9)
                {
                    currentNumber = 1;
                    rouletteSpinner();
                }
            }
            if (rbtn1to5.Checked)
            {
                if (currentNumber < 5)
                {
                    currentNumber++;
                    rouletteSpinner();
                }
                else if (currentNumber > 4)
                {
                    currentNumber = 1;
                    rouletteSpinner();
                }
            }
            if (rbtnEvenNumber.Checked)
            {
                if (currentNumber < 10)
                {
                    currentNumber += 2;
                    rouletteSpinner();
                }
                else if (currentNumber > 9)
                {
                    currentNumber = 2;
                    rouletteSpinner();
                }
            }
            if (rbtnUnevenNumber.Checked)
            {
                if (currentNumber < 9)
                {
                    currentNumber += 2;
                    rouletteSpinner();
                }
                else if (currentNumber > 8)
                {
                    currentNumber = 1;
                    rouletteSpinner();
                }
            }
            if (rbtnRandomNumber.Checked)
            {
                Random a = new Random();
                currentNumber = a.Next(1, 11);
                rouletteSpinner();
            }
        }

        private void rouletteSpinner()
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

        private decimal calculateWinningValue()
        {
            if(rbtnChecked == "rbtn1to5" | rbtnChecked == "rbtnEvenNumber" | rbtnChecked == "rbtnUnevenNumber")
            {
                return nmrSpinInput.Value * 4;
            }
            else
            {
                return nmrSpinInput.Value * 9;
            }
        }
    }
}