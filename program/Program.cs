// Программа, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа

void TestArray (string [] massiv, int lengthMax)
{
    int n = NewArrayLength (massiv, lengthMax);
    if (n == 0) 
    {
        PrintArray (massiv);
        Console.Write (" -> []");
    }
    else
    {
        string [] arrayNew = FillNewArray (massiv, lengthMax, n);
        PrintArray (massiv);
        Console.Write (" -> ");
        PrintArray (arrayNew);
    }
}

int NewArrayLength (string [] array1, int lengthMax)
{
    int n = 0;
    for (int i = 0; i < array1.Length; i++)
        if (array1[i].Length <= lengthMax) n++;
    return n;
}

void PrintArray (string [] massiv)
{
    Console.Write("[");
    for (int i = 0; i < massiv.Length; i++)
    {
        if (i == massiv.Length-1) Console.Write($"\"{massiv[i]}\"");
        else Console.Write ($"\"{massiv[i]}\", ");
    }
    Console.Write("]");
}

string[] FillNewArray (string[] massiv, int lengthMax, int n)
{
    string [] newArray = new string[n];
    int count = 0;
    for (int i = 0; i < massiv.Length; i++)
        if (massiv[i].Length <= lengthMax)
        {
            newArray[count] = massiv[i];
            count++;
        }
    return newArray;
}


string [] array1 = new string[4] {"hello", "2", "world", "^-)"};
string [] array2 = new string[4] {"1234", "1567", "-2", "computer science"};
string [] array3 = new string[3] {"Russia", "Denmark", "Kazan"};
int lengthMax = 3;
TestArray(array1, lengthMax);
Console.WriteLine();
TestArray(array2, lengthMax);
Console.WriteLine();
TestArray(array3, lengthMax);