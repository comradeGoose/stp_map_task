using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.Generic;
public class Test_txt_line
{
    public static void Line(string line)
    {
        string path = @"c:\Users\User\OneDrive\Desktop\out.txt";

        try
        {
            //Open the File
            StreamWriter sw = new StreamWriter(path, true, Encoding.ASCII);
            //Writeout the numbers 1 to 10 on the same line.
            sw.Write(line);
            //close the file
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
}