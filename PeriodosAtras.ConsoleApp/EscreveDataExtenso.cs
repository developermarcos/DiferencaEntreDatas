using System;
namespace PeriodosAtras.ConsoleApp
{
    public class EscreveDataExtenso
    {
        public string Horas(TimeSpan horas)
        {
            string data;

            if(horas.Hours > 0)
            {
                data = HorasPorExtenso(horas.Hours) + " hora(s), ";
                data += NumeroPorExtenso(horas.Minutes) + " minutos(s) e ";
                data += NumeroPorExtenso(horas.Seconds) + " segundos(s) de diferença entre datas";
            }
            else if(horas.Minutes > 0)
            {
                data = NumeroPorExtenso(horas.Minutes) + " minutos(s) e ";
                data += NumeroPorExtenso(horas.Seconds) + " segundos(s) de diferença entre datas";
            }
            else
                data = NumeroPorExtenso(horas.Seconds) + " segundos(s) de diferença entre datas";

            return data;
        }

        public string Dias(int dias)
        {
            string data;

            data = NumeroPorExtenso(dias) + " dia(s) de diferença entre datas";

            return data;
        }

        public string Meses(int meses, int dias)
        {
            string data;
            if (dias > 0)
                data = NumeroPorExtenso(meses) + " mes(es) e " +  NumeroPorExtenso(dias) + " dias de diferença entre datas";
            else
                data = NumeroPorExtenso(meses) + " mes(es) de diferença entre datas";
            return data;
        }

        public string Ano(int ano)
        {
            string data;

            data = NumeroPorExtenso(ano) + " ano(s) de diferença entre datas";

            return data;
        }

        private string NumeroPorExtenso(int valor)
        {
            string numero = "";
            switch (valor)
            {
                case 0:
                    numero = "Zero";
                    break;
                case 1: 
                    numero = "Um"; 
                    break;
                case 2:
                    numero = "Dois";
                    break;
                case 3:
                    numero = "Tres";
                    break;
                case 4:
                    numero = "Quatro";
                    break;
                case 5:
                    numero = "Cinco";
                    break;
                case 6:
                    numero = "Seis";
                    break;
                case 7:
                    numero = "Sete";
                    break;
                case 8:
                    numero = "Oito";
                    break;
                case 9:
                    numero = "Nove";
                    break;
                case 10:
                    numero = "Dez";
                    break;
                case 11:
                    numero = "Onze";
                    break;
                case 12:
                    numero = "Doze";
                    break;
                case 13:
                    numero = "Treze";
                    break;
                case 14:
                    numero = "Quatorze";
                    break;
                case 15:
                    numero = "Quinze";
                    break;
                case 16:
                    numero = "Dezesseis";
                    break;
                case 17:
                    numero = "Dezessete";
                    break;
                case 18:
                    numero = "Dezoito";
                    break;
                case 19:
                    numero = "Dezenove";
                    break;
                case 20:
                    numero = "Vinte";
                    break;
                case 21:
                    numero = "Vinte e um";
                    break;
                case 22:
                    numero = "Vinte e dois";
                    break;
                case 23:
                    numero = "Vinte e três";
                    break;
                case 24:
                    numero = "Vinte e quatro";
                    break;
                case 25:
                    numero = "Vinte e cinco";
                    break;
                case 26:
                    numero = "Vinte e seis";
                    break;
                case 27:
                    numero = "Vinte e sete";
                    break;
                case 28:
                    numero = "Vinte e oito";
                    break;
                case 29:
                    numero = "Vinte e nove";
                    break;
                case 30:
                    numero = "Trinta";
                    break;
            }
            return numero;
        }

        private string HorasPorExtenso(int valor)
        {
            string numero = "";
            switch (valor)
            {
                case 00:
                    numero = "Meia noite";
                    break;
                case 1:
                    numero = "Uma";
                    break;
                case 2:
                    numero = "Duas";
                    break;
                case 3:
                    numero = "Tres";
                    break;
                case 4:
                    numero = "Quatro";
                    break;
                case 5:
                    numero = "Cinco";
                    break;
                case 6:
                    numero = "Seis";
                    break;
                case 7:
                    numero = "Sete";
                    break;
                case 8:
                    numero = "Oito";
                    break;
                case 9:
                    numero = "Nove";
                    break;
                case 10:
                    numero = "Dez";
                    break;
                case 11:
                    numero = "Onze";
                    break;
                case 12:
                    numero = "Doze";
                    break;
            }
            return numero;
        }
    }
}
