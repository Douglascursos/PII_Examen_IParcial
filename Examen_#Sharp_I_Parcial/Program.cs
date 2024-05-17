// See https://aka.ms/new-console-template for more information
using Examen__Sharp_I_Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

 string nota1, nota2, nota3;
    
    Asignatura alumno1 = new Asignatura();

    Console.WriteLine("Ingrese nota del primer parcial:");
    nota1 = Console.ReadLine();
    Console.WriteLine("Ingrese nota del segundo parcial:");
    nota2 = Console.ReadLine();
    Console.WriteLine("Ingrese nota del tercer parcial:");
    nota3 = Console.ReadLine();


    if (nota1 == null || nota2 == null || nota3 == null || nota1 == "" || nota2 == "" || nota3 == "")
{
    Console.WriteLine("Ingresa notas validas");
    Console.WriteLine("Ingrese nota del primer parcial:");
    nota1 = Console.ReadLine();
    Console.WriteLine("Ingrese nota del segundo parcial:");
    nota2 = Console.ReadLine();
    Console.WriteLine("Ingrese nota del tercer parcial:");
    nota3 = Console.ReadLine();
} else
{
    if (Convert.ToInt32(nota1) > 30 || Convert.ToInt32(nota2) > 30 || Convert.ToInt32(nota3) > 40)
    {
        Console.WriteLine("Una de las notas no tiene el formato valido");
        Console.WriteLine("Nota 1 y 2 deben ser menor o igual a 30 y nota 3 menor o igual 40");
        Console.WriteLine("Ingrese nota del primer parcial:");
        nota1 = Console.ReadLine();
        Console.WriteLine("Ingrese nota del segundo parcial:");
        nota2 = Console.ReadLine();
        Console.WriteLine("Ingrese nota del tercer parcial:");
        nota3 = Console.ReadLine();
    } else
    {
        alumno1.N1 = Convert.ToInt32(nota1);
        alumno1.N2 = Convert.ToInt32(nota2);
        alumno1.N3 = Convert.ToInt32(nota3);

        Console.WriteLine("Ingrese el nombre del alumno:");
        alumno1.setNombreAlumno(Console.ReadLine());
        Console.WriteLine("Ingrese el numero de cuenta:");
        alumno1.setNumeroCuenta(Console.ReadLine());
        Console.WriteLine("Ingrese el correo electronico:");
        alumno1.setEmail(Console.ReadLine());
        Console.WriteLine("Ingrese el nombre de la asignatura:");
        alumno1.setNombreAsignatura(Console.ReadLine());
        Console.WriteLine("Ingrese el horario:");
        alumno1.setHorario(Console.ReadLine().Insert(1, ":"));
        Console.WriteLine("Ingrese el nombre del docente:");
        alumno1.setNombreDocente(Console.ReadLine());
        alumno1.Imprimir();
    }
}

































