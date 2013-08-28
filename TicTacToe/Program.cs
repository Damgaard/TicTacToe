using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;

namespace TicTacToe
{
    class Program
    {
        static void SelectPlayers(out IPlayer player1, out IPlayer player2, ref Board Board)
        {
            int turn = 1, choice;
            string name;
            player1 = null;
            player2 = null;
            do
            {
                View.ClearScreen();
                View.SelectPlayer(turn);
                View.SelectPlayerMenu();
                choice = View.GetIntegerChoice();
                if (choice == 1 || choice == 2)
                {
                    View.ChooseName();
                    name = View.GetStringChoice();
                    if (turn == 1)
                    {
                        if (choice == 1)
                        {
                            player1 = new RandomAI(name, ref Board, Field.Circle);
                        }
                        else
                        {
                            player1 = new Human(name, ref Board, Field.Circle);
                        }
                    }
                    else
                    {
                        if (choice == 1)
                        {
                            player2 = new RandomAI(name, ref Board, Field.Cross);
                        }
                        else
                        {
                            player2 = new Human(name, ref Board, Field.Cross);
                        }
                    }
                    turn++;
                }
            } while (turn < 3);
        }

        static void Main(string[] args)
        {
            int next_move;
            IPlayer next_player, player1, player2;
            Board Board = new Board();

            SelectPlayers(out player1, out player2, ref Board);

            next_player = player2;

            View.Introduction();
            while (!Board.IsFull() && !Board.IsWon())
            {
                View.DisplayBoard(Board);
                next_player = next_player == player1 ? player2 : player1;
                Console.WriteLine("It is now player " + next_player.Get_Name() + "s turn to move.");
                next_move = next_player.Move();
                Board.SetPosition(next_move, next_player.Get_PlayerType());
            }
            View.DisplayBoard(Board);
            View.GameOver();
            if (Board.IsWon()) {
                View.Victory(next_player);
            }
        }
    }
}
