using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Athlete : Trainer
    {
        string trainerClass;
        bool canEnterGym;
        public Athlete()
        {
            trainerClass = "Athlete";
            canEnterGym = true;
        }
        
    }
}
