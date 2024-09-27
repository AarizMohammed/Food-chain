using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPracticalMAUIApp1.ProvidedCode
{
    // DO NOT EDIT THIS CLASS

    public abstract partial class Consumer : Organism
    {
        public List<Organism> Food { get; set; } = new List<Organism>();

        public abstract bool IsConsumerOf(Organism organism);
    }
}
