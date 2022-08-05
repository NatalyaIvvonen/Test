string[] CreateArray(int size)
{
    string[] array = new string[size];

    Console.WriteLine("Creating array here: ");

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return array;
}

void ShowArray(string[] array)
{
    Console.WriteLine("Your array is: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

int FindSizeOfNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] CreateNewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
            
    }
    return newArray;
} 

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(size);

ShowArray(myArray);

int newSize = FindSizeOfNewArray(myArray);
// Console.WriteLine($"A size of new array is {newSize}");

Console.WriteLine();

string[] myArray2 = CreateNewArray(myArray, newSize);
ShowArray(myArray2);