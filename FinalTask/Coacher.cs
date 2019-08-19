using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    public class Coacher : Person
    {
        public float LuckyModifier { get; set; }
        public Coacher(string LastName, float LuckyModifier)
        {
            this.LastName = LastName;
            this.LuckyModifier = LuckyModifier;
        }
    }
}
