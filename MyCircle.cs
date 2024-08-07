using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;

        public MyCircle()
        {
            _radius = 50;

        }

        public int Radius { get => _radius; set => _radius = value; }

        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.FillCircle(Color.Red, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black, X, Y, _radius + 2);
        }
    }
}
