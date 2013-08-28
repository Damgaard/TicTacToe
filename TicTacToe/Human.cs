using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class Human : IPlayer
    {
        public string Name;
        public Board Board;
        public Field PlayerType;

        public Human(string Name, ref Board Board, Field PlayerType)
        {
            this.Name = Name;
            this.Board = Board;
            this.PlayerType = PlayerType;
        }

        public int Move()
        {
            int next_move = -1;
            do
            {
                Console.Write("Where do you want to place your piece?");
                next_move = int.Parse(Console.ReadLine());
            } while (!Board.CanPlace(next_move) && next_move > 0 && next_move < Board.HEIGHT * Board.WIDTH);
            return next_move;
         }

        public string Get_Name()
        {
            return Name;
        }

        public Field Get_PlayerType()
        {
            return PlayerType;
        }
    }
}
