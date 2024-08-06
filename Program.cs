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

            Point2D point = new Point2D();
            point.X = 500;
            point.Y = 500;


            do
            {
                SplashKit.ProcessEvents(); // get user input 
                SplashKit.ClearScreen(); // reset buffer inside memory

                // start processing

                // set shape position to be where user clicks
                float userX = SplashKit.MouseX();
                float userY = SplashKit.MouseY();
                bool userMouseClick = SplashKit.MouseClicked(MouseButton.LeftButton);

                

                // other processing

                if (userMouseClick)
                {
                    Shape s = new Shape();
                    s.X = userX;
                    s.Y = userY;

                    draw.AddShape(s);
                }

                // change the shape color if user mouses over the shape and presses space

                bool userSpaceBarPressed = SplashKit.KeyTyped(KeyCode.SpaceKey);
                Point2D userMousePosition = SplashKit.MousePosition();
                Color randomColor = SplashKit.RandomRGBColor(255);




                // end processing



                SplashKit.RefreshScreen(); // send the current screen to be drawn to GPU
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));

        }
    }
}
