// 3ESPA
// Lucas Masaki Nagahama
// RM 553084
using System;

namespace ComparacaoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando variáveis para as duas pessoas
            string nome1, nome2;
            int idade1, idade2;

            // Printando texto para a pessoa 1
            Console.WriteLine("Digite o nome da primeira pessoa:");
            // Coletando input da pessoa 1
            nome1 = Console.ReadLine();

            // Mesma lógica utilizada anteriormente se repete
            Console.WriteLine("Digite a idade da primeira pessoa:");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa:");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite a idade da segunda pessoa:");
            idade2 = int.Parse(Console.ReadLine());

            // Condicional para verificar se idade da pessoa 1 é maior que a idade da pessoa 2
            if (idade1 > idade2)
            {
                // Printando texto com concatenação para aparecer o nome caso condicional acima seja satisfeita
                Console.WriteLine(nome1 + " é o mais velho e " + nome2 + " aluno é o mais novo.");
            }
            // Caso primeira condição não seja satisfeita, será verificada se idade da pessoa 1 é maior que a idade da pessoa 2
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