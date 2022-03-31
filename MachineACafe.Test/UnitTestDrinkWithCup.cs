using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MachineACafe.Test
{
    [TestClass]
    public class UnitTestDrinkWithCup
    {
        [TestMethod]
        public void TestGiveDrinkWithCup()
        {
            //Arrange
            const int price = 40;
            const string name = "Chocolat chaud";
            Drink drink = new Drink("Chocolat chaud", 40);

            CoffeeMachine cm = new CoffeeMachine();
            cm.drink = drink;
            cm.SetCupFound(true);
            //Act
            var res = cm.serveWithCup(drink);

            //Assert
            Assert.AreEqual(40, res,"Votre boisson est servi dans votre gobelet, bonne dégustation");
        }
    }
}