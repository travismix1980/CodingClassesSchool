namespace lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.MaxValue;
            List<int> numList = new List<int>();
            while (num != 0) {
                Console.Write("Please Enter a list of numbers or Enter 0 to finish: ");
                num = Int32.Parse(Console.ReadLine());
                if (num != 0)
                {
                    numList.Add(num);
                }
            }

            // output sum of numList
            Console.WriteLine($"The sum of all the numbers in our list is {numList.Sum()}");

            // output average of numList
            Console.WriteLine($"The average of the numbers in the list is {numList.Average()}");

            // output the max of numList
            Console.WriteLine($"The max number in the list is {numList.Max()}");

            // get smallest positive number in numList will output 0 if there is no positive numbers in list
            int minPositive = numList.Where(x => x > 0 ).DefaultIfEmpty(0).Min();
            Console.WriteLine($"The smallest positive number in the list is {minPositive}.");

            // sort and display the new sorted numList
            numList.Sort();
            Console.WriteLine("Here is the list but sorted from smallest to largest");
            foreach(int n in numList.SkipLast(1))
            {
                Console.Write($"{n}, ");
            }
            // output last number in list
            Console.WriteLine($"{numList.Last()}");
        }
    }
}
