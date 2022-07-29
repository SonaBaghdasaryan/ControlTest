//Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

string[] CreateStringArray(int size)
{
    string[] words = new string [size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words [i]= Console.ReadLine();
    }

    return words;
}

int ElementsCount(string[] array)
{
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}
string[] FindElements(string[] array, int count)
{
    string[] myArray = new string[count];
    int index = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        int length = array[i].Length;
        if (length <= 3)
        {
            myArray[index] = array[i];
            index++;
        }
    }
    return myArray;
}
string Print(string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        output += ($"\"{array[i]}\" ");
    }
    return output;
}

Console.WriteLine("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());              
string[] array1 = CreateStringArray(size);
string input = Print(array1);
int count = ElementsCount(array1);
string[] result = FindElements(array1, count);
string output = Print(result);
Console.WriteLine($"The result is   {output}");



