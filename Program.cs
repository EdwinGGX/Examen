using System;
					
public class Program
{
	public static void Main()
	{
        int np;
        int opc;
        string xd="";
        opc=0;
        int tam;
        Console.WriteLine("¿Cuantas posiciones desea que tenga el arreglo?");
        np = Convert.ToInt32(Console.ReadLine());
        tam = np;
        int[] list = new int[tam];

        do
        {
            Console.Clear();
            Console.WriteLine("MENU DE ARREGLOS UNIDIMENSIONALES");
            Console.WriteLine("1. Ingresar valores al arreglo");
            Console.WriteLine("2. Imprimir arreglo elevado al cuadrado");
            Console.WriteLine("3. Imprimir los números primos");
            Console.WriteLine("4. Salir");

            Console.WriteLine("Ingresar opcion del menu: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Ingresando valores al arreglo");
                    for (int i = 0; i < list.Length; i++)
                    {
                        Console.WriteLine("Ingrese un numero para la posición " + i);
                        list[i]=Convert.ToInt32(Console.ReadLine());     
                    }
                    break;
                case 2:
                    Console.WriteLine("Valores elevados al cuadrado");
                    for (int i=1; i<=list.Length;i++){
                        Console.WriteLine("Número: " +list[i-1]+", elevado al cuadrado: "+Math.Pow(list[i-1],2));
                    }

                    break;
                case 3:
                        xd=""; 
                        Console.WriteLine("Resumen de los numeros primos");
                        for (int i = 0; i < list.Length; i++)
                        {
                            if(EsPrimo(list[i]))
                            {
                                xd = ((i==list.Length-1) ? (xd + list[i].ToString()) : (xd + list[i] + ",")); 
                            }
                        }
                        Console.WriteLine("Resumen: " + xd);

                    break;

                case 4:
                    Console.WriteLine("Adios xD");
                    break;
                default:
                    Console.WriteLine("Intente nuevamente");
                    break;
            }
            Console.ReadKey();
        } while (opc!=4);
         static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if((numero % i) == 0){
                    return false;
                }
            }return true;
    }
  }
}