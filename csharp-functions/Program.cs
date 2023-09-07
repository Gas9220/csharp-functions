// Initial array
int[] numbers = { 2, 6, 7, 5, 3, 9 };

// Print an array
Console.Write("Numbers array: ");
PrintArray(numbers);

Console.WriteLine();

// Square all values of numbers array and verify the original array is untouched
Console.Write("Squared array: ");
PrintArray(SquareArray(numbers));
Console.Write("Untouched original array: ");
PrintArray(numbers);

Console.WriteLine();

// Print the sum of all numbers
Console.Write("Sum of all array values: ");
Console.WriteLine(SumArrayElements(numbers));
Console.Write("Untouched original array: ");
PrintArray(numbers);

// Functions

// Function to print an array
void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }

    Console.WriteLine("]");

}

// Function to square a number
int Square(int number)
{
    return number * number;
}

// Function to square all values in the array
int[] SquareArray(int[] array)
{
    int[] newArray = (int[])array.Clone();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = Square(newArray[i]);
    }

    return newArray;
}

// Sum all array values
int SumArrayElements(int[] array)
{
    int[] newArray = (int[])array.Clone();

    int sum = 0;

    for (int i = 0; i < newArray.Length; i++)
    {
        sum += newArray[i];
    }

    return sum;
}