using System.Collections.Generic;

namespace Labb_2
{
    internal partial class Program
    {
        class AddItem
        {
            List<string> list = new List<string>();
            public void Add()
            {
                Console.WriteLine("lägg till ny sträng: ");
                string nysträng = Console.ReadLine();
                list.Add(nysträng);
                Console.WriteLine(list.Count);
            }
            
        }
    }
}