using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        String myname = "";

        int arg0 = Int16.Parse(args[0]);
        int arg1 = Int16.Parse(args[1]);
        int arg2 = Int16.Parse(args[2]);

        if (arg0 > 1000 || arg0 < 50) Console.WriteLine("You are  fucking idiot... arg0 must be more than 50 and less than 1000");

        Console.WriteLine(arg0 + arg1);

        myname = "jullianbarber";
        Console.WriteLine("The value of yname is:" + myname);

        int a = arg0;
        int b = arg1;
        double dbl = arg2;

        Console.WriteLine("a:" + a + "b:" + b + "dbl:" + dbl);
        Console.WriteLine(dbl / 2);
        Console.WriteLine(a * a);
        Console.WriteLine(b * b);

        double a2 = a * a;
        double b2 = b * b;
        double dblhalf = dbl / 2;

        Console.WriteLine(a2 + b2);

        Console.WriteLine(Math.Sqrt(a2 + b2) + dbl);

        int[] radii = new int[10];
        radii[0] = 23;
        radii[1] = 26;
        radii[2] = 21;
        radii[3] = 29;
        radii[4] = 27;
        radii[5] = 30;
        radii[6] = 40;
        radii[7] = 33;
        radii[8] = 38;
        radii[9] = 41;

        Console.WriteLine(radii[4]);

        Console.ReadKey();
    }
}


