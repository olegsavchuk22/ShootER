using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ShootER.Entites
{
    public class Bullets
    {
        public PictureBox bullet;
        int bltSpeed = 30;
        public WindowsMediaPlayer Shoot;

        public Bullets()
        {
            bullet = new PictureBox();
            Shoot = new WindowsMediaPlayer();
            Shoot.URL = "Sounds\\shoot.mp3";
            Shoot.settings.volume = 5;
        }

        public void BulletCreate()
        {
            Random rnd = new Random();
            bullet = new PictureBox();
            bullet.BorderStyle = BorderStyle.None;
            bullet.Size = new Size(20, 5);
            bullet.BackColor = Color.White;
        }
        public void BulletMove()
        {
            bullet.Left += bltSpeed;
        }
    }
}
