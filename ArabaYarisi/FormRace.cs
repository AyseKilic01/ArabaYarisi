using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class FrmGameRace : Form
    {
        public FrmGameRace()
        {
            InitializeComponent();
        }
        void PictureFor(PictureBox p1, PictureBox p2, PictureBox p3, int speed)
        {
            List<PictureBox> boxes = new List<PictureBox>();
            boxes.Add(p1);
            boxes.Add(p2);
            boxes.Add(p3);
            foreach (var i in boxes)
            {
                if (i.Top >= 350)
                {
                    x = r.Next(0, 200);
                    i.Location = new Point(x, 0);
                }
                else { i.Top += speed; }
            }
        }
        private void FrmGameRace_Load(object sender, EventArgs e)
        {
            
        }
        int collectCoin = 0;
        Random r = new Random();
        int x, y;
        void Enemy(int speed)
        {
            PictureFor(pEnemy1, pEnemy2, pEnemy3, speed);
        }
        void MoveLine(int speed)
        {
            List<PictureBox> labels = new List<PictureBox>();
            labels.Add(line1);
            labels.Add(line2);
            labels.Add(line3);
            labels.Add(line4);
            foreach (var i in labels)
            {
                if (i.Top >= 350)
                {
                    i.Top = 0;
                }
                else { i.Top += speed; }
            }
        }
        void Coins(int speed)
        {
            PictureFor(pCoin1, pCoin2, pCoin3, speed);
        }

        private void gameTimer4_Tick(object sender, EventArgs e)
        {
            MoveLine(5);
            Enemy(5);
            GameOver();
            Coins(gameSpeed);
            CollectCoin();
        }
        int gameSpeed = 0;
        private void FrmGameRace_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                if(pCar.Left < 200)
                pCar.Left += gameSpeed;
            }
            if(e.KeyCode == Keys.Left)
            {
                if(pCar.Left > 0)
                pCar.Left -= gameSpeed;
            }
            if(e.KeyCode == Keys.Up)
            {
                if(gameSpeed < 21)
                {
                    gameSpeed++;
                }
            }
            if(e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }
        }
        void GameOver()
        {
            List<PictureBox> enemies = new List<PictureBox>();
            enemies.Add(pEnemy1);
            enemies.Add(pEnemy2);
            enemies.Add(pEnemy3);
            foreach (var i in enemies)
            {
                if (pCar.Bounds.IntersectsWith(i.Bounds))
                {
                    gameTimer4.Enabled = false;
                    lblEndGame.Visible = true;
                    btnR.Visible = true;
                    btnFinish.Visible = true;
                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Visible = false;
            btnFinish.Visible = false;
            gameTimer4.Enabled = true;
            lblEndGame.Visible = false;
            pCar.Location = new Point(150, 308);
        }
        void CollectCoin()
        {
            List<PictureBox> boxes = new List<PictureBox>();
            boxes.Add(pCoin1);
            boxes.Add(pCoin2);
            boxes.Add(pCoin3);
            foreach(var i in boxes)
            {
                if (pCar.Bounds.IntersectsWith(i.Bounds))
                {
                    collectCoin++;
                    lblcoin.Text = "Coins :" + collectCoin.ToString();
                    x = r.Next(25, 200);
                    i.Location = new Point(x, 0);
                }
            }


        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            gameTimer4.Enabled = true;
            lblcoin.Visible = true;
        }
    }
}
