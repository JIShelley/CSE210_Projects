class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 1.0;
    }

    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public double GetArea()
    {
        return _radius * _radius * 3.14159;
    }
    public void SetRadius(double radius)
    {
        if (_radius < 0.0)
        {
            _radius = 1.0;
            Console.WriteLine("Error.");
        }
        else
        {
            _radius = radius;
        }
    }

    public double GetRadius()
    {
        return _radius;
    }
}
