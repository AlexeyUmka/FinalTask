using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    public class Team
    {
        public string TeamName { get; set; }
        public float TeamSkill { get; set; }
        public List<Footballer> Footballers = new List<Footballer>();
        public Coacher Coacher { get; set; }
        public int GolAmount { get; set; }
        public void AddFootballer(string LastName, int Age)
        {
            if (Footballers.Count != 11)
            {
                Footballer f = new Footballer(LastName, Age);
                Footballers.Add(f);
                TeamSkill += f.Skill*Coacher.LuckyModifier;
            }
            else
                throw new Exception("Превышен лимит комманды!");
        }
        public Team(string TeamName, Coacher Coacher)
        {
            this.TeamName = TeamName;
            this.Coacher = Coacher;
        }
        public void ShowTeamInformation()
        {
            Console.WriteLine("Имя комманды: {0}", TeamName);
            Console.WriteLine("Мастерство: {0}", TeamSkill);
            Console.WriteLine("Тренер: {0}", Coacher.LastName);
            Console.WriteLine("Список футболистов по алфавиту:");
            var fs = Footballers.OrderBy(f => f.LastName);
            foreach(Footballer f in fs)
                Console.WriteLine(f.ToString());
            Console.WriteLine("Старше 30 по убыванию мастерства:");
            var fs2 = from f in Footballers where f.Age > 30 orderby f.Skill descending select f;
            foreach (Footballer f in fs2)
                Console.WriteLine(f.ToString());
        }
    }
}
