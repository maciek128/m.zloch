using ChessGame.Chess.ChessBoard;

namespace ChessGame.Chess.Figures
{
    class Bishop : Figure
    {
        private const string NAME = "Bishop";

        public Bishop(string color, Position pos = null)
            : base(NAME, color, pos)
        {
        }

        protected override bool CanBeMoved(string position)
        {
            
            return true;
        }
    }
}
