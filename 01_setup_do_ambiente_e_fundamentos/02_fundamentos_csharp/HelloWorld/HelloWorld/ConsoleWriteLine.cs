namespace HelloWorld;

public class ConsoleWriteLine
{
    public static void Executar()
    {
        double numero1 = 3.14;
        float numero2 = 0.14f;
        decimal numero3 = 3.14m;
        double numero4 = 1.000;

        Console.WriteLine(numero1);
        Console.WriteLine(numero2);
        Console.WriteLine(numero3);
        Console.WriteLine(numero4);

        bool ativo = true;
        bool ativo2 = false;

        Console.WriteLine(ativo);
        Console.WriteLine(ativo2);

        char letra = 'A';
        char numero = '1';
        char characterEspecial = '@';

        string texto = "Este curso é muito bom";
        char primeiraLetra = texto[0];

        Console.WriteLine(texto);
        Console.WriteLine(primeiraLetra);
    }
}

