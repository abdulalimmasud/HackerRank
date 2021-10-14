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
     * Complete the 'biggerIsGreater' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING w as parameter.
     */

    public static string biggerIsGreater(string w)
    {
        int i = w.Length - 2;
        char[] arr = w.ToCharArray();
        while (!(i < 0 || arr[i] < arr[i + 1]))
            i--;

        if(i >= 0)
        {
            int j = arr.Length - 1;
            while (!(arr[i] < arr[j]))
                j--;
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            char[] carr = arr.Skip(i + 1).Reverse().ToArray();
            for (int k = 0; k < carr.Length; k++)
            {
                i++;
                arr[i] = carr[k];
            }
            return new string(arr);
        }

        return "no answer";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            Console.WriteLine(result);
        }
    }
}
