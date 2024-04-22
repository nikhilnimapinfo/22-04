using System;

namespace Generic
{
    public class Generi<String>
    {
        public String s;
        public Generi(String i)
        {
            s = i;
        }

        public String MyMethod()
        {
            return s;
        }
        public void m1()
        {
            Console.WriteLine("Hi");
        }

        
        public int m2<String>(String h)
        {
            Console.WriteLine(h);
            return 199999;
        }
    }

    

}
