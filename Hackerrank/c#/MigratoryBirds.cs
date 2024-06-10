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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> birds = new Dictionary<int, int>();
        List<int> maxL = new List<int>();
        
        int max = 0;
        int min = 0;
        for(int i = 0; i < arr.Count(); i++)
        {
            if(birds.ContainsKey(arr[i]))
            {
                birds[arr[i]]+=1;
            }else
            {
                birds.Add(arr[i], 1);
            }
            
            if(birds[arr[i]]> max)
            {
                maxL.Clear();
                max = birds[arr[i]];
                maxL.Add(arr[i]);
                
                min = arr[i];
            }else if(birds[arr[i]] == max){
                maxL.Add(arr[i]);
                if(min>arr[i])
                {
                    min = arr[i];
                }
            }
        }
        
        return min;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
