using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;

namespace CalcUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod ("���ϱ� �׽�Ʈ")]
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            int a = 3, b = 5;
            var result = myClass.Plus(a, b);

            Assert.AreEqual(0, result); //��Ʈ�� ���
        }
        [TestMethod]
        public void PrintTest()
        {
            MyClass myClass = new MyClass();
            myClass.NewMethod();
        }
    }
}
