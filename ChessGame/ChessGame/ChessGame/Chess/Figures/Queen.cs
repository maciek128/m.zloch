﻿using ChessGame.Chess.ChessBoard;

namespace ChessGame.Chess.Figures
{
    class Queen : Figure
    {
        private const string NAME = "Queen";

        public Queen(string color, Position pos = null)
            : base(NAME, color, pos)
        {
        }

        protected override bool CanBeMoved(string position)
        {
            return true;
        }
    }
}
