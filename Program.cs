namespace Week6Assignment6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            Console.WriteLine("Part 1");
            TaskStack newTask = new TaskStack(5);
            newTask.Push("Press login");
            newTask.Push("Enter password");
            newTask.Push("Enter username");
            newTask.Push("Open application");

            Console.WriteLine("Uncompleted Steps: ");
            newTask.Display();

            Console.Write($"\nCompleting: " + newTask.Pop());
            Console.Write($"\nCompleting: " + newTask.Pop());

            Console.WriteLine("\nUncompleted Steps: ");
            newTask.Display();
            #endregion

            Console.WriteLine("Part 2");
            int[] numsArray1 = { 1, 2, 3, 4 };
            int[] numsArray2 = { -1, 1, 0, -3, 3 };
            int[] productArray;
            productArray = ProductExceptSelf(numsArray1);
            Console.WriteLine($"Product of values in array: [{string.Join(",", numsArray1)}]");
            Console.WriteLine($"[{string.Join(",", productArray)}]");

            productArray = ProductExceptSelf(numsArray2);
            Console.WriteLine($"\nProduct of values in array: [{string.Join(",", numsArray2)}]");
            Console.WriteLine($"[{string.Join(",", productArray)}]");


        }
        static int[] ProductExceptSelf(int[] array)
        {
            int[] answer = new int[array.Length];
            int prefix = 1, suffix = 1;
            for (int i = 0;i < array.Length;i++)
            {
                answer[i] = prefix;
                prefix *= array[i];
            }
            for (int i = array.Length -1; i >= 0; i--)
            {
                answer[i] *= suffix;
                suffix *= array[i];
            }
            return answer;
        }
    }
}
