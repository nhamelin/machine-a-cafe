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
            const string name = "Expresso";
            //Expresso expresso = new Expresso(40); 

            CoffeeMachine cm = new CoffeeMachine(new Drink("Expresso",40));

            var res = cm.serve(name,price);

            Assert.AreEqual(40, res,"Votre expresso est servi, bonne dégustation");
            Assert.AreEqual("Expresso", name,"Votre expresso est servi, bonne dégustation");
            //Assert.AreEqual(40, price,"Votre expresso est servi, bonne dégustation");
        }
    }
}