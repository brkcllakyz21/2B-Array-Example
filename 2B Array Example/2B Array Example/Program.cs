using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2B_Array_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            //37.	Özel bir okulda öğretmensiniz ve sınıfınızda 10 öğrenci var. Bu 10 öğrenci için notlar aşağıdaki gibidir
            //

            int[,] notlar = new int[10, 3] { { 87, 96, 70 }, { 68, 87, 90 }, { 94, 37, 90 }, { 100, 81, 82 }, { 83, 65, 85 }, { 78, 87, 65 }, { 85, 75, 83 }, { 91, 59, 100 }, { 76, 72, 84 }, { 87, 93, 73 } };
            double max = 0, min = 0, öğrenci_ortalaması = 0, sınıf_ortalaması = 0;
            max = notlar[0, 0];
            min = notlar[0, 0];
            //Bu notları bir diziye kaydediniz ve:
            //-En yüksek notu bulabilecek
            //- En düşük notu bulabilecek
            //- Her bir öğrenci için ortalamayı bulabilecek
            //- Sınıf ortalamasını bulabilecek


            for (int i = 0; i <= notlar.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= notlar.GetUpperBound(1); j++)
                {
                    sınıf_ortalaması += notlar[i, j];
                    öğrenci_ortalaması += notlar[i, j];
                    if (notlar[i, j] > max)
                    {
                        max = notlar[i, j];
                    }
                    if (notlar[i, j] < min)
                    {
                        min = notlar[i, j];
                    }
                }
                öğrenci_ortalaması /= 3;
                Console.WriteLine((i + 1) + ". Öğrencinin ortalaması = " + öğrenci_ortalaması);
                öğrenci_ortalaması = 0;
            }

            Console.WriteLine("En yüksek not = " + max);
            Console.WriteLine("En düşük not = " + min);
            Console.WriteLine("Sınıf ortalaması = " + (sınıf_ortalaması /= 30));







        }
    }
}
