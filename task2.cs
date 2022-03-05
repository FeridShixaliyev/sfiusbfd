using System;

namespace character_searching
{
    class Program
    {
        static void Main(string[] args)
        {
            char sr;    //bu daxil etdiyimiz herfdir
            string str;     //bu daxil etdiyimiz sozdur
            int i, count = 0, flag = 0;
            Console.WriteLine("cumle veya soz daxil edin:");
            str = Console.ReadLine();

            Console.WriteLine("axtardiginiz herfi daxil edin :");
            sr = char.Parse(Console.ReadLine());

            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == sr)
                {
                    flag = 1;

                    count++;
                }
            }
            if (flag == 1)
                Console.WriteLine("isdifade " +  " olunub "+":" + count + " defe ");
            else
                Console.WriteLine("eded tapilmadi");
        }
    }
}
