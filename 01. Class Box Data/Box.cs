using System;

namespace _01._Class_Box_Data
{
    public class Box
    {
        private double lenght;

        private double width;

        private double height;


        public Box(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        public double Lenght
        {
            get => this.lenght;
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                    
                }

                this.lenght = value;
            }
        }

        public double Width
        {
            get => this.width;

            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                }
                this.width = value;
            }

        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public string CalculateVolume()
        {
            //Volume = lwh

            double result = Lenght * Width * Height;

            return $"Volume - {result:f2}";
        }

        public string CalculeteLeteralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            double result = (2 * Lenght * Height) + (2 * Width * Height);

            return $"Lateral Surface Area - {result:f2}";
        }

        public string SurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            double result = (2 * Lenght * Width) + (2 * Lenght * Height) + (2 * Width * Height);

            return $"Surface Area - {result:f2}";
        }


    }
}
