 class Triangle : Shape, Ishape
{
    public double Hypotenuese { get; set; }

    public Triangle( int he, int le) // constructor
    {
        height = he;
        length = le;
    }
    public double getArea()
    {
        return .5 * length * height;
    }
}