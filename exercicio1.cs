using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Digite o número de pessoas premiadas:");
        int premiados = int.Parse(Console.ReadLine()); // Deve-se informar o número de pessoas premiadas

        Console.WriteLine("Digite os tamanhos preferidos pelas pessoas premiadas (sabendo que 1 é referente ao pequeno e 2 para o médio):");
        int[] tamanhoscamisetas = new int[premiados]; // vetor que irá armazenar os tamanhos das camisetas fornecidos pelo usuário

        for (int i = 0; i < premiados; i++)
        {
            tamanhoscamisetas[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Digite o numero de camisetas do tamanho P");
        int tamP = int.Parse(Console.ReadLine()); ; // número de camisetas pequenas

        Console.WriteLine("Digite o numero de camisetas do tamanho M");
        int tamM = int.Parse(Console.ReadLine()); ; // número de camisetas medias

        int contadorPequenas = 0; // para contar a quantidade de camisetas pequenas
        int contadorMedias = 0; // para contar a quantidade de camisetas medias

        for (int i = 0; i < premiados; i++)
        {
            if (tamanhoscamisetas[i] == 1) // informa tamanho pequeno
                contadorPequenas++;
            else if (tamanhoscamisetas[i] == 2) // informa tamanho médio
                contadorMedias++;
        }

        if (tamP <= contadorPequenas && tamM <= contadorMedias)
            Console.WriteLine("S"); // para afirmar as entradas fornecidas
        else
            Console.WriteLine("N"); // para negar as entradas fornecidas
    }
}
