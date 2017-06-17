using ChessGame.Chess;
using ChessGame.Chess.Utilities;
using ChessGame.Chess.Utilities.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChessGame.Chess.ChessBoard
{
    sealed class ChessBoard : IEnumerable
    {

        private static readonly ChessBoard chessBoard = new ChessBoard();

        private const int boardSize = Consts.BOARD_SIZE;
        private string fillPattern1 = "[X]", fillPattern2 = "[ ]";
        private string[,] board;


        public static ChessBoard Instance
        {
            get
            {
                return chessBoard;
            }
        }

        static ChessBoard()
        {
        }

        private ChessBoard()
        {
            board = new string[boardSize, boardSize];
            board.Fill(fillPattern1, fillPattern2, boardSize);
        }


        public string this[Figure f, Position pos]
        {
            get
            {
                return board[pos.iX, pos.Y];
            }
            set
            {
                f.Position = pos;
                board[pos.iX, pos.Y] = value;
            }
        }



        public void PrintBoard()
        {
            string temp = string.Empty;
            List<char> letters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            for(int i = 0; i < boardSize; i++)
            {
                temp += (boardSize - i) + "\t";

                for(int j = 0; j < boardSize; j++)
                {
                    temp += board[i, j] + "\t";
                }

                temp += '\n';
            }

            temp += "\t";
            for(int w = 0; w < letters.Count; w++)
            {
                temp += $" {letters.ElementAt(w).ToString().ToUpper()}\t";
            }

            Console.WriteLine(temp);
        }

        public IEnumerator GetEnumerator()
        {
            List<string> list = new List<string>();
            string boardCell;

            for(int i = 0; i < boardSize; i++)
            {
                for(int j = 0; j < boardSize; j++)
                {
                    boardCell = board[i, j];

                    if(!boardCell.Contains(fillPattern1) && !boardCell.Contains(fillPattern2))
                    {
                        list.Add(board[i, j]);
                    }
                }
            }

            return list.GetEnumerator();
        }

    }

    static class ChessBoardExtensions
    {
        public static int FigureCount(this ChessBoard board)
        {
            int count = 0;

            foreach(var b in board)
            {
                count++;
            }

            return count;
        }
    }
}
