namespace Labb_2
{
    internal partial class Program
    {
        
        static void Main(string[] args)
        {
            AddItem a = new AddItem();
            ListAllItems Lai = new ListAllItems();

            List<string> list = new List<string>();
            bool show = true;
            while (show)
            {
                Console.WriteLine(" 1.Använd köksapparat\n 2.Lägg till köksapparat\n 3.Lista köksapparater\n 4.Ta bort köksapparat\n 5.Avsluta");
                int input = Convert.ToInt32(Console.ReadLine());
                //switch (input)
                //{
                //    case 1:
                //     Console.WriteLine("Use");
                //        break;
                //    case 2:
                //        a.Add();
                //        break;
                //    case 3:
                //        Lai.ListAll();
                //        break;

                //    default:
                //        break;
                //}

                if (input == 1)
                {
                    Console.WriteLine("Use");
                } else if(input == 2)
                {
                Console.WriteLine("lägg till ny sträng: ");
                string nysträng = Console.ReadLine();
                list.Add(nysträng);
                Console.WriteLine(list.Count);
            }
                else if (input == 3)
                {
                    Console.WriteLine("Alla köksapparater: ");
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.ToString());
                        Console.ReadKey();
                    }
                    
                }
                
            }
            
        }
    }
}