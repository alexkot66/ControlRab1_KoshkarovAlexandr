//Написать программу, которая из имеющегося массива строк формирует новый массив 
//из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно
//ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
//рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetNewStringArray(string[] arrStr)
{
int count = 0;
for (int i = 0; i < arrStr.Length; i++)
{
    if(arrStr[i].Length <= 3)
    {
        count++;
    }
}

string[] result = new string[count];
int j = 0;
for (int i = 0; i < arrStr.Length; i++)
{
    if(arrStr[i].Length <= 3)
    {
        result[j] = arrStr[i];
        j++;
    }
}
return result;
}

void PrintArray(string[] strArray)
{
    Console.Write("[");
    for (int i = 0; i < strArray.Length; i++)
    {
        Console.Write($"'{strArray[i]}' ");
    }
    Console.Write("]");
}

string[] arrStr1 = {"Hello", "2", "world", ":-)"};
string[] arrStr2 = {"1234", "1567", "-2", "computer science"};
string[] arrStr3 = {"Russia", "Denmark", "Kazan"};

PrintArray(GetNewStringArray(arrStr1));
Console.WriteLine("");
PrintArray(GetNewStringArray(arrStr2));
Console.WriteLine("");
PrintArray(GetNewStringArray(arrStr3));
Console.WriteLine("");


