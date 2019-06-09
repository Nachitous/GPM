namespace SpatialCubesDomain
{
    public abstract class Figure
    {
        public Point Center {get;set;}

        public Figure(Point center)
        {
            this.Center = center;
        }
    }
}
