using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Concrete
{
    class TournamentManager : ITournamentService
    {
        public void Add(Tournament tournament)
        {
            Console.WriteLine("Tournament Added!");
        }

        public void Delete(Tournament tournament)
        {
            Console.WriteLine("Tournament Deleted!");
        }

        public void Update(Tournament tournament)
        {
            Console.WriteLine("Tournament Updated!");
        }
    }
}
