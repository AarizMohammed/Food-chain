using FinalExamPracticalMAUIApp1.ProvidedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPracticalMAUIApp1.Models
{
    internal class Omnivore : Consumer, IConsumePlants, IConsumeAnimals
    {
        public override bool IsConsumerOf(Organism organism)
        {
            return true;
        }

        public void Consumes(Producer plant)
        {
            Console.WriteLine($"{Name} is consuming {plant.Name}");
        }

        public void Consumes (Consumer animal)
        {
            Console.WriteLine($"{Name} is consuming {animal.Name}");
        }

    }
}
