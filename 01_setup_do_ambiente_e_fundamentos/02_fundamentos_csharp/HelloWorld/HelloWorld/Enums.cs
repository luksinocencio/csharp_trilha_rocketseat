namespace HelloWorld;

public class Enums
{
    /**
     * Enum nao pode ser criado dentro de um metodo
     */
    enum NivelDeDificuldade 
    {
        Baixo = 0,
        Medio = 1,
        Alto = 2
    }

    public static void Executar()
    {
        NivelDeDificuldade nivel = NivelDeDificuldade.Alto;
        int nivelInteiro = (int)nivel;
        Console.WriteLine(nivel);
        Console.WriteLine(nivelInteiro);
    }
}

