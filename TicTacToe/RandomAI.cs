using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class RandomAI : IPlayer
    {
        public string Name;
        public Board Board;
        public Field PlayerType;

        public RandomAI(string Name, ref Board Board, Field PlayerType)
        {
            this.Name = Name;
            this.Board = Board;
            this.PlayerType = PlayerType;
        }

        public int Move()
        {
            Random random = new Random();
            int new_number = 0;
            // TODO: Find a faster method to find a free random position.
            do
            {
                new_number = random.Next(0, 9);
            }
            while (Board.GetPosition(new_number) != Field.Empty);
            return new_number;
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
