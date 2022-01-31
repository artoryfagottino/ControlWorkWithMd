string[] FirstArray = { "MacBook", "777", "_Ж", "просто текст", "GeekBrains", "Bobby", "1&!", "go", "hello man" };
int n = 0;

for (int x = 0; FirstArray.Length > x; x++)
{
    if (FirstArray[x].Length <= 3)
    {
        n = n+1;
    }
}

string[] SecondArray = new string[n];

int i = 0;

for (int x = 0; FirstArray.Length > x; x++)
{
    if (FirstArray[x].Length <= 3)
    {
        SecondArray[i] = FirstArray[x];
        i++;
    }
}

void PrintArray(string[] array)
{
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{array[j]}" + "  ");
    }
    Console.WriteLine();
}
PrintArray(SecondArray);

