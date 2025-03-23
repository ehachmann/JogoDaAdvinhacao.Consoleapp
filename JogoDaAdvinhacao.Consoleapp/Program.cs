using System;

namespace JogoDaAdivinhacao.Consoleapp
    {
        internal class Program
        {

            //Versão 5: Armazenar e exibir números jogados

            static void Main(string[] args)
            {
                int contador = 0;
                
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("        Jogo da Adivinhação        ");
                    Console.WriteLine("-----------------------------------");

                    // Escolha de dificuldade

                    Console.WriteLine("Escolha um nível de dificuldade");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("1 - Fácil (10 tentativas)");
                    Console.WriteLine("2 - Normal (5 tentativas)");
                    Console.WriteLine("3 - Difícil (3 tentativas)");
                    Console.WriteLine("--------------------------------");

                    Console.Write("Digite sua escolha: ");
                    string escolhaDeDificuldade = Console.ReadLine();
                
                int totalDeTentativas = 0;

                    if (escolhaDeDificuldade == "1")
                        totalDeTentativas = 10;
                    else if (escolhaDeDificuldade == "2")
                        totalDeTentativas = 5;
                    else
                        totalDeTentativas = 3;

                // Lógica do Jogo

                    int[] numerosJogados = new int[totalDeTentativas];
                
                    Random geradorDeNumeros = new Random();
                    int numeroSecreto = geradorDeNumeros.Next(1, 21);

                    for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                    {

                        Console.Clear();
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
                        Console.WriteLine("-------------------------------------------");

                        Console.Write("Digite um número entre 1 à 20 para chutar: ");
                        int numeroDigitado = int.Parse(Console.ReadLine());
                        numerosJogados[contador] = numeroDigitado;

                        if (numeroDigitado == numeroSecreto)
                        {
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("      Parabéns, você acertou       ");
                            Console.WriteLine("-----------------------------------");
                            break;
                        }
                        if (tentativa == totalDeTentativas)
                        {
                            Console.WriteLine("-----------------------------------------------------------------------");
                            Console.WriteLine($" Que pena! Você usou todas as tentativas. O número era {numeroSecreto}");
                            Console.WriteLine("-----------------------------------------------------------------------");
                            break;
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

                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine($"    Números que já foram Jogados:    ");
                            Console.WriteLine("--------------------------------------");

                        for (int i = 0; i < numerosJogados.Length; i++)
                        {
                            if (numerosJogados[i] != null)
                                Console.WriteLine($"{i + 1}º Tentativa: {numerosJogados[i]}");
                        }

                        Console.WriteLine("Pressione Enter para continuar...");
                        
                        Console.ReadLine();
                        contador += 1;
                    }

                    Console.Write("Deseja continuar? (S/N): ");
                    string opcaoContinuar = Console.ReadLine().ToUpper();
                    contador = 0;

                    if (opcaoContinuar != "S")
                        break;

                   //Console.ReadLine();
                }
            }
        }
    }

