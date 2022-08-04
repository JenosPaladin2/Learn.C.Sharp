using System;

class Hello
{
    /**
     * Wieso braucht man static void Main?
     * Wieso braucht man string[] args???
     */
    public static void Main(string[] args)
    {

        //Print something in Terminal console
        //Console.WriteLine("Hello World");
        //Console.ReadKey();

        Console.WriteLine("Types Sampdle");

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
            Console.WriteLine("typeof name: " + name.GetTypeCode());
        }

        //-----------------------------------------------------------

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


        /**
         * What are value types?
         * Value types are generally (not always) stored on the stack and are passed by copying.
         * The way in which a variable assignment works differs between reference and value types.
         * 
         * DE: Wertetypen werden im Allgemeinen (nicht immer) auf dem Speicher gespeichert und durch Kopieren weitergegeben.
         * Die Art und Weise, wie eine Variablenzuweisung funktioniert, unterscheidet sich zwischen Referenz- und Wertetypen.
         *
         */

        //Example:
        int v1 = 14;
        int v2 = 24;

        v2 = v1; //overwritten to 14

        Console.WriteLine("v2: " + v2);
        Console.WriteLine("v1: " + v1);


        //Example for Reference type
        A c1 = new A(); //Object vom Typ <Klasse> A initialisieren
        A c2 = new A(); //Object vom Typ <Klasse> A initialisieren

        c1.SetValue(12); //Werte werden gesetzt über die Funktion setValue
        c2.SetValue(22); //Werte werden gesetzt über die Funktion setValue

        c2 = c1;

        Console.WriteLine("c1.value: " + c1.value);
        Console.WriteLine("c2.value: " + c2.value);

        int v4 = 14;
        methodtoshowref(ref v4);
        Console.WriteLine(v4);
        //var test = Console.ReadLine();
        //Console.WriteLine("Der Nutzer hat folgendes eingegeben: sdf"+test);

        Console.WriteLine("Struct Example:");

        //Create a Book object
        Book myBook = new Book();
        myBook.Author = "Sumach Kumar";
        myBook.Title = "Learning C# for beginners";
        myBook.Price = 20.99M; //Anscheinend muss ein M danach stehen, um double Werte als Decimal zu konvertieren.
        myBook.Year = 2022;

        Console.WriteLine("myBook: " + myBook);
        Console.WriteLine("myBook.Author: " + myBook.Author);
        Console.WriteLine("myBook.Title: " + myBook.Title);
        Console.WriteLine("myBook.Price: " + myBook.Price);
        Console.WriteLine("myBook.Year: " + myBook.Year);

        //Andere Alternative, um Objektwerte auszugeben in Konsole.
        Console.WriteLine($"Book {myBook.Title} was written by {myBook.Author}" +
               $" in {myBook.Year}. Price is {myBook.Price}");

        
        //Enums ausgeben
        Console.WriteLine("Day of Week: ", (int) DayOfWeek.Sunday, DayOfWeek.Sunday);
        Console.WriteLine("Day of Week: ", (int)DayOfWeek.Monday, DayOfWeek.Monday);
        Console.WriteLine("Day of Week: ", (int)DayOfWeek.Tuesday, DayOfWeek.Tuesday);
        Console.WriteLine("Day of Week: ", (int)DayOfWeek.Wednesday, DayOfWeek.Wednesday);
        Console.WriteLine("Day of Week: ", (int)DayOfWeek.Thursday, DayOfWeek.Thursday);
        Console.WriteLine("Day of Week: ", (int)DayOfWeek.Friday, DayOfWeek.Friday);
        Console.WriteLine("Day of Week: ", (int)DayOfWeek.Saturday, DayOfWeek.Saturday);
    }
    public static void methodtoshowref(ref int v6)
    {
        v6 = 100;
    }
}


/**
 * What is a class?
 * What is an object?
 * What is the difference between both?
 */
class A
{
    /**
 * What is a Reference Type?
 * A value type is basically stored on the heap and passed by creating a reference.
 * 
 * DE: Ein Werttyp wird grundsätzlich auf dem Heap gespeichert und durch die Erzeugung einer Referenz übergeben.
 */

    public int value
    {
        get;
        set;
    }

    public void SetValue(int passbyref)
    {
        this.value = passbyref;

    }

}

/**
         * What is a C# Struct type?
         * A struct type is a value that is typically used to encapsulate a group of variables that are similar. A struct type can declare constructors, constants, fields, methods, properties, indexers, operators, and nested types.
         * 
         * 
         * DE: Ein Strukturtyp ist ein Wertetyp, der in der Regel verwendet wird, um eine Gruppe von Variablen zu kapseln, die ähnlich sind.
         * Ein struct-Typ kann Konstruktoren, Konstanten, Felder, Methoden, Eigenschaften (Properties), Indexer, Operatoren und verschachtelte Typen deklarieren.
         */

public struct Book
{
    public string Title;
    public string Author;
    public decimal Price;
    public short Year;
}


/**
 * What are Enums?
 * Enums in C# are used to represent a set of constants as integral values.
 * For example, to represent a week day, we know there are only seven days in a week.
 * 
 * 
 * DE: Enums in C# werden verwendet, um eine Reihe von Konstanten als ganze Werte darzustellen.
 * Um zum Beispiel einen Wochentag darzustellen, wissen wir, dass es nur sieben Tage in einer Woche gibt.
 * 
 */

//Create an enum of week days
public enum WeekDays { Sun, Mon, Tue, Wed, Thu, Fri, Sat};

//Create an enum of RGB colors
public enum RGB { Red, Green, Blue};

