using System;

namespace Jose_Valle_S04_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------- ");
            Console.WriteLine("JOSE VALLE SECCION 04: ");
            Console.WriteLine("SUCESION DE FIBONACCI: ");
            Console.WriteLine("---------------------------- ");

            Console.WriteLine("INGRESE UN NUMERO ENTERO: ");
            

            try//ERRORES
            {
                int num = Convert.ToInt32(Console.ReadLine());
                int i = 1;
                
                if (num == 1)
                {
                    Console.WriteLine("1");

                }//IF 2
                else if (num > 1)
                {
                    int sum1=0, sum2=1, sum=0;
                    while (sum < num) 
                    {

                        sum = sum1 + sum2;

                        if(sum < num)
                        {
                            Console.Write(sum + ", ");
                        }
                

                        sum1 = sum2;
                        sum2 = sum;

                    } //WHILE


                }//IF 3
                else
                {
                    Console.WriteLine("DEBE INGRESAR UN NUMERO MAYOR A 0");

                }//FIN ELSE


            }catch (Exception)
            {
                Console.WriteLine("ERROR:INGRESÓ UN NUMERO INVALIDO");

            }
        }
    }
}
