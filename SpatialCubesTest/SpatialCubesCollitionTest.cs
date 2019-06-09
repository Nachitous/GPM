using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpatialCubesBusiness;
using SpatialCubesDomain;

namespace SpatialCubesTest
{
    [TestClass]
    public class SpatialCubesCollitionTest
    {
        [TestMethod]
        public void TwoCubesInDiffentQuadrantAndPlaneTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            bool collide;

            centerA = new Point(-3, -5, 1);
            centerB = new Point(4, 4, 3);

            cubeA = new Cube(centerA, 2, 2, 2);
            cubeB = new Cube(centerB, 2, 2, 2);

            collide = SpatialCubesCalculator.Collide(cubeA, cubeB);

            Assert.IsFalse(collide);
        }
        
        [TestMethod]
        public void TwoCubesInSameQuadrantAndPlaneAppartTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            bool collide;

            centerA = new Point(2, 2, 0);
            centerB = new Point(2, 5, 0);

            cubeA = new Cube(centerA, 1, 1, 1);
            cubeB = new Cube(centerB, 1, 1, 1);

            collide = SpatialCubesCalculator.Collide(cubeA, cubeB);

            Assert.IsFalse(collide);
        }
        
        [TestMethod]
        public void TwoCubesOverlappingTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            bool collide;

            centerA = new Point(0, 0, 0);
            centerB = new Point(3, 3, 3);

            cubeA = new Cube(centerA, 4, 4, 4);
            cubeB = new Cube(centerB, 4, 4, 4);

            collide = SpatialCubesCalculator.Collide(cubeA, cubeB);

            Assert.IsTrue(collide);
        }
        
        [TestMethod]
        public void TwoCubesFullyOverlappingTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            bool collide;

            centerA = new Point(1, 1, 1);
            centerB = new Point(1, 1, 1);

            cubeA = new Cube(centerA, 1, 1, 1);
            cubeB = new Cube(centerB, 1, 1, 1);

            collide = SpatialCubesCalculator.Collide(cubeA, cubeB);

            Assert.IsTrue(collide);
        }
        
        [TestMethod]
        public void OneCubeTotallyIncludedInTheOtherWithSameCenterTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            bool collide;

            centerA = new Point(0, 0, 0);
            centerB = new Point(0, 0, 0);

            cubeA = new Cube(centerA, 1, 1, 1);
            cubeB = new Cube(centerB, 2, 2, 2);

            collide = SpatialCubesCalculator.Collide(cubeA, cubeB);

            Assert.IsTrue(collide);
        }
        
        [TestMethod]
        public void OneCubeTotallyIncludedInTheOtherWithDifferentCenterTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            bool collide;

            centerA = new Point(0, 0, 0);
            centerB = new Point(1, 1, 1);

            cubeA = new Cube(centerA, 4, 4, 4);
            cubeB = new Cube(centerB, 1, 1, 1);

            collide = SpatialCubesCalculator.Collide(cubeA, cubeB);

            Assert.IsTrue(collide);
        }
        
        [TestMethod]
        public void TwoCubesSharingAnEdgeTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            bool collide;

            centerA = new Point(0, 0, 0);
            centerB = new Point(2, 2, 0);

            cubeA = new Cube(centerA, 2, 2, 2);
            cubeB = new Cube(centerB, 2, 2, 2);

            collide = SpatialCubesCalculator.Collide(cubeA, cubeB);

            Assert.IsTrue(collide);
        }

        [TestMethod]
        public void TwoCubesSharingAFaceTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            bool collide;

            centerA = new Point(0, 0, 0);
            centerB = new Point(2, 0, 0);

            cubeA = new Cube(centerA, 2, 2, 2);
            cubeB = new Cube(centerB, 2, 2, 2);

            collide = SpatialCubesCalculator.Collide(cubeA, cubeB);

            Assert.IsTrue(collide);
        }
        
        [TestMethod]
        public void TwoCubesSharingAVertexTest()
        {
            Point centerA;
            Point centerB;

            Cube cubeA;
            Cube cubeB;

            bool collide;

            centerA = new Point(0, 0, 0);
            centerB = new Point(2, 2, 2);

            cubeA = new Cube(centerA, 2, 2, 2);
            cubeB = new Cube(centerB, 2, 2, 2);

            collide = SpatialCubesCalculator.Collide(cubeA, cubeB);

            Assert.IsTrue(collide);
        }
    }
}
