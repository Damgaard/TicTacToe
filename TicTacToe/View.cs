﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class View
    {
        static public void Introduction() 
        {
            ClearScreen();
            Console.WriteLine("Welcome to TicTacToe.");
        }

        static public void ClearScreen()
        {
            Console.Clear();
        }

        static private char FieldToChar(Field field)
        {
            if (field == Field.Empty)
            {
                return ' ';
            }
            else if (field == Field.Circle)
            {
                return 'C';
            }
            else
            {
                return 'X';
            }
        }

        static public void DisplayBoard(Board board)
        {
            String horizontalBorder = "#############";
            String empty = "#   #   #   #";
            String line;

            Console.WriteLine(horizontalBorder);
            for (int i = 0; i < Board.HEIGHT; i++)
            {
                line = "";
                for (int j = 0; j < Board.WIDTH; j++)
                {
                    line += "# " + FieldToChar( board.GetPosition(j, i)) + " ";
                    ;
                }
                line += "#";
                Console.WriteLine(empty);
                Console.WriteLine(line);
                Console.WriteLine(empty);
                Console.WriteLine(horizontalBorder);
            }
        }
    }
}