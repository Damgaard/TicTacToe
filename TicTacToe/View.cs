using System;
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

            ClearScreen();

            Console.WriteLine(horizontalBorder);
            for (int i = 0; i < Board.HEIGHT; i++)
            {
                line = "";
                for (int j = 0; j < Board.WIDTH; j++)
                {
                    line += "# " + FieldToChar(board.GetPosition(j, i)) + " ";
                    ;
                }
                line += "#";
                Console.WriteLine(empty);
                Console.WriteLine(line);
                Console.WriteLine(empty);
                Console.WriteLine(horizontalBorder);
            }
        }

        static public void GameOver()
        {
            Console.WriteLine("Game over!");
        }

        static public void Victory(IPlayer player)
        {
            Console.WriteLine("Player '{0}' is victorious!", player.Get_Name());
            Console.WriteLine("");
        }

        static public void ChooseName()
        {
            Console.WriteLine("What is the name of this player? ");
        }

        static public string GetStringChoice()
        {
            return Console.ReadLine();
        }

        static public int GetIntegerChoice()
        {
            return int.Parse(Console.ReadLine());
        }

        static public void SelectPlayer(int player)
        {
            Console.WriteLine("Select Player {0}", player);
        }

        static public void SelectPlayerMenu()
        {
            Console.WriteLine("Options.");
            Console.WriteLine("1. RandomAI");
            Console.WriteLine("2. Human");
        }
    }
}
