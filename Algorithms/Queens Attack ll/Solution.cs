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
    public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
    {
        int sum = 0;
        var upperRows = obstacles.Where(x => x[0] > r_q).ToList();
        var lowerRows = obstacles.Where(x => x[0] < r_q).ToList();
        var LabelDatas = obstacles.Where(x => x[0] == r_q).ToList();
        
        var leftLabel = LabelDatas.Where(x => x[1] < c_q).OrderByDescending(x => x[1]).FirstOrDefault();
        if (leftLabel != null)
            sum += (c_q - leftLabel[1] - 1);
        else
            sum += c_q - 1;

        var rightLabel = LabelDatas.Where(x => x[1] > c_q).OrderBy(x => x[1]).FirstOrDefault();
        if (rightLabel != null)
            sum += (rightLabel[1] - c_q -1);
        else
            sum += (n - c_q);

        var upperLabel = upperRows.Where(x => x[1] == c_q).OrderBy(x => x[0]).FirstOrDefault();
        if (upperLabel != null)
            sum += (upperLabel[0] - r_q - 1);
        else
            sum += (n - r_q);

        var lowerLabel = lowerRows.Where(x => x[1] == c_q).OrderByDescending(x => x[0]).FirstOrDefault();
        if (lowerLabel != null)
            sum += (r_q - lowerLabel[0] - 1);
        else
            sum += (r_q - 1);

        
        int rowDifference = n - r_q;
        int pointSum = r_q + c_q;
        int pointSub = r_q - c_q;
        if (rowDifference > 0)
        {
            var upperLeftDiagonal = upperRows.Where(x => x[1] < c_q && (x[0]+x[1]) == pointSum).OrderBy(x => x[0]).ThenByDescending(x=> x[1]).FirstOrDefault();
            if (upperLeftDiagonal != null)
                sum += (c_q - upperLeftDiagonal[1] - 1);
            else
            {
                int columnDiff = c_q - 1;
                sum += (rowDifference > columnDiff ? columnDiff : rowDifference);
            }

            var upperRightDiagonal = upperRows.Where(x => x[1] > c_q && (x[0]- x[1]) == pointSub).OrderBy(x => x[0]).ThenBy(x=> x[1]).FirstOrDefault();
            if (upperRightDiagonal != null)
                sum += (upperRightDiagonal[0] - r_q - 1);
            else
            {
                int columnDiff = n - c_q;
                sum += (rowDifference > columnDiff ? columnDiff : rowDifference);
            }
        }

        rowDifference = r_q - 1;
        if(rowDifference > 0)
        {
            var lowerLeftDiagonal = lowerRows.Where(x => x[1] < c_q && (x[0]-x[1]) == pointSub).OrderByDescending(x => x[0]).ThenByDescending(x=> x[1]).FirstOrDefault();
            if (lowerLeftDiagonal != null)
                sum += (r_q - lowerLeftDiagonal[0] - 1);
            else
            {
                int columnDiff = c_q - 1;
                sum += (rowDifference > columnDiff ? columnDiff : rowDifference);
            }

            var lowerRightDiagonal = lowerRows.Where(x => x[1] > c_q && (x[0]+x[1]) == pointSum).OrderByDescending(x => x[0]).ThenBy(x=> x[1]).FirstOrDefault();
            if (lowerRightDiagonal != null)
                sum += (r_q - lowerRightDiagonal[0] - 1);
            else
            {
                int columnDiff = n - c_q;
                sum += (rowDifference > columnDiff ? columnDiff : rowDifference);
            }
        }        

        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int r_q = Convert.ToInt32(secondMultipleInput[0]);

            int c_q = Convert.ToInt32(secondMultipleInput[1]);

            List<List<int>> obstacles = new List<List<int>>();

            for (int i = 0; i < k; i++)
            {
                obstacles.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
            }

            int result = Result.queensAttack(n, k, r_q, c_q, obstacles);

            Console.WriteLine(result);
    }
}
