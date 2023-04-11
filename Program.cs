//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] userInputArray = UserInput(); // Создаем исходный массив и запрашиваем данные у пользователя
PrintArray(userInputArray); // Печатаем исходный массив на экран
string[] newArray = ArrayThreeLength(userInputArray); // Создаем новый массив в котый помещаем только значения, которые меньше или равны 3
PrintArray(newArray); // Печатаем результат на экран

string[] UserInput() //Метод пользовательского ввода
{
    Console.WriteLine("Данная программа, предназначена для выбора выражений из введенных пользвателем, состоящих не более чем из 3 символов");
    Console.Write("Введите количество выражений для проверки: ");
    int arrLength = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        Console.Write($"Введите {i + 1}й элемент массива - ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] arr) // Метод печати массивов
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"“{arr[i]}”, ");
        else Console.Write($"“{arr[i]}”");
    }
    Console.WriteLine("]");
}
string[] ArrayThreeLength(string[] arr) // Метод для создания нового массива с элементами, длинна которых меньше или равна 3
{
    int newArrLength = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArrLength++;
        }
    }
    string[] newArr = new string[newArrLength];
    int k = 0;
    for (int j = 0; j < arr.Length; j++)
    {

        if (arr[j].Length <= 3)
        {
            newArr[k] = arr[j];
            k++;
        }
    }
    return newArr;
}