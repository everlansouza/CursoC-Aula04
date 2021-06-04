using System;

namespace Course4 {

    class Split {
    
        static void Main(string[] args) {

            string nome;

            Console.WriteLine("Digite o nome");
            nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}");

            Console.WriteLine("Informe as cores");
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
