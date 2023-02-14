/*
Задача: написать программу, которая из имеющегося массива строк формирует
 массив из строк, длина которых меньше либо равна 3 символа. Первоначальный 
 массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
 исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

*/

Console.Clear();

string[] FillArray()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Введите любые символы, разделив их запятой либо пробелом: ");
    Console.ResetColor();
    string? enterSymbols = Console.ReadLine();
    char[] separators = new char[] { ',', ' ' };
    string[] Array = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return Array;
}

string PrintArray(string[] Array)
{
    string stringArray = "[";
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1)
        {
            stringArray += $"\"{Array[i]}\"";
            break;
        }
        
        stringArray += ($"\"{Array[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int CountSymbols(string[] Array)
{
    int Sum = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            Sum++;
        }
    }
    return Sum;
}

string[] GenerateNewArray(string[] Array)
{
    int finalArrayLength = CountSymbols(Array);
    string[] finalArray = new string[finalArrayLength];
    int i = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            finalArray[i] = item;
            i++;
        }
    }
    return finalArray;
}

string[] Array = FillArray();
string[] FinalArray = GenerateNewArray(Array);
string ArrayA = PrintArray(Array);
string ArrayB = PrintArray(FinalArray);
Console.WriteLine(ArrayA + " -> " + ArrayB);


