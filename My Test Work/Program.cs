// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int InputValue (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void ArrayElementsValue (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string word = Console.ReadLine();
        array[i] = word;
    }
}

int Counter(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void ValueNewArray(string[] array, string[] newArray)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
}

void PrintArray (string[] newArray)
{
    Console.Write($"[");
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i != newArray.Length-1)
        {
            Console.Write($"{newArray[i]}, ");
        }
        else Console.Write($"{newArray[i]}");
    }
    Console.Write($"]");
}

int length = InputValue($"Enter value to length first array");
string[] firstArray = new string [length];
ArrayElementsValue(firstArray);
string[] arrayTaskCondidion = new string[Counter(firstArray)];
ValueNewArray(firstArray, arrayTaskCondidion);
PrintArray(arrayTaskCondidion);
