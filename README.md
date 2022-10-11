# Итоговая проверочная работа

## Условие задачи
___

Задача: Написать программу, которая из меющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  
<br />

___
## Алгоритм решения  
<br />

![Блок-схема](FinalWork.png 'Блок-схема')

<br />

## **_1. Создаем метод для считывания количества строк_**
 
```c#
int NumberOfStrings(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
```  
<br />

## **_2. Создаем метод для считывания введенных строк_**
```c#
void GetStrings(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        words[i] = Console.ReadLine();
    }
    Console.WriteLine("Новый массив из строк: ");
}
```  
<br />

## **_3. Создаем метод для поиска строк, кол-во значений в которых меньше или равно трем, и вывода их в консоль_**
```c#
void SearchOfStrings(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3) Console.Write(words[i] + " ");
    }
}
```  
<br />

## **_4. Пишем основной код программы с вызовом написанных ранее методов_**
```c#
Console.Write("Введите количество строк, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] words = new string[n];
Console.WriteLine("Поочередно введите строки: ");
GetStrings(words);
SearchOfStrings(words);
```  
<br />