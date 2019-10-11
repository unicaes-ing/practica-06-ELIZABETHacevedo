using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static string bin = "";
        static void Main(string[] args)
        {
            
            int num=0,opcion2=0,alto=0,ancho=0,x=0,y=0;
            string opcion;
            
            Console.WriteLine("ejercicio de la guia");
            opcion2 = pedirNUmero(opcion2);
            switch (opcion2)
            {
                case 1:
                    
            Console.WriteLine("tabla de multiplicar");
            Console.WriteLine("ingrese un numero:");
            num = pedirNUmero(num);
            Console.WriteLine("desea algun color SI/NO");
            opcion = Console.ReadLine();
            if (opcion=="si" || opcion=="SI")
            {
                Console.WriteLine("INGRESE EL COLOR[VERDE,BLANCO,AZUL] :");
                mostrarTabla(num, Console.ReadLine());
            }
            else
            {
                mostrarTabla(num);
            }
            break;
                case 2:
            Console.WriteLine("dibujar cuadrito :)");
            Console.WriteLine("ingrese el alto:");
            alto = pedirNUmero(alto);
            Console.WriteLine("ingrese el ancho");
            ancho = pedirNUmero(ancho);
            Console.WriteLine("quiere algun caracter especial si/no");
            opcion = Console.ReadLine();
            if (opcion == "si")
            {
               
                Console.WriteLine("escribalo");
                        string caracter = Console.ReadLine();
                        Console.WriteLine("quiere ponerlo en una posicion de la pantalla si/no");
                        opcion = Console.ReadLine();
                        if (opcion.Equals("si"))
                        {
                            Console.WriteLine("posicion con respecto x");
                            x = pedirNUmero(x);
                            Console.WriteLine("posicion con respecto y");
                            y = pedirNUmero(y);
                            dibujar(alto, ancho,caracter,x,y);
                        }
                        else
                        {
                            dibujar(alto, ancho,caracter);
                        }

            }
            else
            {
                        dibujar(alto, ancho);
            }
            break;

                case 3:
                    Console.WriteLine("numero base ");
                    int baseN = 0,expo=0;
                     baseN = pedirNUmero(baseN);
                    Console.WriteLine("exponente: ");

                    Console.WriteLine(exponente(baseN, pedirNUmero(expo))) ;
                    break;
                case 4:
                    Console.WriteLine("ingrese un numero:");
                    int numbim = 0;
                    string cadBin;
                    numbim = pedirNUmero(numbim);
                    cadBin = binario(numbim);
                    string a = new string(cadBin.Reverse().ToArray());
                    Console.WriteLine(a);
                    break;
                default:
                    break;
            }

           

    
            Console.ReadKey();

        }



        static void mostrarTabla( int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                //Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0} * {1} = {2}",numero,i,(numero*i));
            }
        }


        static void mostrarTabla( int numero,string color)
        {
            color=color.ToUpper();

            for (int i = 1; i <= 10; i++)
            {
                switch (color)
	{
                    case "AZUL":
                        
                Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "BLANCO":
                        
                Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "VERDE":
                        Console.ForegroundColor = ConsoleColor.Green;
                
                        break;
		default:
                        Console.WriteLine("COLOR NO VALIDO");
 break;
	}
                Console.WriteLine("{0} * {1} = {2}",numero,i,(numero*i));
            }
        }

        static int pedirNUmero(int num)
        {
            do
            {
                if (int.TryParse(Console.ReadLine(), out num) && num > 0)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("numero no valido  intentelo de nuevo");
                }
            } while (true);
        }


        static void dibujar(int alto,int ancho)
        {
            for (int i = 0; i < alto; i++)
            {
                Console.Write("f");
                if(i==0 || i==(alto-1)){
                for (int j = 0; j < ancho-2; j++)
                {
                    Console.Write("*");
                }
                }
                else
                {
                    for (int m = 0; m < ancho-2; m++)
                    {
                        Console.Write(" ");
                        
                    }
                }

                Console.Write("*\n");

                
            }
        }

        static void dibujar(int alto, int ancho,string caracter)
        {
            for (int i = 0; i < alto; i++)
            {
                Console.Write(caracter);
                if (i == 0 || i == (alto - 1))
                {
                    for (int j = 0; j < ancho - 2; j++)
                    {
                        Console.Write(caracter);
                    }
                }
                else
                {
                    for (int m = 0; m < ancho - 2; m++)
                    {
                        Console.Write(" ");

                    }
                }

                Console.Write("{0}\n",caracter);


            }
        }



        static void dibujar(int alto, int ancho, string caracter,int x,int y)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < alto; i++)
            {
                
                Console.Write(caracter);
                if (i == 0 || i == (alto - 1))
                {
                    for (int j = 0; j < ancho - 2; j++)
                    {

                        Console.Write(caracter);
                    }
                }
                else
                {
                    for (int m = 0; m < ancho - 2; m++)
                    {
                        Console.Write(" ");

                    }
                }
                //Console.SetCursorPosition(x, y+1);
                Console.Write("{0}\n",caracter);
                y = y + 1;
                Console.SetCursorPosition(x,y);

            }
        }



        static int exponente(int numero,int exp)
        {
            if (exp==1)
            {
                return numero;
            }
            else
            {
                numero = numero*exponente(numero,exp-1);
            }
            return numero;
        }
        
        static string binario(int numero)
        {
            if (numero<2)
            {
                return bin="1";
            }
            else
            {
                if (numero % 2 == 0)
                {

                    bin = "0" + binario(Math.Abs(numero/2)) ;
                }
                else
                {
                    bin = "1"+ binario(Math.Abs(numero / 2));
                }
            }
            /* if (numero%2!=0)
             {

                 return bin="1";
             }
             else
             {
                 return bin = "0";
             }
             else
             {
                 if (numero%2==0)
                 {

                     bin.Concat("0");
                 }
                 else
                 {
                     bin.Concat("1");
                 }
                 //bin.Concat();
                 bin = bin + binario(Math.Abs(numero/2));
             }
             */
            //string a = new string(bin.Reverse().ToArray());
            //Console.WriteLine(bin);
            return (bin);
            

        }



    }
}
