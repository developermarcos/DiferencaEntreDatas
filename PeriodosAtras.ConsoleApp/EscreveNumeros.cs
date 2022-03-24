using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    internal class EscreveNumeros
    {
        
        public static string Escreve(int v)
        {
            string valor = Convert.ToString(v);
            string mensagem = "";
            string[] valores = valor.Split("");
            if(valores.Length == 1)
            {
                mensagem= EscreveUmAoVinte(valor);
            }
            else if (valores.Length == 2)
            {
                int valorToInt = Convert.ToInt32(valor);
                mensagem= EscreveVinteUmANoventaENove(mensagem, valores, valorToInt);

            }
            if (valores.Length == 3)
            {
                int valorToInt = Convert.ToInt32(valor);
                if (valorToInt <= 100 && valorToInt < 200)
                    mensagem = "CENTO E "+EscreveUmAoVinte(valores[1]);
                else if (valorToInt > 20 && valorToInt < 30)
                    mensagem = "DUZENTOS E "+ EscreveUmAoVinte(valores[1]);
                else if (valorToInt >= 30 && valorToInt < 40)
                    mensagem = "TREZENTOS E "+ EscreveUmAoVinte(valores[1]);
                return mensagem;

            }

            return mensagem;
        }

        private static string EscreveVinteUmANoventaENove(string mensagem, string[] valores, int valorToInt)
        {
            if (valorToInt <= 20)
                mensagem = EscreveUmAoVinte(valores[1]);
            else if (valorToInt > 20 && valorToInt < 30)
                mensagem = "VINTE e "+ EscreveUmAoVinte(valores[1]);
            else if (valorToInt >= 30 && valorToInt < 40)
                mensagem = "TRINTA e "+ EscreveUmAoVinte(valores[1]);
            else if (valorToInt >= 40 && valorToInt < 50)
                mensagem = "QUARENTA e "+ EscreveUmAoVinte(valores[1]);
            else if (valorToInt >= 50 && valorToInt < 60)
                mensagem = "CINQUENTA e "+ EscreveUmAoVinte(valores[1]);
            else if (valorToInt >= 60 && valorToInt < 70)
                mensagem = "SESSENTA e "+ EscreveUmAoVinte(valores[1]);
            else if (valorToInt >= 70 && valorToInt < 80)
                mensagem = "SETENTA e "+ EscreveUmAoVinte(valores[1]);
            else if (valorToInt >= 80 && valorToInt < 90)
                mensagem = "OITENTA e "+ EscreveUmAoVinte(valores[1]);
            else if (valorToInt >= 90 && valorToInt < 100)
                mensagem = "NOVENTA e "+ EscreveUmAoVinte(valores[1]);
            return mensagem;
        }

        private static string EscreveUmAoVinte(string valor)
        {
            string mensagem = "";

            if (valor == "1") mensagem += "UM";
            else if (valor == "2") mensagem += "DOIS";
            else if (valor == "3") mensagem += "TRÊS";
            else if (valor == "4") mensagem += "QUATRO";
            else if (valor == "5") mensagem += "CINCO";
            else if (valor == "6") mensagem += "SEIS";
            else if (valor == "7") mensagem += "SETE";
            else if (valor == "8") mensagem += "OITO";
            else if (valor == "9") mensagem += "NOVE";
            else if (valor == "11") mensagem += "Onze";
            else if (valor == "12") mensagem += "Doze";
            else if (valor == "13") mensagem += "Treze";
            else if (valor == "14") mensagem += "Quatorze";
            else if (valor == "15") mensagem += "Quinze";
            else if (valor == "16") mensagem += "Desseseis";
            else if (valor == "17") mensagem += "Dezesete";
            else if (valor == "18") mensagem += "Dezoito";
            else if (valor == "19") mensagem += "Dezenove";
            else if (valor == "20") mensagem += "Vinte";
            return mensagem;
        }
    }
}
