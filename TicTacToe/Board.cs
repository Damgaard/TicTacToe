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

        public bool IsWon()
        {
            // Horizontal
            for (int i = 0; i < HEIGHT; i++)
            {
                if (GetPosition(0, i) != Field.Empty && (GetPosition(0, i) == GetPosition(1, i)) && (GetPosition(1, i) == GetPosition(2, i) ))
                {
                    return true;
                }
            }

            // Vertical
            for (int i = 0; i < WIDTH; i++)
            {
                if (GetPosition(i, 0) != Field.Empty && (GetPosition(i, 0) == GetPosition(i, 1)) && (GetPosition(i, 1) == GetPosition(i, 2)))
                {
                    return true;
                }
            }

            // Diagonals
            if (GetPosition(1, 1) != Field.Empty) {
                // Top left to bottom right
                if ((GetPosition(0, 0) == GetPosition(1, 1)) && (GetPosition(1, 1) == GetPosition(2, 2)))
                {
                    return true;
                }
                // Top right to bottom left
                if ((GetPosition(0, 2) == GetPosition(1, 1)) && (GetPosition(1, 1) == GetPosition(2, 0)))
                {
                    return true;
                }
            }
            return false;
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
