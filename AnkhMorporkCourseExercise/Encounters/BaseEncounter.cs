using System;
using System.Collections.Generic;
using AnkhMorporkCourseExercise.Models;

namespace AnkhMorporkCourseExercise.Encounters
{
    public abstract class BaseEncounter <T>
    {
        protected readonly ConsoleColor color;
        protected readonly string startLine;
        protected readonly string endLine;

        protected BaseEncounter(ConsoleColor color, string startLine, string endLine)
        {
            this.color = color;
            this.startLine = startLine;
            this.endLine = endLine;
        }

            public void Action(Player player)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(startLine);
            Console.WriteLine(" Type 'a' to accept or 'd' to decline");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "a":
                {
                    Accept(player);
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

        protected abstract void Accept(Player player);

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
