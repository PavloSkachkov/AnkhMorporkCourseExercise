using System;
using System.Collections.Generic;
using AnkhMorporkCourseExercise.Models;
using AnkhMorporkCourseExercise.Repositories;

namespace AnkhMorporkCourseExercise.Encounters
{
    public abstract class BaseEncounter <T>  where T : NPC
    {
        protected readonly ConsoleColor color;
        protected readonly string startLine;
        protected readonly string endLine;
        private readonly IRepository<T> _repository;

        protected BaseEncounter(ConsoleColor color, string startLine, string endLine, IRepository<T> repository)
        {
            this.color = color;
            this.startLine = startLine;
            this.endLine = endLine;
            _repository = repository;
        }

            public void Action(Player player)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(startLine);
            var npc = GetRandomEntity(_repository.Get());

            if (npc is not Assassin)
            {
                npc.AnounceDealMoneyAmount();
            }

            Console.WriteLine(" Type 'a' to accept or 'd' to decline");

            var answer = Console.ReadLine();
            switch (answer)
            {
                case "a":
                {
                    Accept(player, npc);
                }
                    break;
                case "d":
                {
                    Decline(player);
                }
                    break;
                default:
                {
                    Console.WriteLine($"{new string('-', 15)}\n You need to choose\n{new string('-', 15)}");
                    Action(player);
                }
                    break;
            }
            Console.ResetColor();
        }

        protected abstract void Accept(Player player, T npc);

        protected virtual void Decline(Player player)
        {
            player.Kill();
            Console.WriteLine(endLine);
        }

        protected T GetRandomEntity(List<T> entities)
        {
            var rnd = new Random();
            return entities[rnd.Next(0, entities.Count)];
        }
    }
}
