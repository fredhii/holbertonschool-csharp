using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        bool i = false;
        foreach (var item in myDict)
            if (item.Key == key)
                i = true;
        if (i == true)
            myDict[key] = value;
        else
            myDict.Add(key, value);
        return myDict;
    }
}
