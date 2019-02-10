using System;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Players! Let's play some TIICC TACCC TOOOEEE!!");
            Console.WriteLine("*Remember*: Place your entry in the grid by inputting a number!\n");
            
            Game game = new Game();
            game.CreatePlayers();

            string move = null;
            int position = -1;
            int entries = 0;
            bool noWinner = true;

            Player current = null;

            try
            {
                Console.WriteLine("\nBEGIN!\n");
                while(!game.ticTacToe)
                {
                    // Handle for no winner
                    if(entries >= game.Board.Length)
                    {
                        break;
                    }

                    // Flip Flop user
                    switch(position)
                    {
                        case -1:
                            current = game.Players[0];
                            break;
                        case 0:
                            current = game.Players[1];
                            break;
                        case 1:
                            current = game.Players[0];
                            break;
                    }

                    game.ShowGameBoard();
                    Console.WriteLine(String.Format("{0} your move!", current.Name));
                    move = Console.ReadLine();

                    game.InsertMove(move, current);
                    game.CheckForWinner();

                    position = current.Position;
                    entries++;
                }

                if(noWinner)
                {
                    Console.WriteLine("STALEMATE!!!");
                }
                else
                {
                    Console.WriteLine(String.Format("WINNER WINNER! Chicken Dinner! Congrats {0}", current.Name));
                }
                

                // Show Resultant GameBoard
                game.ShowGameBoard();
                Console.WriteLine("GAME OVER");
            }
            catch(Exception e)
            {
                Console.WriteLine(String.Format("Game over! Someone here is a cheater! \n Error!:{0}",e.Message));
            }
        }
    }
}
