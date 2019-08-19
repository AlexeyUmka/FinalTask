using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    public class Footballer : Person
    {
        public int Age { get; set; }
        public int Skill { get; set; }
        public Footballer(string LastName, int Age)
        {
            this.LastName = LastName;
            this.Age = Age;
            Skill = Program.r.Next(0, 101);
        }
        public override string ToString()
        {
            return string.Format("Фамилия футболиста: {0}, Возраст: {1}, Скиллуха: {2}", LastName, Age, Skill);
        }
    }
}
