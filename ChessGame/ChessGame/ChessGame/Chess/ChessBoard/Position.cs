using ChessGame.Chess.Utilities;
using System;

namespace ChessGame.Chess.ChessBoard
{
    public class Position
    {

        public char X { get; }
        public int iX { get; }
        public int Y { get; }





        public Position(char X, int Y)
        {
            if(CheckBounds(Consts.BOARD_SIZE, charToChessInt(X), Y))
            {
                this.X = X;
                this.Y = Y;
                this.iX = charToChessInt(X);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }



 

        private bool CheckBounds(int boardSize, params int[] values)
        {
            bool result = true;

            foreach (int value in values)
            {
                if (!(value >= 0 && value - 1 <= boardSize))
                {
                    result = false;
                }
            }

            return result;
        }

        private int charToChessInt(char c)
        {
            return c - 65;
        }

    }
}
