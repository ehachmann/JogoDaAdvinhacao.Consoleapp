namespace JogoDaAdivinhacao.Consoleapp
{
    internal class Program
    {

        //Versão 1: Estrutura básica e entrada do usuário

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("        Jogo da Adivinhação        ");
            Console.WriteLine("-----------------------------------");

            // Lógica do Jogo

            Console.Write("Digite um número para chutar: ");
            int numerodigitado = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você digitou o número:  {numerodigitado}");
            Console.ReadLine();

        }
    }
}
