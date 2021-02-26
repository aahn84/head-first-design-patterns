using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace app.HeadFirstDesignPatterns.DecoratorPattern
{
    public class InputTest
    {
        public static void Run()
        {
            int input = 0;

            try
            {
                TextReader inputStream = new LowerCaseInputStream(
                    new StreamReader("test.txt")
                );

                while ((input = inputStream.Read()) >= 0)
                {
                    Console.Write((char)input);
                }
                inputStream.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}