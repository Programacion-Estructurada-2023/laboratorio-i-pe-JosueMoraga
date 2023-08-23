using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            //Declaracion de variables de tipo texto

            string? departamento;
            string? municipio;
            string? ciudad;

            Console.Write("\n ingrese el nombre de su departamento: ");
            departamento = Console.ReadLine();

            Console.Write("\n Ingrese el nombre de su municipio ");
            municipio = Console.ReadLine();

            Console.WriteLine("\n Ingrese el nombre de su ciudad ");
            ciudad = Console.ReadLine();

            string? colonia = " Ciudad Pacifica ";
            string? colorCasa = " Casa color azul ";

            //Declaracion de variables tipo enteras

            int añosResidencia;
            int edad;

            Console.Write("\n Ingrese cuantos años tiene de vivir en la residencia actual ");
            añosResidencia = Convert.ToInt32 (Console.ReadLine());

            Console.Write("\n Que edad tiene ");
            edad = Convert.ToInt32 (Console.ReadLine());

            //Declaracion de variables tipo date time

            DateTime fechaNacimiento = new DateTime(2002, 05,15);
            DateTime fechaActual = DateTime.Now;

            //APLICACION DE FUNCIONES 

            //Funcion para comparar cadenas
            Console.WriteLine("\n ************ COMPARACION DE CADENAS ************ ");
            Console.WriteLine("\n Colonia y Ciudad son iguales? >>> " + string.Equals(colonia, ciudad));
            Console.WriteLine("\n Municipio y Ciudad son iguales? >>> " + string.Equals(municipio, ciudad));

            //Funcion para concatenar texto

            string? concatenacion = departamento + " " + municipio +"  "+ ciudad;
            Console.WriteLine("\n Concatenación de texto >>> " + concatenacion);

            //Funcion de mayuscula

            string? mayusculas = departamento.ToUpper();
            Console.WriteLine("\n Departamento en mayúsculas >>> " + mayusculas);

            //Funcion de limpiado de cadena

            string? limpiado = municipio.Trim();
            Console.WriteLine("\n Municipio limpiado de espacios >>> " + limpiado);

            //Funcion de longitud de cadena

            int longitudColonia = colonia.Length;
            int longitudColorCasa = colorCasa.Length;
            Console.WriteLine("\n Longitud de la Colonia >>> " + longitudColonia);
            Console.WriteLine("\n Longitud del Color de Casa >>> " + longitudColorCasa);

            //VARIABLES DE TIPO TEXTO DECLARADAS

            //Funcion de formateo de fecha 

            Console.WriteLine("\n\n************FORMATEO DE FECHAS************");
            Console.WriteLine("\n Fecha de nacimiento >>> " + fechaNacimiento.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n Fecha actual >>> " + fechaActual.ToString("dd/MM/yyyy"));

            //Adicion de 2 semanas a las fechas

            DateTime fechaNacimientoMas2Semanas = fechaNacimiento.AddDays(14);
            DateTime fechaActualMas2Semanas = fechaActual.AddDays(14);

            Console.WriteLine("\n\n************FECHAS CON 2 SEMANAS ADICIONALES************");
            Console.WriteLine("\n Fecha de nacimiento + 2 semanas >>> " + fechaNacimientoMas2Semanas.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n Fecha actual + 2 semanas >>> " + fechaActualMas2Semanas.ToString("dd/MM/yyyy"));

            //Funcion para comparar fechas

            bool fecha1Mayor = fechaNacimiento > fechaActual;
            bool fecha1Menor = fechaNacimiento < fechaActual;
            Console.WriteLine("\n Fecha de nacimiento mayor que fecha actual? >>> " + fecha1Mayor);
            Console.WriteLine("\n Fecha de nacimiento menor que fecha actual? >>> " + fecha1Menor);

            //IMPRESION DE VALORES EN CONSOLA

            //Impresion de valores ingresados de las variables tipo texto

            Console.WriteLine(" \n\n*************************************\n ");
            Console.WriteLine("\n-------- INICIO DE IMPRESION DE VALORES --------" );
            Console.WriteLine("\n\n************ VALORES INGRESADOS DE VARIABLES DE TEXTO ************");
            Console.WriteLine("\n Departamento >>> " + departamento);
            Console.WriteLine("\n Municipio >>> " + municipio);
            Console.WriteLine("\n Ciudad >>> " + ciudad);
            Console.WriteLine("\n Colonia >>> " + colonia);
            Console.WriteLine("\n Color de Casa >>> " + colorCasa); 

            //Impresion de valores de las variables enteras

            Console.WriteLine("\n\n************VALORES DE VARIABLES ENTERAS************");
            Console.WriteLine("\n Años de vivir en la residencia actual >>> " + añosResidencia);
            Console.WriteLine("\n Edad actual >>> " + edad);

            //Impresion de valores ingresados en las comparaciones de cadenas

            Console.WriteLine("\n\n************COMPARACION DE CADENAS************");
            Console.WriteLine("\n Colonia y Ciudad son iguales >>> " + string.Equals(colonia, ciudad));
            Console.WriteLine("\n Municipio y Ciudad son iguales >>> " + string.Equals(municipio, ciudad));

            //Impresion de valores obtenidos de las funciones de fecha

            Console.WriteLine("\n\n************VALORES OBTENIDOS DE FUNCIONES DE FECHA************");
            Console.WriteLine("\n Fecha de nacimiento >>> " + fechaNacimiento.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n Fecha actual >>> " + fechaActual.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n----------------FIN DE IMPRESION----------------\n\n");
            Console.WriteLine("\n\n\n*************************************************************************\n");

            //AUTOEVALUACION 10/10


        }
    }
}