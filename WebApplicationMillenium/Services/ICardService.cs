namespace WebApplicationMillenium.Services;
public interface ICardService
{
    public Task<List<string>?> GetCardActionsAsync(string userId, string cardNumber);
}

