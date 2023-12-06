namespace solutionRoulette
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.pBox3 = new System.Windows.Forms.PictureBox();
            this.pBox4 = new System.Windows.Forms.PictureBox();
            this.pBox5 = new System.Windows.Forms.PictureBox();
            this.pBox10 = new System.Windows.Forms.PictureBox();
            this.pBox9 = new System.Windows.Forms.PictureBox();
            this.pBox8 = new System.Windows.Forms.PictureBox();
            this.pBox7 = new System.Windows.Forms.PictureBox();
            this.pBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.rbtn1to5 = new System.Windows.Forms.RadioButton();
            this.rbtn1to10 = new System.Windows.Forms.RadioButton();
            this.rbtnEvenNumber = new System.Windows.Forms.RadioButton();
            this.rbtnUnevenNumber = new System.Windows.Forms.RadioButton();
            this.rbtnRandomNumber = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nmrSpinInput = new System.Windows.Forms.NumericUpDown();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.txtBoxBalance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSpinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1027, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(225, 105);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 30);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(225, 105);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(12, 141);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(225, 105);
            this.btnAbort.TabIndex = 2;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 252);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(225, 105);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pBox2
            // 
            this.pBox2.Image = global::solutionRoulette.Properties.Resources.kreis_grün;
            this.pBox2.Location = new System.Drawing.Point(447, 59);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(105, 105);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox2.TabIndex = 5;
            this.pBox2.TabStop = false;
            // 
            // pBox3
            // 
            this.pBox3.Image = global::solutionRoulette.Properties.Resources.kreis_grün;
            this.pBox3.Location = new System.Drawing.Point(592, 59);
            this.pBox3.Name = "pBox3";
            this.pBox3.Size = new System.Drawing.Size(105, 105);
            this.pBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox3.TabIndex = 6;
            this.pBox3.TabStop = false;
            // 
            // pBox4
            // 
            this.pBox4.Image = global::solutionRoulette.Properties.Resources.kreis_grün;
            this.pBox4.Location = new System.Drawing.Point(727, 59);
            this.pBox4.Name = "pBox4";
            this.pBox4.Size = new System.Drawing.Size(105, 105);
            this.pBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox4.TabIndex = 7;
            this.pBox4.TabStop = false;
            // 
            // pBox5
            // 
            this.pBox5.Image = global::solutionRoulette.Properties.Resources.kreis_grün;
            this.pBox5.Location = new System.Drawing.Point(858, 178);
            this.pBox5.Name = "pBox5";
            this.pBox5.Size = new System.Drawing.Size(105, 105);
            this.pBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox5.TabIndex = 8;
            this.pBox5.TabStop = false;
            // 
            // pBox10
            // 
            this.pBox10.Image = ((System.Drawing.Image)(resources.GetObject("pBox10.Image")));
            this.pBox10.Location = new System.Drawing.Point(308, 312);
            this.pBox10.Name = "pBox10";
            this.pBox10.Size = new System.Drawing.Size(105, 105);
            this.pBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox10.TabIndex = 13;
            this.pBox10.TabStop = false;
            // 
            // pBox9
            // 
            this.pBox9.Image = ((System.Drawing.Image)(resources.GetObject("pBox9.Image")));
            this.pBox9.Location = new System.Drawing.Point(447, 442);
            this.pBox9.Name = "pBox9";
            this.pBox9.Size = new System.Drawing.Size(105, 105);
            this.pBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox9.TabIndex = 12;
            this.pBox9.TabStop = false;
            // 
            // pBox8
            // 
            this.pBox8.Image = ((System.Drawing.Image)(resources.GetObject("pBox8.Image")));
            this.pBox8.Location = new System.Drawing.Point(592, 442);
            this.pBox8.Name = "pBox8";
            this.pBox8.Size = new System.Drawing.Size(105, 105);
            this.pBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox8.TabIndex = 11;
            this.pBox8.TabStop = false;
            // 
            // pBox7
            // 
            this.pBox7.Image = ((System.Drawing.Image)(resources.GetObject("pBox7.Image")));
            this.pBox7.Location = new System.Drawing.Point(737, 442);
            this.pBox7.Name = "pBox7";
            this.pBox7.Size = new System.Drawing.Size(105, 105);
            this.pBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox7.TabIndex = 10;
            this.pBox7.TabStop = false;
            // 
            // pBox6
            // 
            this.pBox6.Image = global::solutionRoulette.Properties.Resources.kreis_grün;
            this.pBox6.Location = new System.Drawing.Point(858, 312);
            this.pBox6.Name = "pBox6";
            this.pBox6.Size = new System.Drawing.Size(105, 105);
            this.pBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox6.TabIndex = 9;
            this.pBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // rbtn1to5
            // 
            this.rbtn1to5.AutoSize = true;
            this.rbtn1to5.Checked = true;
            this.rbtn1to5.Location = new System.Drawing.Point(12, 436);
            this.rbtn1to5.Name = "rbtn1to5";
            this.rbtn1to5.Size = new System.Drawing.Size(46, 17);
            this.rbtn1to5.TabIndex = 14;
            this.rbtn1to5.TabStop = true;
            this.rbtn1to5.Text = "1 - 5";
            this.rbtn1to5.UseVisualStyleBackColor = true;
            this.rbtn1to5.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtn1to10
            // 
            this.rbtn1to10.AutoSize = true;
            this.rbtn1to10.Location = new System.Drawing.Point(12, 459);
            this.rbtn1to10.Name = "rbtn1to10";
            this.rbtn1to10.Size = new System.Drawing.Size(52, 17);
            this.rbtn1to10.TabIndex = 15;
            this.rbtn1to10.Text = "1 - 10";
            this.rbtn1to10.UseVisualStyleBackColor = true;
            this.rbtn1to10.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnEvenNumber
            // 
            this.rbtnEvenNumber.AutoSize = true;
            this.rbtnEvenNumber.Location = new System.Drawing.Point(12, 482);
            this.rbtnEvenNumber.Name = "rbtnEvenNumber";
            this.rbtnEvenNumber.Size = new System.Drawing.Size(89, 17);
            this.rbtnEvenNumber.TabIndex = 16;
            this.rbtnEvenNumber.Text = "even Number";
            this.rbtnEvenNumber.UseVisualStyleBackColor = true;
            this.rbtnEvenNumber.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnUnevenNumber
            // 
            this.rbtnUnevenNumber.AutoSize = true;
            this.rbtnUnevenNumber.Location = new System.Drawing.Point(12, 505);
            this.rbtnUnevenNumber.Name = "rbtnUnevenNumber";
            this.rbtnUnevenNumber.Size = new System.Drawing.Size(101, 17);
            this.rbtnUnevenNumber.TabIndex = 17;
            this.rbtnUnevenNumber.Text = "uneven Number";
            this.rbtnUnevenNumber.UseVisualStyleBackColor = true;
            this.rbtnUnevenNumber.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnRandomNumber
            // 
            this.rbtnRandomNumber.AutoSize = true;
            this.rbtnRandomNumber.Location = new System.Drawing.Point(12, 528);
            this.rbtnRandomNumber.Name = "rbtnRandomNumber";
            this.rbtnRandomNumber.Size = new System.Drawing.Size(100, 17);
            this.rbtnRandomNumber.TabIndex = 18;
            this.rbtnRandomNumber.Text = "random Number";
            this.rbtnRandomNumber.UseVisualStyleBackColor = true;
            this.rbtnRandomNumber.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(12, 385);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(225, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1027, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1027, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 355);
            this.listBox1.TabIndex = 21;
            // 
            // nmrSpinInput
            // 
            this.nmrSpinInput.Location = new System.Drawing.Point(12, 646);
            this.nmrSpinInput.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmrSpinInput.Name = "nmrSpinInput";
            this.nmrSpinInput.Size = new System.Drawing.Size(120, 20);
            this.nmrSpinInput.TabIndex = 23;
            this.nmrSpinInput.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrSpinInput.ValueChanged += new System.EventHandler(this.spinCost_ValueChanged);
            // 
            // pBox1
            // 
            this.pBox1.Image = global::solutionRoulette.Properties.Resources.kreis_grün;
            this.pBox1.Location = new System.Drawing.Point(308, 178);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(105, 105);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox1.TabIndex = 4;
            this.pBox1.TabStop = false;
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Location = new System.Drawing.Point(9, 630);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(40, 13);
            this.lblDescription2.TabIndex = 24;
            this.lblDescription2.Text = "1 Spin:";
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Location = new System.Drawing.Point(9, 576);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(92, 13);
            this.lblDescription1.TabIndex = 25;
            this.lblDescription1.Text = "Account Balance:";
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.Location = new System.Drawing.Point(12, 592);
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBalance.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 690);
            this.Controls.Add(this.txtBoxBalance);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.nmrSpinInput);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.rbtnRandomNumber);
            this.Controls.Add(this.rbtnUnevenNumber);
            this.Controls.Add(this.rbtnEvenNumber);
            this.Controls.Add(this.rbtn1to10);
            this.Controls.Add(this.rbtn1to5);
            this.Controls.Add(this.pBox10);
            this.Controls.Add(this.pBox9);
            this.Controls.Add(this.pBox8);
            this.Controls.Add(this.pBox7);
            this.Controls.Add(this.pBox6);
            this.Controls.Add(this.pBox5);
            this.Controls.Add(this.pBox4);
            this.Controls.Add(this.pBox3);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSpinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.PictureBox pBox3;
        private System.Windows.Forms.PictureBox pBox4;
        private System.Windows.Forms.PictureBox pBox5;
        private System.Windows.Forms.PictureBox pBox10;
        private System.Windows.Forms.PictureBox pBox9;
        private System.Windows.Forms.PictureBox pBox8;
        private System.Windows.Forms.PictureBox pBox7;
        private System.Windows.Forms.PictureBox pBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton rbtn1to5;
        private System.Windows.Forms.RadioButton rbtn1to10;
        private System.Windows.Forms.RadioButton rbtnEvenNumber;
        private System.Windows.Forms.RadioButton rbtnUnevenNumber;
        private System.Windows.Forms.RadioButton rbtnRandomNumber;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown nmrSpinInput;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.TextBox txtBoxBalance;
    }
}

