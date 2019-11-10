using System;

namespace Kolokwium_I_Michał_Gajewski 
{
    class Program
    {
        static void Main(string[] args)
        {
            //ZADANIE 1A
            double x = 4;
            double y = 2 * (x * x * x) - 8 * (x * x) - 3 * x + 10;
            Console.WriteLine("Wynik fukcji to:" + y);

            //ZADANIE 2A
            double[] przychody_miesieczne = new double[15];
            double[] przychody_dzienne = new double[15] { 120, 145, 156, 178, 198, 167, 789, 123, 12445, 120, 2678, 12, 451, 1123, 764 };
            double suma_przychodow_dziennych= 0;
            double suma_przychodow_msc = 0;
           for (int i = 0; i < przychody_dzienne.Length; i++)
            {
                //Console.WriteLine(przychody_dzienne[i]);
                suma_przychodow_dziennych += przychody_dzienne[i];
                for (int j = 0; j < przychody_miesieczne.Length; j++)
                {
                    //przychody_dzienne[i] = przychody_miesieczne[j]; 
               }
                
            }
           
            Console.WriteLine("Suma przychodow wyniosla:"+ " " + suma_przychodow_dziennych);
            Console.WriteLine("Suma przychodów w msc:" + suma_przychodow_msc);
            }
        //
      
       
    }
}
//gr a