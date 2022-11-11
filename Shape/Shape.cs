abstract class Shape
{
    protected string? _color = "red";
    protected bool _filled = true;
    public Shape() { }
    public Shape(string color, bool filled)
    {
        _color = color;
        _filled = filled;
    }
    public string GetColor(){
        return _color;
    }
    public void SetColor(string color){
        _color = color;
    }
    public bool IsFilled(){
        return _filled;
    }
    public void SetFilled(bool filled){
        _filled = filled;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        return $"Shape[Color={_color},filled={_filled}";
    }
}