using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    enum Field
    {
        Empty,
        Cross,
        Circle
    };

    class Board
    {
        static public int HEIGHT = 3;
        static public int WIDTH = 3;

        private Field [] positions = new Field[WIDTH * HEIGHT];

        public Board()
        {
            for (int i = 0; i < positions.Length; i++)
            {
                positions[i] = Field.Empty; // Default, but let's make it explicit.
            }
        }

        public bool IsFull()
        {
            for (int i = 0; i < positions.Length; i++)
            {
                if (positions[i] == Field.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CanPlace(int pos)
        {
            return positions[pos] == Field.Empty;
        }

        public Field GetPosition(int pos)
        {
            return positions[pos];
        }

        public Field GetPosition(int x, int y)
        {
            return this.GetPosition(y * WIDTH + x);
        }

        public void SetPosition(int pos, Field value)
        {
            positions[pos] = value;
        }
    }
}
