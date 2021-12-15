using System;
using System.Collections.Generic;
using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;

namespace AnkhMorporkCourseExercise.Web.Encounters
{
    public abstract class BaseEncounter<T> where T : NPC
    {
        private readonly IRepository<T> _repository;

        protected BaseEncounter(IRepository<T> repository)
        {
            _repository = repository;
        }

        public NPC GetNpc()
        {
            return GetRandomEntity(_repository.Get());
        }

        public abstract bool Accept(Player player, T npc);

        public virtual void Decline(Player player)
        {
            player.Kill();
        }

        protected T GetRandomEntity(List<T> entities)
        {
            var rnd = new Random();
            return entities[rnd.Next(0, entities.Count)];
        }
    }
}
