using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BubbleSort");
            Console.WriteLine("==========");

            Console.WriteLine("Enter the lenght of your numbers list please:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] list = new int[len];
            string input;

            for(int i = 0; i < len; i++)
            {
                Console.WriteLine(string.Format("Enter the {0} index number of the list: ",i));
                input = Console.ReadLine();
                list[i] = Convert.ToInt32(input);                                  
            }

            Console.WriteLine("Results");
            Console.WriteLine("=======");

            int[] OrderedList = order(list);

            foreach (var item in OrderedList)
                Console.WriteLine(item.ToString());
                        
            Console.ReadLine();
        }

        private static int[] order(int[] List)
        {
            int temp;
            for (int i = List.Length; i > 0; i--)
            {                
                for (int j = 0; j < i-1; j++)
                {
                    
                    if (List[j] > List[j + 1])
                    {
                        temp = List[j+1];
                        List[j + 1] = List[j];
                        List[j] = temp;
                    }                        
                }
            }
            return List;
        }
    }
}
