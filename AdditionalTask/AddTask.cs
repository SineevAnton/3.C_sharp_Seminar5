// This is Task37 from the seminar
// Find the product of pairs of numbers in a one-dimensional array.
// We consider the first and last element as a pair, the second and penultimate,
// etc. Write the result in a new array.

Console.WriteLine("Enter the length of array: ");
int arrLen = int.Parse(Console.ReadLine());

// Method 'initArray' creates and return an array with size, equals 'length' (4 by default).
// Array fills with random numbers included in [-10, 10]
int[] InitArray(int length = 4)
{
    Random rnd = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-10, 11);
    }
    return arr;
}

// Method 'showArray' prints the array passed as an argument to the console 
void ShowArray(int[] arr, string text = "")
{
    var st = string.Join(", ", arr);
    Console.WriteLine(text);
    Console.WriteLine("[{0}]", st);
}

// To make the solution easyer than the same on on seminar
// i had to use 'List' collection, cause 'array' does not support
// any 'Add' method
void GetPairProds(int[] arr)
{
    List<int> result = new List<int>();

    for (int i = 0; i < arr.Length / 2; i++)
    {
        result.Add(arr[i] * arr[arr.Length - 1 - i]);   
    }

    if (arr.Length % 2 != 0) result.Add(arr[arr.Length / 2]);

    ShowArray(result.ToArray(), "Array with pair's prods:");
}

int[] array = InitArray(arrLen);
ShowArray(array, "Initial array is:");

GetPairProds(array);