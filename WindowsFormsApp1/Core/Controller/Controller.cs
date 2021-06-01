using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Racer.Core.Model;

namespace Traffic_Racer.Core.Controller
{
    public static class Controller
    {
        public static bool goright = false;
        public static bool goleft = false;

        public static void UpdateFormState(object sender, EventArgs e)
        {
            if (Traffic_Racer.canMove)
            {
                MoveBackground();
                MoveEnemies();
                GameModel.Car.MovePlayer();
                GameModel.UpdateScore();
                GameModel.СheckCollision();
            }
        }

        private static void MoveBackground()
        {
            foreach (var line in GameModel.Lines)
            {
                line.MoveLine();
            }
        }

        private static void MoveEnemies()
        {
            for (int i = 0; i < GameModel.EnemiesCount; i++)
                GameModel.Enemies[i].MoveEnemy(i);
        }

        public static void CheckDownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goleft = true;
            if (e.KeyCode == Keys.Right)
                goright = true;
        }

        public static void CheckUpKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goleft = false;
            if (e.KeyCode == Keys.Right)
                goright = false;
        }
    }
}
