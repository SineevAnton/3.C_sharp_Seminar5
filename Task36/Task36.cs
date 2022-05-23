// Task 36.
// Create one-dimension array and find the sum of numbers with odd indexes

Console.WriteLine("Enter the length of array: ");
int arrLen = int.Parse(Console.ReadLine());

// Method 'initArray' creates and return an array with size, equals 'length' (4 by default).
// Array fills with random numbers included in [-10, 10].
// This range is selected to facilitate verification.
int[] initArray(int length = 4)
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
void showArray(int[] arr)
{
    var st = string.Join(", ", arr);
    Console.WriteLine("Your array is:");
    Console.WriteLine("[{0}]", st);
}

// Method 'findEvenCountInArray' finds the count of even numbers in the array passed as an argument
int getSumOfnumsOnOddIndexes(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] array = initArray(arrLen);
showArray(array);
Console.WriteLine($"The sum of numbers with odd indexes is: {getSumOfnumsOnOddIndexes(array)}.");