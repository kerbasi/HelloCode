int[] array = {1, 2, 3, 5, 6, 7, 3, 6, 3, 8};

int n = array.Length;
//int i = 0;
int find = 6;
for (int i = 0; i < n; i++)
{
    if (array[i] == find) {
        Console.WriteLine(i);
        break;
    }   
    
}
