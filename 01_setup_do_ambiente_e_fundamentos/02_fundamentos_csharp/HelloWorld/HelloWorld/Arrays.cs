namespace HelloWorld;

// Arrays tem o tamanho fixos

public class Arrays
{
    public static void Executar()
    {
        //int[] inteiros = new int[10];
        //Console.WriteLine(inteiros.Length);

        //inteiros[0] = 1;
        //inteiros[1] = 10;
        //inteiros[2] = 7;

        //Console.WriteLine(inteiros[0]);
        //Console.WriteLine(inteiros[1]);
        //Console.WriteLine(inteiros[2]);
        //Console.WriteLine(inteiros);

        //int[] inteiros = [1, 10, 7];
        //Console.WriteLine(inteiros[0]);
        //Console.WriteLine(inteiros[1]);
        //Console.WriteLine(inteiros[2]);
        //Console.WriteLine(inteiros.Length);

        int[,] inteiros = new int[10, 10];

        inteiros[0, 0] = 1;
        inteiros[0, 3] = 2;

        Console.WriteLine(inteiros[0, 0]);
        Console.WriteLine(inteiros[0, 1]);
        Console.WriteLine(inteiros[0, 2]);
        Console.WriteLine(inteiros[0, 3]);
    }
}
