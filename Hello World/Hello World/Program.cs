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

            Console.WriteLine("i+1=" + (i + 1));

            //How to check which type is a variable???
            Console.WriteLine("typeof name: "+name.GetTypeCode());
        }

        /**
         * What is implicit conversion?
         * Implicit convrsion means converting the lower precision data into higher precision without any loss of data.
         * This conversion occurs automatically.
         * 
         * DE: Implizite Konvertierung bedeutet, dass die Daten mit geringerer Genauigkeit ohne Datenverlust in Daten mit höherer Genauigkeit umgewandelt werden. Diese Umwandlung erfolgt automatisch.
         */
        
        int x = 4568;
        long y = x; //implicit conversion.


        /**
         * What is explicit conversion?
         * Explicit conversion requires an explicit cast. This is done by putting the type in parentheses (). This conversion is not always successful. If successful, it may or may not be converted, with possible loss of data.
         * 
         * DE: Eine explizite Konvertierung erfordert einen expliziten Cast. Dies geschieht, indem der Typ in Klammern () gesetzt wird. Diese Konvertierung ist nicht immer erfolgreich. Wenn Sie erfolgreich ist, kann es sein, dass sie nicht konvertiert wird, was zu Datenverlusten führen kann.
         * 
         */



        
    }
}