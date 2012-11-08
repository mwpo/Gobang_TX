using GoBang;
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

        [TestMethod]
        public void should_place_white_chess_on_2_2_cell_given_one_piece()
        {
            var chessBoard = new Board(8, 8);
            const string expected = "********\n" +
                                    "********\n" +
                                    "**o*****\n" +
                                    "********\n" +
                                    "********\n" +
                                    "********\n" +
                                    "********\n" +
                                    "********\n";

            chessBoard.PlaceChess(2, 2, CELL_STATUS.WHITE);

            Assert.AreEqual(expected, chessBoard.BoardStatus);
        }
    }
}
