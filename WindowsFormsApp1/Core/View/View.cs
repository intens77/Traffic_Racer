using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Racer.Core.Model;
using Traffic_Racer.Core.Controller;

namespace Traffic_Racer.Core.View
{
    public static class View
    {
        public static void Draw(object sender, PaintEventArgs e)
        {
            var bitmap = new Bitmap(Traffic_Racer.GameField.Width, Traffic_Racer.GameField.Height);

            Graphics graphics = Graphics.FromImage(bitmap);
            foreach (var line in GameModel.Lines)
                graphics.DrawImage(line.Icon, line.X, line.Y, line.Width, 200);
            foreach (var enemy in GameModel.Enemies)
            {
                graphics.DrawImage(enemy.Icon, enemy.X, enemy.Y, enemy.Width, enemy.Height);
            }
            graphics.DrawImage(GameModel.Car.Icon, GameModel.Car.X, GameModel.Car.Y, GameModel.Car.Width, GameModel.Car.Height);
            if (!Traffic_Racer.canMove)
            {
                graphics.DrawImage(Image.FromFile(Helpers.Paths.PathToExplosionImage), GameModel.Car.X, GameModel.Car.Y - GameModel.Car.Height / 2, 100, 100);
            }

            Traffic_Racer.GameField.Image = bitmap;
        }
    }
}
