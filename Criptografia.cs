using System;
class Program
{
    static string Criptografar(string entrada)
    {
        string primeiraPassada = "";
        string segundaPassada = "";
        string segundaParteModificada = "";

        int indiceMeio  = 0;
        int deslocamentoLetras  = 3;
        int deslocamentoSegundaParte = 1;

        for (int i = 0; i < entrada.Length; i++)
        {
            char letra = entrada[i];

            if (char.IsLetter(letra))
            {
                char formatoCaractere  = (char)(letra + deslocamentoLetras );
                primeiraPassada += formatoCaractere ;
            }
            else
            {
                primeiraPassada += letra;
            }

        }

        for (int a = primeiraPassada.Length - 1; a >= 0; a--)
        {
            segundaPassada += primeiraPassada[a];
        }

        indiceMeio = segundaPassada.Length / 2;

        string primeiraParte = segundaPassada.Substring(0, indiceMeio );

        string segundaParte = segundaPassada.Substring(indiceMeio , segundaPassada.Length - indiceMeio );

        for (int i = 0; i < segundaParte.Length; i++)
        {
            char letra = segundaParte[i];

            char formatoCaractere  = (char)(letra - deslocamentoSegundaParte);
            segundaParteModificada += formatoCaractere ;
        }

        return (primeiraParte + segundaParteModificada);

    }

    static void Main(string[] args)
    {
        string entrada = "";
        int quantidadeLinhas = 0;

        do
        {
            Console.Write("Quantas linhas deseja tratar ? ");
            quantidadeLinhas = int.Parse(Console.ReadLine());

            if (quantidadeLinhas <= 0)
            {
                Console.WriteLine("Erro. Somente números positivos permitidos.");
                Console.WriteLine("Tente novamente.");
                Console.WriteLine();
            }
        }
        while (quantidadeLinhas <= 0 );

        for (int i = 0; i < quantidadeLinhas; i++)
        {
            Console.WriteLine();

            Console.Write("Digite a entrada: ");
            entrada = Console.ReadLine();
            Console.WriteLine($"Resposta: {Criptografar(entrada)}");
        }

        Console.ReadKey();
    }
}
