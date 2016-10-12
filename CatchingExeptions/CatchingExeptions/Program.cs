using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Computer c = new Computer("ASUS", 79f);
            try
            {
                c.incTemp();                
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }finally
            {
                try
                {
                    i = int.Parse(Console.ReadLine());
                }catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    i = 0;
                }catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    i = 1;
                }catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    i = int.MaxValue;
                }finally
                {
                    Console.WriteLine(i);
                }
            }
            //for (int i = 0; i < 15; i++)
            //{
            //    string s = Console.ReadLine();
            //    if (s == "STOP") break;
            //    try
            //    {
            //        c.incTemp();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //        Console.WriteLine("Help is here: {0}", e.HelpLink);
            //        Console.WriteLine(e.TargetSite);
            //        Console.WriteLine(e.StackTrace);
            //        Console.WriteLine(e.Source);
            //    }
            //}
        }
        
    }
}
