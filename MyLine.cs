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
        private int _length;

        public MyLine(Color bgColor) : base(bgColor)
        {
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void DrawOutline()
        {
            throw new NotImplementedException();
        }

        public override bool IsAt(Point2D pt)
        {
            throw new NotImplementedException();
        }
    }
}
