using System.Collections;
using System.Collections.Generic;

namespace GoBang
{
    public class Matrix : IEnumerable<List<char>>
    {
        private readonly List<List<char>> _elements = new List<List<char>>();

        public Matrix(int row, int column, char initValue)
        {
            for (int i = 0; i < row; i++)
            {
                _elements.Add(new List<char>().InitWithValue(column, initValue));
            }
        }

        public override string ToString()
        {
            string str = string.Empty;

            _elements.ForEach(row =>
                {
                    row.ForEach(cell => str += cell);
                    str += "\n";
                });

            return str;
        }

        public List<char> this[int row]
        {
            get { return _elements[row]; }
        }

        public IEnumerator<List<char>> GetEnumerator()
        {
            return _elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}