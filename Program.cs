class Program{
    public static void Main(string[] args){
    //     // C# program that removes duplicates from an array and sorts the remaining elements in ascending order
    //     int[] array = { 4, 5, 2, 3, 2, 4, 1, 5, 3 };
    //     //Remove Duplicate and sort
    //     int[] result = array.Distinct().OrderBy(x => x).ToArray();
    //      // Print the result
    //     Console.WriteLine("Array after removing duplicates and sorting:");
    //     foreach (int number in result)
    //     {
    //         Console.Write(number + " ");
    //     }

    // take the input from the StdIn and then do the above logic
       Console.WriteLine("Enter number by space separated");
      string input= Console.ReadLine();
      //split the input line into an array of strings
      string[] inputArray= input.Split(' ');
      //Convert string array to int array
      int[] array = Array.ConvertAll(inputArray,int.Parse);
      int[] result = array.Distinct().OrderBy(x => x).ToArray();
        // Print the result
        Console.WriteLine("Array after removing duplicates and sorting:");
        foreach (int number in result)
        {
            Console.Write(number + " ");
        }
    }
}