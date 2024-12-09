namespace TestProject1
{

    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void TestSquareOrRhombus()
        {
            string result = Program.DetermineQuadrilateralType(5, 5, 5, 5);
            Assert.AreEqual("��������������� �������� ��������� ��� ������", result);
        }

        [Test]
        public void TestRectangle()
        {
            string result = Program.DetermineQuadrilateralType(5, 3, 5, 3);
            Assert.AreEqual("��������������� �������� ���������������", result);
        }

        [Test]
        public void TestTrapezoidOrSimpleQuadrilateral()
        {
            string result = Program.DetermineQuadrilateralType(5, 3, 4, 2);
            Assert.AreEqual("��������������� �������� ��������� ��� ������� �����������������", result);
        }

        [Test]
        public void TestNegativeSide()
        {
            string result = Program.DetermineQuadrilateralType(-5, 3, 5, 3);
            Assert.AreEqual("������� �������������� �� ����� ���� <= 0", result);
        }

        [Test]
        public void TestZeroSide()
        {
            string result = Program.DetermineQuadrilateralType(0, 3, 5, 3);
            Assert.AreEqual("������� �������������� �� ����� ���� <= 0", result);
        }
    }
}