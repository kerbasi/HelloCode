void FillArray(int[] collecton)
{
    int length = collecton.Length;
    for (int i = 0; i < length; i++)
    {
        collecton[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        if(collection[index] == find)
        {
            return index;
        }
        index++;
    }
    return -1;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine(IndexOf(array, 3));



