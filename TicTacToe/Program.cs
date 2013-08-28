﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int next_move;
            IPlayer next_player;
            Board Board = new Board();

            IPlayer player1 = new RandomAI("Player1", ref Board, Field.Circle);
            IPlayer player2 = new Human("Player2", ref Board, Field.Cross);
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
