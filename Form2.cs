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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Check_name1(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox1.Text.Trim().Equals(textBox2.Text.Trim()))
            {
                MessageBox.Show("Player1'name and Player2's name cannot be the same,please rename one of them.");

            }
        }

        private void Check_name2(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "" && textBox1.Text.Trim().Equals(textBox2.Text.Trim()))
            {
                MessageBox.Show("Player1'name and Player2's name cannot be the same,please rename one of them.");

            }
        }

        private void Mark_check1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox1.SelectedItem.Equals(comboBox2.SelectedItem))
            {
                MessageBox.Show("Player1'mark and Player2's mark cannot be the same!");

            }
        }

        private void Mark_check2(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox1.SelectedItem != null && comboBox1.SelectedItem.Equals(comboBox2.SelectedItem))
            {
                MessageBox.Show("Player1'mark and Player2's mark cannot be the same!");
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("The names of both players and the marks of both players cannot be empty!");
            }
            else if(textBox1.Text.Trim().Equals(textBox2.Text.Trim())||comboBox1.SelectedItem.Equals(comboBox2.SelectedItem))
            {
                MessageBox.Show("Players cannot  share one name or mark!");
            }
            else
            {
                if (comboBox1.SelectedItem.ToString().Equals("O"))
                {
                    Global.player1 = new Player(textBox1.Text.Trim(), comboBox1.SelectedItem);
                    Global.player2 = new Player(textBox2.Text.Trim(), comboBox2.SelectedItem);
                }
                else
                {
                    Global.player1 = new Player(textBox2.Text.Trim(), comboBox2.SelectedItem);
                    Global.player2 = new Player(textBox1.Text.Trim(), comboBox1.SelectedItem);
                }
                tac.Form3 f3 = new Form3();
                this.Hide();
                f3.ShowDialog();
                this.Close();
                this.Dispose();
            }
        }

        private void BackTO1(object sender, FormClosingEventArgs e)
        {
            tac.tic_tac_toe ff1 = new tic_tac_toe();
            this.Hide();
            ff1.ShowDialog();
            this.Dispose();
        }
    }
}
