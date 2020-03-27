using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_2
{
    class File_Comparison
    {
        //This method is used for the actual comparrason of the selected files.
        public static void Comparing (int Answer_File1, int Answer_File2)
        {
            byte[] Array1 = System.IO.File.ReadAllBytes("..\\a.txt");
            byte[] Array2 = System.IO.File.ReadAllBytes("..\\b.txt");
            byte[] Array3 = System.IO.File.ReadAllBytes("..\\c.txt");
            byte[] Array4 = System.IO.File.ReadAllBytes("..\\d.txt");
            int Answer_Restart_Exit = -1;
            if ((Answer_File1 == 1 & Answer_File2 == 2) || (Answer_File1 == 2 & Answer_File2 == 1))
            {
                if (Array1.Length == Array2.Length)
                {
                    Console.WriteLine("These files are the same!\n");
                }

                else
                {
                    Console.WriteLine("These files are not the same!\n");
                }
            }

            else if ((Answer_File1 == 1 & Answer_File2 == 3) || (Answer_File1 == 3 & Answer_File2 == 1))
            {
                if (Array1.Length == Array3.Length)
                {
                    Console.WriteLine("These files are the same!\n");
                }

                else
                {
                    Console.WriteLine("These files are not the same!\n");
                }
            }

            else if ((Answer_File1 == 1 & Answer_File2 == 4) || (Answer_File1 == 4 & Answer_File2 == 1))
            {
                if (Array1.Length == Array4.Length)
                {
                    Console.WriteLine("These files are the same!\n");
                }

                else
                {
                    Console.WriteLine("These files are not the same!\n");
                }
            }

            else if ((Answer_File1 == 2 & Answer_File2 == 3) || (Answer_File1 == 3 & Answer_File2 == 2))
            {
                if (Array2.Length == Array3.Length)
                {
                    Console.WriteLine("These files are the same!\n");
                }

                else
                {
                    Console.WriteLine("These files are not the same!\n");
                }
            }

            else if ((Answer_File1 == 2 & Answer_File2 == 4) || (Answer_File1 == 4 & Answer_File2 == 2))
            {
                if (Array2.Length == Array4.Length)
                {
                    Console.WriteLine("These files are the same!\n");
                }

                else
                {
                    Console.WriteLine("These files are not the same!\n");
                }
            }

            else if ((Answer_File1 == 3 & Answer_File2 == 4) || (Answer_File1 == 4 & Answer_File2 == 3))
            {
                if (Array3.Length == Array4.Length)
                {
                    Console.WriteLine("These files are the same!\n");
                }

                else
                {
                    Console.WriteLine("These files are not the same!\n");
                }
            }

            else if ((Answer_File1 == 1 & Answer_File1 == 1) || (Answer_File1 == 2 & Answer_File2 == 2) || (Answer_File1 == 3 & Answer_File2 == 3) || (Answer_File1 == 4 & Answer_File2 == 4))
            {
                Console.WriteLine("Wow, really? What do you think the answer is going to be?\nObviously the files are the same....\n");
            }

            do
            {
                Console.WriteLine("Would you like to\n1) Start again\n2) Exit");
                if (!int.TryParse(Console.ReadLine(), out Answer_Restart_Exit))
                {
                    Console.WriteLine("please only enter the number 1 or 2");
                }

                else if (Answer_Restart_Exit < 1 || Answer_Restart_Exit > 2)
                {
                    Console.WriteLine("Please only enter 1 or 2");
                    Answer_Restart_Exit = -1;

                }

            } while (Answer_Restart_Exit < 1 || Answer_Restart_Exit > 2);

            if (Answer_Restart_Exit == 1)
            {
                Console.Clear();
                File_Upload.Files();
            }
            else
            {
                Console.Clear();
                Environment.Exit(0);
            }
        }
            
    }
}

