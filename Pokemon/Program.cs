using System;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string trainer = "JoJo";
            string[] pokeList1 = {};

            Trainer Trainer = new Trainer();
            int numOfPokes = Trainer.receiveAPoke;
            Console.WriteLine(numOfPokes);


            //ITrainer catcher = new Trainer();
            //ITrainer enterer = new Trainer();
            //ITrainer trainerClasser = new Trainer();

            //numOfPokes = catcher.Catch(numOfPokes);
            //string trainerClass = trainerClasser.TrainerTrained(trainer, numOfPokes);
            //string entered = enterer.EnterGym(numOfPokes);
            //if (numOfPokes > 0)
            //{
            //    Console.WriteLine(trainer + " has " + numOfPokes + " Pokemon.");
            //    Console.WriteLine(trainer + " is a " + trainerClass + " Class Trainer.");
            //    Console.WriteLine(trainer + entered + " able to enter the gym.");
            //}
            //else
            //{
            //    Console.WriteLine(trainer + " has " + numOfPokes + " Pokemon, so they are not a trainer.");
            //    Console.WriteLine(trainer + " has " + numOfPokes + trainerClass);
            //    Console.WriteLine(trainer + entered + " able to enter the gym because they have " + numOfPokes + " Pokemon.");

            //}

        }
    }
}
