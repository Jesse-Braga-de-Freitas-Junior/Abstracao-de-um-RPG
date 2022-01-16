using System;
using Projeto___Abstração_de_um_RPG.src.Entites;
namespace Projeto___Abstração_de_um_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight guerreiro = new Knight("Jessé", 35, "Knight"); // consumindo o objeto Arus dentro de src\entites
            Wizard maga = new Wizard("Cristiane", 38, "Knight");
            Pupil aprendiz = new Pupil("Miguel", 3, "Knight");
            Ninja ninja = new Ninja("Júnior", 3, "Knight");
            Archer arqueiro = new Archer("Jecrimi", 3, "Knight");

            Console.WriteLine(guerreiro.Attack(5));
            Console.WriteLine(maga.Attack(5));
            Console.WriteLine(aprendiz.Attack(5));
            Console.WriteLine(ninja.Attack(5));
            Console.WriteLine(arqueiro.Attack(5));
            Console.WriteLine();
            Console.WriteLine(" Round 01");
            Console.WriteLine();

            Console.WriteLine(guerreiro.Attack(9));
            Console.WriteLine(maga.Attack(9));
            Console.WriteLine(aprendiz.Attack(9));
            Console.WriteLine(ninja.Attack(7));
            Console.WriteLine(arqueiro.Attack(9));
            Console.WriteLine();
            Console.WriteLine(" Round 02");
            Console.WriteLine();

            Console.WriteLine(guerreiro.Attack(5));
            Console.WriteLine(maga.Attack(2));
            Console.WriteLine(aprendiz.Attack(3));
            Console.WriteLine(ninja.Attack(5));
            Console.WriteLine(arqueiro.Attack(6));
            Console.WriteLine();
            Console.WriteLine(" Round 03");
            Console.WriteLine();

            Console.WriteLine(guerreiro.Attack(11));
            Console.WriteLine(maga.Attack(15));
            Console.WriteLine(aprendiz.Attack(9));
            Console.WriteLine(ninja.Attack(25));
            Console.WriteLine(arqueiro.Attack(25));
            Console.WriteLine();
            Console.WriteLine(" Round 04");
            Console.WriteLine();

            Console.WriteLine(guerreiro.Attack(5));
            Console.WriteLine(maga.Attack(5));
            Console.WriteLine(aprendiz.Attack(5));
            Console.WriteLine(ninja.Attack(5));
            Console.WriteLine(arqueiro.Attack(5));
            Console.WriteLine();
            Console.WriteLine(" Round 05");
            Console.WriteLine();

            Console.WriteLine(guerreiro.Attack(55));
            Console.WriteLine(maga.Attack(54));
            Console.WriteLine(aprendiz.Attack(35));
            Console.WriteLine(ninja.Attack(65));
            Console.WriteLine(arqueiro.Attack(75));
            Console.WriteLine();
            Console.WriteLine(" Final Round");
            Console.WriteLine();

        }
    }
}
