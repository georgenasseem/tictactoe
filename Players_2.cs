

//--------------------------------Tick Tack Toe 2---------------------------------//


using System;

namespace TicTacToe
{
    class Players_2
    {
        public char[,] playField =
            {
                {'a','b','c'},  //Row 0
                {'d','e','f'},  //Row 1
                {'g','h','i'}   //Row 2
            };

        public int turns = 0;
        public int player = 2;

        public void GamePublic(char[,] playField,int turns, int player)
        {
            turns = 0;
            char input = 'l';
            bool inputCorrect = true;

            //run code as long as the program runs
            do{

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(input, playField, turns, player);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(input, playField, turns, player);
                }

                SetField(playField, turns, player);
                turns++;

                #region
                //Check Winning Condition   
                char[] playerChars = { 'X', 'O' };

                CheckCondition(playerChars, playField, turns, player);

                #endregion


                #region
                //Test if field is already taken
                do
                {
                    Console.Write("\nPlayer {0}: Choose your field! ", turns);
                    try
                    {
                        input = Console.ReadLine()[0];
                    }
                    catch
                    {
                        Console.WriteLine("Plese enter a letter!");
                    }

                    if ((input == 'a') && (playField[0, 0] == 'a'))
                        inputCorrect = true;
                    else if ((input == 'b') && (playField[0, 1] == 'b'))
                        inputCorrect = true;
                    else if ((input == 'c') && (playField[0, 2] == 'c'))
                        inputCorrect = true;
                    else if ((input == 'd') && (playField[1, 0] == 'd'))
                        inputCorrect = true;
                    else if ((input == 'e') && (playField[1, 1] == 'e'))
                        inputCorrect = true;
                    else if ((input == 'f') && (playField[1, 2] == 'f'))
                        inputCorrect = true;
                    else if ((input == 'g') && (playField[2, 0] == 'g'))
                        inputCorrect = true;
                    else if ((input == 'h') && (playField[2, 1] == 'h'))
                        inputCorrect = true;
                    else if ((input == 'i') && (playField[2, 2] == 'i'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please use another field!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion

            } while (true);
        }

        static void GameStatic(char[,] playField,int turns, int player)
        {
            char[,] playFieldInitial =
            {
                {'a','b','c'},
                {'d','e','f'},
                {'g','h','i'}
            };

            playField = playFieldInitial;
            SetField(playField, turns, player);
        

            turns = 0;
            player = 1;

            char input = 'l';
            bool inputCorrect = true;

            //run code as long as the program runs
            do{

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(input, playField, turns, player);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(input, playField, turns, player);
                }

                SetField(playField, turns, player);
                turns++;

                #region
                //Check Winning Condition   
                char[] playerChars = { 'X', 'O' };

                CheckCondition(playerChars, playField, turns, player);

                #endregion


                #region
                //Test if field is already taken
                do
                {
                    Console.Write("\nPlayer {0}: Choose your field! ", player);
                    try
                    {
                        input = Console.ReadLine()[0];
                    }
                    catch
                    {
                        Console.WriteLine("Plese enter a letter!");
                    }

                    if ((input == 'a') && (playField[0, 0] == 'a'))
                        inputCorrect = true;
                    else if ((input == 'b') && (playField[0, 1] == 'b'))
                        inputCorrect = true;
                    else if ((input == 'c') && (playField[0, 2] == 'c'))
                        inputCorrect = true;
                    else if ((input == 'd') && (playField[1, 0] == 'd'))
                        inputCorrect = true;
                    else if ((input == 'e') && (playField[1, 1] == 'e'))
                        inputCorrect = true;
                    else if ((input == 'f') && (playField[1, 2] == 'f'))
                        inputCorrect = true;
                    else if ((input == 'g') && (playField[2, 0] == 'g'))
                        inputCorrect = true;
                    else if ((input == 'h') && (playField[2, 1] == 'h'))
                        inputCorrect = true;
                    else if ((input == 'i') && (playField[2, 2] == 'i'))
                        inputCorrect = true;
                    else
                    {
                            Console.WriteLine("\n Incorrect input! Please use another field!");
                            inputCorrect = false;
                        
                    }

                } while (!inputCorrect);
                #endregion

            } while (true);
        }

        public static void ResetField(char[,] playField,int turns, int player)
        {
            char[,] playFieldInitial =
            {
                {'a','b','c'},
                {'d','e','f'},
                {'g','h','i'}
            };

            playField = playFieldInitial;
            SetField(playField, turns, player);
            turns = 0;
            player = 1;
        }

        public static void SetField(char[,] playField,int turns, int player)
        {
            Console.Clear();
            Console.WriteLine("     |     |      ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");
        }

        public static void EnterXorO(char input, char[,] playField,int turns, int player) {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input)
            {
                case 'a': playField[0, 0] = playerSign; break;
                case 'b': playField[0, 1] = playerSign; break;
                case 'c': playField[0, 2] = playerSign; break;
                case 'd': playField[1, 0] = playerSign; break;
                case 'e': playField[1, 1] = playerSign; break;
                case 'f': playField[1, 2] = playerSign; break;
                case 'g': playField[2, 0] = playerSign; break;
                case 'h': playField[2, 1] = playerSign; break;
                case 'i': playField[2, 2] = playerSign; break;
            }
        }

        public static void CheckCondition(char[]pC, char[,] playField,int turns, int player){

            foreach(char playerChar in pC)
            {
                if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar)) 
                    ||((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar)) 
                    ||((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar)) 
                    ||((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar)) 
                    ||((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar)) 
                    ||((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar)) 
                    ||((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar)) 
                    ||((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
                    )
                {
                    if(playerChar == 'X')
                    { 
                        Console.Clear();
                        Console.WriteLine("\nPlayer 2 has won!");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nPlayer 1 has won!");
                    }

                    Console.WriteLine("To play again enter 1\nTo exit the game enter 2");
                    int a = Int32.Parse(Console.ReadLine());
                    bool ac = false;

                    while(ac == false){
                        
                        if(a == 1 || a == 2){
                            ac = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("To play again enter 1\nTo exit the game enter 2");
                            a = Int32.Parse(Console.ReadLine());
                        }

                    }

                    if(a == 1){
                        
                        GameStatic(playField, turns, player);

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for playing!");
                        System.Environment.Exit(1);
                    }

                }
                else if (turns == 10)
                {
                    Console.WriteLine("/Draw");
                    Console.WriteLine("To play again enter 1\nTo exit the game enter 2");
                    int a = Int32.Parse(Console.ReadLine());
                    bool ac = false;

                    while(ac == false){
                        
                        if(a == 1 || a == 2){
                            ac = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("To play again enter 1\nTo exit the game enter 2");
                            a = Int32.Parse(Console.ReadLine());
                        }

                    }

                    if(a == 1){
                        
                        GameStatic(playField, turns, player);

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for playing!");
                        System.Environment.Exit(1);
                    }
                }
            } 
        }
    }
}
