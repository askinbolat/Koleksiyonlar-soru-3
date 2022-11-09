using System;
using System.Collections;

/*
    Klavyeden girilen cümle içerisindeki sesli harfleri 
    bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
*/

namespace Koleksiyonlar_soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz.");
            string cumle = Console.ReadLine();

            char[] sesliHarf = {'a','e','ı','i','o','ö','u','ü'};

            ArrayList cumleSesliHarf= new ArrayList();

            for (int i = 0; i < cumle.Length; i++)
            {
                for (int k = 0; k < sesliHarf.Length; k++)
                {
                    if (cumle[i]== sesliHarf[k])
                    {
                        cumleSesliHarf.Add(cumle[i]);
                    }
                }
            }
            
            cumleSesliHarf.Sort();
        
            foreach (var item in cumleSesliHarf)
            {
                Console.WriteLine(item);
            }
        }
    }
}