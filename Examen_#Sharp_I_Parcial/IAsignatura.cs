using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen__Sharp_I_Parcial
{
    interface IAsignatura
    {
        double CalcularNotaFinal();
        double CalcularNotaFinal(double N1, double N2, double N3);
        string MensajeNotaFinal(double notaFinal);
        void Imprimir();
    }
}
