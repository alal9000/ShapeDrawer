using SplashKitSDK;
using System;
using System.Drawing;
using Color = SplashKitSDK.Color;

public abstract class Shape
{
	// fields

	private float _x, _y;
	
	private Color _bgColor;
	private bool _selected;

	// constructor
	public Shape(Color bgColor)
	{
		BgColor = bgColor;
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

	

	public bool Selected
	{
		get { return _selected; }
		set { _selected = value; }
	}


	// methods

	public abstract void DrawOutline();

	public abstract void Draw();

	public abstract Boolean IsAt(Point2D pt);
}
