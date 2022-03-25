using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MachineACafe.Test
{
    [TestClass]
    public class UnitTestExpresso
    {
        [TestMethod]
        public void TestGiveExpresso()
        {
            const int price = 40;
            //Expresso expresso = new Expresso(40); 

            CoffeeMachine cm = new CoffeeMachine(new Expresso(40));

            var res = cm.serve(price);

            Assert.AreEqual(40, res,"Votre expresso est servi, bonne dégustation");
            //Assert.AreEqual(40, price,"Votre expresso est servi, bonne dégustation");
        }
    }
}