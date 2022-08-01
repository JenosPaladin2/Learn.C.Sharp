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
         * Einfache Sprache:
         * Implizite Konvertierung bedeutet, dass ein Wert einer Variable zu einem gleichen oder höheren Variablentyp umgewandelt wird.
         */
        
        int x = 4568;
        long y = x; //implicit conversion.


        /**
         * What is explicit conversion?
         * Explicit conversion requires an explicit cast. This is done by putting the type in parentheses (). This conversion is not always successful. If successful, it may or may not be converted, with possible loss of data.
         * 
         * DE: Eine explizite Konvertierung erfordert einen expliziten Cast. Dies geschieht, indem der Typ in Klammern () gesetzt wird.
         * Diese runden Klammern werden auch als "Typkonvertierungsoperator" bezeichnet.
         * 
         * Folgende Syntax wird verwendet: (Zieldatentyp)Ausdruck
         * 
         * Diese Konvertierung ist nicht immer erfolgreich. Wenn Sie erfolgreich ist, kann es sein, dass sie nicht konvertiert wird, was zu Datenverlusten führen kann.
         * 
         * 
         * Einfache Sprache: Datenumwandlung in einen anderen Typ, ohne darauf zu achten, ob der neue Typ gleich oder höherwertig ist. Dadurch kann man zu (theoretisch) allen kompatiblen Typen wechseln.
         * Achtung: Beim Konvertieren von einer gleich oder höherwertigen zu einer niedrigen Typ kann ein Datenverlust entstehen!
         */

        int geradeZahl = 45689; //gleicher Typ
        short expliziteZahl = (short)geradeZahl; // niedriger Typ
        
        double d = 3.14314256; // gleicher Typ
        float f = (float)d; //niedriger Typ

        /**
         * Was ist der Unterschied zwischen implizite Konvertierung und expliziter Konvertierung?
         * 
         * Implizite Konvertierung: Typkonvertierung --> gleich oder höherwertigem Variablentyp
         * Explizit Konvertierung: Typkonvertierung --> alle möglich, sofern kompatibel. Es kann Datenverlust entstehen (von gleich/hoch zu niedrig). 
         */


        /**
         * Wie kann man Datentypen konvertieren, die miteinander nicht kompatibel sind?
         * 
         * Man nutzt die Klasse "Convert". Einige Funktionen dieser Klasse sind (siehe Openbook C#):
         * 
         * Methode                      Beschreibung
         * 
         * ToBoolean(Ausdruck)          Konvertiert den Ausdruck in einen bool-Typ.
         * ToByte(Ausdruck)             Konvertiert den Ausdruck in einen byte-Typ.
         * ToChar(Ausdruck)             Konvertiert den Ausdruck in einen char-Typ.
         * ToDecimal(Ausdruck)          Konvertiert den Ausdruck in einen decimal-Typ.
         * ToDouble(Ausdruck)           Konvertiert den Ausdruck in einen double-Typ.
         * ToInt16(Ausdruck)            Konvertiert den Ausdruck in einen short-Typ.
         * ToInt32(Ausdruck)            Konvertiert den Ausdruck in einen int-Typ.
         * ToInt64(Ausdruck)            Konvertiert den Ausdruck in einen long-Typ.
         * ToSByte(Ausdruck)            Konvertiert den Ausdruck in einen sbyte-Typ.
         * ToSingle(Ausdruck)           Konvertiert den Ausdruck in einen float-Typ.
         * ToString(Ausdruck)           Konvertiert den Ausdruck in einen string-Typ.
         * ToUInt16(Ausdruck)           Konvertiert den Ausdruck in einen ushort-Typ.
         * ToUInt32(Ausdruck)           Konvertiert den Ausdruck in einen uint-Typ.
         * ToUInt64(Ausdruck)           Konvertiert den Ausdruck in einen ulong-Typ.
         * 
         * Wobei Ausdruck den Wert einer Variable darstellt.
         * 
         * Bsp:
         * 
         * long val1 = 5642;
         * int val2 = Convert.ToInt32(val1); //Convert Klasse mit Methode ToInt32 genutzt.
         * 
         * Ist gleichwertig mit
         * 
         * long val1 = 5642;
         * int val2 = (int) val1 //explizite Konvertierung
         * 
         * 
         */

        /**
         * What is local Variable Type inference?
         * C# offers a keyword called "var" that allows a developer to declare a variable without explicitly declaring the type of it. The declared variable gets its data type as soon as it is initialized.
         * The data type of that variable is known by data type of initialized value.
         * 
         * DE: C# bietet ein Schlüsselwort namens "var", mit dem ein Entwickler eine Variable deklarieren kann, ohne explizit den Typ der Variable zu deklarieren.
         * Die deklarierte Variable erhält ihren Datentyp, sobald sie initialisiert wird. Der Datentyp dieser Variable ist durch den Datentyp des initialisierten Wertes bekannt.
         *  
         */

        //Example:

        var inum = 10; //same as int inum = 10;
        var fnum = 10.3; //same as float fnum = 10.3;
        var list = new List<int>(); //same as List<int> list = new List<int>(); 




    }
}