//stp_map_task

//количество строк файла
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
    if(i == num)
    {
        string secondLine = File.ReadLines(@"c:\Users\User\OneDrive\Desktop\task_1.log").ElementAtOrDefault(i - 1);
        Console.WriteLine(secondLine);
        Console.WriteLine();
        string newLine = "";
        foreach(char line in secondLine)
        {
            if(line == ' ')
            {
                Test_txt_line.Line(newLine);
                return;
            }
            newLine += line;
        }
        Console.WriteLine();
        return;
    }
}



