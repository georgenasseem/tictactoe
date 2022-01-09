

//----------------------------------Mode Checker----------------------------------//


using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            bool correct = false;

            Console.WriteLine("Hello to this Tick Tack Toe Game");
            Console.ReadKey();
            Console.WriteLine("To play against the computer enter 1.\nTo go into multiplayer mode enter 2.");

            int answer = Int32.Parse(Console.ReadLine());

            while(!correct){

                if(answer == 1 || answer == 2){
                    correct = true;
                }

                else{
                    Console.WriteLine("Please enter a valid option!");
                    answer = Int32.Parse(Console.ReadLine());
                }

            }

            if(answer == 1){

                Players_1 p1 = new Players_1();
                int player = p1.player;
                int turns = p1.turns;
                char[,] playField = p1.playField;

                p1.GamePublic(playField, turns, player);
            }

            if(answer == 2){

                Players_2 p2 = new Players_2();
                int player = p2.player;
                int turns = p2.turns;
                char[,] playField = p2.playField;

                p2.GamePublic(playField, turns, player);
            }
        }
    }
}

        