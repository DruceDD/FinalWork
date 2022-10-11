int NumberOfStrings(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void GetStrings(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        words[i] = Console.ReadLine() ?? "";
    }
    Console.WriteLine("Новый массив из строк: ");
}

void SearchOfStrings(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3) Console.Write(words[i] + " ");
    }
}

int n = NumberOfStrings("Введите количество строк, которые хотите ввести: ");
string[] words = new string[n];
Console.WriteLine($"Поочередно введите указаное количество строк ({n}): ");
GetStrings(words);
SearchOfStrings(words);