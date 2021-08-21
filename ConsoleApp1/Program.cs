using Modeo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProcShowMessage();
            string message= GetMessage();
            Console.WriteLine(message);

            Person person = new Person();

            //Gracias set, puedo asignar a Hugo
            person.FirstName = "Hugo";

            person.LastName = "Torrico";
            person.Date1 =Convert.ToDateTime( "1988-05-04");

            //Gracias al get puedo obtener el valor
            Console.WriteLine(person.GetFullName());
            Console.WriteLine(person.GetMessage());


            Triangulo triangulo = new Triangulo();
            //Propiedades del triangulo
            triangulo.Base = 10;
            triangulo.Altura = 20;
            //Propiedades heredadas 
            triangulo.Area = 50;
            triangulo.Perimetro = 30;

            //Sobrecargas
            triangulo.CalcularArea(10, 20);
            triangulo.CalcularArea(10, 20, 30);


            Console.Read();
        }
        /// <summary>
        /// Procedimiento
        /// </summary>
        static void ProcShowMessage()
        {
            Console.WriteLine("Hello world");
        }

        static string GetMessage()
        {
            return "Hello world";
        }

    }
}
