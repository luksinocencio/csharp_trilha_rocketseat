using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class DataEHora
    {
        public static void Executar()
        {
            DateOnly dia = new DateOnly(2013, 12, 1);
            
            string diaEmTexto = dia.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));
            Console.WriteLine(diaEmTexto);

            DateTime dial = new DateTime(2013, 12, 1);
            Console.WriteLine(dial);
        }
    }
}
