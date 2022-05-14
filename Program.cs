//stp_map_task
using System.Text;

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
        Test_txt_line.Line(secondLine);
        return;
    }
}

class Test_txt_line
{
    public static void Line(string line)
    {
        string path = @"c:\Users\User\OneDrive\Desktop\test.txt";

        try
        {
            // Создаю файл или перезапишсываю, если файл существует.
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(line);
                // записываю secondLine в файл.
                fs.Write(info, 0, info.Length);
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}

