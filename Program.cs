namespace Labb_2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            bool show = true;
            while (show)
            {
                Console.WriteLine(" 1.Använd köksapparat\n 2.Lägg till köksapparat\n 3.Lista köksapparater\n 4.Ta bort köksapparat\n 5.Avsluta");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                     Console.WriteLine("Use");
                        break;
                    case 2:
                        Console.WriteLine("lägg till ny sträng: ");
                        string nysträng = Console.ReadLine();
                        list.Add(nysträng);
                        Console.WriteLine(list.Count);
                        break;

                    default:
                        break;
                }
            }
            
        }
    }
}