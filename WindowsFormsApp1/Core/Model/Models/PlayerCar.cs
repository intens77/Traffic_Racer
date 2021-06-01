using System.Drawing;
using Traffic_Racer.Helpers;
using Traffic_Racer.Core.Controller;

namespace Traffic_Racer.Core.Model
{
    public class PlayerCar : GameObject
    {
        public int Speed;
        public int SpeedLR;

        public PlayerCar(int x, int y)
        {
            Icon = Image.FromFile(Paths.PathToPlayerCarImage);
            X = x;
            Y = y;
            Width = Icon.Width;
            Height = Icon.Height;
            Speed = -10;
            SpeedLR = 10;
        }

        public void MovePlayer()
        {
            if (X > 0 && Controller.Controller.goleft == true)
                X -= SpeedLR;
            if (X < Traffic_Racer.GameField.Width - GameModel.Car.Width && Controller.Controller.goright == true)
                X += SpeedLR;
        }
    }
}
