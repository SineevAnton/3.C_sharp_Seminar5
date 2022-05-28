// Task34.
// Create an array, filled with random positive three-digits numbers.
// Write a programm to count how many numbers in created array are even.


Console.WriteLine("Enter the length of array: ");
int arrLen = int.Parse(Console.ReadLine());

// Method 'initArray' creates and return an array with size, equals 'length' (4 by default).
// Array fills with random numbers included in [100, 999]
int[] InitArray(int length = 4)
{
    Random rnd = new Random();
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

// Method 'showArray' prints the array passed as an argument to the console 
void ShowArray(int[] arr)
{
    var st = string.Join(", ", arr);
    Console.WriteLine("Your array is:");
    Console.WriteLine("[{0}]", st);
}

// Method 'findEvenCountInArray' finds the count of even numbers in the array passed as an argument
int FindEvenCountInArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count += 1;
    }
    return count;
}

int[] array = InitArray(arrLen);
ShowArray(array);
Console.WriteLine($"The number of even elements is: {FindEvenCountInArray(array)}.");