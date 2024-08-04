class Circle : Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public Circle(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override void Move(int deltaX, int deltaY)
    {
       X = +deltaX;
       Y = +deltaY;
    }

}
