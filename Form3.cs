using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static tac.Program;
namespace tac
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Global.game = new Board();
            Global.turn = 1;
            Button button00 = new Button();
            button00.Dock =DockStyle.Fill;
            button00.BackColor = Color.BlanchedAlmond;
            tableLayoutPanel1.Controls.Add(button00, 0, 0);
            button00.Click += new System.EventHandler(button00_click);
            Button button01 = new Button();
            button01.Dock = DockStyle.Fill;
            button01.BackColor = Color.BlanchedAlmond;
            button01.Click += new System.EventHandler(button01_click);
            tableLayoutPanel1.Controls.Add(button01, 0, 1);
            Button button02 = new Button();
            button02.Dock = DockStyle.Fill;
            button02.BackColor = Color.BlanchedAlmond;
            button02.Click += new System.EventHandler(button02_click);
            tableLayoutPanel1.Controls.Add(button02, 0, 2);
            Button button10 = new Button();
            button10.Dock = DockStyle.Fill;
            button10.BackColor = Color.BlanchedAlmond;
            button10.Click += new System.EventHandler(button10_click);
            tableLayoutPanel1.Controls.Add(button10, 1, 0);
            Button button11 = new Button();
            button11.Dock = DockStyle.Fill;
            button11.BackColor = Color.BlanchedAlmond;
            button11.Click += new System.EventHandler(button11_click);
            tableLayoutPanel1.Controls.Add(button11, 1, 1);
            Button button12 = new Button();
            button12.Dock = DockStyle.Fill;
            button12.BackColor = Color.BlanchedAlmond;
            button12.Click += new System.EventHandler(button12_click);
            tableLayoutPanel1.Controls.Add(button12, 1, 2);
            Button button20 = new Button();
            button20.Dock = DockStyle.Fill;
            button20.BackColor = Color.BlanchedAlmond;
            button20.Click += new System.EventHandler(button20_click);
            tableLayoutPanel1.Controls.Add(button20, 2, 0);
            Button button21 = new Button();
            button21.Dock = DockStyle.Fill;
            button21.BackColor = Color.BlanchedAlmond;
            button21.Click += new System.EventHandler(button21_click);
            tableLayoutPanel1.Controls.Add(button21, 2, 1);
            Button button22 = new Button();
            button22.Dock = DockStyle.Fill;
            button22.BackColor = Color.BlanchedAlmond;
            button22.Click += new System.EventHandler(button22_click);
            tableLayoutPanel1.Controls.Add(button22, 2, 2);
            label3.Text = Global.player1.name;
            label4.Text = Global.player2.name;
            label2.Text = "It's " + Global.player1.name + "'s" + " turn!";
            label1.Text = Global.player1.win.ToString();
            label5.Text = Global.player2.win.ToString();
        }

        private void NewGame(object sender, EventArgs e)
        {

            Form3 newgame3 = new Form3();
            this.Hide();
            newgame3.ShowDialog();
            this.Dispose();
        }

        private void ExitGame(object sender, EventArgs e)
        {
            tac.Form4 f4 = new Form4();
            tac.tic_tac_toe f1 = new tic_tac_toe();
            this.Hide();
            f4.ShowDialog();
            f1.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void BackTo31(object sender, FormClosingEventArgs e)
        {
            tac.tic_tac_toe fff1 = new tic_tac_toe();
            this.Hide();
            fff1.ShowDialog();
            this.Dispose();
        }

        private void button00_click(object sender, EventArgs e)
        {
            Button button_t = (Button)sender;            
            if (Global.turn != 0 && Global.game.PutChess(0,0,Global.turn))//游戏未结束
            {
                if (Global.turn == 1)
                {
                    button_t.BackgroundImage = pictureBox3.Image;
                    label2.Text = "It's " + Global.player2.name + "'s" + " turn!";
                }
                else
                {
                    button_t.BackgroundImage = pictureBox2.Image;
                    label2.Text = "It's " + Global.player1.name + "'s" + " turn!";
                }
                button_t.BackgroundImageLayout = ImageLayout.Stretch;
                button_t.Visible = true;
                int w = Global.game.CheckWin();
                if (w == 1)//改计分
                {
                    Global.turn = 0;
                    Global.player1.win++;
                    Global.player2.lost++;
                    MessageBox.Show(Global.player1.name + " wins!");
                    label1.Text = Global.player1.win.ToString();
                }
                else if (w == -1)
                {
                    Global.turn = 0;
                    MessageBox.Show(Global.player2.name + " wins!");
                    Global.player1.lost++;
                    Global.player2.win++;
                    label5.Text = Global.player2.win.ToString();
                }
                else if (w == 0)
                {
                    MessageBox.Show("draw!");
                    Global.turn = 0;
                    Global.player1.draw++;
                    Global.player2.draw++;
                }
                else
                { Global.turn *= -1; }//交替进行
            }
        }
        private void button01_click(object sender, EventArgs e)
        {
            Button button_t = (Button)sender;
            if (Global.turn != 0 && Global.game.PutChess(0, 1, Global.turn))//游戏未结束
            {
                if (Global.turn == 1)
                {
                    button_t.BackgroundImage = pictureBox3.Image;
                    label2.Text = "It's " + Global.player2.name + "'s" + " turn!";
                }
                else
                {
                    button_t.BackgroundImage = pictureBox2.Image;
                    label2.Text = "It's " + Global.player1.name + "'s" + " turn!";
                }
                button_t.BackgroundImageLayout = ImageLayout.Stretch;
                button_t.Visible = true;
                int w = Global.game.CheckWin();
                if (w == 1)//改计分
                {
                    Global.turn = 0;
                    Global.player1.win++;
                    Global.player2.lost++;
                    MessageBox.Show(Global.player1.name + " wins!");
                    label1.Text = Global.player1.win.ToString();
                }
                else if (w == -1)
                {
                    Global.turn = 0;
                    MessageBox.Show(Global.player2.name + " wins!");
                    Global.player1.lost++;
                    Global.player2.win++;
                    label5.Text = Global.player2.win.ToString();
                }
                else if (w == 0)
                {
                    MessageBox.Show("draw!");
                    Global.turn = 0;
                    Global.player1.draw++;
                    Global.player2.draw++;
                }
                else
                { Global.turn *= -1; }//交替进行
            }
        }
        private void button02_click(object sender, EventArgs e)
        {
            Button button_t = (Button)sender;
            if (Global.turn != 0 && Global.game.PutChess(0, 2, Global.turn))//游戏未结束
            {
                if (Global.turn == 1)
                {
                    button_t.BackgroundImage = pictureBox3.Image;
                    label2.Text = "It's " + Global.player2.name + "'s" + " turn!";
                }
                else
                {
                    button_t.BackgroundImage = pictureBox2.Image;
                    label2.Text = "It's " + Global.player1.name + "'s" + " turn!";
                }
                button_t.BackgroundImageLayout = ImageLayout.Stretch;
                button_t.Visible = true;
                int w = Global.game.CheckWin();
                if (w == 1)//改计分
                {
                    Global.turn = 0;
                    Global.player1.win++;
                    Global.player2.lost++;
                    MessageBox.Show(Global.player1.name + " wins!");
                    label1.Text = Global.player1.win.ToString();
                }
                else if (w == -1)
                {
                    Global.turn = 0;
                    MessageBox.Show(Global.player2.name + " wins!");
                    Global.player1.lost++;
                    Global.player2.win++;
                    label5.Text = Global.player2.win.ToString();
                }
                else if (w == 0)
                {
                    MessageBox.Show("draw!");
                    Global.turn = 0;
                    Global.player1.draw++;
                    Global.player2.draw++;
                }
                else
                { Global.turn *= -1; }//交替进行
            }
        }
        private void button10_click(object sender, EventArgs e)
        {
            Button button_t = (Button)sender;
            if (Global.turn != 0 && Global.game.PutChess(1, 0, Global.turn))//游戏未结束
            {
                if (Global.turn == 1)
                {
                    button_t.BackgroundImage = pictureBox3.Image;
                    label2.Text = "It's " + Global.player2.name + "'s" + " turn!";
                }
                else
                {
                    button_t.BackgroundImage = pictureBox2.Image;
                    label2.Text = "It's " + Global.player1.name + "'s" + " turn!";
                }
                button_t.BackgroundImageLayout = ImageLayout.Stretch;
                button_t.Visible = true;
                int w = Global.game.CheckWin();
                if (w == 1)//改计分
                {
                    Global.turn = 0;
                    Global.player1.win++;
                    Global.player2.lost++;
                    MessageBox.Show(Global.player1.name + " wins!");
                    label1.Text = Global.player1.win.ToString();
                }
                else if (w == -1)
                {
                    Global.turn = 0;
                    MessageBox.Show(Global.player2.name + " wins!");
                    Global.player1.lost++;
                    Global.player2.win++;
                    label5.Text = Global.player2.win.ToString();
                }
                else if (w == 0)
                {
                    MessageBox.Show("draw!");
                    Global.turn = 0;
                    Global.player1.draw++;
                    Global.player2.draw++;
                }
                else
                { Global.turn *= -1; }//交替进行
            }
        }
        private void button11_click(object sender, EventArgs e)
        {
            Button button_t = (Button)sender;
            if (Global.turn != 0 && Global.game.PutChess(1, 1, Global.turn))//游戏未结束
            {
                if (Global.turn == 1)
                {
                    button_t.BackgroundImage = pictureBox3.Image;
                    label2.Text = "It's " + Global.player2.name + "'s" + " turn!";
                }
                else
                {
                    button_t.BackgroundImage = pictureBox2.Image;
                    label2.Text = "It's " + Global.player1.name + "'s" + " turn!";
                }
                button_t.BackgroundImageLayout = ImageLayout.Stretch;
                button_t.Visible = true;
                int w = Global.game.CheckWin();
                if (w == 1)//改计分
                {
                    Global.turn = 0;
                    Global.player1.win++;
                    Global.player2.lost++;
                    MessageBox.Show(Global.player1.name + " wins!");
                    label1.Text = Global.player1.win.ToString();
                }
                else if (w == -1)
                {
                    Global.turn = 0;
                    MessageBox.Show(Global.player2.name + " wins!");
                    Global.player1.lost++;
                    Global.player2.win++;
                    label5.Text = Global.player2.win.ToString();
                }
                else if (w == 0)
                {
                    MessageBox.Show("draw!");
                    Global.turn = 0;
                    Global.player1.draw++;
                    Global.player2.draw++;
                }
                else
                { Global.turn *= -1; }//交替进行
            }
        }
        private void button12_click(object sender, EventArgs e)
        {
            Button button_t = (Button)sender;
            if (Global.turn != 0 && Global.game.PutChess(1, 2, Global.turn))//游戏未结束
            {
                if (Global.turn == 1)
                {
                    button_t.BackgroundImage = pictureBox3.Image;
                    label2.Text = "It's " + Global.player2.name + "'s" + " turn!";
                }
                else
                {
                    button_t.BackgroundImage = pictureBox2.Image;
                    label2.Text = "It's " + Global.player1.name + "'s" + " turn!";
                }
                button_t.BackgroundImageLayout = ImageLayout.Stretch;
                button_t.Visible = true;
                int w = Global.game.CheckWin();
                if (w == 1)//改计分
                {
                    Global.turn = 0;
                    Global.player1.win++;
                    Global.player2.lost++;
                    MessageBox.Show(Global.player1.name + " wins!");
                    label1.Text = Global.player1.win.ToString();
                }
                else if (w == -1)
                {
                    Global.turn = 0;
                    MessageBox.Show(Global.player2.name + " wins!");
                    Global.player1.lost++;
                    Global.player2.win++;
                    label5.Text = Global.player2.win.ToString();
                }
                else if (w == 0)
                {
                    MessageBox.Show("draw!");
                    Global.turn = 0;
                    Global.player1.draw++;
                    Global.player2.draw++;
                }
                else
                { Global.turn *= -1; }//交替进行
            }
        }
        private void button20_click(object sender, EventArgs e)
        {
            Button button_t = (Button)sender;
            if (Global.turn != 0 && Global.game.PutChess(2, 0, Global.turn))//游戏未结束
            {
                if (Global.turn == 1)
                {
                    button_t.BackgroundImage = pictureBox3.Image;
                    label2.Text = "It's " + Global.player2.name + "'s" + " turn!";
                }
                else
                {
                    button_t.BackgroundImage = pictureBox2.Image;
                    label2.Text = "It's " + Global.player1.name + "'s" + " turn!";
                }
                button_t.BackgroundImageLayout = ImageLayout.Stretch;
                button_t.Visible = true;
                int w = Global.game.CheckWin();
                if (w == 1)//改计分
                {
                    Global.turn = 0;
                    Global.player1.win++;
                    Global.player2.lost++;
                    MessageBox.Show(Global.player1.name + " wins!");
                    label1.Text = Global.player1.win.ToString();
                }
                else if (w == -1)
                {
                    Global.turn = 0;
                    MessageBox.Show(Global.player2.name + " wins!");
                    Global.player1.lost++;
                    Global.player2.win++;
                    label5.Text = Global.player2.win.ToString();
                }
                else if (w == 0)
                {
                    MessageBox.Show("draw!");
                    Global.turn = 0;
                    Global.player1.draw++;
                    Global.player2.draw++;
                }
                else
                { Global.turn *= -1; }//交替进行
            }
        }
        private void button21_click(object sender, EventArgs e)
        {
            Button button_t = (Button)sender;
            if (Global.turn != 0 && Global.game.PutChess(2, 1, Global.turn))//游戏未结束
            {
                if (Global.turn == 1)
                {
                    button_t.BackgroundImage = pictureBox3.Image;
                    label2.Text = "It's " + Global.player2.name + "'s" + " turn!";
                }
                else
                {
                    button_t.BackgroundImage = pictureBox2.Image;
                    label2.Text = "It's " + Global.player1.name + "'s" + " turn!";
                }
                button_t.BackgroundImageLayout = ImageLayout.Stretch;
                button_t.Visible = true;
                int w = Global.game.CheckWin();
                if (w == 1)//改计分
                {
                    Global.turn = 0;
                    Global.player1.win++;
                    Global.player2.lost++;
                    MessageBox.Show(Global.player1.name + " wins!");
                    label1.Text = Global.player1.win.ToString();
                }
                else if (w == -1)
                {
                    Global.turn = 0;
                    MessageBox.Show(Global.player2.name + " wins!");
                    Global.player1.lost++;
                    Global.player2.win++;
                    label5.Text = Global.player2.win.ToString();
                }
                else if (w == 0)
                {
                    MessageBox.Show("draw!");
                    Global.turn = 0;
                    Global.player1.draw++;
                    Global.player2.draw++;
                }
                else
                { Global.turn *= -1; }//交替进行
            }
        }
        private void button22_click(object sender, EventArgs e)
        {
            Button button_t = (Button)sender;
            if (Global.turn != 0 && Global.game.PutChess(2, 2, Global.turn))//游戏未结束
            {
                if (Global.turn == 1)
                {
                    button_t.BackgroundImage = pictureBox3.Image;
                    label2.Text = "It's " + Global.player2.name + "'s" + " turn!";
                }
                else
                {
                    button_t.BackgroundImage = pictureBox2.Image;
                    label2.Text = "It's " + Global.player1.name + "'s" + " turn!";
                }
                button_t.BackgroundImageLayout = ImageLayout.Stretch;
                button_t.Visible = true;
                int w = Global.game.CheckWin();
                if (w == 1)//改计分
                {
                    Global.turn = 0;
                    Global.player1.win++;
                    Global.player2.lost++;
                    MessageBox.Show(Global.player1.name + " wins!");
                    label1.Text = Global.player1.win.ToString();
                }
                else if (w == -1)
                {
                    Global.turn = 0;
                    MessageBox.Show(Global.player2.name + " wins!");
                    Global.player1.lost++;
                    Global.player2.win++;
                    label5.Text = Global.player2.win.ToString();
                }
                else if (w == 0)
                {
                    MessageBox.Show("draw!");
                    Global.turn = 0;
                    Global.player1.draw++;
                    Global.player2.draw++;
                }
                else
                { Global.turn *= -1; }//交替进行
            }
        }
    }
}

        
