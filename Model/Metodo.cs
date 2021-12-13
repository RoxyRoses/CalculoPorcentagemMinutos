using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorHoras.Model
{
    class Metodo
    {
        public string CalcularHorario(string horario)
        {
                string horas = horario.Substring(0, 2);
                double minutos = Double.Parse(horario.Substring(2, 2).Trim(':')) / 60;
                string conversao = horas + "." + minutos.ToString().Replace(@"0,", "");

                return conversao;
        }
    }
}
