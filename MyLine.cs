using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        // fields
        private int _length;

        // constructors
        public MyLine(Color clr, int length) : base(clr)
        {
            Length = length;
        }

        public MyLine() : this(Color.Red, 100)
        {
        }

        // properties
        public int Length { get => _length; set => _length = value; }

        // methods
        public override void Draw()
        {

            SplashKit.DrawLine(this.BgColor, X, Y, X + Length, Y);

            SplashKit.FillCircle(Color.Yellow, X, Y, 5);
            SplashKit.FillCircle(Color.Yellow, X + Length, Y, 5);

            if (Selected)
                DrawOutline();
        }

        public override void DrawOutline()
        {
            const int circleRadius = 5;
            const int outlineBuffer = 2;

            float startX = X - circleRadius - outlineBuffer;
            float startY = Y - circleRadius - outlineBuffer;
            float endX = X + Length + circleRadius + outlineBuffer;
            float endY = Y + circleRadius + outlineBuffer;

            SplashKit.DrawRectangle(Color.Black, startX, startY, endX - startX, endY - startY);
        }

        public override bool IsAt(Point2D pt)
        {
            const float thickness = 3.0f;

            return (pt.X >= X - thickness && pt.X <= X + Length + thickness) && (pt.Y >= Y - thickness && pt.Y <= Y + thickness);
        }
    }
}
