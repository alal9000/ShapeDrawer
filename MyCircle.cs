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

        public MyCircle(Color clr, int radius) : base(clr)
        {
            _radius = radius;
        }



        public MyCircle() : this(Color.Blue, 50)
        {

        }

        public int Radius { get => _radius; set => _radius = value; }

        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.FillCircle(BgColor, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black, X, Y, _radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            double distance = SplashKit.PointPointDistance(pt, new Point2D { X = X, Y = Y });
            return distance <= _radius;
        }
    }
}
