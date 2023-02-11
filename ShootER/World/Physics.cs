using ShootER.Entites;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootER.World
{
    public static class Physics
    {
        public static void Intersection(Bullets blt, Enemy enm, PictureBox hero) 
        {
            Random random = new Random();   
            for (int i = 0; i < enm.enemies.Length; i++)
            {
                if (blt.bullet.Bounds.IntersectsWith(enm.enemies[i].Bounds))
                {
                    enm.enemies[i].Location = new Point((i + 1) * random.Next(150, 250) + 1080, random.Next(450, 600));
                    blt.bullet.Location = new Point(2000, hero.Location.Y + 50);
                }
                
            }
        }
       
        public static void IntersectionEnemy(Enemy enm, PictureBox hero, Hero player, Label lbl)
        {
            for (int i = 0; i < enm.enemies.Length; i++)
            {
                if (hero.Bounds.IntersectsWith(enm.enemies[i].Bounds))
                {
                    player.Death(lbl);
                    hero.Visible = false;
                    
                }
            }
        }
    }
}
