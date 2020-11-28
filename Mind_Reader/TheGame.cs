using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Mind_Reader
{
    public partial class TheGame : Form
    {
        public TheGame()
        {
            InitializeComponent();
        }

        private System.Threading.ManualResetEvent mre = new System.Threading.ManualResetEvent(false);
        int cardno = 0, number, noperrow, chno = 0, answer = 2;
        private void Yesbtn_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            chno += (int)Math.Pow(2.0, cardno);
            mre.Set();
        }

        private void Nobtn_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            mre.Set();
        }

        private async void TheGame_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a number between 1 and 128 & Keep it in your mind", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (cardno = 0; cardno <= 6; cardno++)
            {
                noperrow = 0;
                for (number = 1; number <= 127; number++)
                {
                    if (Convert.ToBoolean(number & (int)Math.Pow(2.0, cardno)))
                    {
                        label1.Text += number + "    ";
                        noperrow++;

                        if (noperrow == 5)
                        {
                            label1.Text += "\n";
                            noperrow = 0;
                        }
                    }
                }
                if (noperrow < 5)
                {
                    label1.Text += "\n";
                }
                mre.Reset();
                await Task.Factory.StartNew(() => { mre.WaitOne(); });
            }
            MessageBox.Show("Your Number is : " + chno.ToString() + "   :D <3", "The answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartPage f = new StartPage();
            f.Show();
            this.Hide();
        }

        private void TheGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}