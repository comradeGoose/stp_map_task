using System;
using System.Text;
public class Test_txt_line
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