using System;
using Aula135.Entities.Enums;

namespace Aula135.Entities
{
    class Circle : Shape
    {        
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius; 
        }
    }
}
