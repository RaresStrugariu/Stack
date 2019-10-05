using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
   class Program
   {
      static void Main(string[] args)
      {
         Stack<string> Bands = new Stack<string>();
         Bands.Push("Gorgoroth");
         Bands.Push("Sodom");
         Bands.Push("Annihilator");
         Bands.Push("S.O.A.D");
         
         List<string> myList = Bands.ToList();
         foreach (string bands in myList)
         {
            Console.WriteLine(bands);
            if (bands == myList[myList.Count - 1])
            {
               Console.WriteLine($"The last element : {bands}");
            }
         }
      }
   }
}
