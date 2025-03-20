namespace JogoDaAdivinhacao.Consoleapp
{
    internal class Program
    {

        //Versão 3: Verificar se o Jogador acertou

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("        Jogo da Adivinhação        ");
            Console.WriteLine("-----------------------------------");

            // Lógica do Jogo
            Random geradorDeNumeros = new Random();

            int numeroSecreto = geradorDeNumeros.Next(1,21);
            

            Console.Write("Digite um número (de 1 à 20) para chutar: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado == numeroSecreto)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("      Parabéns, você acertou       ");
                Console.WriteLine("-----------------------------------");
            }
            else if (numeroDigitado > numeroSecreto)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("      O número digitado foi maior que o número secreto     ");
                Console.WriteLine("-----------------------------------------------------------");
            }
            else 
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("      O número digitado foi menor que o número secreto     ");
                Console.WriteLine("-----------------------------------------------------------");
            }

                Console.ReadLine();

        }
    }
}
