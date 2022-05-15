//stp_map_task
using System.Collections.Generic;

SortedList<string,float> dictionary = new SortedList<string, float>();
SortedList<string, float> sort = new SortedList<string, float>();
var nfi = new System.Globalization.NumberFormatInfo();
nfi.NumberDecimalSeparator = ".";

//количество строк файла
int amount_file_lines = File.ReadLines(@"c:\Users\User\OneDrive\Desktop\access.log").Count();
Console.WriteLine("Колличество строк в файле: " + amount_file_lines);

Console.WriteLine();

//Console.Write("Введите номер строки которую хотите вывести в консоль: ");
//string input = String.Empty;
//input = Console.ReadLine();
//int num = Int32.Parse(input);
Console.ReadLine();
Console.WriteLine();

for (int i = 0; i < amount_file_lines; i++)
{
    string IP;
    float time;
    float data;
    float traffic;

    //if (i == num)
    //{
    string secondLine = File.ReadLines(@"c:\Users\User\OneDrive\Desktop\access.log").ElementAtOrDefault(i);
    Console.WriteLine(secondLine);
    Console.WriteLine();
    string newLine = "";

    List<string> list_data = new List<string>();

    foreach (string line in secondLine.Split())
    {
        list_data.Add(line);
    }

    remove_.Remove(list_data);

    IP = list_data[2];
    time = float.Parse(list_data[0], nfi);
    data = float.Parse(list_data[4], nfi);
    traffic = data / time;

    Console.WriteLine("Время: " + time);
    Console.WriteLine("Данные: " + data);
    Console.WriteLine("Трафик: " + traffic);

    if (dictionary.ContainsKey(IP))
    {
        float value;
        float value_f;
        if(dictionary.TryGetValue(IP, out value))
        {
            dictionary.Remove(IP);
            dictionary.Add(IP, value + traffic);
        }
    }
    else
    {
        dictionary.Add(IP, traffic);
    }

    //    Console.WriteLine();
    //    return;
    //}
}

for(int i = 0; i < 10; i++)
{
    float value = dictionary.Values.Max();
    string key = dictionary.FirstOrDefault(x => x.Value == dictionary.Values.Max()).Key;
    sort.Add(key, value);
    dictionary.Remove(key);
    Console.WriteLine("Max key: " + key + " Max value: " + value);
}

foreach (KeyValuePair<string, float> pair in sort)
{
    Test_txt_line.Line("Key (IP): " + pair.Key + " - Traffic: " + pair.Value + " byte/s" + "\n");
}





