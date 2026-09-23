using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento
{
    internal class Program
    {
        static public void Leer(int[] N)

        {

            for (int i = 0; i < N.Length; i++)

            {

                Console.Write("edad[" + i + "]=");

                N[i] = int.Parse(Console.ReadLine());

            }

        }

        static public void Escribir(int[] N)

        {

            for (int i = 0; i < N.Length; i++)

            {

                Console.WriteLine("edad[" + i + "]: " + N[i]);

            }

        }

        static public void ordenar_Asc(int[] N)

        {

            int aux;

            for (int i = 0; i < N.Length - 1; i++)

            {

                for (int j = 0; j < N.Length - 1 - i; j++)

                {

                    if (N[j] > N[j + 1])

                    {

                        aux = N[j];

                        N[j] = N[j + 1];

                        N[j + 1] = aux;

                    }

                }

            }

        }

        static public void ordenar_Desc(int[] N)

        {

            int aux;

            for (int i = 0; i < N.Length - 1; i++)

            {

                for (int j = 0; j < N.Length - 1 - i; j++)

                {

                    if (N[j] < N[j + 1])

                    {

                        aux = N[j];

                        N[j] = N[j + 1];

                        N[j + 1] = aux;

                    }

                }

            }

        }

        static public void orden_seleccion(int[] N)

        {

            int aux;

            for (int i = 0; i < N.Length - 1; i++)

            {

                int minimo = i;

                for (int j = i + 1; j < N.Length; j++)

                {

                    if (N[j] > N[minimo])

                    {

                        minimo = j;

                    }

                }

                aux = N[i];

                N[i] = N[minimo];

                N[minimo] = aux;

            }

        }

        static public void orden_seleccion_desc(int[] N)

        {

            int aux;

            for (int i = 0; i < N.Length - 1; i++)

            {

                int maximo = i;

                for (int j = i + 1; j < N.Length; j++)

                {

                    if (N[j] < N[maximo])

                    {

                        maximo = j;

                    }

                }

                aux = N[i];

                N[i] = N[maximo];

                N[maximo] = aux;

            }

        }

        static void Main(string[] args)

        {

            int n;

            Console.Write("Ingrese la dimensión del arreglo: ");

            n = int.Parse(Console.ReadLine());

            int[] edad = new int[n];

            Leer(edad);

            Console.WriteLine("***********************");

            Console.WriteLine("ARREGLO SIN ORDENAR");

            Console.WriteLine("***********************");

            Escribir(edad);

            Console.WriteLine("***********************");

            Console.WriteLine("ORDENAMIENTO ASCENDENTE");

            Console.WriteLine("***********************");

            ordenar_Asc(edad);

            Escribir(edad);

            Console.WriteLine("***********************");

            Console.WriteLine("ORDENAMIENTO DESCENDENTE");

            Console.WriteLine("***********************");

            ordenar_Desc(edad);

            Escribir(edad);

            Console.WriteLine("***********************");

            Console.WriteLine("ORDENAMIENTO ASCENDENTE POR SELECCIÓN");

            Console.WriteLine("***********************");

            orden_seleccion(edad);

            Escribir(edad);

            Console.WriteLine("***********************");

            Console.WriteLine("ORDENAMIENTO DESCENDENTE POR SELECCIÓN");

            Console.WriteLine("***********************");

            orden_seleccion_desc(edad);

            Escribir(edad);

            Console.ReadKey();

        }



    }

}