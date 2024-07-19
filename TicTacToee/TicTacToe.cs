using System;
using System.Net;
using System.Reflection.Metadata;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    public class HashGame
    {
        //Calls the resources.resx 
        static ResourceManager resManager = new ResourceManager("TicTacToee.Resources.resources", typeof(HashGame).Assembly);
        static CultureInfo culture = CultureInfo.InvariantCulture;

        // Array to represent the board
        static char[] positions = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
        // Variable to represent the current player
        static char currentPlayer = 'X';
        // Variable to determine if the player will play against the computer
        static bool versusPC = false;
        // Variable to choose the language of the game
        static void SetLanguage(string cultureName)
        {
            culture = new CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
        }

        // Method to restart the game
        static void RestartGame()
        {
            positions = new char[] {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
            currentPlayer = 'X';
        }

        // Method to show the board in the terminal
        static void ShowBoard()
        {
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2}", positions[0], positions[1], positions[2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2}", positions[3], positions[4], positions[5]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2}", positions[6], positions[7], positions[8]);
        }

        // Method to verify if there is a winner or a draw
        static bool VerifyVictory(out bool draw)
        {
            // Array with all the victory positions
            int[,] victoryPositions = {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
                { 0, 4, 8 }, { 2, 4, 6 }
            };

            // Verify if a victory was achieved
            for (int i = 0; i < victoryPositions.GetLength(0); i++)
            {
                int a = victoryPositions[i, 0];
                int b = victoryPositions[i, 1];
                int c = victoryPositions[i, 2];

                if (positions[a] == positions[b] && positions[b] == positions[c])
                {
                    draw = false; //Not a draw
                    return true; //It's a victory
                }
            }

            // Verify if have a draw
            for (int i = 0; i < positions.Length; i++)
            {
                if (positions[i] != 'X' && positions[i] != 'O')
                {
                    draw = false; 
                    return false; 
                }
            }
            draw = true; //All positions was filled, so it was a draw
            return false;
        }

        //Method of computer player
        static void playerPC()
        {
            //PC try win against the player
            if (WinOrLose('O')) return;

            //PC try to block the player
            if (WinOrLose('X')) return;

            //Otherwise, choose a strategy
            brainPC();
        }

        //Complementary method of the computer player method
        static bool WinOrLose(char player)
        {
            //Verify all victory positions
        int[,] victoryPositions = {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
                { 0, 4, 8 }, { 2, 4, 6 }
            };
            //Loop to verify the positions in the board
        for (int i = 0; i < victoryPositions.GetLength(0); i++)
        {
            int a = victoryPositions[i, 0];
            int b = victoryPositions[i, 1];
            int c = victoryPositions[i, 2];

            // Verify if two positions in the board are occupied
            if (positions[a] == player && positions[b] == player && positions[c] != 'X' && positions[c] != 'O')
            {
                positions[c] = 'O'; //Do the move
                return true; //Return true showing that the computer made the move
            }
            else if (positions[a] == player && positions[c] == player && positions[b] != 'X' && positions[b] != 'O')
            {
                positions[b] = 'O'; 
                return true;
            }
            else if (positions[b] == player && positions[c] == player && positions[a] != 'X' && positions[a] != 'O')
            {
                positions[a] = 'O'; 
                return true;
            }
        }
        return false; //Return false if it had not find a move
        }

        //Second complementary method of hardPC method
        static void brainPC()
        {
            //Prioritize central positions and corners
            int[] strategyPositions = [4, 0, 2, 6, 8, 1, 3, 5, 7];

            //Verify each strategic position
            for (int i = 0; i < strategyPositions.Length; i++)
            {
                int pos = strategyPositions[i];
                if (positions[pos] != 'X' && positions[pos] != 'O')
                {
                    positions[pos] = 'O';
                    return;
                }
            }
        }
        // Main method of the game
        static void Main()
        {
            bool restart = true;
            bool loopBool = true;
            Console.WriteLine("Language (en/pt): ");
            string language = Console.ReadLine()!.ToLower();
            if (language == "pt")
            {
                SetLanguage("pt-BR");
            }
            else
            {
                SetLanguage("en-US");
            }
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine(resManager.GetString("WelcomeMessage", culture));
            Console.WriteLine(resManager.GetString("VisitMessage", culture));
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            //Loop created in case the player inserted a invalid character
            while (loopBool)
            {
                // Choose if wanna play against another player or against the computer
                Console.WriteLine(resManager.GetString("SelectOpponent", culture));
                string chooseOpponent = Console.ReadLine()!.ToLower();
                if (chooseOpponent == "pc")
                {
                    versusPC = true;
                    break;

                }
                else if (chooseOpponent == "jog" || chooseOpponent == "play")
                {
                    versusPC = false;
                    restart = true;
                    break;
                }
                else
                {
                    restart = false;
                    Console.WriteLine(resManager.GetString("InvalidResponse", culture));
                    continue;

                }
            }
                // Loop to restart the game if the player wants
                while (restart)
                {
                    RestartGame();
                    bool endGame = false;

                    // Main loop of the game
                    do
                    {
                        Console.Clear();
                        ShowBoard();
                        Console.WriteLine("---|---|---");

                        //Case the player wants to play against another player
                        if (currentPlayer == 'X' || !versusPC)
                        {
                            //Receive the PlayerMovePrompt message from the resource manager
                            string playerMovePrompt = resManager.GetString("PlayerMovePrompt", culture) ?? "";
                            Console.WriteLine(string.Format(playerMovePrompt, currentPlayer));
                            string playerInput = Console.ReadLine()!;

                            // Verify if the input is valid
                            if (int.TryParse(playerInput, out int positioon) && positioon >= 1 && positioon <= 9 && positions[positioon - 1] != 'X' && positions[positioon - 1] != 'O')
                            {
                                positions[positioon - 1] = currentPlayer;
                                // Alternate between player X and O
                                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                            }
                        }
                        //Case the player wants to play against the computer
                        else 
                        {
                            versusPC = true;
                            playerPC();
                            currentPlayer = 'X';
                        }

                        // Verify if is a victory or a drow
                        if (VerifyVictory(out bool draw))
                        {
                            char winningPlayer = currentPlayer == 'X' ? 'O' : 'X';
                            Console.Clear();
                            ShowBoard();
                            string WinMessage = resManager.GetString("WinMessage", culture) ?? "";
                            Console.WriteLine(string.Format(WinMessage, winningPlayer));
                            endGame = true;
                        }
                        else if (draw)
                        {
                            Console.Clear();
                            ShowBoard();
                            Console.WriteLine(resManager.GetString("DrawMessage", culture));
                            endGame = true;
                        }

                    } while (!endGame);
                    
                    //Loop created in case the player inserts an invalid character
                    bool error = true;
                    while (error)
                    {
                        Console.WriteLine(resManager.GetString("PlayAgainPrompt", culture));
                        string playAgain = Console.ReadLine()!.ToLower();
                        if (playAgain != "yes" && playAgain != "sim")
                        {
                            restart = false;
                            Console.WriteLine(resManager.GetString("SwitchOrExit", culture));
                            string switchOrExit = Console.ReadLine()!.ToLower();
                            if (switchOrExit == "exit" || switchOrExit == "sair")
                            {
                                Console.WriteLine(resManager.GetString("ExitMessage", culture));
                                break;
                            }
                            else 
                            {
                                Main();
                            }
                        }
                        else if (playAgain == "yes" || playAgain == "sim")
                        {
                            RestartGame();
                            restart = true;
                            error = false;
                        }
                    
                    }    
                }
            }
    }
}

    

