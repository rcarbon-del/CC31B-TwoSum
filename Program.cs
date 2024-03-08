namespace TwoSum
{
    internal class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] {i, j};
                    }
                }
            }
            return new int[] {0, 0};
        }   
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter the number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the target: ");
            int target = Convert.ToInt32(Console.ReadLine());
            int[] result = TwoSum(nums, target);
            if (result[0] == 0 && result[1] == 0)
            {
                Console.WriteLine("No result found");
            } else
            {
                Console.Write($"The result is: [{string.Join(", ", result)}]");
            }
        }
    }
}
