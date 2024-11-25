internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter numbers: ");
        string InitialInput = Console.ReadLine();
        string[] InputStringArray = InitialInput.Split(' ');
        int[] IntArr = Array.ConvertAll(InputStringArray, int.Parse);

        for (int i = 1; i < IntArr.Length; i++)
        {
            int key = IntArr[i];
            int j = i - 1;

            while (j >= 0 && IntArr[j] > key)
            {
                IntArr[j + 1] = IntArr[j];
                j = j - 1;
            }
            IntArr[j + 1] = key;
        }

        foreach (int num in IntArr)
        {
            Console.Write($"{num} ");
        }
    }
}
