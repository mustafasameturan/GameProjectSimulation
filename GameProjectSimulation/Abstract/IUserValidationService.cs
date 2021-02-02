using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
