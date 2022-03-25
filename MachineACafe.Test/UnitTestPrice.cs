using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MachineACafe.Test
{
    [TestClass]
    public class UnitTestPrice
    {
        [TestMethod]
        public void TestPrice()
        {
            // Arrange
            Drink expresso = new Drink("expresso", 40);
            CoffeeMachine coffeeMachine = new CoffeeMachine();

            coffeeMachine.drink = expresso;

            int moneyGiven = 39;
            int price = coffeeMachine.serve(expresso);

            // Act

            // Assert
            Assert.AreEqual(price, moneyGiven, "Merci d'ajouter 1 cts");
        }
    }
}

/*
 * ÉTANT DONNÉ que le client a inséré 39 cts
 * QUAND le client appuie sur « expresso »
 * ALORS la machine affiche « Merci d’ajouter 1 cts »
*/