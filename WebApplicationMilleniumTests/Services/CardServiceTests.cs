using WebApplicationMillenium.Services;

namespace WebApplicationMilleniumTests.Services
{
    public class CardServiceTests
    {       
        [Test]
        public async Task GetCardActionsAsync_OrderadAndPrepaidNoPINCard()
        {
            ICardService cardService = new CardService();

            //Act
            var actionsResult = await cardService.GetCardActionsAsync("User1", "Card11");
            
            //Asserts
            Assert.That(actionsResult, Is.Not.EqualTo(null));
            Assert.That(actionsResult.Count, Is.EqualTo(8));
            Assert.That(actionsResult.Contains("ACTION7"), Is.EqualTo(true));
            Assert.That(actionsResult.Contains("ACTION5"), Is.EqualTo(false));
            Assert.That(actionsResult.Contains("ACTION11"), Is.EqualTo(false));
        }

        [Test]
        public async Task GetCardActionsAsync_OrderadAndDebitPINCard()
        {
            ICardService cardService = new CardService();

            //Act
            var actionsResult = await cardService.GetCardActionsAsync("User1", "Card18");

            //Asserts
            Assert.That(actionsResult, Is.Not.EqualTo(null));
            Assert.That(actionsResult.Count, Is.EqualTo(8));
            Assert.That(actionsResult.Contains("ACTION6"), Is.EqualTo(true));
            Assert.That(actionsResult.Contains("ACTION5"), Is.EqualTo(false));
            Assert.That(actionsResult.Contains("ACTION11"), Is.EqualTo(false));
        }

        [Test]
        public async Task GetCardActionsAsync_InactiveAndPrepaidPINCard()
        {
            ICardService cardService = new CardService();

            //Act
            var actionsResult = await cardService.GetCardActionsAsync("User1", "Card12");

            //Asserts
            Assert.That(actionsResult, Is.Not.EqualTo(null));
            Assert.That(actionsResult.Count, Is.EqualTo(10));
            Assert.That(actionsResult.Contains("ACTION6"), Is.EqualTo(true));
            Assert.That(actionsResult.Contains("ACTION5"), Is.EqualTo(false));
            Assert.That(actionsResult.Contains("ACTION11"), Is.EqualTo(true));
        }
    }
}