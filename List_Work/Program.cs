using System;
using System.Text;
using static MyLibrary.MyLibrary;


internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        // Створення списку з початковою ємністю 5
        List myList = new List(5);

        // Додавання цифр до списку
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);
        myList.Add(40);
        myList.Add(50);

        // Вставка нової цифри на позицію з індексом 2
        myList.Insert(2, 25);

        // Виведення елементів списку
        Console.WriteLine("Список після додавання та вставки:");
        PrintList(myList);

        // Перевірка наявності цифри у списку
        int searchItem = 30;
        if (myList.Contains(searchItem))
        {
            Console.WriteLine($"Цифра '{searchItem}' знайдена у списку.");
        }
        else
        {
            Console.WriteLine($"Цифра '{searchItem}' не знайдена у списку.");
        }

        // Видалення цифри зі списку
        myList.Remove(30);

        // Виведення елементів списку після видалення
        Console.WriteLine("\nСписок після видалення цифри 30:");
        PrintList(myList);

        // Перетворення списку в масив
        object[] array = myList.ToArray();
        Console.WriteLine("\nЕлементи списку після конвертації в масив:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        // Реверсія списку
        myList.Reverse();
        Console.WriteLine("\nСписок після реверсу:");
        PrintList(myList);
    }

    static void PrintList(List list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"[{i}] {list[i]}");
        }
    }
}