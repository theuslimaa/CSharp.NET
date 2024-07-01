using System;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class JogoDaVelha
{
    // Array para representar as casas do tabuleiro do game
    static char[] casas = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
    // Variável que mantém o player que irá iniciar
    static char jogadorAtual = 'X';
    // Variável para determinar se o player vai jogar contra o computador
    static bool versusPC = false;
    // Variável para determinar a dificuldade do computador
    static string dificuldade = "normal";

    // Método para reiniciar o jogo
    static void ReiniciarJogo()
    {
        casas = new char[] {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
        jogadorAtual = 'X';
    }

    // Método para mostrar o tabuleiro na tela
    static void MostrarJogo()
    {
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2}", casas[0], casas[1], casas[2]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2}", casas[3], casas[4], casas[5]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2}", casas[6], casas[7], casas[8]);
    }

    // Método para verificar se há um vencedor ou se deu velha (empate)
    static bool VerificarVitoria(out bool velha)
    {
        // Array com todas as combinações de vitória
        int[,] posicoesVitoria = {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
            { 0, 4, 8 }, { 2, 4, 6 }
        };

        // Verificar se alguma combinação de vitória foi alcançada
        for (int i = 0; i < posicoesVitoria.GetLength(0); i++)
        {
            int a = posicoesVitoria[i, 0];
            int b = posicoesVitoria[i, 1];
            int c = posicoesVitoria[i, 2];

            if (casas[a] == casas[b] && casas[b] == casas[c])
            {
                velha = false; //Não é empate
                return true; //Atingiu a vitória
            }
        }

        // Verificar se todas as casas foram preenchidas (empate)
        for (int i = 0; i < casas.Length; i++)
        {
            if (casas[i] != 'X' && casas[i] != 'O')
            {
                velha = false; //Não é empate
                return false; //Ainda possui casas vazias
            }
        }
        velha = true; //Todas as casas do tabuleiro estão preenchidas, dando velha
        return false;
    }

    //Método do jogador computador na dificuldade facil
    static void pcFacil()
    {
        Random rand = new Random();
        int posicao;
        do
        {
            posicao = rand.Next(1, 10);
        } while (casas[posicao - 1] == 'X' || casas[posicao - 1] == 'O');

        casas[posicao - 1] = 'O';
    }
    
    //Método principal do computador na dificuldade difícil
    static void pcHard()
    {
        //Tenta ganhar do jogador
        if (VencerOuPerder('O')) return;

        //Tenta bloquear o jogador
        if (VencerOuPerder('X')) return;

        //Caso contrário, escolha uma posição estratégica
        EstratégiaPC();
    }

    //Método complementar 1 da dificuldade dificil
    static bool VencerOuPerder(char player)
    {
        // Verifica cada combinação de vitória
       int[,] posicoesVitoria = {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
            { 0, 4, 8 }, { 2, 4, 6 }
       };
        //Loop para verificar as posições no tabuleiro
       for (int i = 0; i < posicoesVitoria.GetLength(0); i++)
       {
        int a = posicoesVitoria[i, 0];
        int b = posicoesVitoria[i, 1];
        int c = posicoesVitoria[i, 2];

        // Verifica se duas casas na linha/coluna/diagonal já estão ocupadas pelo símbolo dado
        if (casas[a] == player && casas[b] == player && casas[c] != 'X' && casas[c] != 'O')
        {
            casas[c] = 'O'; //Faz o movimento
            return true; //Retorna verdadeiro indicando que fez o movimento no tabuleiro
        }
        else if (casas[a] == player && casas[c] == player && casas[b] != 'X' && casas[b] != 'O')
        {
            casas[b] = 'O'; 
            return true;
        }
        else if (casas[b] == player && casas[c] == player && casas[a] != 'X' && casas[a] != 'O')
        {
            casas[a] = 'O'; 
            return true;
        }
       }
       return false; //Retorna falso caso não tenha encontrado nenhum movimento
    }

    //Método complementar 2 da dificuldade dificil
    static void EstratégiaPC()
    {
        //Priorize as posições centrais e cantos
        int[] posicoesEstrategicas = {4, 0, 2, 6, 8, 1, 3, 5, 7};

        //Verifica cada posição estratégica
        for (int i = 0; i < posicoesEstrategicas.Length; i++)
        {
            int pos = posicoesEstrategicas[i];
            if (casas[pos] != 'X' && casas[pos] != 'O')
            {
                casas[pos] = 'O';
                return;
            }
        }
    }
    // Método principal do jogo
    static void Main()
    {
        bool reiniciar = true;
        bool verificando = true;
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("BEM VINDO AO JOGO DA VELHA FEITO PELO THEUSDEV");
        Console.WriteLine("VEJA MEUS OUTROS PROJETOS: https://github.com/thetheusdev");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

        //Loop para verificar caso o jogador insira uma palavra invalida
        while (verificando)
        {
            // Escolher se quer jogar contra o computador ou contra um player
            Console.WriteLine("Deseja jogar contra um jogador ou contra o computador? (jog/pc): ");
            string simComputador = Console.ReadLine()!.ToLower();
            if (simComputador == "pc")
            {
                versusPC = true;
                Console.WriteLine("Escolha a dificuldade: facil ou dificil");
                dificuldade = Console.ReadLine()!.ToLower();
                break;

            }
            else if (simComputador == "jog")
            {
                versusPC = false;
                reiniciar = true;
                break;
            }
            else
            {
                reiniciar = false;
                Console.WriteLine("Resposta invalida, tente novamente.");
                continue;

            }
        }
            // Loop para reiniciar o jogo se o jogador desejar
            while (reiniciar)
            {
                ReiniciarJogo();
                bool fimDeJogo = false;

                // Loop principal do jogo
                do
                {
                    Console.Clear();
                    MostrarJogo();
                    Console.WriteLine("---|---|---");

                    //Caso o player queira jogar contra outro player
                    if (jogadorAtual == 'X' || !versusPC)
                    {
                        Console.WriteLine($"Jogador {jogadorAtual}, escolha sua posição: ");
                        string inputJogador = Console.ReadLine()!;

                        // Verificar se a entrada do jogador é válida
                        if (int.TryParse(inputJogador, out int posicao) && posicao >= 1 && posicao <= 9 && casas[posicao - 1] != 'X' && casas[posicao - 1] != 'O')
                        {
                            casas[posicao - 1] = jogadorAtual;
                        }
                        else 
                        {
                            // Se o jogador colocar algo que não seja os números, solicitar novamente
                            Console.WriteLine("Movimento inválido. Tente de novo.");
                            continue;
                        }

                        // Verificar se há um vencedor ou se deu velha
                        if (VerificarVitoria(out bool velha))
                        {
                            Console.Clear();
                            MostrarJogo();
                            Console.WriteLine($"Jogador {jogadorAtual} ganhou!!!");
                            fimDeJogo = true;
                        }
                        else if (velha)
                        {
                            Console.Clear();
                            MostrarJogo();
                            Console.WriteLine("DEU VELHA!!!");
                            fimDeJogo = true;
                        }
                        else
                        {
                            // Alternar entre o jogador X e o O
                            jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                        }
                    }

                    //Caso o player queira jogar contra o computador
                    if (jogadorAtual == 'O' && versusPC && !fimDeJogo)
                    {
                        if (dificuldade == "facil")
                        {
                            pcFacil();
                        }
                        else if (dificuldade == "dificil")
                        {
                            pcHard();
                        }

                        if (VerificarVitoria(out bool velha))
                        {
                            Console.Clear();
                            MostrarJogo();
                            Console.WriteLine($"Jogador {jogadorAtual} ganhou!!!");
                            fimDeJogo = true;
                        }
                        else if (velha)
                        {
                            Console.Clear();
                            MostrarJogo();
                            Console.WriteLine("DEU VELHA!!!");
                            fimDeJogo = true;
                        }
                        else
                        {
                            jogadorAtual = 'X';
                        }
                    }


                } while (!fimDeJogo);

                //Loop para caso o jogador insira algo invalido, ele retornar
                bool erro = true;
                while (erro)
                {
                    // Perguntar se deseja jogar de novo
                    Console.WriteLine("Jogar novamente? (sim/nao)");
                    string resposta = Console.ReadLine()!.ToLower();
                    if (resposta == "sim")
                    {
                        ReiniciarJogo();
                        break;
                    }
                    else if (resposta == "nao")
                    {
                        // Perguntar se o jogador deseja alternar com quem quer jogar ou sair
                        Console.WriteLine("Deseja alternar com quem quer jogar ou deseja sair de vez? (alternar/sair)");
                        string resposta2 = Console.ReadLine()!.ToLower();
                        if (resposta2 == "alternar")
                        {
                            Main();
                        }
                        else if (resposta2 == "sair")
                        {
                            reiniciar = false;
                            Console.WriteLine("Muito obrigado por jogar e veja os meus outros projetos em https://github.com/thetheusdev.");
                            erro = false;
                        }
                        else
                        {
                            Console.WriteLine("Resposta invalida, tente novamente");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Resposta invalida, tente novamente");
                        continue;
                    }
                }
            }
        }
    }

