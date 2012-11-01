namespace ConsoleApplication1
{
    public class Board
    {
        private const char EMPTY = '*';

        public string BoardStatus
        {
            get { return _cells.ToString(); }
        }

        private readonly CharMatrix _cells;

        public Board(int row, int column)
        {
            _cells = new CharMatrix(row, column, EMPTY);
        }
    }
}