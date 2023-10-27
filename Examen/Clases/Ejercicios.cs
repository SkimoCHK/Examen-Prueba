using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    public class Ejercicios
    {
        public void BusquedaLineal()
        {

            int[] array1 = { 55, 34, 87, 26, 24, 14 };

            Console.WriteLine("Por favor, ingresa un numero para comprobar si existe en el arreglo de numeros pendejo");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;
            int contador = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (numero == array1[i])
                {
                    ;
                    encontrado = true;
                    break;
                }

                contador++;
            }
            if (encontrado)
            {
                Console.WriteLine($"El numero que ingresaste se encuentra en la posicion {contador} del arreglo ");
            }
            else
            {
                Console.WriteLine("El numero no existe puto pendejo de mierda");
            }


        }
        public void Busquedabinaryxd()
        {
            int[] array1 = { 20, 34, 52, 77, 94, 104 };
            Console.WriteLine("Ingresa un numero para ver si existe en el arreglo");
            int numero = Convert.ToInt32(Console.ReadLine());
            int inicio = 0;
            int final = array1.Length - 1;
            int posicion = -1;
 
            while(inicio <= final)
            {
                int medio = (inicio + final) / 2;
                if(numero == array1[medio])
                {
           
                    posicion = medio;
                    break;
                }
                else if (numero > array1[medio])
                {
                    inicio = medio + 1;
                }
                else
                {
                    final = medio - 1;
                }

            }

            if(posicion != -1)
            {
                Console.WriteLine($"El numero existe en la posicon {posicion} del arreglo");
            }
            else
            {
                Console.WriteLine("Sorry, no existe");
            }


        }
        //Escribe un programa en C# que realice una búsqueda lineal para encontrar un número par en un arreglo de números enteros.
        //El programa debe imprimir la primera posición en la que se encuentra un número par en el arreglo
        
        public void busquedapar()
        {

            int[] array1 = { 55, 34, 12, 27, 24, 14 };
            int contador = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {

                    Console.WriteLine($"El primer numero par encontrado es {array1[i]} y se encuentra en la posicion {i} del arreglo");
                    break;
                }

            }


        }
        public void busquedapares()
        {
            int[] array1 = { 55, 34, 12, 27, 24, 14 };
            int contador = 0;
            for(int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    Console.WriteLine($"Se encontro el numero par  {array1[i]} y se encuentra en la posicion {i} del arreglo");
                }
            }
        }


        public void EncontrarNumero()
        {
            int[] array1 = {20,34,52, 77, 94, 104 };
            Console.WriteLine("Ingresa un numero pa ver si existe alv pendejo estupido");
            int numero = Convert.ToInt32(Console.ReadLine());
            int inicio = 0;
            int final = array1.Length - 1;
            bool encontrado = false;
            int posicion = -1;
            while (inicio <= final)
            {
                int medio = (inicio + final) / 2;

                if(numero == array1[medio])
                {
                    encontrado = true;
                    posicion = medio;
                    break;
                }
                else if (numero < array1[medio])
                {
                    final = medio - 1;
                }
                else
                {
                    inicio = medio + 1;
                }

            } 

            if(encontrado)
            {
                Console.WriteLine($"El numero se encontro en la posicion {posicion} del arreglo puto");
            }
            else
            {
                Console.WriteLine("No se encontro ala verga pendejo de mierda");
            }

        }

        public void EncontrarFruta()
        {
            string[] frutas = { "Albaricoque", "Banana" ,"Cereza", "Higo", "Manzana", "Pera" };
            Console.WriteLine("Ingresa un nombre de una fruta pa ver si existen en el arreglo puto");
            string fruta = Console.ReadLine();
            int inicio = 0;
            int final = frutas.Length - 1;
            int posicion = -1;

            while (inicio <= final) {

                int medio = (inicio + final) / 2;
                int compaparacion = string.Compare(fruta, frutas[medio]);
                if (fruta == frutas[medio])
                {
                    posicion = medio;
                    break;
                }
                else if (compaparacion > 0)
                {
                    inicio = medio+1;
                }
                else
                {
                    final = medio - 1;
                }

            }

            if(posicion != -1)
            {
                Console.WriteLine($"La fruta que buscaste existe en la posicion {posicion} del arreglo");

            }
            else
            {
                Console.WriteLine("No hay carnal");
            }

        }
        public void OrdenamientoPorSeleccion()
        {
            int[] array1 = { 5, 2, 3, 9, 6, 4 };
            int temp;
            Console.WriteLine(string.Join(",", array1));
            // Paso 1: Recorremos el arreglo elemento por elemento (excepto el último).
            for (int i = 0; i < array1.Length - 1; i++)
            {
                // Paso 2: Suponemos que el elemento actual (array1[i]) es el mínimo.
                int indiceMinimo = i;

                // Paso 3: Comparamos el elemento actual con el resto del arreglo.
                for (int j = i + 1; j < array1.Length; j++)
                {
                    // Paso 4: Si encontramos un elemento menor, actualizamos el índice del mínimo.
                    if (array1[j] < array1[indiceMinimo])
                    {
                        indiceMinimo = j;
                    }
                }

                // Paso 5: Intercambiamos el elemento actual con el elemento mínimo encontrado.
                temp = array1[i];
                array1[i] = array1[indiceMinimo];
                array1[indiceMinimo] = temp;
            }

            // Paso 6: Imprimimos el arreglo ordenado.
            Console.WriteLine(string.Join(",", array1));
        }
        public void OrdenamientoSeleccion()
        {
            int[] array1 = { 8, 1, 4, 2, 7, 10 };
            int temp;
            Console.WriteLine("Arreglo sin ordenar");
            Console.WriteLine (string.Join(",", array1));

            for (int i = 0; i < array1.Length - 1; i++)
            {
                int indiceminimo = i;

                for(int j = i + 1;j < array1.Length; j++)
                {
                    if (array1[j] < array1[indiceminimo])
                    {
                        indiceminimo = j;
                    }
                }
                temp = array1[i];
                array1[i] = array1[indiceminimo];
                array1[indiceminimo] = temp;

            }
            Console.WriteLine("Indice ordenado");
            Console.WriteLine(string.Join(",", array1));

        }
        ///Escribe un programa que ordene una matriz de numeros enteros en orden ascendente 
        /// Escribe un programa que ordene una matriz de numeros enteros en orden ascendente 
        /// utilizando el algoritmo de ordenamiento por seleccion. 
        /// El programa pedir al usuario que ingrese el tamaño del arreglo y los elementos del mismo.
        ///
        //
        public void Seleccion()
        {
            Console.WriteLine("Por favor, escriba la longitud del arreglo");
            int longitud = Convert.ToInt32(Console.ReadLine());
            
            int[] arregloxd = new int[longitud];

            Console.WriteLine("Ahora por favor escriba los valores de cada elemento del arreglo por favor");
            for (int i = 0; i < arregloxd.Length; i++)
            {
                Console.WriteLine($"Escriba el valor del elemento {i} del arreglo");
                int valor = Convert.ToInt32(Console.ReadLine());
                arregloxd[i] = valor;
            }
            Console.WriteLine("Este es el arreglo que has creado!");
            Console.WriteLine(string.Join(",", arregloxd));

            int temp;
            for (int i = 0; i < arregloxd.Length - 1; i++)
            {
                int indiceminimo = i;
                for (int j = i + 1; j < arregloxd.Length; j++)
                {
                    if (arregloxd[j] < arregloxd[indiceminimo])
                    {
                        indiceminimo = j;
                    }

                   


                }
                temp = arregloxd[i];
                arregloxd[i] = arregloxd[indiceminimo];
                arregloxd[indiceminimo] = temp;

            }

            Console.WriteLine("Este es el arreglo que has creado pero ordenado!!!");
            Console.WriteLine(string.Join(",", arregloxd));

        }
        public void OrdenamientoBurbuja()
        {
            int[] array1 = { 8, 1, 4, 2, 7, 10 };
            Console.WriteLine("Arreglo original: " + string.Join(",", array1));

            int temp;

            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int j = 0; j < array1.Length - 1 - i; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        temp = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Arreglo ordenado por burbuja: " + string.Join(",", array1));
        }







    }
}

