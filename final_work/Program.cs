// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых
// меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
//исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] stringArray = new string[4] { "Hello", ":)", "Good", "3" };
string[] myArray = new string[stringArray.Length];
int count = 0;
int size = 3;
for (int i = 0; i<stringArray.Length; i++)
{
    if (stringArray[i].Length <=size)
    {
        myArray[count]=stringArray[i];  
        count++;   
    }
}
Console.Write($"[{String.Join(" ", stringArray)}] -> ");
Console.Write($"[{String.Join(" ", myArray)}]");

