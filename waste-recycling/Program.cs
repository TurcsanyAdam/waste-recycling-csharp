using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PaperGarbage paperbox = new PaperGarbage("paperbox", false);
            Dustbin redDustBin = new Dustbin("Red");
            Console.WriteLine(redDustBin.Color);
            Console.ReadLine();
           
        }
    }
}
