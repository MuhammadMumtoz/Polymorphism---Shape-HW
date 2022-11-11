class Square : Rectangle
{
    double _side = 1.0;
    public Square() : base() { }
    public Square(double side)
    {
        _side = side;
    }
    public Square(double side, string color, bool filled)
    {
        _side = side;
        _color = color;
        _filled = filled;
    }
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }
    public override void SetLength(double side)
    {
        _length = side;
    }
    public override void SetWidth(double side)
    {
        _width = side;
    }
    public override string ToString()
    {
        return $"Square[Rectangle[Shape[color={_color},filled = {_filled}, length = {_length}, width = {_width}";
    }

}