using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoBangTest
{
    [TestClass]
    public class GoBangTest
    {
        [TestMethod]
        public void should_print_empty_chess_board_given_initial_board()
        {
            var chessBoard = new Board(8, 8);
            const string expected =  "********\n"+
                                     "********\n"+
                                     "********\n"+
                                     "********\n"+
                                     "********\n"+
                                     "********\n"+
                                     "********\n"+
                                     "********\n";  

            Assert.AreEqual(expected,chessBoard.BoardStatus);
        }
    }
}
