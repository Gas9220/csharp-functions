// Initial array
int[] numbers = { 2, 6, 7, 5, 3, 9 };

// Print an array
Console.Write("Numbers array: ");
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