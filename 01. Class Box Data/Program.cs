using System;

namespace _01._Class_Box_Data
{
    class Program
    {
        static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

                Box box = new Box(lenght,width,height);

                if (lenght >=0 && width >= 0 && height >= 0)
                {
                    Console.WriteLine(box.SurfaceArea());
                    Console.WriteLine(box.CalculeteLeteralSurfaceArea());
                    Console.WriteLine(box.CalculateVolume());

                }
            

        }
    }
}
