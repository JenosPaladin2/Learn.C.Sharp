using System;
class Hello
{

    /**
     * Wieso braucht man static void Main?
     * Wieso braucht man string[] args???
     */
    static void Main(string[] args)
    {

        //Print something in Terminal console
        //Console.WriteLine("Hello World");
        //Console.ReadKey();

        Console.WriteLine("Types Sample");

        //Declare int variable
        int i = 34;

        //char variable
        char c = 'm';

        //float variable
        float per = 6.8f;

        //test
        //object o = c;
        object o = c;

        //String variable
        string name = "JenosPaladin";

        int counter = i + 1;

        /*
         * Use c in a condition. Check if the value of c is 'm'
         * then print c and counter
        */

        if (c == 'm')
        {
            Console.WriteLine("i:" + i);
            Console.WriteLine("counter:" + counter);
            Console.WriteLine("c:" + c);
            Console.WriteLine("name:" + name);
            Console.WriteLine(counter);
            Console.WriteLine("per:" + per);


            //How to check which type is a variable???
        }

        Console.WriteLine("i+1=" + (i+1));

        Console.ReadLine();
    }
}