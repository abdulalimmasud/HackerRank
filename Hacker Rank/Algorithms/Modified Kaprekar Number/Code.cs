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
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)
    {
        List<int> kpn = new List<int>();
        if(p == 1)
        {
            kpn.Add(1);
            p = 9;
        }
        string sq_p = "";
        int m = 0, sum = 0, l = 0, lh = 1, f = 0, s =0;
        while(p <= q)
        {
            m = p % 9;
            if(m == 0 || m == 1)
            {
                double n = (double)p;
                double sq = n * n;
                sq_p = (sq).ToString();
                l = sq_p.Length;
                lh = (int)(l / 2);
                f = Convert.ToInt32(sq_p.Substring(0, lh));
                s = Convert.ToInt32(sq_p.Substring(lh));
                if (f + s == p)
                {
                    kpn.Add(p);
                    if (p < 100)
                        p += 10;
                    else
                        p += 100;
                }
                else
                    p++;
            }
            else
                p++;
        }
        if (kpn.Count == 0)
            Console.Write("INVALID RANGE");
        else
            Console.Write(string.Join(" ", kpn));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}
