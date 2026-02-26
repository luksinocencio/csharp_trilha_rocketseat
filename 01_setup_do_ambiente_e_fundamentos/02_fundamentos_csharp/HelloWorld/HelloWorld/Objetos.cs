namespace HelloWorld;

public class Objetos
{
    public static void Executar()
    {
        // var identifica o tipo atraves do compilador
        // object é tipo usado como "any"
        var minhaVariavel = new Carro();
        minhaVariavel.Ligar();

        object minhaVariavel2 = new Carro();
        minhaVariavel2.Equals(minhaVariavel);
    }
}

