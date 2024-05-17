using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen__Sharp_I_Parcial
{
     class Alumno
    {
        private string NombreAlumno, NumeroCuenta, Email;
        public string getNombreAlumno()
        {
            return NombreAlumno;
        }

        public void setNombreAlumno(string NombreAlumno)
        {
            this.NombreAlumno = NombreAlumno;
        }

        public string getNumeroCuenta()
        {
            return NumeroCuenta;
        }

        public void setNumeroCuenta(string NumeroCuenta)
        {
            this.NumeroCuenta = NumeroCuenta;
        }

        public string getEmail()
        {
            return Email;
        }

        public void setEmail(string Email)
        {
            this.Email = Email;
        }
    }
}
