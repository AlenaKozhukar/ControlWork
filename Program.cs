//Задача: Написать программу, которая из имеющегося массива строк формирует 
//новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] lines = new string [] {"qWert", "yui", "op", "aSdf5", "-2", ":-)"};

string shortsymbolSet = "";

string GetShortSymbolSetFromArrayLine()
{
string result = "";

for (int i = 0; i<lines.Length; i++)
{
    string symbolSet = lines [i];

    if (symbolSet.Length > 3)
    continue;
    result = result + lines [i] + " ";
}
return result;
}

shortsymbolSet = GetShortSymbolSetFromArrayLine();
System.Console.WriteLine(shortsymbolSet);