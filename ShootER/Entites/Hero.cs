using ShootER.World;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Label = System.Windows.Forms.Label;

namespace ShootER.Entites
{
    public class Hero
    {
        public int playerSpeed;

        public Hero()
        {
            playerSpeed = 5;
        }
        public void PlayerMove(PictureBox player, Bullets bullet, Enemy enm, Timer t1, Timer t2, Timer t3, Timer t4, KeyEventArgs e)
        {
            player.Image = Properties.Resources.cowboy_run;
            switch (e.KeyCode)
            {
                case Keys.A:
                    {
                        t1.Start();
                        break;
                    }
                case Keys.D:
                    {
                        t2.Start();
                        break;
                    }
                case Keys.S:
                    {
                        t3.Start();
                        break;
                    }
                case Keys.W:
                    {
                        t4.Start();
                        break;
                    }
                case Keys.Space:
                    {
                        bullet.Shoot.controls.play();
                        Physics.Intersection(bullet, enm, player);
                        if (bullet.bullet.Left > 1280)
                        {
                            bullet.bullet.Location = new Point(player.Location.X + 100 + 50, player.Location.Y + 50);
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        public void PlayerStop(PictureBox player, Timer t1, Timer t2, Timer t3, Timer t4)
        {
            player.Image = Properties.Resources.cowboy_idble;
            t1.Stop();
            t2.Stop();
            t3.Stop();
            t4.Stop();
        }
        
        public void Death(Label lbl)
        {
            lbl = new Label();
            lbl.Text = "Game Over";
            lbl.Location = new Point(500, 50);
            lbl.Visible = true;
        }
    }
}
