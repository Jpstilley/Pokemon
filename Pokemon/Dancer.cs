using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Dancer : ITrainer
    {
        string trainerClass;
        bool canEnterGym;
        public Dancer()
        {
            trainerClass = "Dancer";
            canEnterGym = true;
        }

        public int Catch(int numOfPokes)
        {
            {
                if (numOfPokes < 6)
                {
                    numOfPokes++;
                }
                return numOfPokes;
            }
        }

        public string EnterGym(int numOfPokes)
        {
            throw new NotImplementedException();
        }

        public string TrainerTrained(string trainer, int numOfPokes)
        {
            throw new NotImplementedException();
        }
    }
}
