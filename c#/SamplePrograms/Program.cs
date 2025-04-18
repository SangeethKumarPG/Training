internal class Program
{

    public static void checkOddOrEven()
    {
        Console.WriteLine("Enter the number");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine("Number is 0");
        }
        else if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    }

    public static void compareTwoNumbers()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Enter the first number : ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second numbers : ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        if (firstNumber == secondNumber)
        {
            Console.WriteLine("Both numbers are equal");
        }
        else
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First number is largest");
            }
            else
            {
                Console.WriteLine("Second number is largest");
            }
        }
    }

    private static void numbeSeriesDoWhile()
    {
        int n = 0;
        do
        {
            Console.WriteLine(n);
            n++;
        } while (n < 10);
    }

    private static void forLoopNumberSeries()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }


    private static void sumOfTenRandomNumbers()
    {
        int sum = 0;
        Console.WriteLine("Enter the numbers");
        for (int i = 0; i < 10; i++)
        {
            sum += Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Sum is : {sum}");
    }

    private static void oddAndEvenAmongRandomNumbers()
    {
        int odd = 0;
        int even = 0;
        Console.WriteLine("Enter the numbers");
        for (int i = 0; i < 10; i++)
        {
            if (Convert.ToInt32(Console.ReadLine()) % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }
        Console.WriteLine("Odd : " + odd);
        Console.WriteLine("Even : " + even);
    }

    private static void Main(string[] args)
    {
        // Compairing two numbers
        //compareTwoNumbers();

        // Check odd or even
        //checkOddOrEven();

        // do while number series
        //numbeSeriesDoWhile();

        // for loop number series
        //forLoopNumberSeries();

        // sum of 10 random numbers
        //sumOfTenRandomNumbers();

        // odd and even among 10 random numbers
        oddAndEvenAmongRandomNumbers();

    }
}