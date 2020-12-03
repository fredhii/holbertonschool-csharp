using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> booleans = new List<bool>();
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
                booleans.Add(true);
            else
                booleans.Add(false);
        }
        return booleans;
    }
}
