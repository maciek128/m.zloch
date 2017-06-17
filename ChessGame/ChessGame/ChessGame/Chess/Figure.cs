using ChessGame.Chess.ChessBoard;
using System;

namespace ChessGame.Chess
{
    abstract class Figure
    {

        public delegate void PositionChangeHandler();
        public event PositionChangeHandler OnPositionChange;


        public string Color { get; set; }
        public string Name { get; set; }
        private Position position;
        public Position Position
        {
            get
            {
                return position;
            }
            set
            {
                if(null != OnPositionChange) OnPositionChange();
                position = value;
            }
        }



        public Figure(string name, string color, Position pos)
        {
            Name = name;
            Color = color;
            Position = pos;
            OnPositionChange += PositionChanged;
        }



        protected abstract bool CanBeMoved(string position);



        public string ShortName()
        {
            return Color[0].ToString() + Name[0].ToString();
        }

        public override string ToString()
        {
            return $"Base class: {Color} {Name}";
        }

        public void PositionChanged()
        {
            Console.WriteLine($"{Name} changed position!");
        }

    }
}
