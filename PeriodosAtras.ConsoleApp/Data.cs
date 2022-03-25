using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class Data
    {
        public int ObterDiasDiferenca(string data)
        {
            DateTime dataInformada = Convert.ToDateTime(data);
            DateTime dataAtual = DateTime.Now;
            return (int)dataAtual.Subtract(dataInformada).TotalDays;
        }

        public int ObterAnosDiferenca(string data)
        {
            DateTime dataInformada = Convert.ToDateTime(data);
            DateTime dataAtual = DateTime.Now;

            int anoAtual = dataAtual.Year;
            int anoInformado = dataInformada.Year;

            return anoAtual - anoInformado;
        }

        public int ObterHorasDiferenca(string data)
        {
            DateTime dataInformada = Convert.ToDateTime(data);
            DateTime dataAtual = DateTime.Now;
            TimeSpan diferenca = dataAtual - dataInformada;

            return (int)diferenca.TotalHours;
        }

        public int ObterMinutosDiferenca(string data)
        {
            DateTime dataInformada = Convert.ToDateTime(data);
            DateTime dataAtual = DateTime.Now;
            TimeSpan diferenca = dataAtual - dataInformada;
            int numero = (int)diferenca.TotalMinutes;
            
            return numero;
        }

        public int ObterSegundosDiferenca(string data)
        {
            DateTime dataInformada = Convert.ToDateTime(data);
            DateTime dataAtual = DateTime.Now;
            TimeSpan diferenca = dataInformada - dataAtual;

            return (int)diferenca.TotalSeconds;
        }

        public string DifencaEntreDatas(string data)
        {
            string resultado = "";

            if (ObterAnosDiferenca(data) > 0 && ObterDiasDiferenca(data) >= 365)//ano
            {
                resultado += EscreveNumeros.Escreve(ObterAnosDiferenca(data));
                Console.WriteLine(resultado + " ANO(S)");
            }
            else if (ObterDiasDiferenca(data) > 0 && ObterHorasDiferenca(data) >= 24)//dias
            {
                resultado += EscreveNumeros.Escreve(ObterDiasDiferenca(data));
                Console.WriteLine(resultado+" DIA(S)");
            }
            else if (ObterHorasDiferenca(data) > 0 && ObterMinutosDiferenca(data) >= 60)//horas
            {
                resultado += EscreveNumeros.Escreve(ObterHorasDiferenca(data));
                Console.WriteLine(resultado+" HORA(S)");
            }
            else if (ObterMinutosDiferenca(data) > 0)//minutos
            {
                resultado += EscreveNumeros.Escreve(ObterMinutosDiferenca(data));
                Console.WriteLine(resultado+" MINUTO(S)");
                
            }
            else if (ObterSegundosDiferenca(data) > 0 && ObterSegundosDiferenca(data) < 60)//segundos
            {
                resultado += EscreveNumeros.Escreve(ObterSegundosDiferenca(data));
                Console.WriteLine(resultado+" SEGUNDO(S)");
            }
            return resultado;
        }
    }
}
