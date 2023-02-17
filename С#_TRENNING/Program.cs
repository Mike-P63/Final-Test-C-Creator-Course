Console.Clear();

/*
int[] array = { 11, 22, 34, 54, 67, 34, 23, 89, 99 };

int n = array.Length;
int find = 34;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {

        Console.WriteLine(index);
        break;

    }
index++;
}
*/
/*
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        
        index++;
    }
}
 void PrintArray(int[] col)
 {
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        
        Console.Write(col[position] + " , ");
        position++;
    }
 }

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];

FillArray(array);
//array[4] =4;
//array[6] =4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/

Console.Clear();

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length ; i++ )
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length ; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }
        int temporrary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporrary;
    }


}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


