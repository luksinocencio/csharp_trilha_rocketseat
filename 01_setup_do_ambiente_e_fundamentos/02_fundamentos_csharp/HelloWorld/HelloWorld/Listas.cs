using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld;

public class Listas
{
    public static void Executar()
    {
        List<int> inteiros = new List<int>();
        inteiros.Add(1);
        inteiros.Add(2);
        inteiros.Add(3);

        Console.WriteLine(inteiros.Count);

        inteiros.RemoveAt(0);

        Console.WriteLine(inteiros.Count);
        
        List<string> strings = new List<string>();
        strings.Add("Hello");
        strings.Add("World");

        string resultado = string.Join(" ", strings);

        Console.WriteLine(resultado);


        foreach (string n in strings)
        {
            Console.WriteLine(n);
        }

    }
}
