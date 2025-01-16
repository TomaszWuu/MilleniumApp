using WebApplicationMillenium.Enums;
using WebApplicationMillenium.Services;

namespace WebApplicationMillenium.Utils
{
    public static class FeedData
    {
        public struct StatusExtended
        {
            public CardStatus status;
            public bool isPinSetYes;
            public bool isPinUnSetYes;
        }
        public static Dictionary<string, Dictionary<string, CardDetails>> CreateSampleUserCards()
        {
            var userCards = new Dictionary<string, Dictionary<string, CardDetails>>();
            for (var i = 1; i <= 3; i++)
            {
                var cards = new Dictionary<string, CardDetails>();
                var cardIndex = 1;
                foreach (CardType cardType in Enum.GetValues(typeof(CardType)))
                {
                    foreach (CardStatus cardStatus in Enum.GetValues(typeof(CardStatus)))
                    {
                        var cardNumber = $"Card{i}{cardIndex}";
                        cards.Add(cardNumber,
                        new CardDetails(
                        CardNumber: cardNumber,
                        CardType: cardType,
                        CardStatus: cardStatus,
                        IsPinSet: cardIndex % 2 == 0));
                        cardIndex++;
                    }
                }
                var userId = $"User{i}";
                userCards.Add(userId, cards);
            }
            return userCards;
        }

        public static Dictionary<string, Tuple<List<CardType>, List<StatusExtended>>> GetMatrix()
        {
            
            var dictonary =  new Dictionary<string, Tuple<List<CardType>, List<StatusExtended>>>
            {
                {
                    "ACTION1",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                },
                {
                    "ACTION2",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                },
                {
                    "ACTION3",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Ordered,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Restricted,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Blocked,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Expired,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Closed,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                },
                {
                    "ACTION4",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Ordered,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Restricted,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Blocked,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Expired,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Closed,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                },
                {
                    "ACTION5",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Ordered,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Restricted,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Blocked,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Expired,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Closed,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                },
                {
                    "ACTION6",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Ordered,
                                    isPinUnSetYes = false,
                                    isPinSetYes = true
                                },new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = true
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = true
                                },new StatusExtended
                                {
                                    status = CardStatus.Blocked,
                                    isPinUnSetYes = false,
                                    isPinSetYes = true
                                }
                            }
                    )
                },
                {
                    "ACTION7",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Ordered,
                                    isPinUnSetYes = true,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = true,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = true,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Blocked,
                                    isPinUnSetYes = false,
                                    isPinSetYes = true
                                }
                            }
                    )
                },
                {
                    "ACTION8",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Ordered,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Blocked,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                },
                {
                    "ACTION9",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Ordered,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Restricted,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Blocked,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Expired,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Closed,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                },
                {
                    "ACTION10",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Ordered,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                },
                {
                    "ACTION11",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                },
                {
                    "ACTION12",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Ordered,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                },
                {
                    "ACTION13",
                    Tuple.Create
                    (
                        new List<CardType>
                                {
                                    CardType.Prepaid,
                                    CardType.Debit,
                                    CardType.Credit
                                },
                        new List<StatusExtended>
                            {
                                new StatusExtended
                                {
                                    status = CardStatus.Ordered,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Inactive,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                },new StatusExtended
                                {
                                    status = CardStatus.Active,
                                    isPinUnSetYes = false,
                                    isPinSetYes = false
                                }
                            }
                    )
                }
            };
            return dictonary;
        }
    }
}
