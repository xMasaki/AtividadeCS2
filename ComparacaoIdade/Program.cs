using System;

namespace ComparacaoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;

            Console.WriteLine("Digite o nome da primeira pessoa:");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite a idade da primeira pessoa:");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa:");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite a idade da segunda pessoa:");
            idade2 = int.Parse(Console.ReadLine());

            if (idade1 > idade2)
            {
                Console.WriteLine(nome1 + " é o mais velho e " + nome2 + " aluno é o mais novo.");
            }
            else if (idade2 > idade1)
            {
                Console.WriteLine(nome2 + " é o mais velho e " + nome1 + " aluno é o mais novo.");
            }
            else if (idade1 == idade2)
            {
                Console.WriteLine(nome1 + " e " + nome2 + " têm a mesma idade.");
            }
        }
    }
}