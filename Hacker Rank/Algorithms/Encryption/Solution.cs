using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'encryption' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string encryption(string s)
    {
        s = s.Replace(" ", "");
        int l = s.Length;
        double sr = Math.Sqrt(l);
        int r = (int)sr;
        int c = (int)Math.Ceiling(sr);

        if (r * c < l)
        {
            r = c;
        }

        string[] str = new string[r];
        int i = 0; int count = 0;
        while(count < l)
        {
            if(c + count >= l)
            {
                str[i] = s.Substring(count, l - count);
            }
            else
                str[i] = s.Substring(count, c);
            i++;
            count += c;
        }

        string[] resultStr = new string[c];
        for (i = 0; i < c; i++)
        {
            for (int j = 0; j < r; j++)
            {
                if(str[j].Length > i)
                {
                    resultStr[i] += str[j][i];
                }                
            }
        }

        return string.Join(" ", resultStr);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.encryption(s);

        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
