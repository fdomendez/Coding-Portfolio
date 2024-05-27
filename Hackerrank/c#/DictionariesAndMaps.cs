using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int n = int.Parse(Console.ReadLine());
        
        Dictionary<string, string> phoneBook = new Dictionary<string,string>();
        
        for(int i = 0; i < n; i++){
            string line = Console.ReadLine();
            string[] lineArray = line.Split(" ");
            phoneBook.Add(lineArray[0], lineArray[1]);
        }
        
        while(Console.In.Peek() >=0){
            string stdin = Console.ReadLine();
            if(phoneBook.ContainsKey(stdin)){
                Console.WriteLine("{0}={1}", stdin, phoneBook[stdin]);
            }else{
                Console.WriteLine("Not found");
            }

        }
        
    }
}