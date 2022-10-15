string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2" };
string[] newArray = new string[array.Length];
MethodArray(array);
PrintArray(newArray);

void MethodArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}