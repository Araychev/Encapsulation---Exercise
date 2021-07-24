using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;

            }
        }

        public int Age
        {
            get => this.age;

            private set
            {
                if (value <= MinAge || value >= MaxAge)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }
                this.age = value;
            }
        }

        public double ProductPerDay => this.CalculateProductPerDay();

        private double CalculateProductPerDay()
        {
            return this.Age switch
            {
                0 => 1.5,
                1 => 1.5,
                2 => 1.5,
                3 => 1.5,
                4 => 2,
                5 => 2,
                6 => 2,
                7 => 2,
                8 => 1,
                9 => 1,
                10 => 1,
                11 => 1,
                _ => 0.75
            };
        }
    }
}
