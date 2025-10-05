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
    public partial class tic_tac_toe : Form
    {
        public tic_tac_toe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartPlay(object sender, EventArgs e)
        {
            tac.Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void OverGame(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
