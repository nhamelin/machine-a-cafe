using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MachineACafe.Test
{
    [TestClass]
    public class UnitTestExpresso
    {
        [TestMethod]
        public void TestGiveExpresso()
        {
            //Arrange
            const int price = 40;
            const string name = "Expresso";
            Drink drink = new Drink("Expresso", 40);

            CoffeeMachine cm = new CoffeeMachine();
            cm.drink = drink;
            //Act
            var res = cm.serve(drink);

            //Assert
            Assert.AreEqual(40, res,"Votre expresso est servi, bonne dégustation");
            Assert.AreEqual("Expresso", name,"Votre expresso est servi, bonne dégustation");
        }
    }
}