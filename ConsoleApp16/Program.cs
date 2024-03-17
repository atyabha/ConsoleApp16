namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {



            
namespace ConsoleApp3
    {
        class program
        {
            static void Main()
            {
                int n;
                Console.WriteLine("The List Of Calculate !!!"); Console.WriteLine("Regantgle ----> 1");
                Console.WriteLine("Circle ----> 2"); n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        int l = 0;
                        int w = 0; Console.WriteLine("Enter the Area OF Regantgle");
                        l = Convert.ToInt16(Console.ReadLine()); w = Convert.ToInt16(Console.ReadLine());
                        int a = l * w; Console.WriteLine(" the Area OF Regantgle" + a);
                        break;
                    case 2:
                        double t;
                        Console.WriteLine("Enter the Area OF Circle"); t = Convert.ToDouble(Console.ReadLine());
                        double ar; ar= (t*t)*3.14;
                        Console.WriteLine(" the Area OF Circle"+ ar);
                        break;
                }
            }
        }
    }
}
    }
}