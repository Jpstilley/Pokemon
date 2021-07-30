using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Bellhop : Trainer
    {
        string trainerClass;
        bool canEnterGym;
        public Bellhop()
        {
            trainerClass = "Bellhop";
            canEnterGym = true;
        }
    }
}
