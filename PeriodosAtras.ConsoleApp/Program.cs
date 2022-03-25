using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data dataComparar = new Data();
            string resultado;
            
            string anoDiferente = "24/03/2021 16:30:15";
            string diasDiferente = "15/03/2022 16:30:15";
            string horasDiferente = "25/03/2022 08:30:15";
            string minutosDiferente = "25/03/2022 10:45:15";
            string segundosDiferente = "25/03/2022 11:02:00";

            dataComparar.DifencaEntreDatas(anoDiferente);
            dataComparar.DifencaEntreDatas(diasDiferente);
            dataComparar.DifencaEntreDatas(horasDiferente);
            dataComparar.DifencaEntreDatas(minutosDiferente);
            dataComparar.DifencaEntreDatas(segundosDiferente);
            
            Console.ReadKey();
        }
    }
}
