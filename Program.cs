using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);

            Drawing draw = new Drawing();

            do
            {
                SplashKit.ProcessEvents(); // get user input 
                SplashKit.ClearScreen(); // reset buffer inside memory

                // start processing

                // set shape position to be where user clicks
                float userX = SplashKit.MouseX();
                float userY = SplashKit.MouseY();
                bool userMouseClickLeft = SplashKit.MouseClicked(MouseButton.LeftButton);
                bool userMouseClickRight = SplashKit.MouseClicked(MouseButton.RightButton);

                Point2D userMousePos = new Point2D();
                userMousePos.X = SplashKit.MouseX();
                userMousePos.Y = SplashKit.MouseY();

                // Add shape if left mouse button is clicked
                if (userMouseClickLeft)
                {
                    Shape s = new Shape();
                    s.X = userX;
                    s.Y = userY;

                    draw.AddShape(s);
                }

                // Select shape if right mouse button is clicked
                if (userMouseClickRight)
                {
                    draw.SelectShapesAt(userMousePos);
                }

                // remove the shape if the user has selected it and pressed the delete key
                bool userDeletePressed = SplashKit.KeyTyped(KeyCode.DeleteKey);
                if (userDeletePressed)
                {
                    draw.RemoveSelectedShapes();
                }

                // Draw all shapes
                draw.Draw();

                // end processing

                SplashKit.RefreshScreen(); // send the current screen to be drawn to GPU
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}
