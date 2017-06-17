using ChessGame.Chess.Figures.Enums;
using System;

namespace ChessGame.Chess.Utilities.Extensions
{
    public static class EnumExtensions
    {
        public static string Name(this Colors color)
        {
            return Enum.GetName(typeof(Colors), color);
        }
    }
}
