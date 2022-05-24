// Task 38.
// Specify an array of real numbers. Find
// the difference between the maximum and minimum
// array elements.

Console.WriteLine("Enter the length of array: ");
int arrLen = int.Parse(Console.ReadLine());

// Method 'initArray' creates and return an array with size, equals 'length' (4 by default).
// Array fills with random real numbers.
double[] initArray(int length = 4)
{
    Random rnd = new Random();
    double[] arr = new double[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-100, 100) + rnd.NextDouble();
    }
    return arr;
}

// Method 'showArray' prints the array passed as an argument to the console 
void showArray(double[] arr)
{
    string st = new String("");
    for (int i = 0; i < arr.Length; i++)
    {
        st += string.Format("{0:f2}", arr[i]) + " ";
    }
    Console.WriteLine("Your array is:");
    Console.WriteLine("[{0}]", st.Trim());
}

// Method to find the minimum number of the array passed as an argument
double getMinFromArray(double[] arr)
{
    double minVal = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minVal) minVal = arr[i]; 
    }
    return minVal;
}

// Method to find the maximum number of the array passed as an argument
double getMaxFromArray(double[] arr)
{
    double maxVal = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxVal) maxVal = arr[i]; 
    }
    return maxVal;
}

double[] array = initArray(arrLen);
showArray(array);
Console.WriteLine("Minimum of the array is: {0:f2}", getMinFromArray(array));
Console.WriteLine("Maximum of the array is: {0:f2}", getMaxFromArray(array));
Console.WriteLine("Difference between minimum and maximum of the array is:  {0:f2}", getMaxFromArray(array) - getMinFromArray(array));
