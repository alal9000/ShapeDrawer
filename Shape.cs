using SplashKitSDK;
using System;
using System.Drawing;
using Color = SplashKitSDK.Color;

public class Shape
{
	// fields

	private float _x, _y;
	private int _width, _height;
	private Color _bgColor;
	private bool _selected;

	// constructor
	public Shape()
	{
		_x = 0;
		_y = 0;
		_width = 100;
		_height = 100;
		_bgColor = Color.Green;
	}

	// properties

	public Color BgColor
	{
		get { return _bgColor; }
		set { _bgColor = value; }
	}

	public float X
	{
		get { return _x; }
		set { _x = value; }
	}

	public float Y
	{
		get { return _y; }
		set { _y = value; }
	}

	public int Width
	{
		get { return _width; }
		set { _width = value; }
	}

	public int Height
	{
		get { return _height; }
		set { _height = value; }
	}

	public bool Selected
	{
		get { return _selected; }
		set { _selected = value; }
	}


    // methods

    public void DrawOutline()
    {
        SplashKit.DrawRectangle(Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
    }

    public void Draw()
	{
		SplashKit.FillRectangle(_bgColor, _x, _y, _width, _height);

		if (_selected)
		{
			DrawOutline();
		}
	}

	public Boolean IsAt(Point2D pt)
	{
		return (pt.X >= _x && pt.X <= _x + _width) && (pt.Y >= _y && pt.Y <= _y + _height);
	}
}
