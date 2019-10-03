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
              threehours();
              break;
              case '2':
              fourhours();
              break;
              case '3':
              fivehours();
              break;
          
          }       
        }
         public void threehours()
          {
              Console.Clear();
             Console.WriteLine("Hey guys");
          }
          public void fourhours()
          {
             Console.Clear();
             Console.WriteLine("Hey guys");
          }
          public void fivehours()
          {
             Console.Clear();
             Console.WriteLine("Hey guys");
          }
    }
}
