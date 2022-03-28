using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComparaDatas comparaDatas = new ComparaDatas();

            string diasDiferente = "15/03/2021 16:30:15";
            DateTime data = Convert.ToDateTime(diasDiferente);
            Console.WriteLine(comparaDatas.VerificaPeriodo(data));

            string diasDiferente2 = "15/01/2022 16:30:15";
            DateTime data2 = Convert.ToDateTime(diasDiferente2);
            Console.WriteLine(comparaDatas.VerificaPeriodo(data2));

            string diasDiferente3 = "15/03/2022 16:30:15";
            DateTime data3 = Convert.ToDateTime(diasDiferente3);
            Console.WriteLine(comparaDatas.VerificaPeriodo(data3));

            string diasDiferente4 = "28/03/2022 08:30:15";
            DateTime data4 = Convert.ToDateTime(diasDiferente4);
            Console.WriteLine(comparaDatas.VerificaPeriodo(data4));



            Console.ReadKey();
        }
    }
}
