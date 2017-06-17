using ChessGame.Chess;
using ChessGame.Figures;
using ChessGame.Chess.ChessBoard;
using System;
using ChessGame.Chess.Utilities.Extensions;
using ChessGame.Chess.Figures;
using ChessGame.Chess.Figures.Enums;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Chess board example");

            ChessBoard board = ChessBoard.Instance;

            Figure p = FigureFactory.CreateFigure(FigureType.Pawn, Colors.Black, new Position('B', 2));
            board[p, new Position('B', 2)] = p.ShortName();

            Figure q = FigureFactory.CreateFigure(FigureType.Queen, Colors.White);
            board[q, new Position('C', 7)] = q.ShortName();

            board.PrintBoard();

            Console.WriteLine("Figures currently on the board:");
            foreach (string s in board)
            {
                Console.WriteLine(s);
            }

            int figuresOnBoard = board.FigureCount();
            Console.WriteLine("Number of figures on board: " + figuresOnBoard);



            Console.ReadKey();
        }
    }
}
