using System;

namespace ProgramaFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p1 = new Funcionario();
            Funcionario p2 = new Funcionario();

            Console.WriteLine("Nome do primeiro funcionario? ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Salário do primeiro funcionario? ");
            p1.Salário = float.Parse(Console.ReadLine());

            Console.WriteLine("Nome do segundo funcionario? ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Salário do segundo funcionario? ");
            p2.Salário = float.Parse(Console.ReadLine());

            Console.WriteLine("Media salarial: {0}", (p1.Salário + p2.Salário)/2);
             
        }
    }
}
