using System.Collections;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1();

            // Q2();

            Q3();

        }
        static void Q1() 
        {
            ArrayList asal = new ArrayList();
            ArrayList notAsal = new ArrayList();

            int number;
            int temp = 0;
            int asalCounter = 0;
            int notAsalCounter = 0;
            int sumOfAsal = 0;
            int sumOfNotAsal = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + 1 + " sayiyi giriniz : ");
                number = Convert.ToInt32(Console.ReadLine());
                while (number <= 0)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                    number = Convert.ToInt32(Console.ReadLine());

                }
                for (int k = 1; k < number; k++)
                {
                    if (number % k == 0)
                    {
                        temp++;
                    }
                }
                if (temp == 1)
                {
                    asal.Add(number);
                    sumOfAsal += number;

                }
                else
                {
                    notAsal.Add(number);
                    sumOfNotAsal += number;
                }
                temp = 0;
            }
            Console.WriteLine("***************** asal sayılar *************************");
            foreach (var item in asal)
            {
                Console.WriteLine("Asal sayılar = {0}", item);
                asalCounter++;

            }

            Console.WriteLine("************************ Asal olmayan sayılar *********************************");
            foreach (var item in notAsal)
            {
                Console.WriteLine("Asal olmayan sayılar = {0}", item);
                notAsalCounter++;
            }


            asal.Sort();
            asal.Reverse();
            int averageAsal = sumOfAsal / asalCounter;
            int averageNotAsal = sumOfNotAsal / notAsalCounter;

            Console.WriteLine("Asal sayıların ortalaması = "+averageAsal);
            Console.WriteLine("Asal olmayan sayıların ortalaması = "+averageNotAsal);
            Console.WriteLine("Asal sayıların adeti = "+asalCounter);
            Console.WriteLine("Asal olmayan sayıların adeti = " + notAsalCounter);


          
        }    

        static void Q2()
        {
            ArrayList numbers= new ArrayList();
            ArrayList biggest = new ArrayList();
            ArrayList smallest = new ArrayList();
            int sumOfSmallest = 0;
            int sumOfBiggest = 0;
            int number;
            Console.WriteLine("20 Adet Sayı Giriniz.");
            for (int i = 0; i < 20; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }
            numbers.Sort();
            for (int i = 0; i < 3; i++)
            {
                 smallest.Add(numbers[i]);
                 
            }
            numbers.Reverse();
            for(int i=0;i<3;i++)
            {
                biggest.Add(numbers[i]); 
            }

            Console.WriteLine("********************* En büyük 3 sayı *********************");
            foreach (var item in biggest)
            {
                Console.WriteLine(" "+item);
            }


            Console.WriteLine("********************* En küçük 3 sayı *********************");
            foreach (var item in smallest)
            {
                Console.WriteLine(" " + item);
            }
        }

      
        
    }
}