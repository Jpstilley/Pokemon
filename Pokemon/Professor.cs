using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Professor
    {
        bool amProfessor;
        bool canEnterGym;
        public Professor()
        {
            amProfessor = true;
            canEnterGym = false;
        }

        public int GivePokemon(int numOfPokemon)
        {
            numOfPokemon += numOfPokemon;
            return numOfPokemon;
        }
    }
}
