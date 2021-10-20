using Microsoft.VisualStudio.TestTools.UnitTesting;
using mindbox_стажировка;

namespace ShapeTests
{
    [TestClass]
   public class TriangleTests
    {
        [TestMethod]
        public void NegativeSidesTest()
        {
            //Arrange
            double side1 = 1;
            double side2 = -5;
            double side3 = -10;
            //Act
            Triangle tri = new Triangle(side1, side2, side3);

            //Assert
            Assert.IsTrue(side1 > 0);
            Assert.IsTrue((side2 > 0), "Вторая данная сторона меньше нуля");
            Assert.IsTrue((side3 > 0), "Третья данная сторона меньше нуля");
        }
    }
}
