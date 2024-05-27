using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string stdin;
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding))
        {
            stdin = reader.ReadToEnd();
            
            string even = "";
            string odd = "";
            
            int wordI = 0;
            for(int i=0; i<stdin.Length; i++)
            {
                int n;
                string c = stdin[i].ToString();
                if(!int.TryParse(c, out n))
                {
                    if(c.Trim().Length > 0)
                    {
                        //Console.WriteLine(stdin[i]);
                        if(wordI==0 || wordI%2==0){ //even
                            even += stdin[i];
                        }else{
                            odd += stdin[i];
                        }
                        wordI++;
                    }else{
                        if(wordI>0)
                        {
                            Console.WriteLine("{0} {1}", even, odd);
                        }
                        wordI = 0;
                        even = "";
                        odd = "";
                    }
                }
                //Console.WriteLine(even);     
            }
            Console.WriteLine("{0} {1}", even, odd);   
        }  
    }
}