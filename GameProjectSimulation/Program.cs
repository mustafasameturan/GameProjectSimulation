using GameProjectSimulation.Concrete;
using GameProjectSimulation.Entities;
using System;

namespace GameProjectSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Mustafa" , LastName = "Turan" , BirthYear = 2000, IdentiyNumber = 12345 });

            TournamentManager tournamentManager = new TournamentManager();
            tournamentManager.Add(new Tournament {Id = 1, TournamentName = "CS GO 1v1", TournamentDate = "2021", TournamentPrize = 10000,
            TournamentPlace = "Istanbul" });
                
        }
    }
}
