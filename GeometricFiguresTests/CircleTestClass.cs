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
    public class CircleTestClass
    {
        [Test, TestCaseSource("PositiveCircleCases")]
        public void GetAreaCirclePositiveTest(int radius)
        {
            Circle circle = new Circle(radius);
            double myArea = Math.Round(Math.PI * radius * radius, 5);
            double methodArea = Math.Round(circle.getAreaCircle(), 5);
            Assert.AreEqual(myArea, methodArea, "Метод вернул неверное значение площади круга при radius = {0}", radius);
        }

        [Test, TestCaseSource("NegativeCircleCases")]
        public void GetAreaCircleNegativeTest(int radius)
        {
            double area;
            Circle circle = new Circle(radius);            
            area = circle.getAreaCircle();
            Assert.IsNull(area, "Метод вернул значение площади круга при radius = {0}", radius);
        }

        [Test, TestCaseSource("PositiveCircleCases")]
        public void GetLengthCirclePositiveTest(int radius)
        {
            Circle circle = new Circle(radius);
            double myLength = Math.Round(2 * Math.PI * radius, 5);
            double methodLength = Math.Round(circle.getLengthCircle(), 5);
            Assert.AreEqual(myLength, methodLength, "Метод вернул неверное значение длины окружности при radius = {0}", radius);
        }

        [Test, TestCaseSource("NegativeCircleCases")]
        public void GetLengthCircleNegativeTest(int radius)
        {
            double length;
            Circle circle = new Circle(radius);
            length = circle.getLengthCircle();
            Assert.IsNull(length, "Метод вернул значение длины окружности при radius = {0}", radius);
        }

        static object[] PositiveCircleCases =
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

        static object[] NegativeCircleCases =
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
