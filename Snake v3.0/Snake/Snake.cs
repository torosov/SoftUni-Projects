using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    struct Position
    {
        //POSSITIONS OF THE SNAKE
        public int Row;
        public int Col;

        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }

    class Snake
    {
        static void PrintM(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void EE()
        {
            string[,] matrix = new string[24, 70];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = " ";
                }
            }
            Console.Clear();
            string somethin = @"
                                  
                                  
                                  
                                  
                                  
       

                           
                   ########   ########   ##       ########
                      ##         ##      ##          ##
                      ##         ##      ##          ##
                      ##         ##      ##          ##    
                      ##      ########   ########    ##                        
                                  
                                  
                                  
                                  
                                  
                  
                ";
            string somethin2 = @"
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  
                                  

                                  
     ##### #  # ##### #   #        ##### #   # ##### #   # ##### #   #
     #   # # #  #      # #         #     ##  # #   # #   # #     #   #
     #   # ##   ##      #          ##    # # # #   # #   # # ### ##### 
     #   # # #  #       #          #     #  ## #   # #   # #   # #   #
     ##### #  # #####   #     #    ##### #   # #####  ###  ##### #   # # # #
                             #     ";
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine(somethin);
                Thread.Sleep(50);
                Console.ForegroundColor=ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine(somethin);
                Thread.Sleep(50);
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine(somethin);
                Thread.Sleep(50);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine(somethin);
                Thread.Sleep(50);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine(somethin);
                Thread.Sleep(50);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine(somethin);
                Thread.Sleep(50);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine(somethin);
                Thread.Sleep(50);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine(somethin);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.Write(somethin2);
            Thread.Sleep(2000);
            // THE SOMETHING
            for (int i = 23; i >= 10; i--)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        matrix[j, k] = " ";
                    }
                }
                matrix[i, 10] = "T";
                matrix[i, 11] = "H";
                matrix[i, 12] = "I";
                matrix[i, 13] = "S";
                matrix[i, 14] = " ";
                matrix[i, 15] = "I";
                matrix[i, 16] = "S";
                matrix[i, 17] = " ";
                matrix[i, 18] = "A";
                matrix[i, 19] = " ";
                matrix[i, 20] = "T";
                matrix[i, 21] = "R";
                matrix[i, 22] = "I";
                matrix[i, 23] = "B";
                matrix[i, 24] = "U";
                matrix[i, 25] = "T";
                matrix[i, 26] = "E";
                if (i < 23)
                {
                    matrix[i+1, 10] = "T";
                    matrix[i+1, 11] = "O";
                    matrix[i+1, 12] = " ";
                    matrix[i+1, 13] = "O";
                    matrix[i+1, 14] = "N";
                    matrix[i+1, 15] = "E";
                    matrix[i+1, 16] = " ";
                    matrix[i+1, 17] = "O";
                    matrix[i+1, 18] = "F";
                    matrix[i+1, 19] = " ";
                    matrix[i+1, 20] = "M";
                    matrix[i+1, 21] = "Y";
                    matrix[i+1, 22] = " ";
                    matrix[i+1, 23] = "F";
                    matrix[i+1, 24] = "A";
                    matrix[i+1, 25] = "V";
                    matrix[i+1, 26] = "O";
                    matrix[i+1, 27] = "U";
                    matrix[i+1, 28] = "R";
                    matrix[i+1, 29] = "I";
                    matrix[i+1, 30] = "T";
                    matrix[i+1, 31] = "E";
                }
                if (i < 22)
                {
                    matrix[i+2, 10] = "C";
                    matrix[i+2, 11] = "H";
                    matrix[i+2, 12] = "I";
                    matrix[i+2, 13] = "L";
                    matrix[i+2, 14] = "D";
                    matrix[i+2, 15] = "H";
                    matrix[i+2, 16] = "O";
                    matrix[i + 2, 17] = "O";
                    matrix[i+2, 18] = "D";
                    matrix[i + 2, 19] = " ";
                    matrix[i + 2, 20] = "V";
                    matrix[i + 2, 21] = "I";
                    matrix[i + 2, 22] = "D";
                    matrix[i + 2, 23] = "E";
                    matrix[i + 2, 24] = "O";
                    matrix[i + 2, 25] = " ";
                    matrix[i + 2, 26] = "G";
                    matrix[i + 2, 27] = "A";
                    matrix[i + 2, 28] = "M";
                    matrix[i + 2, 29] = "E";
                    matrix[i + 2, 30] = "S";
                    matrix[i + 2, 31] = ".";
                    matrix[i + 2, 32] = ".";
                    matrix[i + 2, 33] = ".";
                }
                Thread.Sleep(500);
                Console.Clear();
                PrintM(matrix);
            }
            Console.Clear();
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[j, k] = " ";
                }
            }
            Thread.Sleep(1000);
            string[] ee=new string[]
            {
"          #######",
"         #######",
"        #    #",
"        #    #",
"        #    #",
"         #  #",
"    #####    #####",
"  ###            ###",
" ##  #          #  ##",
"  ##   #          # ##",
"   ## # #########################",
"    ########################",
"       ##########       ###",     
"        ### ##",
"         ### ##",
"          ### ##",
"           ### ##",
"            ### ##",
"           ### ##",
"          ### ##      ###   ###   ###    ### ### #  # ### ###  #",
"         ### ##       # #    #    # #    #   # # ## #  #  # # # #",
"         ### ##       ###    #    ###    #   # # # ##  #  ### ###",
"         #### ###     ##     #    #      #   # # #  #  #  ##  # #",
"         ###### ###   # # # ### # # #    ### ### #  #  #  # # # #"};
            for (int i = 0; i < ee.Length; i++)
            {
                for (int j = 0; j < ee[i].Length; j++)
                {
                    matrix[i, j] = ee[i][j].ToString();
                }
            }
            PrintM(matrix);
            while (!Console.KeyAvailable)
            {
                if (Console.KeyAvailable) break;
                //BUILDING
                Thread.Sleep(500);
                matrix[10, 35] = "*";
                matrix[10, 36] = "*";
                matrix[10, 34] = "*";
                matrix[9, 35] = "*";
                matrix[11, 35] = "*";
                Console.Clear();
                PrintM(matrix);
                Thread.Sleep(500);
                //2
                if (Console.KeyAvailable) break;
                for (int i = 8; i <= 12; i=i+4)
                {
                    matrix[i, 40] = "*";
                    matrix[i, 41] = "*";
                    matrix[i, 39] = "*";
                    matrix[i - 1, 40] = "*";
                    matrix[i + 1, 40] = "*";
                }
                Console.Clear();
                PrintM(matrix);
                Thread.Sleep(500);
                //3
                if (Console.KeyAvailable) break;
                for (int i = 6; i <= 14; i = i + 4)
                {
                    matrix[i, 45] = "*";
                    matrix[i, 46] = "*";
                    matrix[i, 44] = "*";
                    matrix[i - 1, 45] = "*";
                    matrix[i + 1, 45] = "*";
                }
                //clear 1
                matrix[10, 35] = " ";
                matrix[10, 36] = " ";
                matrix[10, 34] = " ";
                matrix[9, 35] = " ";
                matrix[11, 35] = " ";
                Console.Clear();
                PrintM(matrix);
                Thread.Sleep(500);
                //4
                if (Console.KeyAvailable) break;
                for (int i = 4; i <= 16; i = i + 4)
                {
                    matrix[i, 50] = "*";
                    matrix[i, 51] = "*";
                    matrix[i, 49] = "*";
                    matrix[i - 1, 50] = "*";
                    matrix[i + 1, 50] = "*";
                }
                //clear 2
                for (int i = 8; i <= 12; i = i + 4)
                {
                    matrix[i, 40] = " ";
                    matrix[i, 41] = " ";
                    matrix[i, 39] = " ";
                    matrix[i - 1, 40] = " ";
                    matrix[i + 1, 40] = " ";
                }
                Console.Clear();
                PrintM(matrix);
                Thread.Sleep(500);
                //5
                if (Console.KeyAvailable) break;
                for (int i = 2; i <= 18; i = i + 4)
                {
                    if (i == 18)
                    {
                        matrix[i, 55] = "*";
                        matrix[i, 56] = "*";
                        matrix[i, 54] = "*";
                        matrix[i - 1, 55] = "*";
                    }
                    else
                    {
                        matrix[i, 55] = "*";
                        matrix[i, 56] = "*";
                        matrix[i, 54] = "*";
                        matrix[i - 1, 55] = "*";
                        matrix[i + 1, 55] = "*";
                    }
                }
                //clear 3
                for (int i = 6; i <= 14; i = i + 4)
                {
                    matrix[i, 45] = " ";
                    matrix[i, 46] = " ";
                    matrix[i, 44] = " ";
                    matrix[i - 1, 45] = " ";
                    matrix[i + 1, 45] = " ";
                }
                Console.Clear();
                PrintM(matrix);
                Thread.Sleep(500);
                //explosion
                if (Console.KeyAvailable) break;
                for (int i = 2; i <= 18; i = i + 4)
                {
                    if (i == 18)
                    {
                        matrix[i, 55] = " ";
                        matrix[i, 56] = "-";
                        matrix[i, 54] = "-";
                        matrix[i - 1, 55] = "|";
                        matrix[i - 1, 54] = "\\";
                        matrix[i - 1, 56] = "/";
                    }
                    else
                    {
                        matrix[i, 55] = " ";
                        matrix[i, 56] = "-";
                        matrix[i, 54] = "-";
                        matrix[i - 1, 55] = "|";
                        matrix[i - 1, 54] = "\\";
                        matrix[i - 1, 56] = "/";
                        matrix[i + 1, 54] = "/";
                        matrix[i + 1, 55] = "|";
                        matrix[i + 1, 56] = "\\";
                    }
                }
                Console.Clear();
                PrintM(matrix);
                //CLEARING 4
                if (Console.KeyAvailable) break;
                for (int i = 4; i <= 16; i = i + 4)
                {
                    matrix[i, 50] = " ";
                    matrix[i, 51] = " ";
                    matrix[i, 49] = " ";
                    matrix[i - 1, 50] = " ";
                    matrix[i + 1, 50] = " ";
                }
                Console.Clear();
                PrintM(matrix);
                //clearing explosion
                for (int i = 2; i <= 18; i = i + 4)
                {
                    if (i == 18)
                    {
                        matrix[i, 55] = " ";
                        matrix[i, 56] = " ";
                        matrix[i, 54] = " ";
                        matrix[i - 1, 55] = " ";
                        matrix[i - 1, 54] = " ";
                        matrix[i - 1, 56] = " ";
                    }
                    else
                    {
                        matrix[i, 55] = " ";
                        matrix[i, 56] = " ";
                        matrix[i, 54] = " ";
                        matrix[i - 1, 55] = " ";
                        matrix[i - 1, 54] = " ";
                        matrix[i - 1, 56] = " ";
                        matrix[i + 1, 54] = " ";
                        matrix[i + 1, 55] = " ";
                        matrix[i + 1, 56] = " ";
                    }
                }
                Console.Clear();
                PrintM(matrix);
            }
            Console.Clear();
            //...
        }
        static void Intro()
        {
            //SOME ClICHE TEAM COMMERCIAL CREATED BY THE DESIGNER...            
            Console.Clear();
            Console.WriteLine("     ##### ##### #     # ##### ##### ##### ####");
            Console.WriteLine("     #   # #   # #     # #     #   # #     #   #");
            Console.WriteLine("     ##### #   #  # # #  ###   ##### ###   #   #");
            Console.WriteLine("     #     #   #  # # #  #     #  #  #     #   #");
            Console.WriteLine("     #     #####   # #   ##### #   # ##### ####");
            Console.WriteLine();
            Console.WriteLine("                         ####  #    #");
            Console.WriteLine("                         #   #  #  #");
            Console.WriteLine("                         ####    ##");
            Console.WriteLine("                         #   #   ##");
            Console.WriteLine("                         ####    ##      # # #");
            for (int i = 0; i < 1; i++)
            {
                Thread.Sleep(1200);
            }
            Console.Clear();
            Console.WriteLine("                                ###########");
            Console.WriteLine("                              ##           ##");
            Console.WriteLine("   ##### ##### ##### ####   ##          #    ##  #   # #####  ###");
            Console.WriteLine("     #   #   #   #   #   #  ##         #'#   ##  ##  #   #   #   #");
            Console.WriteLine("     #   #####   #   #   #  ##          #    ##  # # #   #   #####");
            Console.WriteLine("     #   #  #    #   #   #  ##               ##  #  ##   #   #   #");
            Console.WriteLine("   ##### #   # ##### ####   ##               ##  #   # ##### #   #");
            Console.WriteLine("                              ##           ##");
            Console.WriteLine("                                ###########");
            for (int i = 0; i < 1; i++)
            {
                Thread.Sleep(1500);
            }
            Console.Clear();
        }
        static void PrintCredits()
        { 
            //THE GUYS THAT CREATED THIS PILE OF ... JUNK CODE
            Console.Clear();
            string credits2 =@"                        
                 #############
                 #  Credits  #
                 #############
                  Developers:
                     -----
                 Team IRIDONIA:
                 Boyan Torosov - Developer/Designing
                 Borislav Kostov - QA Testing/Development
                 Ivaylo Jelev - Designer/Developer
                 Megi Bashlieva - QA Testing/Development
                 #############
                 Special Thanks:
                    Testers:
                     -----



                 And a lot of gratitude to:  
                     -----
                 Our restless minds - came up with all of this
                 Our creative imaginations - intriguing design
                 Youtube - ideas for code
                 Alchohol - happiness ^_^
                                         ";
            Console.WriteLine(credits2);
            Console.Write("Press any key to return to main menu !");
            Console.ReadKey();
        }
        static void PlayGame(int Speed)
        {
            int pointlevel = 4-(Speed/60);
            //THIS IS SOME BULLSHIT
            string deadSnakeimage = @" 
                                       #############                         
                                     ##             ##                   
                                   ##                 ## 
                                 ##   #   #     #   #   ##                  
                                ##     # #       # #     ##              
                                ##      #         #      ##         
                                ##     # #       # #     ##        
                                ##    #   #     #   #    ##            
                                ##                       ##      
                                 ##                     ##           
                                   ##    #########    ##       
                                     ##          ## ##        
                                       ##         ##    ##  
                                         ##     ## ## ##  ##       
                                         ##     ##  ##     ##
                                         ##     ##        #  #
                                                         #    # ";
            int code = 0;
            int ee = 0;
            //THIS IS THE MAIN GAME
            Position[] directions = new Position[]
            {
                new Position(0,1),//right
                new Position(0,-1), //left
                new Position(1,0), //down
                new Position(-1,0) //up
            };
            int direction = 0;
            Random randomNumbersGenerator = new Random();
            Console.BufferHeight = Console.WindowHeight;
            //FOOD <3
            Position food = new Position(randomNumbersGenerator.Next(2, Console.WindowHeight - 2), randomNumbersGenerator.Next(2, Console.WindowWidth - 2));

            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i < 5; i++)
            {
                snakeElements.Enqueue(new Position(1, i));
            }

            foreach (Position position in snakeElements)
            {
                Console.SetCursorPosition(position.Col, position.Row);
                Console.Write('*');
            }

            Console.Clear();
            PrintFrame();//FIELD & ELEMENTS REPRINT

            while (true)
            {
                //GENERAL MOVEMENT
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        if (code == 4 || code == 6) code++;
                        else code = 0;
                        if (direction != 0)direction = 1;
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        if (code == 5 || code == 7) code++;
                        else code = 0;
                        if(direction != 1)direction = 0;
                    }
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        if (code == 0 || code == 1) code++;
                        else code = 0;
                        if(direction != 2)direction = 3;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        if (code == 2 || code == 3) code++;
                        else code = 0;
                        if(direction != 3)direction = 2;
                    }
                    if (userInput.Key == ConsoleKey.B)
                    {
                        if (code == 8) code++;
                        else code = 0;
                    }
                    if (userInput.Key == ConsoleKey.A)
                    {
                        if (code == 9) code++;
                        else code = 0;
                    }
                    if (userInput.Key == ConsoleKey.Enter)
                    {
                        if (code == 10)
                        {
                            code++;
                            ee = 1;
                            Console.Beep(700, 100);
                        }
                        else code = 0;
                    }
                }

                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position snakeNewHead = new Position(snakeHead.Row + nextDirection.Row, snakeHead.Col + nextDirection.Col);

                foreach (Position position in snakeElements)
                {
                    //THIS HAPPENS IF YOU ARE NOOB AND DIE
                    if (position.Col == snakeNewHead.Col && position.Row == snakeNewHead.Row)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("Points: {0}", (snakeElements.Count - 6) * (5*pointlevel));
                        Console.WriteLine();
                        Console.Write(deadSnakeimage);
                        Thread.Sleep(2000);
                        if (Console.KeyAvailable)
                        {
                            while (Console.KeyAvailable)
                            {
                                Console.ReadKey();
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Game Over!");
                            Console.WriteLine("Points: {0}", (snakeElements.Count - 6) * (5*pointlevel));
                            Console.Write("Press any key to return to main menu!");
                            Console.WriteLine();
                            Console.Write(deadSnakeimage);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Game Over!");
                            Console.WriteLine("Points: {0}", (snakeElements.Count - 6) * (5*pointlevel));
                            Console.Write("Press any key to return to main menu!");
                            Console.WriteLine();
                            Console.Write(deadSnakeimage);
                            Console.ReadKey();
                        }
                        if(ee==1)EE();
                        return;
                    }
                }

                snakeElements.Enqueue(snakeNewHead);

                if (snakeNewHead.Row <= 0 || snakeNewHead.Col <= 0 || snakeNewHead.Row >= Console.WindowHeight - 1 ||
                    snakeNewHead.Col >= Console.WindowWidth - 1)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("Points: {0}", (snakeElements.Count - 6) * (5*pointlevel));
                    Console.WriteLine();
                    Console.Write(deadSnakeimage);
                    Thread.Sleep(2000);
                    if (Console.KeyAvailable)
                    {
                        while (Console.KeyAvailable)
                        {
                            Console.ReadKey();
                        }
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("Points: {0}", (snakeElements.Count - 6) * (5*pointlevel));
                        Console.Write("Press any key to return to main menu!");
                        Console.WriteLine();
                        Console.Write(deadSnakeimage);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("Points: {0}", (snakeElements.Count - 6) * (5*pointlevel));
                        Console.Write("Press any key to return to main menu!");
                        Console.WriteLine();
                        Console.Write(deadSnakeimage);
                        Console.ReadKey();
                    }
                    if(ee==1)EE();
                    return;
                }

                if (snakeNewHead.Col == food.Col && snakeNewHead.Row == food.Row)
                {
                    food = new Position(randomNumbersGenerator.Next(1, Console.WindowHeight - 1), randomNumbersGenerator.Next(1, Console.WindowWidth - 1));
                }
                else
                {
                    snakeElements.Dequeue();
                }

                //Console.Clear();

                
                //PrintFrame();//FIELD & ELEMENTS REPRINT
                foreach (Position position in snakeElements)
                {
                    Console.SetCursorPosition(position.Col, position.Row);
                    Console.Write('*');
                }
                Console.SetCursorPosition(snakeNewHead.Col, snakeNewHead.Row);
                Console.Write('@');

                Console.SetCursorPosition(snakeElements.First().Col, snakeElements.First().Row);
                Console.Write(' ');

                Console.SetCursorPosition(food.Col, food.Row);
                Console.Write("*");

                Thread.Sleep(Speed - (snakeElements.Count / 3) * 10);

            }
            Console.ReadLine();
        }

        static void PrintFrame()
        {
            //REPRINT FUNCTION
            Console.SetCursorPosition(1, 0);

            Console.WriteLine(new string('*', Console.WindowWidth - 2));
            Console.SetCursorPosition(0, 1);
            for (int i = 0; i < Console.WindowHeight - 2; i++)
            {
                Console.WriteLine('*');
            }
            Console.Write(' ');
            Console.Write(new string('*', Console.WindowWidth - 2));

            for (int i = 1; i <= Console.WindowHeight - 2; i++)
            {
                if (i == Console.WindowHeight - 2)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 1, i);
                    Console.Write('*');
                }
                else
                {
                    Console.SetCursorPosition(Console.WindowWidth - 1, i);
                    Console.WriteLine('*');
                }

            }

        }
        private static void PrintMenu(string[,] matrix)
        {
            //PRINTING THE MENU
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("                              ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintSecondaryOptionsMenu1(string[,] matrix)
        {
            //THIS IS BULLSHIT
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("          ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                if (i == 1)
                {
                    Console.Write("                  #############");
                }
                else if (i == 2)
                {
                    Console.Write("                  # S P E E D #");
                }
                Console.WriteLine();
            }
        }
        private static void PrintSecondaryOptionsMenu2(string[,] matrix)
        {
            //THIS IS THE SECOND BULLSHIT
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("          ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                if (i == 1)
                {
                    Console.Write("                  #############");
                }
                else if (i == 2)
                {
                    Console.Write("                  # C O L O R #");
                }
                Console.WriteLine();
            }
        }
        private static void PrintOptionsMenu(string[,] matrix,string[,] matrix2,string[,]optionalmatrix1,string[,]optionalmatrix2)
        {
            //PRINTING THE FIRST SECONDARY OPTIONS MENU
            PrintSecondaryOptionsMenu1(optionalmatrix1);
            //PRINTING THE OPTIONS MENU
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("               ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //PRINTING THE SECOND SECONDARY OPTIONS MENU
            PrintSecondaryOptionsMenu2(optionalmatrix2);
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                Console.Write("               ");
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Intro();
            //INITIALISE MENU 
            string[,] menu = new string[16,20];
            //THE BORDERS
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                menu[i, 0] = "#";
                menu[i, 19] = "#";
            }
            for (int i = 0; i < menu.GetLength(1); i++)
            {
                menu[15, i] = "#";
                menu[0, i] = "#";
            }
            //SOME CRAZY MUMBO JUMBO DOWN THERE ... 
            for (int i = 1; i < menu.GetLength(0)-1; i++)
            {
                for (int j = 1; j < menu.GetLength(1)-1; j++)
                {
                    if (i == 2)
                    {
                        menu[i, j] = "#";
                    }
                    else
                    {
                        menu[i, j] = " ";
                    }
                }
            }
            //THE CAPTION
            menu[1, 4] = "S";
            menu[1, 7] = "N";
            menu[1, 10] = "A";
            menu[1, 13] = "K";
            menu[1, 16] = "E";
            //THE CONTENT
            //OPTION 1
            menu[4, 2] = "P";
            menu[4, 4] = "L";
            menu[4, 6] = "A";
            menu[4, 8] = "Y";
            menu[4, 11] = "G";
            menu[4, 13] = "A";
            menu[4, 15] = "M";
            menu[4, 17] = "E";
            //OPTION 2
            menu[7, 3] = "O";
            menu[7, 5] = "P";
            menu[7, 7] = "T";
            menu[7, 9] = "I";
            menu[7, 11] = "O";
            menu[7, 13] = "N";
            menu[7, 15] = "S";
            //OPTION 3
            menu[10, 4] = "C";
            menu[10, 6] = "R";
            menu[10, 8] = "E";
            menu[10, 10] = "D";
            menu[10, 12] = "I";
            menu[10, 14] = "T";
            menu[10, 16] = "S";
            //OPTION 4
            menu[13, 9] = "E";
            menu[13, 11] = "X";
            menu[13, 13] = "I";
            menu[13, 15] = "T";
            //END OF MENU INITIALISATION
            //SAVING THE PRIMAL MENU
            string[,] primalmenu = new string[16, 20];
            for (int i = 0; i < primalmenu.GetLength(0); i++)
            {
                for (int j = 0; j < primalmenu.GetLength(1); j++)
                {
                    primalmenu[i, j] = menu[i, j];
                }
            }
            //...
            //INITIALISING OPTIONS MENU
            string[,] optionsmenu = new string[5,45];
            string[,] optionsmenu2 = new string[5,45];
            int Speed=210;
            int optionalspeed = 1;
            bool endoptionscycle = false;
            //BUILDING THE MENU
            //OH GOD HERE WE GO AGAIN...
            for (int i = 0; i < optionsmenu.GetLength(0); i++)
            {
                optionsmenu[i, 0] = "#";
                optionsmenu[i, optionsmenu.GetLength(1)-1] = "#";
            }
            for (int i = 0; i < optionsmenu.GetLength(1); i++)
            {
                optionsmenu[0, i] = "#";
                optionsmenu[4, i] = "#";
            }
            for (int i = 1; i < optionsmenu.GetLength(0)-1; i++)
            {
                for (int j = 1; j < optionsmenu.GetLength(1)-1; j++)
                {
                    optionsmenu[i, j] = " ";
                }
            }
            //OPTION 1
            optionsmenu[2, 5] = "E";
            optionsmenu[2, 7] = "A";
            optionsmenu[2, 9] = "S";
            optionsmenu[2, 11] = "Y";
            //OPTION 2
            optionsmenu[2, 17] = "M";
            optionsmenu[2, 19] = "E";
            optionsmenu[2, 21] = "D";
            optionsmenu[2, 23] = "I";
            optionsmenu[2, 25] = "U";
            optionsmenu[2, 27] = "M";
            //OPTION 3
            optionsmenu[2, 33] = "H";
            optionsmenu[2, 35] = "A";
            optionsmenu[2, 37] = "R";
            optionsmenu[2, 39] = "D";
            //...
            //STAHP PLZ
            for (int i = 0; i < optionsmenu2.GetLength(0); i++)
            {
                optionsmenu2[i, 0] = "#";
                optionsmenu2[i, optionsmenu2.GetLength(1) - 1] = "#";
            }
            for (int i = 0; i < optionsmenu2.GetLength(1); i++)
            {
                optionsmenu2[0, i] = "#";
                optionsmenu2[4, i] = "#";
            }
            for (int i = 1; i < optionsmenu2.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < optionsmenu2.GetLength(1) - 1; j++)
                {
                    optionsmenu2[i, j] = " ";
                }
            }
            //OPTION 1
            optionsmenu2[2, 4] = "B";
            optionsmenu2[2, 6] = "L";
            optionsmenu2[2, 8] = "A";
            optionsmenu2[2, 10] = "C";
            optionsmenu2[2, 12] = "K";
            //OPTION 2
            optionsmenu2[2, 19] = "B";
            optionsmenu2[2, 21] = "L";
            optionsmenu2[2, 23] = "U";
            optionsmenu2[2, 25] = "E";
            //OPTION 3
            optionsmenu2[2, 31] = "Y";
            optionsmenu2[2, 33] = "E";
            optionsmenu2[2, 35] = "L";
            optionsmenu2[2, 37] = "L";
            optionsmenu2[2, 39] = "O";
            optionsmenu2[2, 41] = "W";
            //...
            //...
            //THE FIRST CAPTIONED(OPTIONS MENU)
            for (int i = 1; i < 15; i++)
            {
                optionsmenu[1, i] = "*";
                optionsmenu[3, i] = "*";
            }
            optionsmenu[2, 1] = "*";
            optionsmenu[2, 14] = "*";
            int previStartPos = 1;//FOR THE STARRED OPTIONS MENU
            int previEndPos = 14;//FOR THE STARRED OPTIONS MENU
            //INITIALISE SECONDARY OPTIONS
            int secondaryOptionchoice = 1;
            int optionColor = 1;
            int secondStartPos = 1;
            int secondEndPos = 14;
            for (int i = 1; i < 15; i++)
            {
                optionsmenu2[1, i] = "*";
                optionsmenu2[3, i] = "*";
            }
            optionsmenu2[2, 1] = "*";
            optionsmenu2[2, 14] = "*";
            //FIRST SECONDARY OPTION
            string[,] secondaryOptions1 = new string[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    secondaryOptions1[i, j] = "*";
                }
            }
            secondaryOptions1[1, 1] = "#";
            //SECOND SECONDARY OPTION
            string[,] secondaryOptions2 = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    secondaryOptions2[i, j] = "*";
                }
            }
            secondaryOptions2[1, 1] = " ";
            //....
            //THE FIRST CAPTIONED(MAIN MENU)
            for (int i = 1; i < menu.GetLength(1) - 1; i++)
            {
                menu[3, i] = "*";
                menu[5, i] = "*";
            }
            menu[4, 1] = "*";
            menu[4, 18] = "*";
            //...
            bool cycle = true;
            ConsoleKeyInfo menuchoice;
            ConsoleKeyInfo optionsChoice;
            int option=1;//THIS IS SOMETHING THATS HARD TO EXPLAIN
            while (cycle)//THIS IS THE MENU CHOICE LOOP
            {
                Console.Clear();
                PrintMenu(menu);
                if (Console.KeyAvailable)
                {
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey();
                    }
                    menuchoice = Console.ReadKey();
                }
                else
                {
                    menuchoice = Console.ReadKey();
                }
                if (menuchoice.Key == ConsoleKey.UpArrow)
                {
                    if (option > 1)
                    {
                        option--;//OPTION CHANGES
                        //THIS RETURNS THE MATRIX TO ITS PRIMAL FORM
                        for (int i = 0; i < menu.GetLength(0); i++)
                        {
                            for (int j = 0; j < menu.GetLength(1); j++)
                            {
                                menu[i, j] = primalmenu[i, j];
                            }
                        }
                        //AND HERE'S THE BUILDING ITSELF
                        for (int i = 1; i < menu.GetLength(1) - 1; i++)
                        {
                            menu[(option*3), i] = "*";
                            menu[((option*3)+2), i] = "*";
                        }
                        menu[((option * 3) + 1), 1] = "*";
                        menu[((option * 3) + 1), 18] = "*";
                        Console.Clear();
                        PrintMenu(menu);
                    }
                }
                if (menuchoice.Key == ConsoleKey.DownArrow)
                {
                    if (option < 4)
                    {
                        option++;//OPTION CHANGES
                        //THIS RETURNS THE MATRIX TO ITS PRIMAL FORM
                        for (int i = 0; i < menu.GetLength(0); i++)
                        {
                            for (int j = 0; j < menu.GetLength(1); j++)
                            {
                                menu[i, j] = primalmenu[i, j];
                            }
                        }
                        //AND HERE'S THE BUILDING ITSELF
                        for (int i = 1; i < menu.GetLength(1) - 1; i++)
                        {
                            menu[(option * 3), i] = "*";
                            menu[((option * 3) + 2), i] = "*";
                        }
                        menu[((option * 3) + 1), 1] = "*";
                        menu[((option * 3) + 1), 18] = "*";
                        Console.Clear();
                        PrintMenu(menu);
                    }
                }
                if (menuchoice.Key == ConsoleKey.Enter)
                {
                    //CHECK THE CHOICE
                    switch (option)
                    {
                        case 1:
                            //PLAY GAME
                            Speed = (4-optionalspeed)*60;

                            PlayGame(Speed);
                            break;
                        case 2:
                            //OPTIONS MENU
                            while (!endoptionscycle)
                            {
                                Console.Clear();
                                PrintOptionsMenu(optionsmenu,optionsmenu2,secondaryOptions1,secondaryOptions2);
                                optionsChoice = Console.ReadKey();
                                if (optionsChoice.Key == ConsoleKey.RightArrow)
                                {
                                    if (secondaryOptionchoice == 1)
                                    {
                                        if (optionalspeed < 3)
                                        {
                                            //SOME MUMBO JUMBO AGAIN
                                            for (int i = previStartPos; i <= previEndPos; i++)
                                            {
                                                optionsmenu[1, i] = " ";
                                                optionsmenu[3, i] = " ";
                                            }
                                            optionsmenu[2, previStartPos] = " ";
                                            optionsmenu[2, previEndPos] = " ";
                                            optionalspeed++;
                                            previStartPos = previEndPos + 1;
                                            if (previEndPos == 14)
                                            {
                                                previEndPos += 15;
                                            }
                                            else
                                            {
                                                previEndPos += 14;
                                            }
                                            for (int i = previStartPos; i <= previEndPos; i++)
                                            {
                                                optionsmenu[1, i] = "*";
                                                optionsmenu[3, i] = "*";
                                            }
                                            optionsmenu[2, previStartPos] = "*";
                                            optionsmenu[2, previEndPos] = "*";
                                            Console.Clear();
                                            PrintOptionsMenu(optionsmenu, optionsmenu2, secondaryOptions1,
                                                secondaryOptions2);
                                        }
                                    }
                                    else//SECONDARY OPTIONS
                                    {
                                        if (optionColor < 3)
                                        {
                                            //GOD HELP ME PLEASE 
                                            optionColor++;
                                            switch (optionColor)
                                            {
                                                case 1:
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    break;
                                                case 2:
                                                    Console.BackgroundColor = ConsoleColor.Blue;
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    break;
                                                case 3:
                                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    break;
                                            }
                                            for (int i = secondStartPos; i <= secondEndPos; i++)
                                            {
                                                optionsmenu2[1, i] = " ";
                                                optionsmenu2[3, i] = " ";
                                            }
                                            optionsmenu2[2, secondStartPos] = " ";
                                            optionsmenu2[2, secondEndPos] = " ";
                                            secondStartPos = secondEndPos + 1;
                                            if (secondEndPos == 14)
                                            {
                                                secondEndPos += 15;
                                            }
                                            else
                                            {
                                                secondEndPos += 14;
                                            }
                                            for (int i = secondStartPos; i <= secondEndPos; i++)
                                            {
                                                optionsmenu2[1, i] = "*";
                                                optionsmenu2[3, i] = "*";
                                            }
                                            optionsmenu2[2, secondStartPos] = "*";
                                            optionsmenu2[2, secondEndPos] = "*";
                                            Console.Clear();
                                            PrintOptionsMenu(optionsmenu, optionsmenu2, secondaryOptions1,
                                                secondaryOptions2);
                                        }      
                                    }
                                }
                                if (optionsChoice.Key == ConsoleKey.LeftArrow)
                                {
                                    if (secondaryOptionchoice == 1)
                                    {
                                        if (optionalspeed > 1)
                                        {
                                            //THIS IS GETTING BOORING ... I SHOULD PROBABLY STOP ...
                                            for (int i = previStartPos; i <= previEndPos; i++)
                                            {
                                                optionsmenu[1, i] = " ";
                                                optionsmenu[3, i] = " ";
                                            }
                                            optionsmenu[2, previStartPos] = " ";
                                            optionsmenu[2, previEndPos] = " ";
                                            optionalspeed--;
                                            if (previStartPos == 15)
                                            {
                                                previStartPos -= 14;
                                            }
                                            else
                                            {
                                                previStartPos -= 15;
                                            }
                                            if (previEndPos == 29)
                                            {
                                                previEndPos -= 15;
                                            }
                                            else
                                            {
                                                previEndPos -= 14;
                                            }
                                            for (int i = previStartPos; i <= previEndPos; i++)
                                            {
                                                optionsmenu[1, i] = "*";
                                                optionsmenu[3, i] = "*";
                                            }
                                            optionsmenu[2, previStartPos] = "*";
                                            optionsmenu[2, previEndPos] = "*";
                                            Console.Clear();
                                            PrintOptionsMenu(optionsmenu, optionsmenu2, secondaryOptions1,
                                                secondaryOptions2);
                                        }
                                    }
                                    else//SECONDARY OPTIONS
                                    {
                                        if (optionColor > 1)
                                        {
                                            //STAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHPPPP ...
                                            for (int i = secondStartPos; i <= secondEndPos; i++)
                                            {
                                                optionsmenu2[1, i] = " ";
                                                optionsmenu2[3, i] = " ";
                                            }
                                            optionsmenu2[2, secondStartPos] = " ";
                                            optionsmenu2[2, secondEndPos] = " ";
                                            optionColor--;
                                            switch (optionColor)
                                            {
                                                case 1:
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    break;
                                                case 2:
                                                    Console.BackgroundColor = ConsoleColor.Blue;
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    break;
                                                case 3:
                                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    break;
                                            }
                                            if (secondStartPos == 15)
                                            {
                                                secondStartPos -= 14;
                                            }
                                            else
                                            {
                                                secondStartPos -= 15;
                                            }
                                            if (secondEndPos == 29)
                                            {
                                                secondEndPos -= 15;
                                            }
                                            else
                                            {
                                                secondEndPos -= 14;
                                            }
                                            for (int i = secondStartPos; i <= secondEndPos; i++)
                                            {
                                                optionsmenu2[1, i] = "*";
                                                optionsmenu2[3, i] = "*";
                                            }
                                            optionsmenu2[2, secondStartPos] = "*";
                                            optionsmenu2[2, secondEndPos] = "*";
                                            Console.Clear();
                                            PrintOptionsMenu(optionsmenu, optionsmenu2, secondaryOptions1,
                                                secondaryOptions2);
                                        }
                                    }
                                }
                                if (optionsChoice.Key == ConsoleKey.UpArrow)
                                {
                                    if (secondaryOptionchoice > 1)
                                    {
                                        secondaryOptionchoice--;
                                        secondaryOptions1[1, 1] = "#";
                                        secondaryOptions2[1, 1] = " ";
                                    }
                                }
                                if (optionsChoice.Key == ConsoleKey.DownArrow)
                                {
                                    if (secondaryOptionchoice < 2)
                                    {
                                        secondaryOptionchoice++;
                                        secondaryOptions2[1, 1] = "#";
                                        secondaryOptions1[1, 1] = " ";
                                    }
                                }
                                if (optionsChoice.Key == ConsoleKey.Enter)
                                {
                                    //EEH ... THIS IS THE CHOICE OF SPEED
                                    Speed = (4-optionalspeed) * 60;
                                    endoptionscycle = true;
                                    //AND COLOR

                                }
                            }
                            endoptionscycle = false;
                            break;
                            //END OF OPTIONS MENU ...
                        case 3:
                            //THE CREDITS
                            PrintCredits();
                            break;
                            //BY THE WAY THE CRAZY-ASS DESIGNER THAT CREATED THIS CRAZY-ASS MENU
                            //IS ACTUALLY THE ONE WRITTING THESE COMMENTS BECAUSE HE IS CLEARLY THE ONLY ONE
                            //THAT COULD ACTUALLY NAVIGATE IN THIS ... THING ...
                            //ITS FUNNY BECAUSE THE CODE OF THE MENU IS ... AAA WHATEVER IM SHUTTING UP ...
                        case 4:
                            //END OF GAME FINAALLLYYYYYYY ... END OF TORMENT ... PEACE TO MY SOUL AND MIND ... 
                            //AND TO YOUR EYES ...
                            cycle = false;
                            break;
                    }
                }
            }
        }
    }
}
//^ THEM CURVES ;)