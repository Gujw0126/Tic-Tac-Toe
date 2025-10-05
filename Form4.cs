using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tac
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label2.Text = Global.player1.name;
            label3.Text = Global.player2.name;
            label7.Text = Global.player1.win.ToString();
            label8.Text = Global.player1.lost.ToString();
            label9.Text = Global.player1.draw.ToString();
            label10.Text = Global.player2.win.ToString();
            label11.Text = Global.player2.lost.ToString();
            label12.Text = Global.player2.draw.ToString();
        }

        private void ScoreClose(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void BackTo41(object sender, FormClosingEventArgs e)
        {
            
            this.Dispose();
        }
    }
}
