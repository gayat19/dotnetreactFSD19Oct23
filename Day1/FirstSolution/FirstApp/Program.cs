namespace FirstApp
{
    internal class Program
    {
        static void CheckNumberStatus()//Method header
        {//body
            int num1;
            //Console.WriteLine("Please enter a number");
            //num1 = Convert.ToInt32(Console.ReadLine());
            num1 =GetARandomNumber();
            if (num1 > 100)
                Console.WriteLine("Too big. The numebr is "+num1);
            else
                Console.WriteLine($"The number {num1} is Okay");
        }
        static int GetARandomNumber()
        {
            int num1 = new Random().Next(1,200);
            return num1;
        }
        static void AddTwoNumbers()
        {
            int number1, number2;
            number1 = GetARandomNumber();
            number2 = GetARandomNumber();
            int sum = number1 + number2;
            Console.WriteLine($"The sum of {number1} and {number2} is {sum}");
        }
        static void Main(string[] args)
        {
            CheckNumberStatus();//method invocation
            AddTwoNumbers();

        }
    }
}