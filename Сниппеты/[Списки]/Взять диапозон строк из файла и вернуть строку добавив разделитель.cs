﻿// ВЗЯТЬ ДИАПОЗОН СТРОК ИЗ ФАЙЛА И ВЕРНУТЬ СТРОКУ ДОБАВИВ РАЗДЕЛИТЕЛЬ 

// путь к файлу
string path = project.Variables["pathToKeyWordFile"].Value;

/*
тест_1
тест_2
тест_3
тест_4
тест_5
тест_6
тест_7
*/

// создаём список всех строк
var lines = new List<string>();

// получаем количество всех строк
int count = Convert.ToInt32(Macros.FileSystem.FileCountOfLines(path));

// загрузим все строки в список
for(int i = 0; i < count; i++)
{
	lines.Add(Macros.FileSystem.FileGetLine(path, i.ToString(), false));
}

// возвращаем ключевые слова через ";" в указанном диапазоне от 3 до 6
// т.е. начиная с 2-го индекса в количестве 4 штуки
return string.Join(";", lines.GetRange(2, 4));
