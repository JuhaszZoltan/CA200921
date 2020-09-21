using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CA200921
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //töltsünk fel egy tömböt 100db 2 számjegyű, 3ma osztható számmal,
            //írjuk ki, úgy, hogy mind sorba 10 elem legyen
            //határrozzuk meg:
            //-elemek összegét
            //legnagyobb elem indexét
            //legkissebb elemet
            //30 és 50 közötti elemek számát
            //szerepel-e a tömbben a 66


            int[] t = new int[100];

            //[12 - 99] (x * 3) -> biztos, hogy 3mal osztható
            //[4 - 33] * 3


            //feltöltés
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(4, 34) * 3;
            }
            //kiírás
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i] + " ");
                if ((i + 1) % 10 == 0) Console.Write("\n");
            }

            int sum = 0;
            for (int i = 0; i < t.Length; i++)
            {
                sum += t[i];
            }
            Console.WriteLine($"\nElemek összege: {sum}");


            //int[] t = {33, 20, 40, 10, 1, 55, ...};

            int mini = 0;
            int maxi = 0;

            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] < t[mini]) mini = i;
                if (t[i] > t[maxi]) maxi = i;
            }

            Console.WriteLine($"max index: {maxi}");
            //Console.WriteLine($"max hely: {maxi + 1}");
            //Console.WriteLine($"max value: {t[maxi]}");
            Console.WriteLine($"min value: {t[mini]}");


            int c = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] <= 50 && t[i] >= 30) c++;
            }
            Console.WriteLine($"[30;50] közötti elemek száma: {c}");

            //eldöntés legközelebb, mert kicsengettek :(

            Console.ReadKey();
        }
    }
}
