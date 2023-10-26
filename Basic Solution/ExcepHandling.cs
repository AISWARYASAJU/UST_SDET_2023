using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Solution
{
    internal class ExcepHandling
    {
        public ExcepHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public void Divide()
        {
            int res = Num1 / Num2;
            Console.WriteLine(res);
            /*try
            {
                int[] num = { 10, 20, 30 };

                int res = Num1 / Num2;
                 Console.WriteLine(res);


                /*  foreach (var n in num)
                  {
                   int res = n / Num2;
                      Console.WriteLine(res);
                  }*/


            /*    for (int i = 0; i < 3; i++)
                {
                    int res = num[i] / Num2;
                    Console.WriteLine(res);
                }
            }
            catch (ArithmeticException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                //Console.WriteLine(ex.Source);
                Console.WriteLine("dont give 0 for deno");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } */
            // finally
            //{
            //  Console.WriteLine("done");
            //
            // }\


           
        }
        public void NumCheck()
        {
            if(Num1>= 100)
            {
                Console.WriteLine("congrats");
            }
            else
            {
                throw new ArgumentException();
            }     
        }

    }


    } 
