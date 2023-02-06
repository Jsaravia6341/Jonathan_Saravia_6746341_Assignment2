using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;
namespace TestClass
{
    public class TriangleTest
    {

        [TestFixture]

        public class TriangleTests
        {
            [Test]

            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            }


            [Test]
             public void ValidTriangle__OutputValidTriangle()
            {
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            }


        }

    }
}
