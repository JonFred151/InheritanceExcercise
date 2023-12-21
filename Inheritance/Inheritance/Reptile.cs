using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile()
        { 
            Age = 0;
            IsAlive = true;
            ScaleFeatherFur = "Scale";
        }
        public bool Venomous { get; set; }
        public bool CanGrowTail { get; set; }
        public string Habitat {  get; set; }
        public string ScaleColor { get; set; }
    }
}
