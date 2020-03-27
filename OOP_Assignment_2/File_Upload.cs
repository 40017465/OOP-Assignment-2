using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_2
{
    class File_Upload
    {
        //This method is used for selected which files are going to be used in the comparrason.
        public static void Files()
        {
            int Answer_File1 = -1;
            int Answer_File2 = -1;

            do
            {
                Console.WriteLine("which file would you like to select first? \n 1) A \n 2) B \n 3) C \n 4) D");
                if (!int.TryParse(Console.ReadLine(), out Answer_File1))
                {
                    Console.Clear();
                    Console.WriteLine("please only enter the number 1, 2, 3 or 4");
                }

                else if (Answer_File1 < 1 || Answer_File1 > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Please only enter 1, 2, 3 or 4");

                }


            } while (Answer_File1 < 1 || Answer_File1 > 4);

            Console.Clear();

            do
            {
                Console.WriteLine("What other file would you like to select? \n 1) A \n 2) B \n 3) C \n 4) D");
                if (!int.TryParse(Console.ReadLine(), out Answer_File2))
                {
                    Console.Clear();
                    Console.WriteLine("please only enter the number 1, 2, 3 or 4");
                }

                else if (Answer_File2 < 1 || Answer_File2 > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Please only enter 1, 2, 3 or 4");

                }

            } while (Answer_File2 < 1 || Answer_File2 > 4);

            Console.Clear();
            File_Comparison.Comparing(Answer_File1, Answer_File2);                    
        }



    }
        
}

