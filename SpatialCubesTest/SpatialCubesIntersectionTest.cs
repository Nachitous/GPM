using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpatialCubesBusiness;
using SpatialCubesDomain;

namespace SpatialCubesTest
{
    [TestClass]
    public class SpatialCubesIntersectionTest
    {
        [TestMethod]
        public void TwoCubesInDiffentQuadrantAndPlaneTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            double intersectionVolumne;

            centerA = new Point(-3, -5, 1);
            centerB = new Point(4, 4, 3);

            cubeA = new Cube(centerA, 2, 2, 2);
            cubeB = new Cube(centerB, 2, 2, 2);

            intersectionVolumne = SpatialCubesCalculator.Intersect(cubeA, cubeB);

            Assert.IsTrue(intersectionVolumne == 0);
        }
        
        [TestMethod]
        public void TwoCubesInSameQuadrantAndPlaneAppartTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            double intersectionVolumne;

            centerA = new Point(1, 1, 0);
            centerB = new Point(1, 4, 0);

            cubeA = new Cube(centerA, 2, 2, 2);
            cubeB = new Cube(centerB, 2, 2, 2);

            intersectionVolumne = SpatialCubesCalculator.Intersect(cubeA, cubeB);

            Assert.IsTrue(intersectionVolumne == 0);
        }
        
        [TestMethod]
        public void TwoCubesOverlappingTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            double intersectionVolumne;

            centerA = new Point(0, 0, 0);
            centerB = new Point(3, 3, 3);

            cubeA = new Cube(centerA, 4, 4, 4);
            cubeB = new Cube(centerB, 4, 4, 4);

            intersectionVolumne = SpatialCubesCalculator.Intersect(cubeA, cubeB);

            Assert.IsTrue(intersectionVolumne > 0);
        }
        
        [TestMethod]
        public void IncludedSameCenterTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            double intersectionVolumne;

            centerA = new Point(5, 5, 5);
            centerB = new Point(5, 5, 5);

            cubeA = new Cube(centerA, 4, 4, 4);
            cubeB = new Cube(centerB, 2, 2, 2);

            intersectionVolumne = SpatialCubesCalculator.Intersect(cubeA, cubeB);

            Assert.IsTrue(intersectionVolumne > 0);
        }
        
        [TestMethod]
        public void CompleteOverlapTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            double intersectionVolumne;

            centerA = new Point(5, 3, 4);
            centerB = new Point(3, 2, 3);

            cubeA = new Cube(centerA, 4, 6, 4);
            cubeB = new Cube(centerB, 8, 1, 6);

            intersectionVolumne = SpatialCubesCalculator.Intersect(cubeA, cubeB);

            Assert.IsTrue(intersectionVolumne > 0);
        }
        
        [TestMethod]
        public void IncludedDifferentCenterTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            double intersectionVolumne;

            centerA = new Point(0, 0, 0);
            centerB = new Point(1, 1, 1);

            cubeA = new Cube(centerA, 4, 4, 4);
            cubeB = new Cube(centerB, 1, 1, 1);

            intersectionVolumne = SpatialCubesCalculator.Intersect(cubeA, cubeB);

            Assert.IsTrue(intersectionVolumne > 0);
        }
        
        [TestMethod]
        public void TouchingEdgeTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            double intersectionVolumne;

            centerA = new Point(0, 0, 0);
            centerB = new Point(2, 2, 0);

            cubeA = new Cube(centerA, 2, 2, 2);
            cubeB = new Cube(centerB, 2, 2, 2);

            intersectionVolumne = SpatialCubesCalculator.Intersect(cubeA, cubeB);

            Assert.IsTrue(intersectionVolumne == 0);
        }

        [TestMethod]
        public void TouchingFaceTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            double intersectionVolumne;

            centerA = new Point(0, 0, 0);
            centerB = new Point(2, 0, 0);

            cubeA = new Cube(centerA, 2, 2, 2);
            cubeB = new Cube(centerB, 2, 2, 2);

            intersectionVolumne = SpatialCubesCalculator.Intersect(cubeA, cubeB);

            Assert.IsTrue(intersectionVolumne == 0);
        }
        
        [TestMethod]
        public void TouchingVertexTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            double intersectionVolumne;

            centerA = new Point(0, 0, 0);
            centerB = new Point(2, 2, 2);

            cubeA = new Cube(centerA, 2, 2, 2);
            cubeB = new Cube(centerB, 2, 2, 2);

            intersectionVolumne = SpatialCubesCalculator.Intersect(cubeA, cubeB);

            Assert.IsTrue(intersectionVolumne == 0);
        }
    }
}
