namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Daxil edilən 3 ədədin pifaqor ədədləri olub olmadığını yoxla(3 4 5 daxil edilibse 3 ^ 2 + 4 ^ 2 = 5 ^ 2 çap olunsun)
           

            while (true)
            {   Console.WriteLine("3 eded daxil edin:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                if (a * a + b * b == c * c) Console.WriteLine($"{a}^2 + {b}^2 = {c}^2");
                else if (a * a + c * c == b * b) Console.WriteLine($"{a}^2 + {c}^2 = {b}^2");
                else if (b * b + c * c == a * a) Console.WriteLine($"{b}^2 + {c}^2 = {a}^2");
                else Console.WriteLine("Bu ededler pifaqor teoremine uymur");
            }

            
        }
    }
}