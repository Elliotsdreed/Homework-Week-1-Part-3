using System;

namespace Homework_Week_1_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello passenger, How long is your flight expected to take?");
            Console.WriteLine("120 minutes" + Environment.NewLine + "240 Minutes" + Environment.NewLine + "360 Minutes");
          
          char selectedOption = Console.ReadKey().KeyChar;

          switch(selectedOption)
          {
              case '1':
              Threehours();
              break;
              case '2':
              Fourhours();
              break;
              case '3':
              Fivehours();
              break;
          
          }       
        }
         public static void Threehours()
          {
              Console.Clear();
             Console.WriteLine("Hey guys");
          }
          public static void Fourhours()
          {
             Console.Clear();
             Console.WriteLine("Hey guys");
          }
          public static void Fivehours()
          {
             Console.Clear();
             Console.WriteLine("Hey guys");
          }
    }
}
