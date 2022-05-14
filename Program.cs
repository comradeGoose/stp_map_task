//stp_map_task
//третья строка 
string secondLine = File.ReadLines("C:\\task_1.txt").ElementAtOrDefault(2);
Console.WriteLine(secondLine);


//количество строк файла
int amount_file_lines = File.ReadLines("C:\\task_1.log").Count();
Console.WriteLine(amount_file_lines);