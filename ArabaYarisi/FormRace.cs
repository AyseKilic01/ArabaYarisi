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

        private void FrmGameRace_Load(object sender, EventArgs e)
        {
            
        }
        Random r = new Random();
        int x, y;
        void Enemy(int speed)
        {
            if (pEnemy1.Top >= 350)
            {
                x = r.Next(0, 200);
                pEnemy1.Location = new Point(x, 0);
            }
            else {pEnemy1.Top += speed; }
            if (pEnemy2.Top >= 250)
            {
                x = r.Next(0, 250);
                pEnemy2.Location = new Point(x, 0);
            }
            else { pEnemy2.Top += speed; }
            if (pEnemy3.Top >= 350)
            {
                x = r.Next(200, 350);
                pEnemy3.Location = new Point(x, 0);
            }
            else { pEnemy3.Top += speed; }
        }
        void MoveLine(int speed)
        {
            if(line1.Top >= 350)
            {
                line1.Top = 0;
            }
            else { line1.Top += speed; }
            if (line2.Top >= 350)
            {
                line2.Top = 0;
            }
            else { line2.Top += speed; }
            if (line3.Top >= 350)
            {
                line3.Top = 0;
            }
            else { line3.Top += speed; }
            if (line4.Top >= 350)
            {
                line4.Top = 0;
            }
            else { line4.Top += speed; }
        }

        private void gameTimer4_Tick(object sender, EventArgs e)
        {
            MoveLine(5);
            Enemy(5);
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            gameTimer4.Enabled = true;
        }
    }
}
