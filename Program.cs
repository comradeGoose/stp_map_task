//stp_map_task

//количество строк файла

var nfi = new System.Globalization.NumberFormatInfo();
nfi.NumberDecimalSeparator = ".";

int amount_file_lines = File.ReadLines(@"c:\Users\User\OneDrive\Desktop\task_1.log").Count();
Console.WriteLine("Колличество строк в файле: " + amount_file_lines);

Console.WriteLine();

Console.Write("Введите номер строки которую хотите вывести в консоль: ");
string input = String.Empty;
input = Console.ReadLine();
int num = Int32.Parse(input);
Console.WriteLine();

for (int i = 0; i < amount_file_lines; i++)
{

    float time;
    float data;

    if (i == num)
    {
        string secondLine = File.ReadLines(@"c:\Users\User\OneDrive\Desktop\task_1.log").ElementAtOrDefault(i - 1);
        Console.WriteLine(secondLine);
        Console.WriteLine();
        string newLine = "";

        List<string> list_data = new List<string>();

        foreach (string line in secondLine.Split())
        {
            list_data.Add(line);
        }


        remove_.Remove(list_data);
        //Console.WriteLine(list_data[1]);

        for (int q = 0; q < list_data.Count; q++)
        {
            Console.WriteLine(list_data[q]);
        }

        //time = float.Parse(list_data[0], nfi);

        //data = float.Parse(list_data[4], nfi);

        //Console.WriteLine(time);
        //Console.WriteLine(data);

        Console.WriteLine();
        return;
    }
}

public class remove_
{
    public static void Remove(List<string> list)
    {
        int count = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == "")
            {
                if(count == list.Count)
                {
                    return;
                }
                list.Remove(list[i]);
                remove_.Remove(list);
            }
            else
            {
                count++;
            }
        }
    }
}



