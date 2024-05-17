using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen__Sharp_I_Parcial
{
    class Asignatura : Alumno, IAsignatura
    {

        public int N1, N2, N3;
        private string NombreAsignatura, Horario, NombreDocente;

        public string getNombreAsignatura()
        {
            return NombreAsignatura;
        }

        public void setNombreAsignatura(string NombreAsignatura)
        {
            this.NombreAsignatura = NombreAsignatura;
        }

        public string getHorario()
        {
            return Horario;
        }

        public void setHorario(string Horario)
        {
            this.Horario = Horario;
        }

        public string getNombreDocente()
        {
            return NombreDocente;
        }

        public void setNombreDocente(string NombreDocente)
        {
            this.NombreDocente = NombreDocente;
        }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(double N1, double N2, double N3)
        {
            return N1 + N2 + N3;
        }

        public void Imprimir()
        {

            Console.WriteLine(
                
                "Nombre del estudiante:" + getNombreAlumno() + "\n" +
                "Numero de cuenta: " + getNumeroCuenta() + "\n" +
                "Correo electronico: " + getEmail() + "\n" +
                "Nombre de la Asignatura: " + getNombreAsignatura() + "\n" +
                "Horario: " + getHorario() + "\n" +
                "Nombre del docente: " + getNombreDocente() + "\n" +
                "Nota final: " + CalcularNotaFinal() + "%" + " - " + MensajeNotaFinal(N1 + N2 + N3) + "\n" +
                "Nota final: " + CalcularNotaFinal() + "%" + " - " + MensajeNotaFinal(N1 + N2 + N3)
                ); 
        }

        public string MensajeNotaFinal(double notaFinal)
        {   
            string x = "";
            if (notaFinal >= 0 && notaFinal <= 59)
            {
                x = "Reprobado";
            } else if (notaFinal >= 60 && notaFinal <= 79)
            {
                x = "Bueno";
            }
            else if (notaFinal >= 80 && notaFinal <= 89)
            {
                x = "Muy bueno";
            } else if (notaFinal >= 90 && notaFinal <= 100)
            {
                x = "Excelente";
            }
            return x;
        }
    }

   

    }

