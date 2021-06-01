using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Racer.Helpers;
using System.Drawing;

namespace Traffic_Racer.Core.Model
{
    public static class GameModel
    {
        public static PlayerCar Car;
        public static int Score;
        public static int EnemiesCount;
        public static int LinesCount;
        public static List<EnemyCar> Enemies;
        public static List<Line> Lines;

        public static void Initialize(PlayerCar car, int enemiesCount, int linesCount)
        {
            Car = car;
            EnemiesCount = enemiesCount;
            LinesCount = linesCount;

            InitGameObjects();
        }

        private static void InitGameObjects()
        {
            Lines = new List<Line>();
            Enemies = new List<EnemyCar>();
            for (int i = 0; i < LinesCount; i++) 
                Lines.Add(new Line(0, 400 * i));

            for (int i = 0; i < EnemiesCount; i++)
                Enemies.Add(new EnemyCar(Paths.PathToRedCarImage, 100 * i, new Random().Next(-400, 400)));
        }

        public static void СheckCollision()
        {
            if (Traffic_Racer.canMove)
                foreach (var enemy in Enemies)
                    if (Car.Width + enemy.Width >= Math.Max(Car.Width + Car.X, enemy.Width + enemy.X)
                    - Math.Min(Car.X, enemy.X) &&
                    Car.Height + enemy.Height >= Math.Max(Car.Height + Car.Y, enemy.Height + enemy.Y)
                    - Math.Min(Car.Y, enemy.Y))
                        Traffic_Racer.canMove = false;

        }

        public static void UpdateScore()
        {
            Score++;
            Traffic_Racer.ScoreLabel.Text = "Score: " + Score.ToString();
        }
    }
}
