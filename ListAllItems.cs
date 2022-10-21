namespace Labb_2
{
    internal partial class Program
    {
        
        public class ListAllItems
        {
            List<string> list = new List<string>();
            public void ListAll()
            {
                foreach(var item in list)
                {
                    list.Add("bajs");
                    Console.WriteLine(item);
                }
            }
        }
    }
}