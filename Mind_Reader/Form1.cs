using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mind_Reader
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheGame F = new TheGame();
            F.Show();
            this.Hide();
        }

        private void StartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
