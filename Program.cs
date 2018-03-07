using System;

namespace InterviewQ3
{
    class Program
    {
       static void Main(string[] args)
        {
           int height, space;
           	Console.Write("\n\n\n");
            Console.Write("Display a pyramid in console.\n\n\n");
            Console.Write("Input number of rows: ");

            height = Convert.ToInt32(Console.ReadLine());
            space = height;
            
            for (var i=1; i<=height; i++)
            {

                        for (var j=space; j>=1; j--) 
                        {
                            Console.Write(" ");
                        }
                        for (var k=1; k<=i; k++) 
                        {
                            Console.Write("* ");
                        }
            
                Console.Write("\n");
                space--;
            }

        }
    }
}


//This will clear up the confusion:
//                          Your first for-loop: Creates the number of rows, and the 2 loops it CONTAINS are printing 
        //                  their respective number of spaces or characters (spaces here are j, characters k).
        //                  So for each line, these 2 inside loops tell how many times to print the symbols.