using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MachineACafe.Test
{
    [TestClass]
    public class ManqueDeMonnaieTest
    {
        [TestMethod]
        public void ManqueDeMonnaie()
        {
            // Arrange
            const int monnaieInsérée = 39;
            const int prixExpresso = 40;

            // Act

            // Assert
            Assert.AreEqual(prixExpresso, monnaieInsérée, "Merci d'ajouter 1 cts");
        }
    }
}

/*
 * ÉTANT DONNÉ que le client a inséré 39 cts
 * QUAND le client appuie sur « expresso »
 * ALORS la machine affiche « Merci d’ajouter 1 cts »
*/