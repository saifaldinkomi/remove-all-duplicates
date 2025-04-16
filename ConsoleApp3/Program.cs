using System.Diagnostics.Metrics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter text: ");
            string input=Console.ReadLine();
            string output = "";
            foreach (var item in input)
            {           
                int counter = 0;
                    if(string.IsNullOrEmpty(output))    
                 output += item;
                foreach (var item1 in output)
                {
                    if (item1 == item)
                        counter++;
                }
                if (counter == 0)
                    output += item;
            }
            Console.WriteLine("after falter: "+output);
            
        }
    }
}
