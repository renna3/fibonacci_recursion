using System;

namespace fibonacci
{
    class Program
    {
        public static long fibo(long max,long n1, long n2)
        {
           

            if (max == 0)
            {
                return n1;
            }

            else
            {
                Console.WriteLine(n1);
                //n1 diventa n2, n2 procede
                long temp = n1;
                n1 = n2;
                n2 += temp;
                max--;         
                return fibo(max,n1,n2);
            }
            

            
        }
        static void Main(string[] args)
        {
            //programma che manda il n-imo numero di fibonacci
            long  n1 = 0;
            long  n2 = 1; //questi sono i due numeri noti inziali

            int n = Convert.ToInt32(Console.ReadLine());
            n--; //perchè parto a contare da 0
            
            Console.WriteLine(fibo(n,n1,n2)); 

        }
    }
}
