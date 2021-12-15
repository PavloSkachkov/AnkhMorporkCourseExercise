using System.Linq;
using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;

namespace AnkhMorporkCourseExercise.Web.Encounters
{
    public class PubsEncounter : BaseEncounter<Pub>
    {
        public const int MaxBeerAmount = 2;
        private readonly IRepository<Pub> _pubsRepository;

        public PubsEncounter(IRepository<Pub> pubsRepository) : base(pubsRepository)
        {
            _pubsRepository = pubsRepository;
        }
        public override bool Accept(Player player, Pub npc = null)
        {
            Accept(player, npc, 0);
            return true;
        }

        public bool Accept(Player player, Pub pub, int beerAmount)
        {
            if (!player.IsAlive)
            {
                return false;
            }
            if (player.BeerAmount < MaxBeerAmount)
            {
                var currentPub = _pubsRepository.Get().FirstOrDefault();
                player.DecreaseMoneyAmount(currentPub.DealMoneyAmount * beerAmount);
                player.BeerAmount += beerAmount;
                return true;
            }
            return false;
        }


        public override void Decline(Player player)
        {
        }
    }
}