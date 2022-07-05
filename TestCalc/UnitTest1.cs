namespace TestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            Calculater.CalcFunc calc = new Calculater.CalcFunc();
            List<int> a = new List<int> { 1, 2, 3 };
            int resuft = calc.Sum(a);
            Assert.AreEqual(6, resuft);
        }
        [TestMethod]
        public void TestisNumber()
        {
            Calculater.Validation strisNuber = new Calculater.Validation();
            string a = "asas";
            string b = "1234";
            bool resuft1 = strisNuber.isNumber(a);
            Assert.IsFalse(resuft1);
            bool resuft2 = strisNuber.isNumber(b);
            Assert.IsTrue(resuft2);

        }
    }
}