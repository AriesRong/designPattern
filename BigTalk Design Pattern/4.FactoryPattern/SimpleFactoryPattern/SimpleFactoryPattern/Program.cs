using System;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input numberA:");
            double numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input numberB:");
            double numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input algorithm:");
            string algorithm = Console.ReadLine();

            Operation operation;
            
            SimpleFactory sf=new SimpleFactory();
            operation = sf.createOperation(algorithm);
            double result=0d;
            if (operation != null)
            {
                result = operation.getResult(numA, numB);
            }
            else
            {
                Console.WriteLine("WRONG MESSAGE INPUT!");
            }
            

            Console.WriteLine("Result:{0}", result);
            Console.Read();
        }
    }
}
