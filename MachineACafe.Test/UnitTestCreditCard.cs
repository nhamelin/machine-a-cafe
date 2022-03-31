using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MachineACafe.Test
{
    [TestClass]
    public class UnitTestCreditCard    {
        [TestMethod]
        public void TestInsufficientBalance()
        {
            // Arrange
            Drink expresso = new Drink("expresso", 40);
            CoffeeMachine coffeeMachine = new CoffeeMachine();

            coffeeMachine.drink = expresso;
            // Act
            int balance = 39;
            CreditCard creditcard = new CreditCard(balance);

            int price = coffeeMachine.serve(expresso);
            bool res = creditcard.checkBalance(price);



            // Assert
            Assert.AreNotEqual(true, res, "Paiement refusé");
        }
    }
}