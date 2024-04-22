using System;


namespace Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          Func<int,int>Squre= i=>  i* i;
            Console.WriteLine(Squre(5));
            string[] arr = new string[] { "A", "B" ,"C"};

           
            for (int a=0;a < arr.Length;a++) {
                Func<string, string> NAME = d => d + d+d;
                Console.WriteLine(NAME(arr[a]));
            }

            foreach (var r in arr)
            {
                Func<string, string> NAME = d => d + d + d;
                Console.WriteLine(NAME(r));
            }
           
        }
       
    }
}
