using System;


    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            String myname = "";            
            Console.WriteLine("---->" + myname);
            
            myname = "jullianbarber";
            Console.WriteLine("The value of yname is:" + myname);

            int a = 54;
            int b = 32;
            double dbl = 17;

            Console.WriteLine("a:" +a + "b:" + b + "dbl:" + dbl);
            Console.WriteLine( dbl/2);
            Console.WriteLine(a * a);
            Console.WriteLine(b * b);

            double a2 = a * a;
            double b2 = b * b;
            double dblhalf = dbl / 2;

            Console.WriteLine(a2 + b2);

            Console.WriteLine(Math.Sqrt(a2 + b2) + dblhalf);



           Console.ReadKey();
        }
    }

