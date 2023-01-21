using System.Reflection.Metadata.Ecma335;

namespace Task2
{
    public delegate int Operation (int num1, int num2);
     class Program
    {
        public static int Calculate(int a,int b,Operation op)
        {
            int result = op(a, b);
            return result;
        }
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        //public static int Sub(int num1, int num2)
        //{
        //    return num1 - num2;
        //}
        //public static int Multiply(int num1, int num2)
        //{
        //    return num1 * num2;
        //}
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("Enter Number 1 : ");
            a = int.Parse(Console.ReadLine());

            int b = 3;
            Console.WriteLine("Enter Number 2 : ");
            b = int.Parse(Console.ReadLine());

            int TempResult;
            int operation;

            Console.WriteLine("1-Add\n2-Subtract\n3-Multiply\n4-Divide");
            operation=int.Parse(Console.ReadLine());
            switch(operation)
            {
                case 1:
                    
                    TempResult=(Calculate(a, b, Add));                                          // Delegate
                    break;
                case 2:
                    TempResult = (Calculate(a, b, delegate(int num1,int num2) { return num1 - num2; })); //Anonymous Method
                    break;
                case 3:
                    TempResult = (Calculate(a, b, (int num1, int num2) => (num1 * num2)));    //Lambda Expression 
                    break;
                case 4:
                    TempResult = (Calculate(a, b, Divide));
                    break;
                default:
                    TempResult = 0;
                    break;
            }    
            
            Console.WriteLine("Result : {0}",TempResult);
        }
    }
}