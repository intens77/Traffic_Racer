using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Racer.Core.Model
{
    public class EnemyCar : GameObject
    {
        public int Speed;

        public EnemyCar(string path, int x, int y)
        {
            Icon = Image.FromFile(path);
            X = x;
            Y = y;
            Width = Icon.Width;
            Height = Icon.Height;
            Speed = 5;
        }

        public void MoveEnemy(int step)
        {
            if (Y > 1000)
            {
                X = new Random().Next(100 * step, (100 * (step + 1)) - Width);
                Y = -new Random().Next(200, 500);
                Speed = new Random().Next(5, 10);
            }
            Y += Speed;
        }
    }
}
