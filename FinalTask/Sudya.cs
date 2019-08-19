using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    public class Sudya : Person
    {
        public int Preference { get; set; }
        public Sudya(string LastName, int Preference)
        {
            this.LastName = LastName;
            this.Preference = Preference;
        }
        public static void EventHandler(string message, Team t)
        {
            Console.WriteLine(message+t.TeamName);
        }   
    }
}
