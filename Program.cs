//incluido blibliotecas
using System;
using System.Globalization;
//nome 
namespace couse
{
    // criando a classe programa
    public class Triangulo
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public double CalculoArea()
        {
            double p = (a + b + c) / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

    }
    public class program
    {


        //programa principal
        public static void Main(string[] args)
        {
            //variaveis double para calculos grandes, e funcoes para facilitar o programa
            Triangulo x = LerTriangulo("X");
            Triangulo y = LerTriangulo("Y");
            //variaveis da area, pegar a mdedida da funcao para fazer o calculo
            double areaX = x.CalculoArea();
            double areaY = y.CalculoArea();

            Console.WriteLine("Area de x = " + areaX.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Y = " + areaY.ToString(CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area = X");
            }
            else
            {
                Console.WriteLine("maior area = Y");
            }
        }
        // funcao atribuido os valores e array
        public static Triangulo LerTriangulo(string nometriangulo)
        {
            // colocando a quantidade de numeros na array
           Triangulo triangulo = new Triangulo();
            // interface de usuario de atribuicao de valores do triangulo
            Console.WriteLine("Entre com as medidas do triangulo " + nometriangulo + ":");
            //variavel de repeticao aonde irar passar por todos os resultados e colocando os valores na array
            triangulo.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //return
            return triangulo;
        }
    }
}
