using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUILib;

namespace Console_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Debug.WriteLine("Start");
                var cPage = new ConsolePage {PageTitle = "Test"};
                cPage.Initialize(0,0);
                cPage.Draw();
                Debug.WriteLine("End");
            }
            catch (Exception ex)
            {
                Debug.Print("[Error] {0}", ex.Message);
                Console.Write("[Error] " + ex.Message);
                if (ex.InnerException != null)
                {
                    Debug.Print("       =====> {0}", ex.InnerException.Message);
                    Console.WriteLine("...");
                }
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
