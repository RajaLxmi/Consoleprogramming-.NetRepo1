class Cube : Shape,Ishape
{
    public double  Width { get; set; }

    public Cube(int he,int le)
    {
        height = he;
        length = le;
    }

    public double getArea()
    {
        return length * length;
    }
}