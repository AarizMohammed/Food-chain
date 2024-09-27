using FinalExamPracticalMAUIApp1.ProvidedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPracticalMAUIApp1.Models
{
    public class Carnivore : Consumer, IConsumeAnimals
    {
        public override bool IsConsumerOf(Organism organism)
        {
            if (organism is Consumer && !(organism is Producer))
            {
                return true;
            }
            return false;
        }

        public void Consumes(Consumer animal)
        {
            Console.WriteLine($"{Name} is consuming {animal.Name}");
        }
    }
}
