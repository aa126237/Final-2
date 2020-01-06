using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Final
{
    class Enemy
    {
        public static int enemiesLevel = 1;
        public static int numberOfEnemies = 0;
        public static List<Enemy> enemies = new List<Enemy>();

        public static void summonEnemy()
        {
            enemies.Add(new Enemy(Convert.ToString(numberOfEnemies)));
        }


        public Enemy(string enemyName)
        {

        }




    }
}
