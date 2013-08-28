using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    interface IPlayer
    {
        int Move();
        string Get_Name();
        Field Get_PlayerType();
    }
}
