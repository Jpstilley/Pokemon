using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    interface ITrainer
    {
        
        public int Catch(int numOfPokes);
        public string EnterGym(int numOfPokes);
        public string TrainerTrained(string trainer, int numOfPokes);
    }
}
