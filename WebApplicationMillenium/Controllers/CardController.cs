using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMillenium.Models;
using WebApplicationMillenium.Services;

namespace WebApplicationMillenium.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;
        private readonly ILogger<CardController> _logger;

        public CardController(ILogger<CardController> logger, ICardService cardService)
        {
            _logger = logger;
            _cardService = cardService;
        }

        [Route("actions")]
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CardRequest request)
        {
            if (String.IsNullOrEmpty(request.UserId) || String.IsNullOrEmpty(request.CardNumber))
            {
                return BadRequest("Invalid data. UserId and CardNumber can't be empty");
            }
            var result = await _cardService.GetCardActionsAsync(request.UserId, request.CardNumber);

            return result != null ? new JsonResult(result) : NotFound("User or card not found!") ;
        }
    }
}
