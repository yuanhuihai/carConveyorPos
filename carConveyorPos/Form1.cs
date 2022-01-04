using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace carConveyorPos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RonePic.Hide();
            RtwoPic.Hide();
            RthreePic.Hide();
            RfourPic.Hide();
        }

        private void Oone_Click(object sender, EventArgs e)
        {
            Rone.BackColor = Color.Green;
            readingStation.BackColor = Color.Green;
            RRone.Text = carIn.Text;
            carIn.Text = null;
            RonePic.Show();
        }

        private void Otwo_Click(object sender, EventArgs e)
        {
            RRtwo.Text = RRone.Text;
            RRone.Text = null;
            Rtwo.BackColor = Color.Green;
            Rone.BackColor = Color.White;
            RonePic.Hide();
            RtwoPic.Show();
            
            readingStation.BackColor = Color.White;

        }

        private void Othree_Click(object sender, EventArgs e)
        {
            RRthree.Text = RRtwo.Text;
            RRtwo.Text = null;
            Rthree.BackColor = Color.Green;
            Rtwo.BackColor = Color.White;
            RtwoPic.Hide();
            RthreePic.Show();
      
        }

        private void Ofour_Click(object sender, EventArgs e)
        {
            RRfour.Text = RRthree.Text;
            RRthree.Text = null;
            Rfour.BackColor = Color.Green;
            Rthree.BackColor = Color.White;
            RthreePic.Hide();
            RfourPic.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            RRfour.Text = null;
            Rfour.BackColor = Color.White;
            RfourPic.Hide();
        }

        private void RRone_TextChanged(object sender, EventArgs e)
        {
            string s1 = rollerNum.Text;
        
            if(string.Equals(s1,"RB005"))
            {
                string s2 = carNum.Text;
                string s3 = RRone.Text;
                if(string.Equals(s2,s3)){
                    sendOne.Text = "sendOut=0";
                }
            }
        }

        private void RRtwo_TextChanged(object sender, EventArgs e)
        {
            string s1 = rollerNum.Text;

            if (string.Equals(s1, "RB010"))
            {
                string s2 = carNum.Text;
                string s3 = RRtwo.Text;
                if (string.Equals(s2, s3))
                {
                    sendTwo.Text = "sendOut=0";

                }
            }
        }

        private void RRthree_TextChanged(object sender, EventArgs e)
        {
            string s1 = rollerNum.Text;

            if (string.Equals(s1, "RB015"))
            {
                string s2 = carNum.Text;
                string s3 = RRthree.Text;
                if (string.Equals(s2, s3))
                {
                    sendThree.Text = "sendOut=0";

                }
            }
        }
    }
}
