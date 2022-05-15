using System;
using System.Collections.Generic;

public class remove_
{
    public static void Remove(List<string> list)
    {
        int count = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == "")
            {
                if (count == list.Count)
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
