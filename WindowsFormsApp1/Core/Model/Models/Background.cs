using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Racer.Core.Model
{
    public class Background : GameObject
    {
        public Background(string path, int x, int y)
        {
            Icon = Image.FromFile(path);
            X = x;
            Y = y;
            Width =  Traffic_Racer.GameField.Width;
            Height = Traffic_Racer.GameField.Height;
        }
    }
}
