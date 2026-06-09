using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;

namespace ejerciciosfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            
            do
            {
                Console.Clear(); 
                Console.WriteLine("Seleccione un ejercicio:");
                Console.WriteLine("1. Contador de números del 1 al 10");
                Console.WriteLine("2. Suma de números del 1 al 100");
                Console.WriteLine("3. Tabla de multiplicar");
                Console.WriteLine("4. números pares");
                Console.WriteLine("5. Promedio de notas");
                Console.WriteLine("6. Arreglo de números");
                Console.WriteLine("7. Mayor y menor en un arreglo");
                Console.WriteLine("8. Contador de Positivos, Negativos y Ceros");
                Console.WriteLine("9. Búsqueda en un arreglo");
                Console.WriteLine("10. Frecuencia de valores");
                Console.WriteLine("11. Salir");
                Console.Write("Opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Contador_de_numeros();
                        break;
                    case 2:
                        Suma_de_num();
                        break;
                    case 3:
                        Tabla_de_multiplicar();
                        break;
                    case 4:
                        numeros_pares();
                        break;
                    case 5:
                        Promedio_de_notas();
                        break;
                    case 6:
                        Arreglo_de_numeros();
                        break;
                    case 7:
                        Mayor_y_menor_en_un_arreglo();
                        break;
                    case 8:
                        Contador_de_Positivos_Negativos_y_Ceros();
                        break;
                    case 9:
                        Busqueda_en_un_arreglo();
                        break;
                    case 10:
                        Frecuencia_Valores();
                        break;
                    case 11:
                        Console.WriteLine("Saliendo del programa... ¡Adiós!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 11);
        } 

        static void Contador_de_numeros()
        {
            Console.Clear();
            Console.WriteLine("--- Contador de números del 1 al 10 ---");

            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nPresione ENTER para volver al menú...");
            Console.ReadLine(); 
        }

        static void Suma_de_num()
        {
            Console.Clear();
            Console.WriteLine("--- Suma de números del 1 al 100 ---");

            int contador = 0;
            int suma = 0;

            while (contador < 101)
            {
                Console.WriteLine(contador);
                contador++;
                suma += contador;
            }
            Console.WriteLine("Resultado: {0}", suma);


            Console.WriteLine("\nPresione ENTER para volver al menú...");
            Console.ReadLine();
        }

        static void Tabla_de_multiplicar()
        {
            Console.Clear();
            Console.WriteLine("--- Tabla de multiplicar ---");

            Console.WriteLine("agrega un numero para crear la tabla: ");
            string? num = Console.ReadLine();

            int numero = int.Parse(num);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
            }


            Console.WriteLine("\nPresione ENTER para volver al menú...");
            Console.ReadLine();
        }

        static void numeros_pares()
        {
            Console.Clear();
            Console.WriteLine("--- Números pares ---");

            for (int i = 0; i < 51; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Es par {0}", i);
                }
                else
                {
                    Console.WriteLine("es impar {0}", i);
                }
            }

            Console.WriteLine("\nPresione ENTER para volver al menú...");
            Console.ReadLine();
        }

        static void Promedio_de_notas()
        {
            Console.Clear();
            Console.WriteLine("--- Promedio de notas ---");

            int Suma = 0;

            for (int notas = 1; notas < 6; notas++)
            {
                Console.WriteLine("agrega las notas:");
                string? num = Console.ReadLine();
                Suma += int.Parse(num);
            }
            Console.WriteLine("Esta es la suma: {0}", Suma);
            Console.WriteLine("El promedio es: {0}", Suma / 5);

            Console.WriteLine("\nPresione ENTER para volver al menú...");
            Console.ReadLine();
        }

        static void Arreglo_de_numeros()
        {
            Console.Clear();
            Console.WriteLine("--- Arreglo de números ---");

            int[] numeros = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese 5 números enteros:");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Los números ingresados son:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }

        Console.WriteLine("\nPresione ENTER para volver al menú...");
        Console.ReadLine();
        }

        static void Mayor_y_menor_en_un_arreglo()
        {
            Console.Clear();
            Console.WriteLine("--- Mayor y menor en un arreglo ---");

            int[] numeros = new int[10];
            int mayor = 0;
            int menor = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número:");
                int numero = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    mayor = numero;
                    menor = numero;
                }
                else
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
            }

            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("El número menor es: " + menor);


            Console.WriteLine("\nPresione ENTER para volver al menú...");
            Console.ReadLine();
        }

        static void Contador_de_Positivos_Negativos_y_Ceros()
        {
            Console.Clear();
            Console.WriteLine("--- Contador de Positivos, Negativos y Ceros ---");

            int[] numeros = new int[10];
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > 0)
                {
                    positivos++;
                }
                else if (numeros[i] < 0)
                {
                    negativos++;
                }
                else
                {
                    ceros++;
                }
            }

            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Ceros: " + ceros);

            Console.WriteLine("\nPresione ENTER para volver al menú...");
            Console.ReadLine();
        }

        static void Busqueda_en_un_arreglo()
        {
            Console.Clear();
            Console.WriteLine("--- Búsqueda en un arreglo ---");

            int[] numeros = { 5, 10, 15, 20, 25 };
            Console.WriteLine("Ingrese el valor a buscar:");
            int valorBuscado = int.Parse(Console.ReadLine());
            bool encontrado = false;
            int posicion = 0;
            int IndiceActual = 0;

            foreach (int numero in numeros )
            {
                if (numero == valorBuscado)
                {
                    encontrado = true;
                    posicion = IndiceActual;
                    break;
                }
                IndiceActual += 1;
            }

            if (encontrado)
            {
                Console.WriteLine("El número {0} existe en el arreglo y se encuentra en la posición {1}.", valorBuscado, posicion);
            }
            else
            {
                Console.WriteLine("El número {0} no existe en el arreglo.", valorBuscado);
            }

            Console.WriteLine("\nPresione ENTER para volver al menú...");
            Console.ReadLine();
        }

        static void Frecuencia_Valores()
        {
            Console.Clear();
            Console.WriteLine("--- Frecuencia de valores ---");

            int[] numeros = new int[10];
            int contador = 0;
            int repetidos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un número:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            while (contador < numeros.Length)
            {
                bool encontrado = false;
                for (int i = 0; i < contador; i++)
                {
                    if (numeros[contador] == numeros[i])
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    contador++;
                    continue;
                }
                repetidos = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[contador] == numeros[i])
                    {
                        repetidos = repetidos + 1;
                    }
                }
                if (repetidos > 1)
                {
                    Console.WriteLine("El número {0} se repite {1} veces.", numeros[contador], repetidos);
                }

                contador = contador + 1;
            }

            Console.WriteLine("\nPresione ENTER para volver al menú...");
            Console.ReadLine();
        }
    } 
}
