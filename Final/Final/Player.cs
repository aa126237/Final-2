using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Player
    {
        public static int playerHitpoints = 12;
        public static int playerAttackSpeed = 1;
        public static int playerMoveSpeed = 3;
        public static int playerDamage = 1;

        public static void playerDamaged(int damage)
        {
            playerHitpoints -= damage;
        }
    }
}
