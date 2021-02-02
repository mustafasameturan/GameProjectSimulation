using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "Mustafa"  && gamer.LastName == "Turan" && gamer.IdentiyNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
