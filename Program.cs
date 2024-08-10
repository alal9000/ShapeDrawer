using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }

        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);

            Drawing draw = new Drawing();

            ShapeKind kindToAdd = ShapeKind.Circle;

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

                bool rKeyPressed = SplashKit.KeyTyped(KeyCode.RKey);
                bool cKeyPressed = SplashKit.KeyTyped(KeyCode.CKey);
                bool lKeyPressed = SplashKit.KeyTyped(KeyCode.LKey);

                if (rKeyPressed)
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                else if (cKeyPressed)
                {
                    kindToAdd = ShapeKind.Circle;
                }
                else if (lKeyPressed)
                {
                    kindToAdd = ShapeKind.Line;
                }

                // Add shape if left mouse button is clicked
                if (userMouseClickLeft)
                {
                    Shape newShape;
                   
                    if (kindToAdd == ShapeKind.Circle)
                    {
                        MyCircle newCircle = new MyCircle();
                        newShape = newCircle;
                    }
                    else if (kindToAdd == ShapeKind.Rectangle)
                    {
                        MyRectangle newRect = new MyRectangle();
                        newShape = newRect;
                    }
                    else
                    {
                        MyLine newLine = new MyLine();
                        newShape = newLine;
                    }

                    newShape.X = userX;
                    newShape.Y = userY;

                    draw.AddShape(newShape);
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
