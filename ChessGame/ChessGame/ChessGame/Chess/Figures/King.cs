using ChessGame.Chess.ChessBoard;

namespace ChessGame.Chess.Figures
{
    class King : Figure
    {
        private const string NAME = "King";

        public King(string color, Position pos = null)
            : base(NAME, color, pos)
        {
        }

        protected override bool CanBeMoved(string position)
        {
           
            return true;
        }

        public new string ToString()
        {
            return $"King class: {Color} {Name}";
        }
    }
}
