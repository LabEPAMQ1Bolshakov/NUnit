using GeometricFigures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresTests
{
    [TestFixture]
    public class TriangleTestClass
    {
        [Test, TestCaseSource("PositiveTriangleCases")]
        public void GetAreaTrianglePositiveTest(int side)        
        {
            Triangle triangle = new Triangle(side, side, side);
            double halfP = (double)(side + side + side)/2;
            double myArea = Math.Round(
                Math.Pow(halfP*(halfP-side)*(halfP-side)*(halfP-side)
                , 0.5), 5);
            double methodArea = Math.Round(triangle.getAreaTriangle(), 5);
            Assert.AreEqual(myArea, methodArea, "Метод вернул неверное значение площади треугольника при\nside1 = {0}\nside2 = {1}\nside3 = {2}", side, side, side);
        }

        [Test, TestCaseSource("NegativeTriangleCases")]
        public void GetAreaTriangleNegativeTest(int side)
        {
            double area;
            Triangle triangle = new Triangle(side, side, side);            
            area = triangle.getAreaTriangle();
            Assert.IsNull(area, "Метод вернул значение площади треугольника при\nside1 = {0}\nside2 = {1}\nside3 = {2}", side, side, side);
        }

        [Test, TestCaseSource("PositiveTriangleCases")]
        public void GetLengthTrianglePositiveTest(int side)        
        {
            Triangle triangle = new Triangle(side, side, side);            
            double myLength = side + side + side;
            double methodLength = triangle.getLengthTriangle();
            Assert.AreEqual(myLength, methodLength, "Метод вернул неверное значение периметра треугольника при\nside1 = {0}\nside2 = {1}\nside3 = {2}", side, side, side);
        }

        [Test, TestCaseSource("NegativeTriangleCases")]
        public void GetLengthTriangleNegativeTest(int side)
        {
            double length;
            Triangle triangle = new Triangle(side, side, side);
            length = triangle.getLengthTriangle();
            Assert.IsNull(length, "Метод вернул значение площади треугольника при\nside1 = {0}\nside2 = {1}\nside3 = {2}", side, side, side);
        }

        static object[] PositiveTriangleCases =
        {
            new object[] {0},
            new object[] {1},
            new object[] {2},
            new object[] {3},
            new object[] {4},
            new object[] {5},
            new object[] {6},
            new object[] {7},
            new object[] {8},
            new object[] {9},
            new object[] {10},
            new object[] {11},
            new object[] {12},
            new object[] {13},
            new object[] {14},
            new object[] {15},
            new object[] {16},
            new object[] {17},
            new object[] {18},
            new object[] {19},
            new object[] {20},
        };

        static object[] NegativeTriangleCases =
        {
            new object[] {-1},
            new object[] {-2},
            new object[] {-3},
            new object[] {-4},
            new object[] {-5},
            new object[] {-6},
            new object[] {-7},
            new object[] {-8},
            new object[] {-9},
            new object[] {-10},
            new object[] {-11},
            new object[] {-12},
            new object[] {-13},
            new object[] {-14},
            new object[] {-15},
            new object[] {-16},
            new object[] {-17},
            new object[] {-18},
            new object[] {-19},
            new object[] {-20},
        };
    }
}
