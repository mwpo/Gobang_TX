using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Board
    {
        public string BoardStatus
        {
            get { return _boardStatus; }
        }

        private List<List<char>> _cells = new List<List<char>>()
                                              {
                                                  new List<char>(){'*','*','*','*','*','*','*','*',},
                                                  new List<char>(){'*','*','*','*','*','*','*','*',},
                                                  new List<char>(){'*','*','*','*','*','*','*','*',},
                                                  new List<char>(){'*','*','*','*','*','*','*','*',},
                                                  new List<char>(){'*','*','*','*','*','*','*','*',},
                                                  new List<char>(){'*','*','*','*','*','*','*','*',},
                                                  new List<char>(){'*','*','*','*','*','*','*','*',},
                                                  new List<char>(){'*','*','*','*','*','*','*','*',},
                                              };

        private string _boardStatus = string.Empty;

        public Board()
        {
            _cells.ForEach(row =>
                               {
                                   row.ForEach(cell => _boardStatus += cell);
                                   _boardStatus += "\n";
                               });
        }
    }
}