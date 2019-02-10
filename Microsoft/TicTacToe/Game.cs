using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Game
    {
        // String Array as we want to swap numbers with entries
        public string[] Board;
        public List<Player> Players;

        public bool ticTacToe;

        public Game()
        {
            ticTacToe = false;
            Players = new List<Player>();
            Board = new string[]{"0","1","2","3","4","5","6","7","8"};
        }

        public void CreatePlayers()
        {
            for(int i = 0; i < 2; i++)
            {
                Player player = new Player();
                player = GatherUserInformation(i);
                player.Position = i;
                Players.Add(player);
            }
        }

        public void ShowGameBoard()
        {
            Console.WriteLine(String.Format("{0}|{1}|{2}\n{3}|{4}|{5}\n{6}|{7}|{8}\n",Board[0],Board[1],Board[2],Board[3],Board[4],Board[5],Board[6],Board[7],Board[8]));
        }

        public void InsertMove(string input, Player player)
        {
            int move;
            if(Int32.TryParse(input, out move))
            {
                Board[move] = player.Letter;
            }
            else
            {
                throw new Exception("Illegal Entry!");
            }
        }

        public void CheckForWinner()
        {
            // Horizontal
            if(Board[0] == Board[1] && Board[1] == Board[2])
            {
                ticTacToe = true;
            }
            else if(Board[3] == Board[4] && Board[4] == Board[5])
            {
                ticTacToe = true;
            }
            else if(Board[6] == Board[7] && Board[7] == Board[8])
            {
                ticTacToe = true;
            }

            // Vertical
            else if(Board[0] == Board[3] && Board[3] == Board[6])
            {
                ticTacToe = true;
            }
            else if(Board[1] == Board[4] && Board[4] == Board[7])
            {
                ticTacToe = true;
            }
            else if(Board[2] == Board[5] && Board[5] == Board[8])
            {
                ticTacToe = true;
            }

            // Diagonal
            else if(Board[0] == Board[4] && Board[4] == Board[8])
            {
                ticTacToe = true;
            }
            else if(Board[6] == Board[4] && Board[4] == Board[2])
            {
                ticTacToe = true;
            }
        }

        public Player GatherUserInformation(int position)
        {
            Player output = new Player();
            Console.WriteLine(String.Format("Player {0}: What's your name?", position+1));
            output.Name = Console.ReadLine();
            Console.WriteLine(String.Format("Player {0}: What letter would you like to use for the game?", position+1));
            output.Letter = Console.ReadLine();

            return output;
        }
    }
}