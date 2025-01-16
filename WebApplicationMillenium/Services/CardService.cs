using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WebApplicationMillenium.Enums;
using WebApplicationMillenium.Utils;

namespace WebApplicationMillenium.Services
{
    public record CardDetails(string CardNumber, CardType CardType, CardStatus CardStatus, bool IsPinSet);
    public class CardService : ICardService
    {
        private readonly Dictionary<string, Dictionary<string, CardDetails>> _userCards = FeedData.CreateSampleUserCards();
        public async Task<List<string>?> GetCardActionsAsync(string userId, string cardNumber)
        {
            // Generate sample data
            var cards = FeedData.CreateSampleUserCards();
            await Task.Delay(1000);

            var usercards = cards.Where(c => c.Key == userId).FirstOrDefault();
            
            KeyValuePair<string, CardDetails> card;
            if (usercards.Value != null)
            {
                card = usercards.Value.Where(c => c.Key == cardNumber).FirstOrDefault();
            }
            else
            {
                return null;
            }

            if (card.Value == null)
            {
                return null;
            }

            return GetAvailableActionsForCard(card.Value);
        }

        private List<string> GetAvailableActionsForCard(CardDetails cardDetails)
        {
            var matrix = FeedData.GetMatrix();

            var list = new List<string>();

            foreach(var m in matrix)
            {
                try
                {
                    var count = m.Value.Item2.Where(x => x.status == cardDetails.CardStatus).Count();
                    var extStatus = m.Value.Item2.Where(x => x.status == cardDetails.CardStatus).First();

                    if (m.Value.Item1.Contains(cardDetails.CardType))
                    {
                        if (!extStatus.isPinSetYes && !extStatus.isPinUnSetYes)
                        {
                            list.Add(m.Key);
                        }
                        else
                        if (extStatus.isPinSetYes && cardDetails.IsPinSet)
                        {
                            list.Add(m.Key);
                        }
                        else
                        if (extStatus.isPinUnSetYes && !cardDetails.IsPinSet)
                        {
                            list.Add(m.Key);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            return list;
        }
    }
}
