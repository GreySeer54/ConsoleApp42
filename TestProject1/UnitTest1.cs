namespace TestProject1
{

    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void TestSquareOrRhombus()
        {
            string result = Program.DetermineQuadrilateralType(5, 5, 5, 5);
            Assert.AreEqual("Четырехугольник является квадратом или ромбом", result);
        }

        [Test]
        public void TestRectangle()
        {
            string result = Program.DetermineQuadrilateralType(5, 3, 5, 3);
            Assert.AreEqual("Четырехугольник является прямоугольником", result);
        }

        [Test]
        public void TestTrapezoidOrSimpleQuadrilateral()
        {
            string result = Program.DetermineQuadrilateralType(5, 3, 4, 2);
            Assert.AreEqual("Четырехугольник является трапецией или простым четырехугольником", result);
        }

        [Test]
        public void TestNegativeSide()
        {
            string result = Program.DetermineQuadrilateralType(-5, 3, 5, 3);
            Assert.AreEqual("Сторона многоугольника не может быть <= 0", result);
        }

        [Test]
        public void TestZeroSide()
        {
            string result = Program.DetermineQuadrilateralType(0, 3, 5, 3);
            Assert.AreEqual("Сторона многоугольника не может быть <= 0", result);
        }
    }
}