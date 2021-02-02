using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Abstract
{
    interface ITournamentService
    {
        void Add(Tournament tournament);
        void Delete(Tournament tournament);
        void Update(Tournament tournament);

    }
}
