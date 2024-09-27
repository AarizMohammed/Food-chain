using FinalExamPracticalMAUIApp1.ProvidedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPracticalMAUIApp1.Models
{
    public class Herbivore : Consumer, IConsumePlants
    {
        public override bool IsConsumerOf(Organism organism)
        {
            if (organism is Producer)
            {
                return true; //herbivores can consume producers
            }
            return false;
        }

        public void Consumes(Producer plant)
        {
            Console.WriteLine($"{Name} is consuming {plant.Name}");
        }
    }
}
