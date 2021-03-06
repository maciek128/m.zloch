﻿using ChessGame.Chess.ChessBoard;

namespace ChessGame.Chess.Figures
{
    class Pawn : Figure
    {
        private const string NAME = "Pawn";

        public Pawn (string color, Position pos = null)
            : base(NAME, color, pos)
        {
        }

        protected override bool CanBeMoved(string position)
        {
          
            return true;
        }
    }
}
