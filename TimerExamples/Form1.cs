using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimerExamples
{
    public partial class Form1 : Form
    {
        int count = 0;
        Stopwatch myWatch = new Stopwatch();    

        public Form1()
        {
            InitializeComponent();
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            count++;
            countOutput.Text = $"{count}";

            if (count % 10 == 0)
            {
                if (colourOutput.BackColor == Color.Red)
                {
                    colourOutput.BackColor = Color.Green;
                }
                else if (colourOutput.BackColor == Color.Green)
                {
                    colourOutput.BackColor = Color.Yellow;
                }
                else
                {
                    colourOutput.BackColor = Color.Red;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (countTimer.Enabled == false)
            {
                countTimer.Enabled = true;
                button1.Text = "Stop";

                myWatch.Reset();
                myWatch.Start();
                
            }
            else
            {
                countTimer.Enabled = false;
                button1.Text = "Start";

                myWatch.Stop();

                //timeOutput.Text = myWatch.Elapsed + "";
                //timeOutput.Text = myWatch.ElapsedMilliseconds + "";
                timeOutput.Text = myWatch.Elapsed.ToString(@"ss\:ff");
            }
        }
    }
}
