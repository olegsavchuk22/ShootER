using ShootER.Entites;
using ShootER.World;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ShootER
{
    public partial class Form1 : Form
    {
        Map world;
        Hero player;
        Bullets bullet;
        Enemy enemies;
       

        WindowsMediaPlayer GameSong;

        public Form1()
        {
            Init();
            
            BackgroundImage = world.bg;
            BackgroundImageLayout = ImageLayout.Stretch;

            
            InitializeComponent();
           
        }

        public void Init()
        {
            world = new Map();
            player = new Hero();
            bullet = new Bullets();
            enemies = new Enemy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            world.CloudCreate();
            bullet.BulletCreate();
            enemies.EnemyCreate();

            GameSong = new WindowsMediaPlayer();
            GameSong.URL = "Sounds\\GameSong.mp3";
            GameSong.settings.setMode("loop", true);
            GameSong.settings.volume = 15;

            for (int i = 0; i < world.cloud.Length; i++)
            {
                this.Controls.Add(world.cloud[i]);
            }
            this.Controls.Add(bullet.bullet);
            for (int i = 0; i < enemies.enemies.Length; i++)
            {
                this.Controls.Add(enemies.enemies[i]);
            }

            GameSong.controls.play();
        }

        private void MoveBGTimer_Tick(object sender, EventArgs e)
        {
            world.CloudMove();
        }

        private void MoveLeftT_Tick(object sender, EventArgs e)
        {
            if (HeroBox.Left > 10)
            {
                HeroBox.Left -= player.playerSpeed;
            }
        }

        private void MoveRightT_Tick(object sender, EventArgs e)
        {
            if (HeroBox.Left < 1150)
            {
                HeroBox.Left += player.playerSpeed;
            }
        }

        private void MoveUpT_Tick(object sender, EventArgs e)
        {
            if (HeroBox.Top > 395)
            {
                HeroBox.Top -= player.playerSpeed;
            }
            else
                HeroBox.Top = 394;
        }

        private void MoveDownT_Tick(object sender, EventArgs e)
        {
            if (HeroBox.Top < 565)
            {
                HeroBox.Top += player.playerSpeed;
            }
            else
                HeroBox.Top = 566;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            player.PlayerMove(HeroBox, bullet, enemies, MoveLeftT, MoveRightT, MoveDownT, MoveUpT, e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            player.PlayerStop(HeroBox, MoveLeftT, MoveRightT, MoveDownT, MoveUpT);
        }

        private void MoveBulletT_Tick(object sender, EventArgs e)
        {
            bullet.BulletMove();
        }

        private void MoveEnemyT_Tick(object sender, EventArgs e)
        {
            enemies.EnemyMove(HeroBox, bullet, player, label1);
        }
        //public void Death(string str)
        //{
        //    label1 = new Label();
        //    label1.Text = str;
        //    label1.Location = new Point(500, 50);
        //    label1.Visible = true;

        //    //MoveEnemyT.Stop();
        //}
    }
}
