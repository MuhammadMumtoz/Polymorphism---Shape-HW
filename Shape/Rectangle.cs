class Rectangle : Shape
{
    protected double _width = 1.0;
    protected double _length = 1.0;
    public Rectangle() : base() { }
    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }
    public Rectangle(double length, double width, string color, bool filled) : base(color, filled)
    {
        _length = length;
        _width = width;
    }
    public double GetLength(){
        return _length;
    }
    public virtual void SetLength(double length){
        _length = length;
    }
    public double GetWidth(){
        return _width;
    }
    public virtual void SetWidth(double width){
        _width = width;
    }
    public override double GetArea()
    {
        return _length*_width;
    }
    public override double GetPerimeter()
    {
        return 2*(_length+_width);
    }
    public override string ToString()
    {
        return $"Rectangle[Shape[color={_color},filled={_filled},width={_width},length={_length}]]";
    }
}