using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Enemy
    {
        public static int enemiesLevel = 1;
        public static int numberOfEnemies = 0;
        public static List<Enemy> enemies = new List<Enemy>();

        public static void summonEnemy()
        {
            enemies.Add(new Enemy(Convert.ToString(numberOfEnemies), 1 + (enemiesLevel / 4), 1, (enemiesLevel * 4) - 1));
        }


        public Enemy(string enemyName, int enemyMovespeed, int enemydamage, int enemyHealth)
        {

        }




    }
}
