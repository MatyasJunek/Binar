using System;

namespace Binar
{
    class Program
    {
        public static int BinarFind(int find, int[] field, int indexFrom, int IndexTo)
        {
            int half = (indexFrom+IndexTo)/ 2;

            if (indexFrom > IndexTo)
                return -1;

            if (find == field[half])
                return half;

            if (find < field[half])
                return BinarFind(find,field, indexFrom, half - 1);

            if (find > field[half])
                return BinarFind(find, field, half+1, IndexTo);

            return -1;
            
        }
        static void Main(string[] args)
        {
            int count = 1;
            int[] pole = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                pole[i] = count;
                count++;
            }
            Console.WriteLine(BinarFind(30, pole, 0,pole.Length)); 
            
        }
    }
}
