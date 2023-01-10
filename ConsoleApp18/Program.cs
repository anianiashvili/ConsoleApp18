using System;

class Program
{
    static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    static void DrawBoard() 
    {
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
        Console.WriteLine("-------------------");
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
        Console.WriteLine("-------------------");
        Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
    }

    static void Main(string[] args)
    {
        string player1 = "", player2 = "";
        int choice = 0, turn = 1, score1 = 0, score2 = 0;
        bool winFlag = false, playing = true, correctInput = false;

        Console.WriteLine("Hello!!!!!!");
        player2 = Console.ReadLine();
        while (playing == true)
        {
            while (winFlag == false) 
            {
                DrawBoard();
                Console.WriteLine(player1, score1, player2, score2);
                if (turn == 1)
                {
                    Console.WriteLine(player1);
                }
                if (turn == 2)
                {
                    Console.WriteLine(player2);
                }

                while (correctInput == false)
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice > 0 && choice < 10)
                    {
                        correctInput = true;
                    }
                    else
                    {
                        continue;
                    }
                }

                correctInput = false;

                if (turn == 1)
                {
                    if (pos[choice] == "X") 
                    {
                        Console.WriteLine("");
                        Console.Write("Try again.");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        pos[choice] = "O";
                    }
                }
                if (turn == 2)
                {
                    if (pos[choice] == "O") 
                    {
                        Console.Write("Try again.");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        pos[choice] = "X";
                    }
                }

                winFlag = CheckWin();

                if (winFlag == false)
                {
                    if (turn == 1)
                    {
                        turn = 2;
                    }
                    else if (turn == 2)
                    {
                        turn = 1;
                    }
                    Console.Clear();
                }
            }

            Console.Clear();

            DrawBoard();

            for (int i = 1; i < 10; i++) 
            {
                pos[i] = i.ToString();
            }

            if (winFlag == false) 
            {
                Console.WriteLine("It's a draw!");
                Console.WriteLine(player1, score1, player2, score2);

                Console.WriteLine("1. Play again");
                Console.WriteLine("2. Leave");
               

                while (correctInput == false)
                {
                    Console.WriteLine("");
                    choice = int.Parse(Console.ReadLine());

                    if (choice > 0 && choice < 3)
                    {
                        correctInput = true;
                    }
                }

                correctInput = false; 

                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        Console.Clear();
                    
                        Console.ReadLine();
                        playing = false;
                        break;
                }
            }

 
            {
                if (turn == 1)
                {
                    score1++;
                    Console.WriteLine("{0} you wins!!!!!!!!!!!!", player1);
      
                    Console.WriteLine("1. Play again");
                    Console.WriteLine("2. Leave");

                    while (correctInput == false)
                    {
                  
                        choice = int.Parse(Console.ReadLine());

                        if (choice > 0 && choice < 3)
                        {
                            correctInput = true;
                        }
                    }

                    correctInput = false; 

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            winFlag = false;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("");
                            Console.ReadLine();
                            playing = false;
                            break;
                    }
                }

                if (turn == 2)
                {
                    score2++;
                    Console.WriteLine("{0} you wins!!!!!!!!!!", player2);
                
                    Console.WriteLine("1. Play again");
                    Console.WriteLine("2. Leave");

                    while (correctInput == false)
                    {
                        Console.WriteLine("");
                        choice = int.Parse(Console.ReadLine());

                        if (choice > 0 && choice < 3)
                        {
                            correctInput = true;
                        }
                    }

                    correctInput = false; 

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            winFlag = false;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Thanks for playing!");
                            Console.ReadLine();
                            playing = false;
                            break;
                    }
                }
            }
        }
    }

    static bool CheckWin() 
    {
        if (pos[1] == "O" && pos[2] == "O" && pos[3] == "O") // ჰორიზონტალური
        {
            return true;
        }
        else if (pos[4] == "O" && pos[5] == "O" && pos[6] == "O")
        {
            return true;
        }
        else if (pos[7] == "O" && pos[8] == "O" && pos[9] == "O")
        {
            return true;
        }

        else if (pos[1] == "O" && pos[5] == "O" && pos[9] == "O") // დიაგონალი
        {
            return true;
        }
        else if (pos[7] == "O" && pos[5] == "O" && pos[3] == "O")
        {
            return true;
        }

        else if (pos[1] == "O" && pos[4] == "O" && pos[7] == "O")//სვეტი
        {
            return true;
        }
        else if (pos[2] == "O" && pos[5] == "O" && pos[8] == "O")
        {
            return true;
        }
        else if (pos[3] == "O" && pos[6] == "O" && pos[9] == "O")
        {
            return true;
        }

        if (pos[1] == "X" && pos[2] == "X" && pos[3] == "X") //ჰორიზონტალური
        {
            return true;
        }
        else if (pos[4] == "X" && pos[5] == "X" && pos[6] == "X")
        {
            return true;
        }
        else if (pos[7] == "X" && pos[8] == "X" && pos[9] == "X")
        {
            return true;
        }

        else if (pos[1] == "X" && pos[5] == "X" && pos[9] == "X") // დიაგონალი
        {
            return true;
        }
        else if (pos[7] == "X" && pos[5] == "X" && pos[3] == "X")
        {
            return true;
        }

        else if (pos[1] == "X" && pos[4] == "X" && pos[7] == "X") // სვეტი
        {
            return true;
        }
        else if (pos[2] == "X" && pos[5] == "X" && pos[8] == "X")
        {
            return true;
        }
        else if (pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}