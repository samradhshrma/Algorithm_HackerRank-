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

    /*link: https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem

     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
      var highest = scores[0];
      var lowest  = scores[0];
      var highest_count=0;
      var lowest_count=0;
      for(var i=0;i<scores.Count;i++)
      {
          if(scores[i]>highest)
          {
              highest=scores[i];
              highest_count++;
          }
          if(scores[i]<lowest)
          {
              lowest=scores[i];
              lowest_count++;
          }
           
      }
      var<int> result = new List<int> {highest_count,lowest_count  };
      return result;
      
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
