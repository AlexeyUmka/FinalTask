using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    public delegate void GameEvents(string message, Team t);
    public class Game
    {
        public event GameEvents NarusheniePravil;
        public event GameEvents Gol;
        public Team FirstTeam { get; set; }
        public Team SecondTeam { get; set; }
        public Sudya Sudya { get; set; }
        public static string GetWinner(Team team1, Team team2, Sudya Sudya)
        {
            double difference=Math.Abs(team1.TeamSkill - team2.TeamSkill);
            Team lessTeam = team1.TeamSkill < team2.TeamSkill ? team1 : team2;
            Team biggerTeam = team1.TeamSkill > team2.TeamSkill ? team1 : team2;
            if (Sudya.Preference == 0)
            {
                if(team1.GolAmount > team2.GolAmount)
                    return string.Format("Победила {0}", team1.TeamName);
                else
                    return string.Format("Победила {0}", team2.TeamName);
            }
            else if(Sudya.Preference == 1)
            {
                return string.Format("Победила {0}", team1.TeamName);
            }
            else
                return string.Format("Победила {0}", team2.TeamName);
        }
        public Game(Team team1, Team team2, Sudya Sudya)
        {
            FirstTeam = team1;
            SecondTeam = team2;
            this.Sudya = Sudya;
            NarusheniePravil += Sudya.EventHandler;
            Gol += Sudya.EventHandler;
        }
        public void GameStarted() {
            Gol("Комманда забила гол: ", SecondTeam);
            NarusheniePravil("Комманда нарушившая правила: ", FirstTeam);
}
    }
}
