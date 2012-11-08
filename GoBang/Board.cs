namespace GoBang
{
    public static class CELL_STATUS
    {
        public const char EMPTY = '*';
        public const char WHITE = 'o';
        public const char BLACK = '1';
    }

    public class Board
    {
        public string BoardStatus
        {
            get { return _cells.ToString(); }
        }

        private readonly Matrix _cells;

        public Board(int row, int column)
        {
            _cells = new Matrix(row, column, CELL_STATUS.EMPTY);
        }

        public bool TryPlace(int row, int column, char chess)
        {
            _cells[row][column] = chess;
            return true;
        }
    }
}