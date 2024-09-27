using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExamPracticalMAUIApp1.Models;

namespace FinalExamPracticalMAUIApp1.ProvidedCode
{
    // DO NOT EDIT THIS CLASS

    interface IConsumePlants
    {
        void Consumes(Producer plant);
    }

    interface IConsumeAnimals
    {
        void Consumes(Consumer animal);
    }
}
