namespace JogoDaAdivinhacao.Consoleapp
{
    internal class Program
    {

        //Versão 2: Gerar um número secreto aleatório

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("        Jogo da Adivinhação        ");
            Console.WriteLine("-----------------------------------");

            // Lógica do Jogo
            Random geradorDeNumeros = new Random();

            int numeroSecreto = geradorDeNumeros.Next(1,21);
            

            Console.Write("Digite um número (de 1 à 20) para chutar: ");
            int numerodigitado = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você digitou o número:  {numerodigitado}");

            Console.WriteLine($"O número secreto é: {numeroSecreto}");
            Console.ReadLine();

        }
    }
}
