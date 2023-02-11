using ShootER.World;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootER.Entites
{
    public class Enemy
    {
        public PictureBox[] enemies;
        int enemySize;
        int enemySpeed;
        Image enemySkin;

        Random random = new Random();

        public Enemy()
        {
            enemies = new PictureBox[4];
            enemySize = random.Next(60, 90);
            enemySpeed = 3;
            enemySkin = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Images\\apap.gif"));
        }

        public void EnemyCreate()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(enemySize, enemySize);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BackColor = Color.Transparent;
                enemies[i].Image = enemySkin;
                enemies[i].Location = new Point((i + 1) * random.Next(150, 250) + 1080, random.Next(450, 600)); 
            }
        }
        public void EnemyMove(PictureBox hero, Bullets blt, Hero player, Label lbl)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Left -= enemySpeed + (int)(Math.Sin(enemies[i].Left * Math.PI / 180) + Math.Cos(enemies[i].Left * Math.PI / 180));
                Physics.IntersectionEnemy(this, hero, player, lbl);
                Physics.Intersection(blt, this, hero);
               

                if (enemies[i].Left < 0) 
                {
                    enemySize = random.Next(60, 90);
                    enemies[i].Size = new Size(enemySize, enemySize);
                    enemies[i].Location = new Point((i + 1) * random.Next(150, 250) + 1080, random.Next(450, 600));
                }
            }
        }
    }
}
