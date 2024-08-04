using Microsoft.VisualBasic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;



class Program
{
    static void Main(string[] args)
    {



        Rectangle rectangle = new Rectangle(0, 0, 10, 20);
        Console.WriteLine(rectangle);
        rectangle.Move(-5, -10);
        Console.WriteLine(rectangle);



    }

}
