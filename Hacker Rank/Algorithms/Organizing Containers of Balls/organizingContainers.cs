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
     * Complete the 'organizingContainers' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts 2D_INTEGER_ARRAY container as parameter.
     */

    public static string organizingContainers(List<List<int>> container)
    {
        int n = container.Count;
        int[] r = new int[n];
        int[] c = new int[n];
        int j = 0;
        for (int i = 0; i < n; i++)
        {
            for (j = 0; j < container[i].Count; j++)
            {
                r[i] += container[i][j];
                c[j] += container[i][j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            j = 0;
            for (j = i; j < n; j++)
            {
                if(r[i] == c[j])
                {
                    int t = c[j];
                    c[j] = c[i];
                    c[i] = t;
                    break;
                }
            }
            if(j == n)
            {
                return "Impossible";
            }
        }
        return "Possible";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> container = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                container.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(containerTemp => Convert.ToInt32(containerTemp)).ToList());
            }

            string result = Result.organizingContainers(container);

            Console.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
