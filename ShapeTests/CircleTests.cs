using Microsoft.VisualStudio.TestTools.UnitTesting;
using mindbox_стажировка;

namespace ShapeTests
{
    [TestClass]

    public class CircleTests

    {
        
        [TestMethod]
        public void NegativeAreaTestCircle()
        {
            double userInput = -2.5;

            Circle circ = new Circle(userInput);

            Assert.IsTrue(circ.Area > 0);

            

        }
    }
}
