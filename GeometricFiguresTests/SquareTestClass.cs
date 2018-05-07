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
    public class SquareTestClass
    {
        [Test, TestCaseSource("PositiveSquareCases")]
        public void GetAreaSquarePositiveTest(int side)
        {
            Square square = new Square(side);
            int myArea = side*side;
            double methodArea = square.getAreaSquare();
            Assert.AreEqual(myArea, methodArea, "Метод вернул неверное значение площади квадрата при side = {0}", side);
        }

        [Test, TestCaseSource("NegativeSquareCases")]
        public void GetAreaSquareNegativeTest(int side)
        {
            double area;
            Square square = new Square(side);
            area = square.getAreaSquare();
            Assert.IsNull(area, "Метод вернул значение площади квадрата со стороной = {0}", side);
        }

        [Test, TestCaseSource("PositiveSquareCases")]
        public void GetLengthSquarePositiveTest(int side)
        {
            Square square = new Square(side);
            int myLength = side * 4;
            double methodLength = square.getLengthSquare();
            Assert.AreEqual(myLength, methodLength, "Метод вернул неверное значение периметра квадрата при side = {0}", side);
        }

        [Test, TestCaseSource("NegativeSquareCases")]
        public void GetLetgthSquareNegativeTest(int side)
        {
            double length;
            Square square = new Square(side);
            length = square.getLengthSquare();
            Assert.IsNull(length, "Метод вернул значение периметра квадрата со стороной = {0}", side);
        }

        static object[] PositiveSquareCases =
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

        static object[] NegativeSquareCases =
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
