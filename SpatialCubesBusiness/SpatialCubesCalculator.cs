using SpatialCubesDomain;
using System;

namespace SpatialCubesBusiness
{
    public static class SpatialCubesCalculator
    {
        public static bool Collide(Cube aCube, Cube otherCube)
        {
            bool result = false;

            double centerDistanceX = Math.Abs(aCube.Center.X - otherCube.Center.X);
            double centerDistanceY = Math.Abs(aCube.Center.Y - otherCube.Center.Y);
            double centerDistanceZ = Math.Abs(aCube.Center.Z - otherCube.Center.Z);

            double gapX = centerDistanceX - aCube.Width / 2 - otherCube.Width / 2;
            double gapY = centerDistanceY - aCube.Height / 2 - otherCube.Height / 2;
            double gapZ = centerDistanceZ - aCube.Depth / 2 - otherCube.Depth / 2;

            result = gapX <= 0 && gapY <= 0 && gapZ <= 0;

            return result;
        }

        public static double Intersect(Cube aCube, Cube otherCube)
        {
            double intersectionVolume = 0;

            if (Collide(aCube, otherCube))
            {

                Point[] aCubeVertices = GetVertices(aCube);
                Point[] otherVertices = GetVertices(otherCube);

                double intersectionWidth = GetIntersectionDistance(aCubeVertices[0].X, aCubeVertices[1].X, otherVertices[0].X, otherVertices[1].X);

                double intersectionHeight = GetIntersectionDistance(aCubeVertices[0].Y, aCubeVertices[4].Y, otherVertices[0].Y, otherVertices[4].Y);

                double intersectionDepth = GetIntersectionDistance(aCubeVertices[0].Z, aCubeVertices[3].Z, otherVertices[0].Z, otherVertices[3].Z);

                intersectionVolume = intersectionWidth * intersectionHeight * intersectionDepth;
            }

            return intersectionVolume;
        }

        public static Point[] GetVertices(Cube aCube)
        {
            Point[] aCubeVertices = new Point[8];

            double halfWidth = aCube.Width / 2;
            double halfHeight = aCube.Height / 2;
            double halfDepth = aCube.Depth / 2;

            double centerX = aCube.Center.X;
            double centerY = aCube.Center.Y;
            double centerZ = aCube.Center.Z;

            //Lower face
            aCubeVertices[0] = new Point(centerX - halfWidth, centerY - halfHeight, centerZ - halfDepth);
            aCubeVertices[1] = new Point(centerX + halfWidth, centerY - halfHeight, centerZ - halfDepth);
            aCubeVertices[2] = new Point(centerX + halfWidth, centerY - halfHeight, centerZ + halfDepth);
            aCubeVertices[3] = new Point(centerX - halfWidth, centerY - halfHeight, centerZ + halfDepth);
            //Upper face
            aCubeVertices[4] = new Point(centerX - halfWidth, centerY + halfHeight, centerZ - halfDepth);
            aCubeVertices[5] = new Point(centerX + halfWidth, centerY + halfHeight, centerZ - halfDepth);
            aCubeVertices[6] = new Point(centerX + halfWidth, centerY + halfHeight, centerZ + halfDepth);
            aCubeVertices[7] = new Point(centerX - halfWidth, centerY + halfHeight, centerZ + halfDepth);

            return aCubeVertices;
        }

        private static double GetIntersectionDistance(double startPointA, double endPointA, double startPointB, double endPointB)
        {
            double result = 0;

            double intersectionStartingPoint;
            double intersectionEndingPoint;

            if ((startPointA + endPointA >= startPointB) || (startPointB + endPointB >= startPointA))
            {
                intersectionStartingPoint = (Math.Min(startPointA, startPointB) == startPointA) ? startPointB : startPointA;

                intersectionEndingPoint = (Math.Min(endPointA, endPointB) == endPointA) ? endPointA : endPointB;

                result = Math.Abs(intersectionStartingPoint - intersectionEndingPoint);
            }

            return result;
        }
    }
}
