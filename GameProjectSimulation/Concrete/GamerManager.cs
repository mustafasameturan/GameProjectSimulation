using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Registration completed!");
            }
            else
            {
                Console.WriteLine("Verification failed.Registration could not be completed.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registiration deleted!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Registiration Updated!");
        }
    }
}
