using System;
using System.Collections.Generic;
using System.Text;

namespace SpatialCubesDomain
{
    public class Cube : Figure
    {
        public double Width {get;set;}
        public double Height {get; set;}
        public double Depth {get; set;}

        public Cube(Point center, double width, double height, double depth) : base(center)
        {
            if (width <= 0)
            {
                throw new ArgumentException("Width has to be a positive number");
            }

            if (height <= 0)
            {
                throw new ArgumentException("Height has to be a positive number");
            }

            if (depth <= 0)
            {
                throw new ArgumentException("Depth has to be a positive number");
            }

            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }        
    }
}
