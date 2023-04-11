//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []



string[] UserInput()
{
    string[] value = new string[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        Console.Write($"Введите {i + 1}й элемент массива - ");
       value[i] = Console.ReadLine();
    }
    return value;
}
void PrintArray (string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length-1) Console.Write($"“{arr[i]}”, ");
        else Console.Write($"“{arr[i]}”");
    }
    Console.WriteLine("]");
}