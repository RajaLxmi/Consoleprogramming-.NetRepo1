class Rectangle : Shape, Ishape
{
    public Rectangle(int he,int le)
    {
        height = he;
        length = le;
    }
    public double getArea()
    {
        return length * height;
    }
}