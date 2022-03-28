using System;

namespace PeriodosAtras.ConsoleApp
{
    public class ComparaDatas
    {
        const int ano = 365;
        const int mes = 30;
        const int dia = 1;
        public DateTime dataAtual = DateTime.Now;
        
        public string VerificaPeriodo(DateTime data)
        {
            int diferencaDatas = (dataAtual - data).Days;
            
            if (diferencaDatas >= ano) {
                return DiferencaAno(diferencaDatas);
            }
            else if(diferencaDatas < ano && diferencaDatas > mes)
            {
                return DiferencaMeses(diferencaDatas);
            }
            else if (diferencaDatas < mes && diferencaDatas > dia)
            {
                return DiferencaDias(diferencaDatas);
            }
            else
            {
                TimeSpan diferencaData = dataAtual.Subtract(data);
                return DiferencaInferiorUmDias(diferencaData);
            }

        }

        private string DiferencaAno(int dias)
        {
            string dataExtenso;
            
            int quantidadeDeAnos = dias / ano;

            EscreveDataExtenso escreveData = new EscreveDataExtenso();

            dataExtenso = escreveData.Ano(quantidadeDeAnos);

            return dataExtenso;

        }

        private string DiferencaMeses(int dias)
        {
            string dataExtenso;

            int quantidadeMeses = dias / mes;
            int quantidadeExtraDias = dias - (mes * quantidadeMeses);

            EscreveDataExtenso escreveData = new EscreveDataExtenso();
            dataExtenso = escreveData.Meses(quantidadeMeses, quantidadeExtraDias);

            return dataExtenso;
        }

        private string DiferencaDias(int data)
        {
            string dataExtenso;

            EscreveDataExtenso escreveData = new EscreveDataExtenso();
            dataExtenso = escreveData.Dias(data);

            return dataExtenso;
        }

        private string DiferencaInferiorUmDias(TimeSpan data)
        {
            string dataExtenso;

            EscreveDataExtenso escreveData = new EscreveDataExtenso();
            dataExtenso = escreveData.Horas(data);

            return dataExtenso;
        }
    }
}
