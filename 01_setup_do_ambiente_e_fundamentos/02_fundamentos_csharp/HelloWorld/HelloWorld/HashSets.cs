using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld;

public class HashSets
{
    public static void Executar()
    {
        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(3);

        Console.WriteLine(set.Count);
    }
}
