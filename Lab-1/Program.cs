namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //main function includes calls to sub-call and a catch for custom exceptions
            try
            {
                StartSequence();
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program is complete");
            }
        }
        static void StartSequence ()
        {
            // calls for (Populate/GetSum/GetProduct/GetQuotient) functions with details about the current run of the program to the user
            try
            {
                Console.WriteLine("this is my game, my game is amazing!");
                Console.WriteLine("Please enter a number greater than zero");
                int arraySize = Convert.ToInt32(Console.ReadLine());
                if (arraySize < 1)
                {
                    throw new Exception("the number you entered is less than or equals zero.");
                }

                int[] array = new int[arraySize];

                array = Populate(array);

                int sum = GetSum(array);

                int product = GetProduct(array, sum);

                decimal quotient = GetQuotient(product);

                Console.WriteLine($"Your Array size is : {arraySize}");
                Console.Write("The numbers in the array are ");
                for (int i = 0; i < arraySize; i++)
                {
                    if (i == arraySize - 1)
                    {
                        Console.WriteLine($"{array[i]}");
                        continue;
                    }
                    Console.Write($"{array[i]},");
                }
                Console.WriteLine($"The sum of the array is {sum}");
                Console.WriteLine($"{sum} * {product / sum} = {product}");
                Console.WriteLine($"{product} / {product / quotient} = {quotient}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine (ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static int [] Populate(int[] array)
            //fills array with custom input
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
            //gets the sum of the array of numbers that the user entered
            int sum = 0;
            for (int i = 0; i<array.Length; i++)
            {
                sum+= array[i];
            }
            
            if (sum < 20)
            {
                throw new Exception($"the value of {sum} is too low");
            }

            return sum;
        }

        static int GetProduct(int[] array, int sum)
        {
            //multiplies the element that the user selected with the sum of the array
            Console.WriteLine($"select a random number from 1 to {array.Length}");
            int product = Convert.ToInt32(Console.ReadLine());
            if (product < 1 || product>array.Length)
            {
                throw new Exception("out of array range");
            }
            product = array[product - 1];
            product *= sum;
            
            return product;
        }

        static decimal GetQuotient(int product)
        {   
            //divides the value of the GetProduct function with a number of the user choice
            Console.WriteLine($"Please enter a number to divide your product {product} by");
            int quotient = Convert.ToInt32(Console.ReadLine());
            if (quotient == 0)
            {
                throw new Exception("Cant divide by 0");
            }
            return decimal.Divide(product,quotient);
        }

    }
}