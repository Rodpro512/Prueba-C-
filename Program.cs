using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola mundo");

        string variable1 = "Soy una cadena de texto";
        Console.WriteLine(variable1);

        int index;

        int variable2 = 8;
        Console.WriteLine(variable2);
        Console.WriteLine(variable2 - 1);

        float variable3 = 1.5f;
        Console.WriteLine(variable3);

        Console.WriteLine(variable1 + variable2 + variable3);

        dynamic variable4 = 6;
        Console.WriteLine(variable4);
        variable4 = "Ahora soy texto";
        Console.WriteLine(variable4);

        Console.WriteLine(variable1 + variable4); //Concatena los datos (Ahora soy texto 1)

        bool variable5 = true;
        Console.WriteLine(variable5);

        Console.WriteLine($"Mi dato int es: {variable2} y mi dato bool es: {variable5}");

        const string Variable6 = "Mi valor no cambia";
        Console.WriteLine(Variable6);

        for (index = 0; index < 10; index++)
        {
            Console.WriteLine(index);
        }

        if (variable2 < 6)
        {
            Console.WriteLine("Mi valor es menor que 6");
        }

        else if (variable2 > 7)
        {
            Console.WriteLine("Mi valor es mayor a 7");
        }

        else
        {
            Console.WriteLine("Mi valor no es menor que 6 ni mayor a 7");
        }

        string variable7 = "Soy otra cadena de texto";
        Console.WriteLine(variable7);
    }
}

