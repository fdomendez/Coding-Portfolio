using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i =0; i < n; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            
            IsPrime(number);
        }
    }
    
    static void IsPrime(int n)
    {
        if(n ==2)
        {
            Console.WriteLine("Prime");
        }else if(n % 2 == 0 || n == 1){
            Console.WriteLine("Not prime");
        }else{
            bool prime = true;
            
            for(int i = 3; i < n/2; i=i+2)
            {
                if(n % i == 0)
                {
                    prime=false;
                    break;
                }
            }
            if(prime)
            {
                Console.WriteLine("Prime");
            }else{
                Console.WriteLine("Not prime");
            }
            
        }
    }
    
    
}