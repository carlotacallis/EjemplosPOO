using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circulo miCirculo; //creacion objeto circulo. variable de tipo circulo (objeto con propiedad pi y metodo calcularArea)

            miCirculo= new Circulo(); //Iniciación de variable/objetos de tipo Circulos. Instanciar una clase. Ejemplarizacion


            Console.WriteLine(miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.CalculoArea(9));

           

            ConversorEuroDolar obj= new ConversorEuroDolar();

            obj.cambiaValorEuro(1.45);

            Console.WriteLine(obj.convierte(50));
            Circulo circulo2= new Circulo();
            circulo2.CalculoArea(6);

            Circulo circulo3 = new Circulo();
            circulo3.CalculoArea(10);

            Circulo circulo4= new Circulo();
            circulo4.CalculoArea(13);

        }
    }
    class Circulo
    {
        private const double pi = 3.1416; //propiedad de la clase circulo. Campo de clase.
        
        public double CalculoArea(int radio) //metodo de clase. Nos especifica que puede hacer el objeto circulo
        {

            return pi * radio * radio;
        }


    }

    class ConversorEuroDolar
    {

        private double euro = 1.253;

        public double convierte(double cantidad)
        {
            return cantidad * euro;

        }

        public void cambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;

            else

             euro = nuevoValor;


        }

    }


}
