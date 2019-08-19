using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Program
    {
        public static Random r { get; set; } = new Random();
        static void Main(string[] args)
        {
            float t1modifier = 1.2f;
            float t2modifier = 1.1f;
            Team t1 = new Team("Donbas", new Coacher("Vitya", t1modifier));
            Team t2 = new Team("Madrid", new Coacher("Petya", t2modifier));
            Console.WriteLine("Коэф тренера 1 комманды "+t1modifier);
            Console.WriteLine("Коэф тренера 2 комманды "+t2modifier);
            Sudya sudya = new Sudya("Petro", 0);
            Console.WriteLine("Судья подсуживает "+sudya.Preference+" комманде");
            t1.AddFootballer("F", 6);
            t1.AddFootballer("G", 7);
            t1.AddFootballer("H", 39);
            t1.AddFootballer("I", 10);
            t1.AddFootballer("J", 11);
            t1.AddFootballer("A", 31);
            t1.AddFootballer("B", 2);
            t1.AddFootballer("C", 33);
            t1.AddFootballer("D", 34);
            t1.AddFootballer("E", 5);
            

           
            t2.AddFootballer("E", 35);
            t2.AddFootballer("F", 6);
            t2.AddFootballer("G", 37);
            t2.AddFootballer("A", 1);
            t2.AddFootballer("B", 32);
            t2.AddFootballer("C", 3);
            t2.AddFootballer("D", 4);
            t2.AddFootballer("H", 9);
            t2.AddFootballer("I", 10);
            t2.AddFootballer("J", 11);
            t1.ShowTeamInformation();
            t2.ShowTeamInformation();
            Game g = new Game(t1, t2, sudya);
            g.GameStarted();
            Console.WriteLine(Game.GetWinner(g.FirstTeam, g.SecondTeam, sudya));
            Console.ReadLine();
        }
    }
}
