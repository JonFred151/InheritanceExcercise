using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            Age = 0;
            ScaleFeatherFur = "Feather";
        }
        public string FeatherColor { get; set; }
        public bool CanFly { get; set; }
        public bool Migrate { get; set; }
        public double BeakLength { get; set; }
    }
}
