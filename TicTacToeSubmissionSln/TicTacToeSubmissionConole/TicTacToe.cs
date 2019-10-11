
using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(34,6);
            _boardRenderer.Render();
        }



      /*public void Run()
           {

             for (int i = 0; i < 9; i++)
               {
                   // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

                   Console.SetCursorPosition(2, 19);

                   Console.Write("Player X");

                   Console.SetCursorPosition(2, 20);

                   Console.Write("Please Enter Row: ");
                   var row = Console.ReadLine();

                   Console.SetCursorPosition(2, 22);


                   Console.Write("Please Enter Column: ");
                   var column = Console.ReadLine();


                   // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                   _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);



                   Console.SetCursorPosition(2, 24);
                   Console.Write("Now Player O turn");

                   Console.SetCursorPosition(2, 25);

                   Console.Write("Please Enter Row: ");
                   row = Console.ReadLine();

                   Console.SetCursorPosition(2, 26);


                   Console.Write("Please Enter Column: ");
                   column = Console.ReadLine();

                   _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);


               }
           }*/






            public int Getuser(int row, int column)
        {
            int answer = row * 3 + column;
            return answer;
        }


        public void myGame()
        {



            var boardNum = new char[9];
            var playerChar = ' ';

          _boardRenderer.Render();


            for (int i = 0; i < boardNum.Length; i++)
            {
                Console.SetCursorPosition(2, 19);
                Console.WriteLine("Player O");
                Console.Write("Please enter a row: ");
                var userX= Convert.ToInt32(Console.ReadLine()) - 1;

                Console.SetCursorPosition(2, 21);
                Console.Write("Please enter Column: ");
                var userY= Convert.ToInt32(Console.ReadLine()) - 1;

                _boardRenderer.AddMove(userX, userY, PlayerEnum.O, true);
                _boardRenderer.Render();


                Console.SetCursorPosition(2, 24);
                Console.WriteLine("Player X");
                Console.Write("Please enter a row: ");
                userX = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.SetCursorPosition(2, 26);
                Console.Write("Please enter Column: ");
                userY = Convert.ToInt32(Console.ReadLine()) - 1;

                _boardRenderer.AddMove(userX, userY, PlayerEnum.O, true);
                _boardRenderer.Render();

                var userInput = Getuser(userX, userY);

                

           /* if(boardNum[userInput] != ' ')
                {
                   
                    Console.SetCursorPosition(27, 19);
                    Console.WriteLine("that space is already taken");
                }*/

                if (boardNum[userInput] != ' ')
                {
                    if (i % 2 == 0)
                    {
                        playerChar = 'x';
                    }
                    else
                    {
                        playerChar = 'o';
                    }

                    if (playerChar == 'x')
                    {
                        _boardRenderer.AddMove(userX, userY, PlayerEnum.X);
                    }
                    else
                    {
                        _boardRenderer.AddMove(userX, userY, PlayerEnum.O);
                    }


                    _boardRenderer.Render();

                   



                }



            }


        }

      

    }
}
