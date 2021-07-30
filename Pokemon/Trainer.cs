using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Trainer : ITrainer
    {
        public int receiveAPoke;
        public Trainer()
        {
            receiveAPoke++;
        }








        public int Catch(int numOfPokes)
        {
            if (numOfPokes < 6)
            {
                numOfPokes++;
            }
            return numOfPokes;
        }
        public string EnterGym(int numOfPokes)
        {
            string answer = "";
            if (numOfPokes > 0)
            {
                answer = " was";
                return answer;
            }
            answer = " wasn't";
            return answer;
        }
        public string TrainerTrained(string trainer, int numOfPokes)
        {
            Random rnd = new();
            int ranNum = rnd.Next(1, 6);
            string tdTrainer = "";
            if (numOfPokes > 0)
            {
                if (ranNum == 1)
                {
                    tdTrainer = "Hiker";
                    return tdTrainer;
                }
                else if (ranNum == 2)
                {
                    tdTrainer = "Dancer";
                    return tdTrainer;
                }
                else if (ranNum == 3)
                {
                    tdTrainer = "Bellhop";
                    return tdTrainer;
                }
                else if (ranNum == 4)
                {
                    tdTrainer = "Firebreather";
                    return tdTrainer;
                }
                else if (ranNum == 5)
                {
                    tdTrainer = "Athlete";
                    return tdTrainer;
                }
                else
                {
                    tdTrainer = "Bodybuilder";
                    return tdTrainer;
                }
            }
            else
            {
                tdTrainer = " Pokemon, so they cannot have a trainer class.";
                return tdTrainer;
            }
        }
    }
}
