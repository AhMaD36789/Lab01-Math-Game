namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
        }
        static void StartSequence ()
        {

            Console.WriteLine("this is my game, my game is amazing!");
            Console.WriteLine("Please enter a number greater than zero");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            if (arraySize < 1)
            {
                Console.WriteLine("the number you entered is less than or equals zero. \n you have been assigned a default value of 3");
                arraySize = 3;
            }

            int[] array = new int[arraySize];

            array = Populate(array);

            int sum = GetSum(array);

            int product = GetProduct(array, sum);

            int quotient = GetQuotient(product);

            Console.WriteLine($"Your Array size is : {arraySize}");
            Console.Write("The numbers in the array are ");
            for (int i = 0;i < arraySize;i++)
            {
                if (i == arraySize - 1)
                {
                    Console.WriteLine($"{array[i]}");
                    continue;
                }
                Console.Write($"{array[i]},");
            }
            Console.WriteLine($"The sum of the array is {sum}");
            Console.WriteLine($"{sum} * {product/sum} = {product}");
            Console.WriteLine($"{product} / {product/quotient} = {quotient}");
            Console.WriteLine("Program is complete");
        }

        static int [] Populate(int[] array)
        {
            for (int i = 1; i <= array.Length; i++)
            {
                Console.WriteLine($"please enter number {i} : {array.Length}");
                array[i - 1] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i<array.Length; i++)
            {
                sum+= array[i];
            }
            //throw custom exception if the sum is less than 20
            return sum;
        }

        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine($"select a random number from 1 to {array.Length}");
            int product = array[Convert.ToInt32(Console.ReadLine())-1];
            product *= sum;
            //index out of range exception
            return product;
        }

        static int GetQuotient(int product)
        {   
            Console.WriteLine($"Please enter a number to divide your product {product} by");
            int quotient = Convert.ToInt32(Console.ReadLine());
            //divide by zero exception|output the message to the console|don not throw it back to main|return 0 if the catch gets called
            return product/=quotient;
        }

    }
}